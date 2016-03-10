using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    public class RegisterEventType : EventTypeBase
    {
        /// <summary>
        /// Generates output of a RegisterEventType
        /// </summary>
        /// <returns>Numbers from 1 to 100 with multiples of </returns>
        protected override string [] GenerateOutput()
        {
            string [] builtOutput = new string [100];

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    builtOutput[i - 1] = "Register Patient";
                else if (i % 3 == 0)
                    builtOutput[i - 1] = "Register";
                else if (i % 5 == 0)
                    builtOutput[i - 1] = "Patient";
                else
                    builtOutput[i - 1] = i.ToString();
            }

            return builtOutput;
        }
    }
}
