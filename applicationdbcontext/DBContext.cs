using rj.Model;
  using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace rj.applicationdbcontext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<Suman_Orders> Suman_Orders
        {
            get;
            set;
        }



        
        }

    }

