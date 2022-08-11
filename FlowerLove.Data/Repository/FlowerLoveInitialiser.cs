using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerLove.Data.DAO;
using FlowerLove.Data.IDAO;
using FlowerLove.Data.Models.Domain;

namespace FlowerLove.Data.Repository
{
    public class FlowerLoveInitialiser :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<FlowerLoveContext>
    {
        protected override void Seed(FlowerLoveContext context)
        {
            tblCategory tblCategory = new tblCategory()
            {
                Name = "Birthday Flower",

            };
            tblCategory tblCategory2 = new tblCategory()
            {
                Name = "Christmas Flower",
            };
            tblCategory tblCategory3 = new tblCategory()
            {
                Name = "Wedding Flower",
            };
            context.tblCategories.Add(tblCategory);
            context.tblCategories.Add(tblCategory2);
            context.tblCategories.Add(tblCategory3);

            tblUser tblUser = new tblUser()
            {
                Name = "admin",
                Email = "admin@gmail.com",
                Password = "123",
                RoleType = 1,
            };
            context.tblUsers.Add(tblUser);

            tblProduct tblProduct1= new tblProduct()
            {
                Name = "Pink Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 30,
                Image = "img-1.jpg",
                CatId = 1
            };
            context.tblProducts.Add(tblProduct1);

            tblProduct tblProduct2 = new tblProduct()
            {
                Name = "Sun Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 40,
                Image = "img-2.jpg",
                CatId = 2
            };
            context.tblProducts.Add(tblProduct2);

            tblProduct tblProduct3 = new tblProduct()
            {
                Name = "Red Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 90,
                Image = "img-3.jpg",
                CatId = 3
            };
            context.tblProducts.Add(tblProduct3);

            tblProduct tblProduct4 = new tblProduct()
            {
                Name = "Orange Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 40,
                Image = "img-4.jpg",
                CatId = 1
            };
            context.tblProducts.Add(tblProduct4);


            tblProduct tblProduct5 = new tblProduct()
            {
                Name = "White Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 25,
                Image = "img-5.jpg",
                CatId = 2
            };
            context.tblProducts.Add(tblProduct5);

            tblProduct tblProduct6 = new tblProduct()
            {
                Name = "Red Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 60,
                Image = "img-6.jpg",
                CatId = 3
            };
            context.tblProducts.Add(tblProduct6);

            tblProduct tblProduct7 = new tblProduct()
            {
                Name = "Pink Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 35,
                Image = "img-7.jpg",
                CatId = 1
            };
            context.tblProducts.Add(tblProduct7);

            tblProduct tblProduct8 = new tblProduct()
            {
                Name = "Red Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 50,
                Image = "img-8.jpg",
                CatId = 2
            };
            context.tblProducts.Add(tblProduct8);

            tblProduct tblProduct9 = new tblProduct()
            {
                Name = "Red Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 70,
                Image = "img-9.jpg",
                CatId = 3
            };
            context.tblProducts.Add(tblProduct9);

            tblProduct tblProduct10 = new tblProduct()
            {
                Name = "Yellow Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 60,
                Image = "img-10.jpg",
                CatId = 1
            };
            context.tblProducts.Add(tblProduct10);

            tblProduct tblProduct11 = new tblProduct()
            {
                Name = "Red Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 50,
                Image = "img-11.jpg",
                CatId = 2
            };
            context.tblProducts.Add(tblProduct11);

            tblProduct tblProduct12 = new tblProduct()
            {
                Name = "Sun Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 45,
                Image = "img-12.jpg",
                CatId = 3
            };
            context.tblProducts.Add(tblProduct12);

            tblProduct tblProduct13 = new tblProduct()
            {
                Name = "Double Color Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 35,
                Image = "img-13.jpg",
                CatId = 1
            };
            context.tblProducts.Add(tblProduct13);

            tblProduct tblProduct14 = new tblProduct()
            {
                Name = "Colorful Flower Pot",
                Description = "Material : Ceramic, Plant Location : Indoor",
                Unit = 20,
                Image = "img-14.jpg",
                CatId = 2
            };
            context.tblProducts.Add(tblProduct14);

            context.SaveChanges();
        }
    }
}
