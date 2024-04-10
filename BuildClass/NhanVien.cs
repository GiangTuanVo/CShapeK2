using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClass
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string Ten { get; set; }

        public void TinhLuong()
        {
            Console.WriteLine("Day la phuong thuc tinh luong nhan vien");
        }
        public virtual int TinhLuong(int ngaycong)
        {
            return ngaycong * 100;
        }
    }
}
