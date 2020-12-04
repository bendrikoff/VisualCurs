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

        public static List<Region> Search(string str)
        {
            List<Region> regions = new List<Region>();

            foreach (Region region in list)
            {

                if (region.name.ToLower().Contains(str.ToLower()))
                {
                    regions.Add(region);
                }
            }
            return regions;
        }
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
        public int CompareTo(Region p)
        {
            return this.name.CompareTo(p.name);
        }
    }
    //class RegionComparer : IComparer<Region>
    //{
    //    public int Compare(Region r1, Region r2)
    //    {
    //        if (r1.Name.Length > r2.Name.Length)
    //            return 1;
    //        else if (r1.Name.Length < r2.Name.Length)
    //            return -1;
    //        else
    //            return 0;
    //    }
    //}
}
