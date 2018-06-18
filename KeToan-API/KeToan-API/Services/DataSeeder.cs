using API.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using KeToan;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public static class DataSeeder
    {
        static IApplicationBuilder _app;
        static zModel _db;
        public static void SeedData(this IApplicationBuilder app)
        {
            _app = app;
            _db = _app.ApplicationServices.GetService<zModel>();
            app.allControlller();

            if (!_db.ePhanQuyen.Any(n => n.TenQuyen.Equals("Admin")))
            {
                var nQuyen = new ePhanQuyen() { TenQuyen = "Admin" };
                _db.ePhanQuyen.Add(nQuyen);

                if (_db.ChangeTracker.HasChanges())
                    _db.SaveChanges();

                _db.xChucNang.ToList().ForEach(n => _db.eQuyen.Add(new eQuyen()
                {
                    ChucNangID = n.KeyID,
                    PhanQuyenID = nQuyen.KeyID
                }));

                if (_db.ChangeTracker.HasChanges())
                    _db.SaveChanges();
            }

            if (!_db.eTaiKhoan.Any(n => n.AccCode.Equals("admin")))
            {
                _db.eTaiKhoan.Add(new eTaiKhoan()
                {
                    AccCode = "admin",
                    Password = "admin".Encrypt(),
                    AccName = "admin",
                    PhanQuyenID = 1
                });
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();
        }

        private static void allControlller(this IApplicationBuilder app)
        {
            var lstChucNang = _db.xChucNang.ToList();
            foreach (ControllerActionDescriptor item in
                                app.ApplicationServices.GetServices<IActionDescriptorCollectionProvider>()
                                .First().ActionDescriptors.Items)
            {
                if (!item.ControllerName.Equals("Test"))
                {
                    string methods = "GET";
                    string route = item.AttributeRouteInfo.Template.Trim().ToLower();
                    if (!route.StartsWith("/"))
                        route = "/" + route;
                    if (item.ActionConstraints != null)
                    {
                        methods = "";
                        try
                        {
                            methods = string.Join("|",
                                (
                                (Microsoft.AspNetCore.Mvc.Internal.HttpMethodActionConstraint)
                                item.ActionConstraints
                                .FirstOrDefault(n => n is Microsoft.AspNetCore.Mvc.Internal.HttpMethodActionConstraint))
                                .HttpMethods
                                .Distinct()
                                ).Trim().ToUpper();
                        }
                        catch { methods = "GET"; }
                    }
                    var chucnang = new xChucNang()
                    {
                        ModuleName = Utils.ModuleHelper.ModuleName,
                        Route = route,
                        Methods = methods,
                        ControllerName = item.ControllerName
                    };
                    if (!lstChucNang.Any(n => n.Route.Equals(chucnang.Route) && n.Methods.Equals(chucnang.Methods)))
                    {
                        _db.xChucNang.Add(chucnang);
                    }
                }
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();
        }
    }
}
