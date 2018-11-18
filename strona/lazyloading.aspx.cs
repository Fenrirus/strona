using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace strona
{
    public partial class lazyloading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SampleDataContext dbcontext = new SampleDataContext())
            {
                dbcontext.Log = Response.Output;
                //lazy
                //gvdepartments.datasource = dbcontext.departments;
                // eager
                gvDepartments.DataSource = from dept in dbcontext.Departments
                                           select new { name = dept.Name, employees = dept.Employees };
                gvDepartments.DataBind();
            }
            //using (SampleDataContext dbContext = new SampleDataContext())
            //{
            //    dbContext.Log = Response.Output;
            //    DataLoadOptions dataLoad = new DataLoadOptions();
            //    dataLoad.LoadWith<Departments>(d => d.Employees);
            //    dbContext.LoadOptions = dataLoad;

            //    gvDepartments.DataSource = dbContext.Departments;
            //    gvDepartments.DataBind();
            //}
        }
    }
}