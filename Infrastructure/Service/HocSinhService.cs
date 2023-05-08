using Infrastructure.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IHocSinhService
    {
        IQueryable<HocSinh> GetTatCaHocSinh();
        HocSinh GetHocSinh(int id);
        void InsertHocSinh(HocSinh hocSinh);
        void UpdateHocSinh(HocSinh hocSinh);
        void DeleteHocSinh(HocSinh hocSinh);
    }

    public class HocSinhService : IHocSinhService
    {
        private IHocSinhRepository hocSinhRepository;

        public HocSinhService(IHocSinhRepository hocSinhRepository)
        {
            this.hocSinhRepository = hocSinhRepository;
        }

        public IQueryable<HocSinh> GetTatCaHocSinh()
        {
            return hocSinhRepository.GetAll();
        }

        public HocSinh GetHocSinh(int id)
        {
            return hocSinhRepository.GetById(id);
        }

        public void InsertHocSinh(HocSinh hocSinh)
        {
            hocSinhRepository.Insert(hocSinh);
        }

        public void UpdateHocSinh(HocSinh hocSinh)
        {
            hocSinhRepository.Update(hocSinh);
        }

        public void DeleteHocSinh(HocSinh hocSinh)
        {
            hocSinhRepository.Delete(hocSinh);
        }
    }
}
