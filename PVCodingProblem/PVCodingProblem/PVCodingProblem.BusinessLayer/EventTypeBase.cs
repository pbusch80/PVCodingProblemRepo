using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    public abstract class EventTypeBase : IEventType
    {
        private string [] _output = new string[100];
        private bool _isLoaded = false;

        #region IEventType Members

        public string [] Output
        {
            get
            {
                if (!_isLoaded)
                {
                    _output = GenerateOutput();
                    _isLoaded = true;
                }
                return _output;
            }
        }

        #endregion

        abstract protected string[] GenerateOutput();
    }
}
