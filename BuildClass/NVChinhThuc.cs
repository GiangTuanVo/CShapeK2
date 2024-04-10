using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClass
{
    class NVChinhThuc : NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Day la phuong thuc tinh luong VNCT");
        }
        public override int TinhLuong(int ngaycong)
        {
            if (ngaycong == 20) return 100000000;

            return 1444;
        }
    }
}
