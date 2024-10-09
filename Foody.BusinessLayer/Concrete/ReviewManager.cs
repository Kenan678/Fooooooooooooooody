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
    public   class ReviewManager:IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewManager(IReviewDal ReviewDal)
        {
            _reviewDal = ReviewDal;
        }

        public void Delete(int id)
        {
            _reviewDal.Delete(id);
        }

        public List<Review> GetAll()
        {
            return _reviewDal.GetAll();
        }

        public Review GetById(int id)
        {
            return _reviewDal.GetById(id);
        }

        public void Insert(Review entity)
        {
            _reviewDal.Insert(entity);
        }

        public void Update(Review entity)
        {
            _reviewDal.Update(entity);
        }
    }
}
