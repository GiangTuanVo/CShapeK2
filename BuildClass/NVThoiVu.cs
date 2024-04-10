using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClass
{
    class NVThoiVu : NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Day la phuong thuc tinh luong VNTV");
        }
        public override int TinhLuong(int ngaycong)
        {
            return base.TinhLuong(ngaycong);
        }
    }
}
