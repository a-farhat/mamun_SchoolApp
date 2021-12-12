﻿
using mamun_SchoolApp.Data;
using mamun_SchoolApp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mamun_SchoolApp.Repository
{
    public class CountriesRepository : ICountriesRepository
    {

        SchoolDbContext _contextDB;
        public CountriesRepository(SchoolDbContext contextDB)
        {
            _contextDB = contextDB;
        }
        public string Delete(int id)
        {
            var student = _contextDB.Countries.FirstOrDefault(x => x.id == id);
            _contextDB.Countries.Remove(student);
            _contextDB.SaveChanges();
            return "Deleted";
        }

        public Countries Get(int id)
        {
            return _contextDB.Countries.FirstOrDefault(x => x.id == id);
        }

        public List<Countries> Gets()
        {
            return _contextDB.Countries.ToList();
        }

        public Countries Save(Countries Countries)
        {
            _contextDB.Countries.Add(Countries);
            _contextDB.SaveChanges();
            return this.Get(Countries.id);
        }

        public Countries Update(Countries Countries)
        {
            _contextDB.Countries.Update(Countries);
            _contextDB.SaveChanges();
            return this.Get(Countries.id);
        }
    }
}
