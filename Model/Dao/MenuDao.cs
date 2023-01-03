using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class MenuDao
    {
        OnLineShopDbContext db = null;
        public MenuDao() {

            db = new OnLineShopDbContext();

        }
        public List<Menu1> ListByGroupId(int groupId)
        {
            return db.Menu1.Where(x => x.TypeID == groupId && x.Status==true).OrderBy(x=> x.DisplayOder).ToList();
        }
    }
}
