using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C2T.WebApi;
using Microsoft.AspNetCore.Mvc;
using C2T.WebApi.Controllers;
using C2T.WebApi.Repository;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace C2T.WebUI.Controllers
{
    
    [Route("api/[controller]")]
    public class ACQUIRERController : Controller
    {
        private readonly  IACQUIRERRepository _acquirerRepository;
        
        public ACQUIRERController(IACQUIRERRepository _acquirerRepository)
        {
            this._acquirerRepository = _acquirerRepository;
        }
        
        [HttpGet("[action]")]
        public IEnumerable<AcquirerViewModel> WeatherForecasts()
        {
            var hilal =   _acquirerRepository.GetAll();
            return hilal?.Select(item => new AcquirerViewModel()
            {
                ACQUIRER_ID = 1,
                NAME = item.ToString()

            }).OrderBy(p => p.NAME).ToList();
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public class AcquirerViewModel
        {
            public int ACQUIRER_ID { get; set; }

            public string NAME { get; set; }
           
        }
    }
}