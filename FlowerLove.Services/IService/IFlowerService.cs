using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Services.IService
{
    public interface IFlowerService
    {
        void AddUsers(tblUser tblUser);
        tblUser GetUser(tblUser tblUser);
        List<tblCategory> GetAllCategories();
        void AddCategory(tblCategory tblCategory);
        tblCategory GetCategoryById(int Id);
        void EditCategory(tblCategory tblCategory);
        void DeleteCategory(tblCategory tblCategory);
        List<tblProduct> GetAllProducts();
        void AddProduct(tblProduct tblProduct);
        tblProduct GetProductById(int Id);
        void EditProduct(tblProduct tblProduct);
        void DeleteProduct(tblProduct tblProduct);
    }
}
