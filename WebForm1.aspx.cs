using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TxtID.Text);
            string ename = TxtName.Text;
            int esal = int.Parse(TxtSal.Text);
            if (new BusinessLogic().AddEmployee(eid, ename, esal))
            { 
                Response.Write("Inserted Succesfully");
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TxtID.Text);
            string ename = TxtName.Text;
            int esal = int.Parse(TxtSal.Text);
            if (new BusinessLogic().UpdateEmployee(eid, ename, esal))
            {
                Response.Write("Updated Succesfully");
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TxtID.Text);
            if (new BusinessLogic().DelEmployee(eid))
            {
                Response.Write("Updated Succesfully");
            }
        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = new BusinessLogic().ShowEmployees();
            GridView1.DataBind();
        }

        protected void BntFind_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(TxtID.Text);
            string[] res = new BusinessLogic().GetEmplyeeById(eid);
            TxtID.Text = res[0];
            TxtName.Text = res[1];
            TxtSal.Text = res[2];
        }
    }
}