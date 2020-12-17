using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        public List<IRace> Models { get; private set; }

        public void Add(IRace model)
        {
            Models.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return Models.ToList();
        }

        public IRace GetByName(string name)
        {
            var model = Models.FirstOrDefault(m => m.Name == name);
            return model;
        }
        
        public bool Remove(IRace model)
        {
            return Models.Remove(model);
        }
    }
}
