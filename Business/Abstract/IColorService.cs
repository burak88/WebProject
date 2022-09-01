using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetList();
        void ColorAdd(Color color);
        Color GetById(int id);
        void ColorDelete(Color color);
        void ColorUpdate(Color color);
    }
}
