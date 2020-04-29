using Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
  public interface EFRepo
    {
        void Create(StudentPoco student);
        StudentPoco Get(Guid Id);
        void Delete(Guid id);
        void Update(StudentPoco student);
    }
}
