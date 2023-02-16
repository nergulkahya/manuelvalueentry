using Manuelvalueentry.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Manuelvalueentry.Database.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("server=./sqlserver;database=MANUELVALUEENTRY_DB;integrated security=true;");
        }
        public DbSet<FactoryModel> Factory { get; set; }
        public DbSet<RoomModel> Room { get; set; }
        public DbSet<ParameterModel> Parameter { get; set; }
        public DbSet<Parameter_HistoryModel> Parameter_History { get; set; }
        public DbSet<Room_ParameterModel> Room_Parameter{ get; set; }
        public DbSet<UserModel> User{ get; set; }
        public DbSet<RoleModel> Role { get; set; }
    }
}
