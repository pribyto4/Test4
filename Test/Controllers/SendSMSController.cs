using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Helpers;
using Test.Data;

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
                _context.Add(sendSMS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        return View(sendSMS);
    }


}
