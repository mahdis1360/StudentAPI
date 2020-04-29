using AutoMapper;
using DTO;
using EFRepo;
using Pocos;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class StudentLogic
    {
        private readonly EfRepo  _repo;
        

        public StudentLogic(EfRepo repo)
        {
            _repo = repo;
        }

       

        private void verify(StudentPoco student)
        {
            if (string.IsNullOrEmpty(student.Name))
            {
                throw new ArgumentOutOfRangeException("Name is empety");

            }
        }

        public void Create(StudentDto student)
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.CreateMap<StudentDto, StudentPoco>());
            var mapper = configuration.CreateMapper();
            StudentPoco poco = mapper.Map<StudentPoco>(student);
            verify(poco);
            _repo.Create(poco);
        }

        public StudentPoco Get(Guid id)
        {

            return _repo.Get(id);


        }

        public void Update(StudentDto student)
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.CreateMap<StudentDto, StudentPoco>());
            var mapper = configuration.CreateMapper();
            StudentPoco poco = mapper.Map<StudentPoco>(student);
            _repo.Update(poco);
        }

        public void Delete(Guid id)
        {

             _repo.Delete(id);


        }
    }
}
