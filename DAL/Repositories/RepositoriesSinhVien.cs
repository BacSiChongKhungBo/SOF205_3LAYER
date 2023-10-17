using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositoriesSinhVien : ISinhVienRepository
    {
        private DBContext _dbContext;
        public RepositoriesSinhVien()
        {
            _dbContext = new DBContext();
        }
        public bool AddSV(Sinhvien sv)
        {
            _dbContext.Add(sv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSV(Sinhvien sv)
        {
            _dbContext.Remove(sv);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Phuhuynh> GetPhuhuynhs()
        {
            return _dbContext.Phuhuynhs.ToList();
        }

        public List<Sinhvien> GetSinhviens()
        {
            return _dbContext.Sinhviens.ToList();
        }

        public bool UpdateSV(Sinhvien sv)
        {
            _dbContext.Update(sv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
