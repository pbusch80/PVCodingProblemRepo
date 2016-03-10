using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCodingProblem.BusinessLayer
{
    public abstract class EventTypeBase : IEventType
    {
        #region Private Members
        // Holds the generated output for the liftime of the object after it has been loaded.
        private string [] _output = new string[100];

        // Indicates whether or not the EventType has it output loaded
        private bool _isLoaded = false;

        #endregion Private Members

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

        #region Methods

        /// <summary>
        /// Generates the output of the event type
        /// </summary>
        /// <returns>A string array representation of the generated output.</returns>
        abstract protected string[] GenerateOutput();
        
        #endregion Methods
    }
}
