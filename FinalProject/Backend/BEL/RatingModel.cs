using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RatingModel
    {
        public int ratingid { get; set; }
        public int userid { get; set; }
        public int packageid { get; set; }
        public double rating1 { get; set; }
        public string complain { get; set; }
        public string complainstatus { get; set; }

        public string package_packagename { get; set; }
        public string user_name { get; set; }
    }
}
