using MVCfullDemo2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCfullDemo2023.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEmployees()
        {

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp = FillEmpoloyeeModel();
            return View(listEmp);
        }


        // GET: EmployeeByID
        public ActionResult GetEmployeeByID(int ID)
        {

            EmployeeModel Emp = new EmployeeModel();
            Emp = FillEmpoloyeeModel().Where(e=>e.ID==ID).FirstOrDefault();
            return View(Emp);
        }



        public List<EmployeeModel> FillEmpoloyeeModel()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.AddRange(new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    ID=1001,Name="Bandi Vamshi Krishna",PhoneNo=9999999999,Email="vamshi@gmail.com",DOB="30/04/1991",
                    Address="Sai Bhagavan Colony, Ramachandrapuram",City="Hyderabad",
                    State="Telangana",PinCode=502032,Country="India"
                },
                new EmployeeModel
                {
                    ID=1002,Name="Vamshi Krishna",PhoneNo=8888888888,Email="bandi@gmail.com",DOB="30/04/1992",
                    Address="Sai Bhagavan Colony, Ramachandrapuram",City="Hyderabad",
                    State="Telangana",PinCode=502032,Country="India"
                },
                new EmployeeModel
                {
                    ID=1003,Name="Krishna",PhoneNo=7777777777,Email="krishna@gmail.com",DOB="30/04/1993",
                    Address="Sai Bhagavan Colony, Ramachandrapuram",City="Hyderabad",
                    State="Telangana",PinCode=502032,Country="India"
                },
                new EmployeeModel
                {
                    ID=1004,Name="Vamshi",PhoneNo=6666666666,Email="bvk@gmail.com",DOB="30/04/1994",
                    Address="Sai Bhagavan Colony, Ramachandrapuram",City="Hyderabad",
                    State="Telangana",PinCode=502032,Country="India"
                }
            });
            return listEmp;
        }
    }
}