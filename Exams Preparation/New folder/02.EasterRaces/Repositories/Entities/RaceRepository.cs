using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly IDictionary<string, IRace> raceByName;
        public RaceRepository()
        {
            this.raceByName = new Dictionary<string, IRace>();
        }

        public void Add(IRace model)
        {
            if (this.raceByName.ContainsKey(model.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RaceExists, model.Name));
            }
            this.raceByName.Add(model.Name, model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return this.raceByName.Values.ToList();
        }

        public IRace GetByName(string name)
        {
            return this.raceByName.GetByKeyOrDefaut(name);
        }

        public bool Remove(IRace model)
        {
            return this.raceByName.Remove(model.Name);
        }
    }
}
