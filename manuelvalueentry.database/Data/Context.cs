using Manuelvalueentry.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Manuelvalueentry.Database.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("server=DESKTOP-C7IMFHQ\\SQLEXPRESS;database=ManuelValueEntryDB;integrated security=true;");
        }
        public DbSet<FactoryModel> FactoryModels { get; set; }
        public DbSet<RoomModel> RoomModels { get; set; }
        public DbSet<ParameterModel> ParameterModels { get; set; }
        public DbSet<Parameter_HistoryModel> Parameter_HistoryModels { get; set; }
        public DbSet<Room_ParameterModel> Room_ParameterModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<RoleModel> RoleModels { get; set; }
    }
}
