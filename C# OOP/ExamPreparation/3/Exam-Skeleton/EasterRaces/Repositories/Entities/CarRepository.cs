using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {

        public List<ICar> Models { get; private set; }

        public void Add(ICar model)
        {
            Models.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return Models.ToList();
        }

        public ICar GetByName(string name)
        {
            var model = Models.FirstOrDefault(m => m.Model == name);
            return model;
        }

        public bool Remove(ICar model)
        {
            return Models.Remove(model);
        }
    }  
}
