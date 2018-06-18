using KeToan;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public partial class zModel : DbContext
    {
        public zModel(DbContextOptions<zModel> option) : base(option)
        {
            //try { Database.Migrate(); }
            //catch
            //{
            //    Database.EnsureDeleted();
                Database.EnsureCreated();
            //}
        }

        public zModel()
        {
            //try { Database.Migrate(); }
            //catch
            //{
            //    Database.EnsureDeleted();
                Database.EnsureCreated();
            //}
        }
    }
}