using LinqToTwitter;
using System.Collections.Generic;

namespace TweetScope.Web.UI.ViewModel
{
    public class AnalyzeViewModel
    {
        public IEnumerable<Status> MostLikedStatuses { get; set; }  
        public IEnumerable<Status> MostReTweetStatuses { get; set; }
    }
}