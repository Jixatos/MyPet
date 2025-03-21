using MyPet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Controllers
{
    class EspeciesController
    {
        private readonly EspeciesService _especiesService;

        public EspeciesController(EspeciesService especiesService)
        {
            _especiesService = especiesService;
        }

        public List<string> GetPetNames()
        {
            return _especiesService.GetEspeciesNames();
        }
    }
}
