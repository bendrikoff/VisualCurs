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

        public static void PopSort()
        {
            PopComparer pop = new PopComparer();
            Districts.list.Sort(new PopComparer());
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
    public class AreaComparer : IComparer<District>
    {
        public int Compare(District p1, District p2)
        {
            if (p1.area > p2.area)
                return 1;
            else if (p1.area < p2.area)
                return -1;
            else
                return 0;
        }
    }
    public class PopComparer : IComparer<District>
    {
        public int Compare(District p1, District p2)
        {
            if (p1.population > p2.population)
                return -1;
            else if (p1.population < p2.population)
                return 1;
            else
                return 0;
        }
    }

}
