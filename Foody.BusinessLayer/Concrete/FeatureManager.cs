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
    public   class FeatureManager:IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal FeatureDal)
        {
            _featureDal = FeatureDal;
        }

        public void Delete(int id)
        {
            _featureDal.Delete(id);
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void Insert(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void Update(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
