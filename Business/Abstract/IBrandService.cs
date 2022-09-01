using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetList();
        Brand GetById(int id);
        void BrandAdd(Brand brand);
        void BrandDelete(Brand brand);
        void BrandUpdate(Brand brand);

    }
}
