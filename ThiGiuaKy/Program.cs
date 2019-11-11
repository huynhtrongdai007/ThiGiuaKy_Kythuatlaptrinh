using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            ClsHinhTron ht = new ClsHinhTron();
            ClsMenu menu = new ClsMenu();
            List<ClsHinhTron> listHinhTron = new List<ClsHinhTron>(); 
            int iLuachon;
     
            menu.AddItem("Nhap Thong tin duong Tron");
            menu.AddItem("Tinh chu vi hinh Tron");
            menu.AddItem("Tinh Dien Tinh Hinh Tron");
            menu.AddItem("Thoat");
  
           do
           {
               iLuachon = menu.DisplayMenu();
                if(iLuachon == 0)
               {     
                   ht.NhapThongTin();
                   listHinhTron.Add(ht);
               }
            else if(iLuachon == 1)
            {
                Console.Write("Chu vi hinh tron = ",ht.ChuVi());
                Console.ReadKey();
            }
            else if(iLuachon == 2)
            {

               
                Console.Write("Dien tich hinh chon = ",ht.TinhDienTich());
                Console.ReadKey();
            }
           }while(iLuachon != 3);
        }
    }
}
