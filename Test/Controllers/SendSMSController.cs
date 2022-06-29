using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Helpers;

namespace Test.Controllers;

public class SendSMSController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Index(SendSMS obj)
    {
        if (ModelState.IsValid)
        {
            if (obj.PhoneNumber != null)
            {
                if (obj.PhoneNumber[0] == '+')
                {
                    obj.PhoneNumber = obj.PhoneNumber.Substring(1, obj.PhoneNumber.Length-1);
                }
                //write data in File
                string FilePath = "/media/tom/rychlý data/Dokumenty/Tomáš/PRG Linux/Programy - .NET/Test4_4 MVC dotnet6.0 generovaný/Test/Data/SendSMS.txt";
                object Text = obj.PhoneNumber + "," + obj.SMSText;
                Helpers.FileUtil.AddLine(FilePath, Text);
            }

            return View(obj);
        }
        else
        {
            return View();
        }
    }

}
