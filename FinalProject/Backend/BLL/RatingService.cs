using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class RatingService
    {
        public static List<RatingModel> GetAllRatings()
        {
            var ratings = RatingRepo.GetAllRatings();
            return AutoMapper.Mapper.Map<List<Rating>, List<RatingModel>>(ratings);
        }

        public static RatingModel GetRating(int id)
        {
            var rating = RatingRepo.GetRating(id);
            return AutoMapper.Mapper.Map<Rating, RatingModel>(rating);
        }

        public static RatingModel AddRating(RatingModel rating)
        {
            var r = AutoMapper.Mapper.Map<RatingModel, Rating>(rating);
            var data = RatingRepo.AddRating(r);
            return AutoMapper.Mapper.Map<Rating, RatingModel>(data);
        }

        public static RatingModel EditRating(RatingModel rating)
        {
            var r = AutoMapper.Mapper.Map<RatingModel, Rating>(rating);
            var data = RatingRepo.EditRating(r);
            return AutoMapper.Mapper.Map<Rating, RatingModel>(data);
        }

        public static RatingModel DeleteRating(int id)
        {
            var rating = RatingRepo.DeleteRating(id);
            return AutoMapper.Mapper.Map<Rating, RatingModel>(rating);
        }
    }
}
