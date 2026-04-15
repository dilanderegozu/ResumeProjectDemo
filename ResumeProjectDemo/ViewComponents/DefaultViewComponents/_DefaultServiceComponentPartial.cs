using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using System.Diagnostics.Metrics;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial:ViewComponent
    {

        private readonly ResumeContext _context;

        public _DefaultServiceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();
            return View(values); 
        }
    }
}
/*
title - letter
ti-server
ti-exchange-vertical
ti-harddrives
ti-layout
ti-lock
*/