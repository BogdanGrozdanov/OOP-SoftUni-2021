using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly Dictionary<string, ICar> carByModel;
        public CarRepository()
        {
            this.carByModel = new Dictionary<string, ICar>();
        }
        public void Add(ICar model)
        {
            if (this.carByModel.ContainsKey(model.Model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model.Model));
            }
            this.carByModel.Add(model.Model, model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return this.carByModel.Values.ToList();
        }

        public ICar GetByName(string name)
        {
            return this.carByModel.GetByKeyOrDefaut(name);
        }

        public bool Remove(ICar model)
        {
            return this.carByModel.Remove(model.Model);
        }
    }
}
