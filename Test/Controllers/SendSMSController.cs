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
        if (obj.PhoneNumber != null)
        { //write data in File
            string FilePath = "/media/tom/rychlý data/Dokumenty/Tomáš/PRG Linux/Programy - .NET/Test4_4 MVC dotnet6.0 generovaný/Test/Data/SendSMS.txt";
            object Text = obj.PhoneNumber + "," + obj.SMSText;
            Helpers.FileUtil.AddLine(FilePath, Text);
        }
        return View(obj);
    }

}
