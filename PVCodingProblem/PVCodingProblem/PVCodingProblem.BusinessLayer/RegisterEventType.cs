using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    /// <summary>
    /// A RegisterEventType
    /// </summary>
    public class RegisterEventType : EventTypeBase
    {
        /// <summary>
        /// Generates output of a RegisterEventType
        /// </summary>
        /// <returns>Numbers from 1 to 100 with multiples of 3 and 5 being replaced by text. </returns>
        protected override string [] GenerateOutput()
        {
            string [] builtOutput = new string [100];

            // loops through all numbers from 1 to 100 replacing multiples of certain numbers with text.
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
