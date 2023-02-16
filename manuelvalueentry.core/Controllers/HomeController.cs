using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using manuelvalueentry.core.Models;
using Manuelvalueentry.Bussiness.Manager;
using Manuelvalueentry.Database.EntityFramework;
using Manuelvalueentry.Entity.Models;
using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Core.Mapper;

namespace manuelvalueentry.core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        FactoryModelManager factoryModel = new FactoryModelManager(new EFFactoryRepository());
        public IActionResult Index()
        {
            List<FactoryModel> _factoryModelList = factoryModel.GetAllList();
            List<Factory> _factoryList = new List<Factory>();
            foreach (FactoryModel _factoryItem in _factoryModelList)
            {
                Factory _factory=FactoryMapper.MapToActiveFactory(_factoryItem);
                if (_factory !=null && !_factoryList.Contains(_factory))
                {
                    _factoryList.Add(_factory);
                }
            }
            return View(_factoryList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
