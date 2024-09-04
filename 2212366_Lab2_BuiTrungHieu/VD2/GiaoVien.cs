using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    public  class GiaoVien
    {
        public string HoTen { get; set; }

        public string MaSo { get; set; }

        public DanhMucMonHoc dsMonHoc;

        public string GioiTinh;

        public string Mail;

        public DateTime NgaySinh;

        public string[] NgoaiNgu;

        public string soDT;

        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoten, string gioitinh, string mail, DateTime ngaysinh, string[] ngoaingu, string sodt, DanhMucMonHoc ds)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.Mail = mail;
            this.NgaySinh = ngaysinh;
            this.NgoaiNgu = ngoaingu;
            this.soDT = sodt;
            this.dsMonHoc = ds;
        }

        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n"
                     + "Họ tên:" + HoTen + "\n"
                     + "Giới tính:" + GioiTinh + "\n"
                     + "Ngày sinh:" + NgaySinh + "\n"
                     + "Số ĐT:" + soDT + "\n"
                     + "Địa chỉ Mail:" + Mail + "\n";
            string nn = "Ngoại ngữ:";
            foreach (string item in NgoaiNgu)
            {
                nn += item + ",";
            }
            string mh = "Môn học:";
            foreach (MonHoc item in dsMonHoc.ds)
            {
                mh += item + ",";
            }

            return s + nn + "\n" + mh;
        }
    }
}
