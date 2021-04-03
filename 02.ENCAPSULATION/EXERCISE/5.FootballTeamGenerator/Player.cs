using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int MinStats = 1;
        private const int MaxStats = 100;
        private string name;
        private int stats;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name
        {
            get => name;
            private set
            {
                Validator.Throw_If_String_Is_Null_OR_Empty(value, "A name should not be empty.");
                this.name = value;
            }
        }
        public int Endurance
        {
            get => this.endurance;
            private set
            {
                Validator.Throw_If_Number_Is_Out_Of_Range(value, MinStats, MaxStats, $"{nameof(this.Endurance)} should be between 0 and 100.");
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                Validator.Throw_If_Number_Is_Out_Of_Range(value, MinStats, MaxStats, $"{nameof(this.Sprint)} should be between 0 and 100.");
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                Validator.Throw_If_Number_Is_Out_Of_Range(value, MinStats, MaxStats, $"{nameof(this.Dribble)} should be between 0 and 100.");
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                Validator.Throw_If_Number_Is_Out_Of_Range(value, MinStats, MaxStats, $"{nameof(this.Passing)} should be between 0 and 100.");
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                Validator.Throw_If_Number_Is_Out_Of_Range(value, MinStats, MaxStats, $"{nameof(this.Shooting)} should be between 0 and 100.");
                this.shooting = value;
            }
        }
        public double AverageSkilsPoint => Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);

    }
}
