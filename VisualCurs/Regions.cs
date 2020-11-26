using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCurs
{
    public static class Regions
    {
        public static List<Region> list= new List<Region>();
    }
    public class Region : FederalDistrict
    {
        public FederalDistrict federalDistrict;

        public Region(FederalDistrict federalDistrict,string name, int area, int population, string center):base(name,area,population,center)
        {
            this.federalDistrict = federalDistrict;
            this.name = name;
            this.area = area;
            this.population = population;
            this.center = center;
        }
    }
}
