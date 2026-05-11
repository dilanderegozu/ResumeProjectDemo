using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ResumeContext _context;

        public PortfolioController(ResumeContext context)
        {
            _context = context;
        }


        public IActionResult PortfolioList()
        {
            var values = _context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            ViewBag.v = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            portfolio.ImageUrl = "test";
            portfolio.Status = true;     // Yeni proje AKTİF olarak başlasın
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
            var value = _context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult ChangeStatus(int id)
        {
            var value = _context.Portfolios.Find(id);
            if (value != null)
            {
                value.Status = !value.Status; // Durumu tersine çevirir
                _context.SaveChanges();
            }
            return RedirectToAction("PortfolioList");
        }
    }
}

