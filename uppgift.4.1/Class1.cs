using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift._4._1
{
    public class Djur
    {
        private string namn;
        private int older;
        public string getNamn()
        {
            return this.namn;
        }
        public void setNamn(string name)
        {
            this.namn = namn;
        }
        public class katt : Djur
        {
            private int tassStorlek;
            public void settassStorlek(int tassStorlek)
            {
                this.tassStorlek = tassStorlek;
            }
            public int gettassStorlek()
            {
                return this.tassStorlek;
            }
            public void jama()
            {
                Console.WriteLine("meow");
            }
        }
    }
}