using LabEF.Data;
using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class RegionLogic : BaseLogic, IABMLogic<Region>
    {
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Add(Region newRegion)   //EJEMPLO INSERT
        {
            context.Region.Add(newRegion);
            context.SaveChanges();
        }

        public void Remove(int id) //EJEMPLO DELETE
        {
            //var regionAEliminar = context.Region.First(r => r.RegionID == id);
            //regionAEliminar = context.Region.FirstOrDefault(r => r.RegionID == id);
            //regionAEliminar = context.Region.Single(r => r.RegionID == id);
            //regionAEliminar = context.Region.SingleOrDefault(r => r.RegionID == id);

            var regionAEliminar = context.Region.Find(id); //Busca por la primary key
            context.Region.Remove(regionAEliminar);
            context.SaveChanges();
        }

        public void Update(Region region) 
        {
            var regionUpdate = context.Region.Find(region.RegionID);
            regionUpdate.RegionDescription = region.RegionDescription;
            context.SaveChanges();
        }
    }
}
