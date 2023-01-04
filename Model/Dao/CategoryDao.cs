using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryDao
    {
        OnLineShopDbContext db = null;
        public CategoryDao() {
            db = new OnLineShopDbContext();
            
        }
        public List<Category> ListAll(long id)
        {
            return db.Categories.Where(x=>x.Status == true).ToList();   
        }
      
        }

    }
}
