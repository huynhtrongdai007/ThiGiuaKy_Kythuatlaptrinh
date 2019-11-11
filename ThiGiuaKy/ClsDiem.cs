using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy
{
    class ClsDiem
    {

        public int iX{get;set;}
        public int iY { get; set; }

        public  ClsDiem(int ix, int iy)
        {
            iX = ix;
            iY = iy;
        }

        public ClsDiem(ClsDiem diem)
        {
            iX=diem.iX;
            iY = diem.iY;
        }
        public ClsDiem()
        {

        }
    }
}
