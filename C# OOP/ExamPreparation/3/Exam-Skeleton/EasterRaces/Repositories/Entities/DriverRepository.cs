﻿using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        public List<IDriver> drivers { get; private set; }

        public void Add(IDriver model)
        {
            drivers.Add(model);
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return drivers.ToList();
        }

        public IDriver GetByName(string name)
            => drivers.FirstOrDefault(m => m.Name == name);
            
        

        public bool Remove(IDriver model)
        {
            return drivers.Remove(model);
        }
    }
}
