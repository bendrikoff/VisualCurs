using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCurs
{
    public static class FederalDistricts
    {
        public static List<FederalDistrict> list=new List<FederalDistrict>();

        public static List<FederalDistrict> Search(string str)
        {
            List<FederalDistrict> federalDistricts = new List<FederalDistrict>();

            foreach (FederalDistrict federalDistrict in list)
            {

                if (federalDistrict.name.ToLower().Contains(str.ToLower()))
                {
                    federalDistricts.Add(federalDistrict);
                }
            }
            return federalDistricts;
        }
        public static void SortPops()
        {
            FederalDistricts.list.Sort(new PopComparer<FederalDistrict>());
        }
        public static void SortArea()
        {
            FederalDistricts.list.Sort(new AreaComparer<FederalDistrict>());
        }
    }
    public class FederalDistrict
    {
      public string name;
      public   int area;
      public   int population;
      public  string center;

        public FederalDistrict(string name,int area,int population,string center)
        {
            this.name = name;
            this.area = area;
            this.population = population;
            this.center = center;
        }
    }
    public class AreaComparer<T> : IComparer<T> where T : FederalDistrict
    {
        public int Compare(T p1, T p2)
        {
            if (p1.area > p2.area)
                return -1;
            else if (p1.area < p2.area)
                return 1;
            else
                return 0;
        }
    }
    public class PopComparer<T> : IComparer<T> where T : FederalDistrict
    {
        public int Compare(T p1, T p2)
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
