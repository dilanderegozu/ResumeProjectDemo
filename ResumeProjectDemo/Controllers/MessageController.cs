using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

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

        [HttpPost]
        public IActionResult SendMessage(Message model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.NameSurname) ||
                    string.IsNullOrWhiteSpace(model.EmailAddress) ||
                    string.IsNullOrWhiteSpace(model.MessageContent))
                {
                    return BadRequest("Zorunlu alanlar eksik.");
                }

                model.MessageDetail = "";   // null gelirse hata vermesin
                model.IsRead = false;
                model.SendDate = DateTime.Now;

                _context.Messages.Add(model);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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