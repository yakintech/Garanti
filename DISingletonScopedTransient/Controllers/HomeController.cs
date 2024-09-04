using DISingletonScopedTransient.Models;
using DISingletonScopedTransient.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DISingletonScopedTransient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        private readonly ISingletonService _singletonService2;
        private readonly IScopedService _scopedService2;
        private readonly ITransientService _transientService2;

        public HomeController(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService, ISingletonService singletonService2, IScopedService scopedService2, ITransientService transientService2)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService2 = singletonService2;
            _scopedService2 = scopedService2;
            _transientService2 = transientService2;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonService.GetGuid();
            ViewBag.Scoped = _scopedService.GetGuid();
            ViewBag.Transient = _transientService.GetGuid();

            ViewBag.Singleton2 = _singletonService2.GetGuid();
            ViewBag.Scoped2 = _scopedService2.GetGuid();
            ViewBag.Transient2 = _transientService2.GetGuid();

            return View();
        }
    }
}
