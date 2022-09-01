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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void ColorAdd(Color color)
        {
            _colorDal.Insert(color);
        }

        public void ColorDelete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void ColorUpdate(Color color)
        {
            _colorDal.Update(color);
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(x => x.ColorId == id);
        }

        public List<Color> GetList()
        {
            return _colorDal.List();
        }
    }
}
