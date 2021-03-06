using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;
using DemoMvc.CommonHelper;
using Newtonsoft.Json;

namespace DemoMvc.Controllers
{
    public class IndexController : Controller
    {
        DbUserMasterConnectcs DUMC = new DbUserMasterConnectcs();
        // GET: Index
        public ActionResult CreateNewAccount()
        {
            return View();
        }
        [Route()]
        public ActionResult UserRecords()
        {
            return View();
        }

        public ActionResult Chart()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateNewAccount(int Id, string FirstName, string LastName, string ContactNo, string EmailId, string Password, char Gender)
        {
            int flag = 0;
            Records U = new Records();
            {
                U.Id = Id;
                U.FirstName = FirstName;
                U.LastName = LastName;
                U.ContactNo = ContactNo;
                U.EmailId = EmailId;
                U.Gender = Gender;
                U.Password = Password;
                U.Status = 'Y';
            };

            flag = DUMC.InsertUserData(U);

            if (flag == 1)
            {
                var result = new { Success = "Success", Message = "Data Inserted Successfully..!!" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var result = new { Success = "False", Message = "Error Message" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]

        public JsonResult GetAllUserData(string OrderBy, string WhereClause)
        {
            List<Records> ULst = new List<Records>();

            ULst = DUMC.GetUserData(OrderBy, WhereClause);

            return Json(new { data = ULst }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult UpdateUserStatus(int Id, char Status)
        {
            int flag = 0;
            Records U = new Records();
            {
                U.Id = Id;
                U.Status = Status;
            };

           flag = DUMC.UpdateUserStatus(U);
             if (flag == 1)
            {
                 var result = new { Success = "Success", Message = "Status Updated Successfully..!!" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var result = new { Success = "False", Message = "Error Message" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

         [HttpGet]
        public JsonResult ChartCall(string SelectAsLabel, string GroupBy)
        {
            List<UserChartResponseModel> ULst = new List<UserChartResponseModel>();
            ULst = DUMC.GetUserChartData(SelectAsLabel,GroupBy);
            return Json(new { data = ULst }, JsonRequestBehavior.AllowGet);
        }
    }
}