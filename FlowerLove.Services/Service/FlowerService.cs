using FlowerLove.Data.DAO;
using FlowerLove.Data.IDAO;
using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using FlowerLove.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Services.Service
{
    public class FlowerService : IFlowerService
    {
        IFlowerDAO flowerDAO;
        public FlowerService()
        {
            flowerDAO = new FlowerDAO();
        }

        public void AddUsers(tblUser tblUser)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.AddUsers(db, tblUser);
            }
        }

        public tblUser GetUser(tblUser tblUser)
        {
            using (var db = new FlowerLoveContext())
            {
                return flowerDAO.GetUser(db, tblUser);
            }
        }


        /// <summary>
        /// Catrgories
        /// </summary>
        /// <param name="tblUser"></param>
        /// <returns></returns>
        public List<tblCategory> GetAllCategories()
        {
            using (var db = new FlowerLoveContext())
            {
                return flowerDAO.GetAllCategories(db);
            }
        }

        public void AddCategory(tblCategory tblCategory)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.AddCategory(db, tblCategory);
            }
        }
        public tblCategory GetCategoryById(int Id)
        {
            using (var db = new FlowerLoveContext())
            {
                return flowerDAO.GetCategoryById(db, Id);
            }
        }

        public void EditCategory(tblCategory tblCategory)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.EditCategory(db, tblCategory);
            }
        }

        public void DeleteCategory(tblCategory tblCategory)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.DeleteCategory(db, tblCategory);
            }
        }

        public List<tblProduct> GetAllProducts()
        {
            using (var db = new FlowerLoveContext())
            {
                return flowerDAO.GetAllProducts(db);
            }
        }

        public void AddProduct(tblProduct tblProduct)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.AddProduct(db, tblProduct);
            }
        }
        public tblProduct GetProductById(int Id)
        {
            using (var db = new FlowerLoveContext())
            {
                return flowerDAO.GetProductById(db, Id);
            }
        }

        public void EditProduct(tblProduct tblProduct)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.EditProduct(db, tblProduct);
            }
        }
        public void DeleteProduct(tblProduct tblProduct)
        {
            using (var db = new FlowerLoveContext())
            {
                flowerDAO.DeleteProduct(db, tblProduct);
            }
        }



    }
}
