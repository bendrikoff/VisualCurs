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

    
}
