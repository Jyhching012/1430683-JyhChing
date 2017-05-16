using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1430683_ASG.Models
{
    public class InfoUserModel
    {
        public InformationOfUser GetInformationOfUser(string guId)
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            InformationOfUser info = (from x in db.InformationOfUsers
                                      where x.GUID == guId
                                      select x).FirstOrDefault();

            return info;
        }

        public void  InsertInformationOfUser(InformationOfUser info)
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            db.InformationOfUsers.Add(info);
            db.SaveChanges();
        }

    }
}