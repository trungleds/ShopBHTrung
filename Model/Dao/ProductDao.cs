﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductDao
    {
        OnLineShopDbContext db = null;
        public ProductDao() { 
            db  = new OnLineShopDbContext();
        }
        public List<Product> ListNewProduct(int top) {
            return db.Products.OrderByDescending(x=>x.CreateDate).Take(top).ToList();
        }
        public List<Product> ListFeatureProduct(int top)
        {
            return db.Products.Where(x => x.TopHot != null && x.TopHot > DateTime.Now).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
                
    }
}
