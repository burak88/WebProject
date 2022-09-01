using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISaleService
    {
        List<Sale> GetList();
        void SaleAdd(Sale sale);
        Sale GetById(int id);
        void SaleDelete(Sale sale);
        void SaleUpdate(Sale sale);
    }
}
