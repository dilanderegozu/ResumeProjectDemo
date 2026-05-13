using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        ResumeContext context = new ResumeContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}