using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    interface IABMLogic<T> //Se puede agregar otro parámetro
    {
        List<T> GetAll();
        void Add(T Tnombre);
        void Update(T Tnombre);
        void Remove(int id);
    }
}
