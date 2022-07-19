using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Helpers;
using Test.Data;
using PhoneNumbers;

namespace Test.Controllers;

public class SendSMSController : Controller
{
    private readonly SMSContext _context;

    public SendSMSController(SMSContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Index([Bind("Id,PhoneNumber,JSInput,JSInputCounteryCode,SMSText")] InputsSMS inputsSMS)
    {
        if (ModelState.IsValid)
        {
            if (inputsSMS.PhoneNumber != null)
            {
                string PhoneNumberInternational;
                try
                {
                    PhoneNumber pn = PhoneNumberUtil.GetInstance().Parse(inputsSMS.PhoneNumber, "");
                    PhoneNumberInternational = PhoneNumberUtil.GetInstance().Format(pn, PhoneNumberFormat.INTERNATIONAL); //INTERNATIONAL is with spaces, E164 without
                }
                catch (NumberParseException npex)
                {
                    ModelState.AddModelError("NumberParseException", npex.Message);
                    return View(inputsSMS);
                }
                SendSMS sendSMS = new SendSMS();
                sendSMS.Id = inputsSMS.Id;
                sendSMS.PhoneNumber = PhoneNumberInternational;
                sendSMS.SMSText = inputsSMS.SMSText;
                _context.Add(sendSMS);
                await _context.SaveChangesAsync();
                TempData["success"] = "SMS was sent successfully";
                return RedirectToAction(nameof(Index));
            }
        }
        return View(inputsSMS);
    }
}
