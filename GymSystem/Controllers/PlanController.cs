
using GymSystem.DAL.Contexts;
using GymSystem.DAL.Repos.Classes;
using GymSystem.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Controllers
{
    public class PlanController : Controller
    {
        // 2 actions: Index(all plans), details(plan details)  
        private readonly IPlanRepository planRepository;

        public PlanController(IPlanRepository planRepo)
        {
            planRepository=planRepo;
            
        }

        public async Task<IActionResult> Index()
        {
            var plans = await planRepository.GetAll();
            return View(plans);
        }
        public async Task<IActionResult> Details(int id)
        {
            var paln = await planRepository.GetById(id);
            if (paln == null) { 
                RedirectToAction("Index");
            }
            return View(paln);

        }
    }
}
