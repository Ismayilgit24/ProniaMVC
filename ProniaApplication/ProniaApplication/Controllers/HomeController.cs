﻿using Microsoft.AspNetCore.Mvc;
using ProniaApplication.DAL;
using ProniaApplication.Models;
using ProniaApplication.ViewModels;

namespace ProniaApplication.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

           

            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();

            HomeVM homeVM = new HomeVM()
            {
                Slides = _context.Slides.OrderBy(s => s.Order).Take(2).ToList()
            };
            return View(homeVM);
        }
    }
}
