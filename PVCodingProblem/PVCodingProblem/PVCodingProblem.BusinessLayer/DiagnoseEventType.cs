using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    public class DiagnoseEventType : EventTypeBase
    {
        protected override string [] GenerateOutput()
        {
            string [] builtOutput = new string[100];

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
