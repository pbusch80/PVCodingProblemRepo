using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    /// <summary>
    /// A DiagnoseEventType
    /// </summary>
    public class DiagnoseEventType : EventTypeBase
    {
        /// <summary>
        /// Generates output of a DiagnoseEventType
        /// </summary>
        /// <returns>Numbers from 1 to 100 with multiples of 2 and 7 being replaced by text. </returns>
        protected override string [] GenerateOutput()
        {
            string [] builtOutput = new string[100];

            // loops through all numbers from 1 to 100 replacing multiples of certain numbers with text.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                    builtOutput[i - 1] = "Diagnose Patient";
                else if (i % 2 == 0)
                    builtOutput[i - 1] = "Diagnose";
                else if (i % 7 == 0)
                    builtOutput[i - 1] = "Patient";
                else
                    builtOutput[i - 1] = i.ToString();
            }

            return builtOutput;
        }
    }
}
