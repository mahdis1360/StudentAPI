using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Pocos;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFRepo
{
    public class EfRepo : Repository.EFRepo
    {
        private readonly StudentContext _context;

        public EfRepo()
        {
            _context = new StudentContext();
        }
        public void Create(StudentPoco student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            StudentPoco student = _context.students.Find(id);
            if (student != null)
            {
                throw new ArgumentOutOfRangeException("i didnot find");
            }
            _context.students.Remove(student);
            _context.SaveChanges();
        }

        public StudentPoco Get(Guid Id)
        {
            
            return _context.students.Find(Id);
        }

        public void Update(StudentPoco student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
             
        }

    
    }
}
