using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface ISinhVienRepository
    {
        //chỉ chứa hàm k chứa code
        // thêm sửa xoá và lấy danh sách
        //danh sách phụ huynh
        public List<Sinhvien> GetSinhviens();
        public List<Phuhuynh> GetPhuhuynhs();
        public bool UpdateSV(Sinhvien sv);
        public bool DeleteSV(Sinhvien sv);
        public bool AddSV(Sinhvien sv);

    }
}
