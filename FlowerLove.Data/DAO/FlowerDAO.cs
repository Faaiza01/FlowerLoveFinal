using FlowerLove.Data.IDAO;
using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.DAO
{
    public class FlowerDAO : IFlowerDAO
    {
        public void AddUsers(FlowerLoveContext db, tblUser tblUser)
        {
            db.tblUsers.Add(tblUser);
            db.SaveChanges();
        }
        public tblUser GetUser(FlowerLoveContext db, tblUser tblUser)
        {
            return db.tblUsers.SingleOrDefault(m => m.Email == tblUser.Email && m.Password == tblUser.Password);

        }

        public List<tblCategory> GetAllCategories(FlowerLoveContext db)
        {
            return db.tblCategories.ToList();
        }

        public void AddCategory(FlowerLoveContext db, tblCategory tblCategory)
        {
            db.tblCategories.Add(tblCategory);
            db.SaveChanges();
        }

        public tblCategory GetCategoryById(FlowerLoveContext db, int Id)
        {
            return db.tblCategories.SingleOrDefault(m => m.CatId == Id);

        }

        public void EditCategory(FlowerLoveContext db, tblCategory tblCategory)
        {
            db.Entry(tblCategory).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteCategory(FlowerLoveContext db, tblCategory tblCategory)
        {
            db.tblCategories.Remove(tblCategory);
            db.SaveChanges();
        }

        public List<tblProduct> GetAllProducts(FlowerLoveContext db)
        {
            return db.tblProducts.ToList();
        }
        public void AddProduct(FlowerLoveContext db, tblProduct pro)
        {
            db.tblProducts.Add(pro);
            db.SaveChanges();
        }
        public tblProduct GetProductById(FlowerLoveContext db, int Id)
        {
            return db.tblProducts.SingleOrDefault(m => m.ProID == Id);
        }

        public void EditProduct(FlowerLoveContext db, tblProduct tblProduct)
        {
            db.Entry(tblProduct).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProduct(FlowerLoveContext db, tblProduct tblProduct)
        {
            db.tblProducts.Remove(tblProduct);
            db.SaveChanges();
        }



    }
}
