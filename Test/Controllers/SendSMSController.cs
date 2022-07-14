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
    public async Task<IActionResult> Index([Bind("Id,PhoneNumber,SMSText")] SendSMS sendSMS)
    {
        if (ModelState.IsValid)
        {
            if (sendSMS.PhoneNumber != null)
            {
                string phoneNumber = sendSMS.PhoneNumber;
                try
                {
                    PhoneNumber pn = PhoneNumberUtil.GetInstance().Parse(phoneNumber, "");
                    sendSMS.PhoneNumber = PhoneNumberUtil.GetInstance().Format(pn, PhoneNumberFormat.E164); //INTERNATIONAL je s mezerama, E164 bez mezer
                }
                catch (NumberParseException npex)
                {
                    ModelState.AddModelError("NumberParseException", npex.Message);
                    return View(sendSMS);
                }
                _context.Add(sendSMS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        return View(sendSMS);
    }
}
