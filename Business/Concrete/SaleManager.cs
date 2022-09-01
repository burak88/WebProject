using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }

        public Sale GetById(int id)
        {
            return _saleDal.Get(p => p.SaleId == id);
        }

        public List<Sale> GetList()
        {
            return _saleDal.List();
        }

        public void SaleAdd(Sale sale)
        {
            _saleDal.Insert(sale);
        }

        public void SaleDelete(Sale sale)
        {
            _saleDal.Delete(sale);
        }

        public void SaleUpdate(Sale sale)
        {
            _saleDal.Update(sale);
        }
    }
}
