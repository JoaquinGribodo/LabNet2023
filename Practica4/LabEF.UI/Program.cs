using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menues menu = new Menues();
            menu.MenuGeneral();

            Console.ReadKey();
        }
    }
}
