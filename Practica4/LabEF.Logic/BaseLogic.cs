using LabEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context; //El readonly solo permite instanciar context en la misma línea o en el constructor.

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
