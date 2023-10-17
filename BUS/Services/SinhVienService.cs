using BUS.IServices;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SinhVienService : ISinhVienService
    {
        private RepositoriesSinhVien _repos;
        
        public SinhVienService()
        {
            _repos = new RepositoriesSinhVien();
        }

        public string Add(Sinhvien sv)
        {
            try
            {
                _repos.AddSV(sv);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }
        }

        public Phuhuynh GetPH(int id)
        {
            return _repos.GetPhuhuynhs().FirstOrDefault(x => x.Id == id);
        }

        public List<Sinhvien> GetSV(string search, int type)
        {
            if (search != null)
            {
                switch (type)
                {
                    case 1: // Tìm theo mã
                        return _repos.GetSinhviens().Where(x => x.Ten.Contains(search)).ToList();
                    case 2: //Tìm theo địa chỉ
                        return _repos.GetSinhviens().Where(x => x.Diachi.Contains(search)).ToList();
                    case 3: //Tìm theo SDT
                        return _repos.GetSinhviens().Where(x => x.Sdt.Contains(search)).ToList();
                    default:
                        return _repos.GetSinhviens().Where(x => x.Ten.Contains(search) || x.Diachi.Contains(search) || x.Sdt.Contains(search)).ToList();
                }
            }
            else
            {
                return _repos.GetSinhviens().ToList();
            }
        }

        public string Remove(Sinhvien sv)
        {
            var clone = _repos.GetSinhviens().FirstOrDefault(x => x.Id == sv.Id);
            try
            {
                if (clone == null)
                {
                    return "Xóa thất bại";
                }
                else
                {
                    _repos.DeleteSV(clone);
                    return "Xóa thành công";
                }
            }
            catch (Exception ex)
            {

                return "Có lỗi xảy ra";
            }
        }

        public string Update(Sinhvien sv)
        {
            var clone = _repos.GetSinhviens().FirstOrDefault(x => x.Id == sv.Id);
            try
            {
                if (clone == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    clone.Ten = sv.Ten;
                    clone.Sdt = sv.Sdt;
                    clone.Diachi = sv.Diachi;
                    clone.Email = sv.Email;
                    clone.IdPh = sv.IdPh;
                    _repos.DeleteSV(clone);
                    return "Sửa thành công";
                }
            }
            catch (Exception ex)
            {

                return "Có lỗi xảy ra";
            }
        }
    }
}
