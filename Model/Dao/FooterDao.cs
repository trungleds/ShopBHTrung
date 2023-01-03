using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class FooterDao
    {
        OnLineShopDbContext db = null;
        public FooterDao()
        {
            db = new OnLineShopDbContext();
        }
        public Footer GetFooter()
        {
            return db.Footers.SingleOrDefault(x=>x.Status == true);
        }
    }
  
}
