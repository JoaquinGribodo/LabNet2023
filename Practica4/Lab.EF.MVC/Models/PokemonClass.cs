using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class PokemonClass
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class Root
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<PokemonClass> results { get; set; }
    }
}