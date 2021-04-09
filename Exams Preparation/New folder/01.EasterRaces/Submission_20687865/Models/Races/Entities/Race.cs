using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int RaceMinSymbols = 5;
        private const int LapsMinCount = 1;

        private string name;
        private int laps;
        private readonly Dictionary<string, IDriver> driversByName;
        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;

            this.driversByName = new Dictionary<string, IDriver>();
        }
        public string Name
        {
            get => this.name;
            private set
            {

                if (string.IsNullOrEmpty(value) || value.Length < RaceMinSymbols)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.InvalidName, value, RaceMinSymbols));
                }
                this.name = value;
            }
        }

        public int Laps
        {
            get => this.laps;
            private set
            {
                if (value < LapsMinCount)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.InvalidNumberOfLaps, LapsMinCount));
                }
                this.laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => this.driversByName.Values.ToList();

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentException(ExceptionMessages.DriverInvalid);
            }
            if (!driver.CanParticipate)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }
            if (this.driversByName.ContainsKey(driver.Name))
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            }
            this.driversByName.Add(driver.Name, driver);
        }
    }
}

