using Microsoft.EntityFrameworkCore;
using Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFRepo
{
   public class StudentContext :DbContext
    {
      public  DbSet<StudentPoco> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-41TMA4UR;Initial Catalog=StudentAPI;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
