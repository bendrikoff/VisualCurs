using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCurs
{
    public static class Districts
    {
        public static List<District> list = new List<District>();
    }
    public class District:Region
    {
       public Region region;

        public District(Region region,FederalDistrict federalDistrict, string name, int area, int population, string center) :base(federalDistrict,name, area, population, center)
        {
            this.region = region;
            this.federalDistrict = federalDistrict;
            this.name = name;
            this.area = area;
            this.population = population;
            this.center = center;

        }
    }
}
