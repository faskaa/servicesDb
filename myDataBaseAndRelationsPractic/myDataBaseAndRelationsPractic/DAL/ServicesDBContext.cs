using Microsoft.EntityFrameworkCore;
using myDataBaseAndRelationsPractic.Models;

namespace myDataBaseAndRelationsPractic.DAL
{
    public class ServicesDBContext:DbContext
    {

        public ServicesDBContext(DbContextOptions<ServicesDBContext> opt) : base(opt) 
        {
        
        
        }
        public DbSet<Service> Services { get; set; }
    }
}
