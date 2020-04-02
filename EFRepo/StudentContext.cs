using Microsoft.EntityFrameworkCore;
using Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFRepo
{
   public class StudentContext :DbContext
    {
        DbSet<StudentPoco> students { get; set; }
    }
}
