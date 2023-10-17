
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface ISinhVienService
    {
        public string Add(Sinhvien sv);
        public string Remove(Sinhvien sv);
        public string Update(Sinhvien sv);
        public List<Sinhvien> GetSV(string search, int type);

        public Phuhuynh GetPH(int id);
    }
}
