using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVCodingProblem.BusinessLayer;


namespace PVCodingProblem.WinForms
{
    public partial class EventTypeDisplay : Form
    {
        public EventTypeDisplay()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var bindableResults = from output in new RegisterEventType().Output select new { Output = output };

            eventTypeResultsGv.DataSource = bindableResults.ToList();
        }

        private void diagnoseBtn_Click(object sender, EventArgs e)
        {
            var bindableResults = from output in new DiagnoseEventType().Output select new { Output = output };

            eventTypeResultsGv.DataSource = bindableResults.ToList();
        }
    }
}
