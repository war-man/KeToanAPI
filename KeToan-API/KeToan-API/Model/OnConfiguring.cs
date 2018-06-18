using API.Utils;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public partial class zModel
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.CreateOption();
        }
    }
}
