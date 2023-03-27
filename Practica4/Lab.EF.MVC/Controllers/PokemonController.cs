using Lab.EF.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon

        public ActionResult Index()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://pokeapi.co/");

                var request = client.GetAsync("api/v2/pokemon").Result;

                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    Root listadoPokemones = JsonConvert.DeserializeObject<Root>(resultString);
                    return View("PokemonView", listadoPokemones.results);
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}