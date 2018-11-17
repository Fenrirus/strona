﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace strona
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void GetData()
        {
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = dbContext.Employees;
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using(SampleDataContext dbContext = new SampleDataContext())
            {
                Employees newEmployes = new Employees()
                {
                    FirstName = "Robert",
                    LastName = "K",
                    Gender = "Male",
                    Salary = 55000,
                    DepartmentId = 1
                };
                dbContext.Employees.InsertOnSubmit(newEmployes);
                dbContext.SubmitChanges();
            }
            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employees newEmployes = dbContext.Employees.SingleOrDefault(x => x.FirstName == "Robert");
                newEmployes.Salary = 65000;
                dbContext.SubmitChanges();
            }
            GetData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employees newEmployes = dbContext.Employees.SingleOrDefault(x => x.FirstName == "Robert");
                dbContext.Employees.DeleteOnSubmit(newEmployes);
                dbContext.SubmitChanges();
            }
            GetData();
        }
    }
}