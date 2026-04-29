using System;
using System.Collections.Generic;
using System.Text;

namespace Verseny
{
    internal class Versenyző
    {
        private int Id;
        private string Név;
        public List<int> Eredmények;

        public Versenyző(int id, string név, List<int> eredmények)
        {
            Id = id;
            Név = név;
            //Eredmények = new List<int>();
            Eredmények = eredmények;
        }

        public override string ToString()
        {
            //id név, eredményei: eredmény1, …legjobb: legjobbEredmény
            string s = $"{Id} {Név}, eredményei: ";
            foreach (var item in Eredmények)
            {
                s += $"{item}, ";
            }
            s += $"legjobb: {legjobbUgrás()}";
            return s;
        }

        private int legjobbUgrás()
        {
            int maxi = 0;
            for (int i = 0; i < Eredmények.Count; i++)
            {
                if (Eredmények[i] > Eredmények[maxi])
                {
                    maxi = i;
                }
            }
            return Eredmények[maxi];
        }

        public void setId(int id)
        {
            Id=id;
        }
        public int getId()
        {
            return Id;
        }

        public void setNév(string név)
        {
            Név=név;
        }
        public string getNév()
        {
            return Név;
        }
    }
}
