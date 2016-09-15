using System;
using System.Linq;

namespace AlexaSkill.Data
{
    public class Requests
    {
        public Request Create(Request request)
        {
        //    using (var db = new bobcatdatabaseEntities())
        //    {
        //        var member = db.Members.FirstOrDefault(m => m.AlexaUser == request.UserId);

        //        if (member == null)
        //        {
        //            request.Member = new Member() { AlexaUser = request.UserId, CreatedDate = DateTime.UtcNow, ListRequestDate = DateTime.UtcNow, RequestCount = 1 };

        //            db.Requests.Add(request);
        //        }
        //        else
        //        {
        //            member.Requests.Add(request);
        //        }

        //        db.SaveChanges();
        //    }

            return request;
        }
    }
}
