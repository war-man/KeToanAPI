using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Core
{
#if DEBUG
    [AllowAnonymous]
#else
    [Authorize]
#endif
    public class ControllerTemplate<T> : Controller
        where T : class, new()
    {
        public readonly IDataRepository<T> Instance;
        public readonly IRepositoryCollection Collection;
        public ControllerTemplate(IRepositoryCollection collection)
        {
            Instance = collection.GetRepo<T>();
            Collection = collection;
        }

        [HttpGet]
        public virtual IEnumerable<T> GetAll()
        {
            Instance.Context = new zModel();
            return Instance.GetEntity().Result;
        }

        [HttpGet("ids")]
        public virtual List<T> GetList([FromQuery] int[] id)
        {
            if (id != null && id.Length > 0)
            {
                List<T> lstResult = new List<T>();

                foreach (int key in id)
                {
                    var entry = Instance.GetEntity(key);
                    if (entry != null)
                        lstResult.Add(entry);
                }
                return lstResult;
            }
            else
                return null;
        }

        [HttpPost]
        public virtual IActionResult AddEntities([FromBody]T[] entities)
        {
            try
            {
                Instance.Context = new zModel();
                Instance.BeginTransaction();
                if (entities != null && entities.Length > 0)
                {
                    foreach (T entry in entities)
                    {
                        Instance.AddEntity(entry);
                    }
                }
                else
                    return BadRequest();
                Instance.SaveAll();
                if (Instance.CommitTransaction())
                {
                    foreach (var entity in entities)
                    {
                        Instance.Context.Entry<T>(entity).Reload();
                    }
                }

                return StatusCode(201, entities);
            }
            catch (Exception ex)
            {
                Instance.RollbackTransaction();
                Instance.Logger.LogError(new EventId(), ex, $"Add {typeof(T).Name} Error");
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public virtual IActionResult UpdateEntities([FromBody]T[] entities)
        {
            try
            {
                Instance.Context = new zModel();
                Instance.BeginTransaction();
                if (entities != null && entities.Length > 0)
                {
                    foreach (T entry in entities)
                    {
                        Instance.UpdateEntity(entry);
                    }
                }
                else
                    return BadRequest();
                var result = Instance.SaveAll();

                if (Instance.CommitTransaction())
                {
                    foreach (var entity in entities)
                    {
                        Instance.Context.Entry<T>(entity).Reload();
                    }
                }
                return StatusCode(201, entities);
            }
            catch (Exception ex)
            {
                Instance.RollbackTransaction();
                Instance.Logger.LogError(new EventId(), ex, $"Update {typeof(T).Name} Error");
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public virtual IActionResult DeleteEntities([FromBody]T[] entities)
        {
            try
            {
                Instance.Context = new zModel();
                Instance.BeginTransaction();
                if (entities != null && entities.Length > 0)
                {
                    foreach (T entry in entities)
                    {
                        Instance.RemoveEntity(entry);
                    }
                }
                else
                    return BadRequest();
                Instance.SaveAll();
                Instance.CommitTransaction();
                return StatusCode(204, entities);
            }
            catch (Exception ex)
            {
                Instance.RollbackTransaction();
                Instance.Logger.LogError(new EventId(), ex, $"Delete {typeof(T).Name} Error");
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("ids")]
        public virtual IActionResult DeleteEntities([FromQuery] int[] id)
        {
            try
            {
                Instance.Context = new zModel();
                Instance.BeginTransaction();
                if (id != null && id.Length > 0)
                {
                    id.ToList().ForEach(n =>
                    {
                        Instance.Logger.LogInformation($"Delete by KeyId: {n}");
                        Instance.RemoveEntity(n);
                    });
                }
                else
                    return BadRequest();
                Instance.SaveAll();
                Instance.CommitTransaction();
                return StatusCode(204, id);
            }
            catch (Exception ex)
            {
                Instance.RollbackTransaction();
                Instance.Logger.LogError(new EventId(), ex, $"Delete {typeof(T).Name} Error");
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
