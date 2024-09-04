using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    public class MonHoc
    {
        public int ID { get; set; }

        public int SoTC { get; set; }

        public string TenMH { get; set; }

        public MonHoc()
        {

        }

        public MonHoc(int id, string ten, int tc)
        {
            this.ID = id;
            this.SoTC = tc;
            this.TenMH = ten;
        }

        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }

        public override string ToString()
        {
            //return string.Format("{0}, {1}, {2}", ID, TenMH, SoTC);
            return TenMH;
        }
    }
}
