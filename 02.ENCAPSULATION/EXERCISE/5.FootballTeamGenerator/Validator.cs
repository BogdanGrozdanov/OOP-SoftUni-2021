using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void Throw_If_String_Is_Null_OR_Empty(string str, string exceptionMesage)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException(exceptionMesage);
            }
        }

        public static void Throw_If_Number_Is_Out_Of_Range(int number, int min, int max, string exceptionMesage)
        {
            if (number < min || number > max)
            {
                throw new ArgumentException(exceptionMesage);
            }
        }
    }

}
