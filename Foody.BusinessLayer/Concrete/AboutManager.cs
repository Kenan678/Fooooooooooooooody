using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(int id)
        {
            _aboutDal.Delete(id);       
        }

        public List<About> GetAll()
        {
            return  _aboutDal.GetAll(); 
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void Insert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void Update(About entity)
        {
          _aboutDal.Update(entity); 
        }
    }
}
