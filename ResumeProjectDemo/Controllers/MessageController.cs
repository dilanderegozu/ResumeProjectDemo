using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null)
            {
                value.IsRead = true; // Mesaj açıldığında okundu olarak işaretle
                _context.SaveChanges();
            }
            return View(value);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null)
            {
                _context.Messages.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("MessageList");
        }
    }
}