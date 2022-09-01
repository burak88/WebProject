using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetList();
        void CustomerAdd(Customer customer);
        Customer GetById(int id);
        void CustomerDelete(Customer customer);
        void CustomerUpdate(Customer customer);
    }
}
