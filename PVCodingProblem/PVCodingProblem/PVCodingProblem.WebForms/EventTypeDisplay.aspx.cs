using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PVCodingProblem.BusinessLayer;

namespace PVCodingProblem.WebForms
{
    public partial class EventTypeDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateContentBtn_Click(object sender, EventArgs e)
        {
            if (eventTypesDdl.SelectedValue == "Register")
                eventTypeOutputResultsRpt.DataSource = new RegisterEventType().Output;
            else if (eventTypesDdl.SelectedValue == "Diagnose")
                eventTypeOutputResultsRpt.DataSource = new DiagnoseEventType().Output;

            eventTypeOutputResultsRpt.DataBind();
        }
    }
}