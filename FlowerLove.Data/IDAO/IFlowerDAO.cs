using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.IDAO
{
    public interface IFlowerDAO
    {
        void AddUsers(FlowerLoveContext db, tblUser tblUser);
        tblUser GetUser(FlowerLoveContext db, tblUser tblUser);
        List<tblCategory> GetAllCategories(FlowerLoveContext db);
        void AddCategory(FlowerLoveContext db, tblCategory tblCategory);
        tblCategory GetCategoryById(FlowerLoveContext db, int Id);
        void EditCategory(FlowerLoveContext db, tblCategory tblCategory);
        void DeleteCategory(FlowerLoveContext db, tblCategory tblCategory);
        List<tblProduct> GetAllProducts(FlowerLoveContext db);
        void AddProduct(FlowerLoveContext db, tblProduct pro);
        tblProduct GetProductById(FlowerLoveContext db, int Id);
        void EditProduct(FlowerLoveContext db, tblProduct tblProduct);
        void DeleteProduct(FlowerLoveContext db, tblProduct tblProduct);
    }
}
