using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RatingRepo
    {
        //static ANTSEntities ContextClass.context;
        //static RatingRepo()
        //{
        //    ContextClass.context = new ANTSEntities();
        //}

        public static List<Rating> GetAllRatings()
        {
            return ContextClass.context.Ratings.Where(e => e.complain != null).ToList();
        }

        public static Rating GetRating(int id)
        {
            return ContextClass.context.Ratings.FirstOrDefault(e => e.ratingid == id);
        }

        public static Rating AddRating(Rating r)
        {
            ContextClass.context.Ratings.Add(r);
            ContextClass.context.SaveChanges();
            return r;
        }

        public static Rating EditRating(Rating r)
        {
            var rating = ContextClass.context.Ratings.FirstOrDefault(e => e.ratingid == r.ratingid);
            ContextClass.context.Entry(rating).CurrentValues.SetValues(r);
            ContextClass.context.SaveChanges();
            return rating;
        }

        public static Rating DeleteRating(int id)
        {
            var rating = ContextClass.context.Ratings.FirstOrDefault(e => e.ratingid == id);
            ContextClass.context.Ratings.Remove(rating);
            ContextClass.context.SaveChanges();
            return rating;
        }
    }
}
