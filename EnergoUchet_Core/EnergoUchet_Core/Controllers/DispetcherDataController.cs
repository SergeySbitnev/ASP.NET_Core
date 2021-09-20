using Microsoft.AspNetCore.Mvc;
using EnergoUchet_Core.Models;

namespace EnergoUchet_Core.Controllers
{
    public class DispetcherDataController : Controller
    {
        private IDispetcherDataRepository dispetcherDataRepository;

        public DispetcherDataController (IDispetcherDataRepository repo)
        {
            dispetcherDataRepository = repo;
        }

        public ViewResult List() => View(dispetcherDataRepository.DispetcherDatas); 
    }
}
