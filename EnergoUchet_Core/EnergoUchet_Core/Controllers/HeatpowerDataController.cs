using Microsoft.AspNetCore.Mvc;
using EnergoUchet_Core.Models;

namespace EnergoUchet_Core.Controllers
{
    public class HeatpowerDataController : Controller
    {
        private IHeatpowerDataRepository heatpowerDataRepository;

        public HeatpowerDataController (IHeatpowerDataRepository repo)
        {
            heatpowerDataRepository = repo;
        }

        public ViewResult List() => View(heatpowerDataRepository.HeatpowerDatas);
    }
}
