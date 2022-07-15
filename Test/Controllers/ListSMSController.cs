using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    public class ListSMSController : Controller
    {
        private readonly SMSContext _context;

        public ListSMSController(SMSContext context)
        {
            _context = context;
        }

        // GET: ListSMS
        public async Task<IActionResult> Index()
        {
            return View(await _context.SendSMS.ToListAsync());
        }
    }
}
