using Microsoft.AspNetCore.Mvc;
using EnergoUchet_Core.Models;

namespace EnergoUchet_Core.Controllers
{
    public class KipiaDataController : Controller
    {
        private IKipiaDataRepository kipiaDataRepository;

        public KipiaDataController (IKipiaDataRepository repo)
        {
            kipiaDataRepository = repo;
        }

        public ViewResult List() => View(kipiaDataRepository.KipiaDatas);
    }
}
