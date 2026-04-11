using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultExperinceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
