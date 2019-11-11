using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy
{
    class ClsHinhTron
    {

        double R;
      
         ClsDiem Tam = new ClsDiem();

         public ClsDiem sTam
         {
             get{
                    return Tam;
             }
             set
             {
                 Tam = value;
             }
         }
        public virtual void NhapThongTin()
         {
             int x, y;
             
             Console.Write("Nhap ban kinh R = ");
             R = double.Parse(Console.ReadLine());
             Console.Write("Nhap X xua tam duong tron");
             x = int.Parse(Console.ReadLine());
             Console.Write("Nhap Y xua tam duong tron");
             y = int.Parse(Console.ReadLine());
             Tam = new ClsDiem(x, y);
            
        
         }

         public double ChuVi()
         {
             double S = R * 2 * 3.14;
             return S;
         }

         public double TinhDienTich()
         {
             double C = Math.Pow(R,2) * 3.14;
             return C;
         }
    }
}
