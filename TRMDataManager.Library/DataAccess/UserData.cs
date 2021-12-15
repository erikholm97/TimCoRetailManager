using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.Inretnal.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SQLDataAccess sqlAccess = new SQLDataAccess();
            //https://youtu.be/p6zMfK_B7a4?t=2716
            var p = new { Id = Id };

            var output = sqlAccess.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "TRM.Data");

            return output;
        }
    }
}
