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

        public static List<District> Search(string str)
        {
            List<District> districts = new List<District>();

            foreach(District district in list)
            {
                
                if (district.name.ToLower().Contains(str.ToLower()))
                {
                    districts.Add(district);
                }
            }
            return districts;
        }

        public static void SortPops()
        {
            Districts.list.Sort(new PopComparer<District>());
        }
        public static void SortArea()
        {
            Districts.list.Sort(new AreaComparer<District>());
        }
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
