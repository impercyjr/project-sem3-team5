namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<T1809E.SEM3.P102_Team05.Data.AppDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(T1809E.SEM3.P102_Team05.Data.AppDatabaseContext context)
        {
<<<<<<< Updated upstream
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
=======
            // context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            // context.Products.AddOrUpdate(new Product()
            // {
            //     Id = 1,
            //     Name = "Kem Đánh Răng",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2446/86596/bhx/kdr-sensodyne-trang-sang-100g-2-700x467.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-15"),
            //     DeleteAt = DateTime.Parse("2019-02-03"),
            //     InStock = 1,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 2,
            //     Name = "Bàn Chải",
            //     Thumbnail = "https://phugiatrading.com/wp-content/uploads/2019/02/ban-chai-danh-rang-han-quoc-bio-care-crystal-nano-gold-1001g-2-1.jpg",
            //     Price = 15000,
            //     CreateAt = DateTime.Parse("2019-01-04"),
            //     UpdateAt = DateTime.Parse("2019-01-16"),
            //     DeleteAt = DateTime.Parse("2019-02-04"),
            //     InStock = 2,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 3,
            //     Name = "Dầu Gội",
            //     Thumbnail = "https://depcosmetics.vn/wp-content/uploads/2017/01/8934868113652_1.jpg",
            //     Price = 65000,
            //     CreateAt = DateTime.Parse("2019-01-05"),
            //     UpdateAt = DateTime.Parse("2019-01-17"),
            //     DeleteAt = DateTime.Parse("2019-02-07"),
            //     InStock = 3,
            //     Status = OrderStatus.ACTIVE
            // }, new Product()
            // {
            //     Id = 4,
            //     Name = "Dầu Rửa Bát",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-18"),
            //     DeleteAt = DateTime.Parse("2019-02-06"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 5,
            //     Name = "Áo Len",
            //     Thumbnail = "https://bizweb.dktcdn.net/100/107/464/files/9498404712-307052022.jpg?v=1564733482956",
            //     Price = 105000,
            //     CreateAt = DateTime.Parse("2019-01-15"),
            //     UpdateAt = DateTime.Parse("2019-01-20"),
            //     DeleteAt = DateTime.Parse("2019-02-13"),
            //     InStock = 3,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 6,
            //     Name = "Áo Sơ Mi",
            //     Thumbnail = "https://salt.tikicdn.com/cache/550x550/ts/product/8e/4d/53/27b355f238f46235c9fefcd07a1cfd0e.jpg",
            //     Price = 75000,
            //     CreateAt = DateTime.Parse("2019-01-12"),
            //     UpdateAt = DateTime.Parse("2019-01-21"),
            //     DeleteAt = DateTime.Parse("2019-02-05"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 7,
            //     Name = "Dầu Rửa Bát",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-25"),
            //     DeleteAt = DateTime.Parse("2019-02-23"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 8,
            //     Name = "Quần Jean",
            //     Thumbnail = "https://vn-live-03.slatic.net/original/7efdce91f32f7004c953ddc8a22216d4.jpg",
            //     Price = 135000,
            //     CreateAt = DateTime.Parse("2019-02-23"),
            //     UpdateAt = DateTime.Parse("2019-03-15"),
            //     DeleteAt = DateTime.Parse("2019-03-24"),
            //     InStock = 19,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 9,
            //     Name = "Áo Khoác nam",
            //     Thumbnail = "https://bizweb.dktcdn.net/thumb/large/100/180/420/products/750x750-1-1.jpg",
            //     Price = 225000,
            //     CreateAt = DateTime.Parse("2019-03-13"),
            //     UpdateAt = DateTime.Parse("2019-03-15"),
            //     DeleteAt = DateTime.Parse("2019-04-03"),
            //     InStock = 40,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 10,
            //     Name = "Áo khoác nữ",
            //     Thumbnail = "https://quanaogiaxuong.com/wp-content/uploads/8947-clean-z1437963267757-960adcd8edf1993390eb7cec2fc8f9dc.jpg",
            //     Price = 235000,
            //     CreateAt = DateTime.Parse("2019-01-17"),
            //     UpdateAt = DateTime.Parse("2019-01-25"),
            //     DeleteAt = DateTime.Parse("2019-02-30"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // });
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Orders");
            context.Orders.AddOrUpdate(new Order()
            {
                OrderId=1,
                CustomerID=101,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
                Status = OrderStatus1.ACTIVE
            },new Order()
            {
                OrderId = 2,
                CustomerID = 102,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-02-17"),
                UpdatedAt = DateTime.Parse("2019-02-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
               Status = OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 3,
                CustomerID = 103,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-03-13"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-04-30"),
                Status = OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 4,
                CustomerID = 104,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-17"),
                UpdatedAt = DateTime.Parse("2019-04-25"),
                DeletedAt = DateTime.Parse("2019-05-30"),
               Status = OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 5,
                CustomerID = 105,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2019-05-17"),
                UpdatedAt = DateTime.Parse("2019-05-25"),
                DeletedAt = DateTime.Parse("2019-06-30"),
               Status = OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 6,
                CustomerID = 106,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-06-17"),
                UpdatedAt = DateTime.Parse("2019-06-25"),
                DeletedAt = DateTime.Parse("2019-07-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 7,
                CustomerID = 107,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-07-17"),
                UpdatedAt = DateTime.Parse("2019-07-25"),
                DeletedAt = DateTime.Parse("2019-08-30"),
               Status = OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 8,
                CustomerID = 108,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760000,
                CreatedAt = DateTime.Parse("2019-08-17"),
                UpdatedAt = DateTime.Parse("2019-08-25"),
                DeletedAt = DateTime.Parse("2019-09-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 9,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2019-09-17"),
                UpdatedAt = DateTime.Parse("2019-09-25"),
                DeletedAt = DateTime.Parse("2019-10-30"),
               Status = OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 10,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 11,
                CustomerID = 112,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-20"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 12,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Hanoi",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-18"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 13,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "DN",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-08"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 14,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-09"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 15,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-22"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 16,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 9000000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-16"),
                DeletedAt = DateTime.Parse("2019-02-20"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 17,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 18,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-03"),
                UpdatedAt = DateTime.Parse("2019-01-10"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 19,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
             new Order()
             {
                OrderId = 20,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 20,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 21,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "ThaiLand",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-08"),
                UpdatedAt = DateTime.Parse("2019-02-16"),
                DeletedAt = DateTime.Parse("2019-02-20"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 22,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
new Order()
             {
                OrderId = 23,
                CustomerID = 112,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-06"),
                UpdatedAt = DateTime.Parse("2019-02-14"),
                DeletedAt = DateTime.Parse("2019-02-18"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 24,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 25,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Dong Nai",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 26,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 27,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "HCM",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-23"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 28,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-24"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 29,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-02-07"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-02-25"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 30,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 31,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 32,
                CustomerID = 110,
                OrderNumber = 4,
                ShippingAddress = "CanTho",
                Total = 1900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 34,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "VP",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-09"),
                UpdatedAt = DateTime.Parse("2019-03-16"),
                DeletedAt = DateTime.Parse("2019-03-20"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 35,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 36,
                CustomerID = 112,
                OrderNumber = 3,
                ShippingAddress = "Hanoi",
                Total = 920400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 37,
                CustomerID = 110,
                OrderNumber = 6,
                ShippingAddress = "Nghean",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 38,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-03-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 39,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Camau",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 40,
                CustomerID = 120,
                OrderNumber = 6,
                ShippingAddress = "Camau",
                Total = 853323,
                CreatedAt = DateTime.Parse("2019-04-08"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 41,
                CustomerID = 134,
                OrderNumber = 3,
                ShippingAddress = "Dong Nai",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-04-08"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-05-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 42,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Hanoi",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-04-08"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-04-20"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 43,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Camau",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 44,
                CustomerID = 120,
                OrderNumber = 1,
                ShippingAddress = "Ha Nam",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-04-08"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-05-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 44,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Camau",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 45,
                CustomerID = 115,
                OrderNumber = 3,
                ShippingAddress = "Hoang Sa",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 46,
                CustomerID = 116,
                OrderNumber = 6,
                ShippingAddress = "Camau",
                Total = 12340310,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 47,
                CustomerID = 143,
                OrderNumber = 13,
                ShippingAddress = "Tay Nguyen",
                Total = 1234041,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 48,
                CustomerID = 120,
                OrderNumber = 3,
                ShippingAddress = "Cao Bang",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 49,
                CustomerID = 140,
                OrderNumber = 9,
                ShippingAddress = "Tây ban nha",
                Total = 123400,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            new Order()
             {
                OrderId = 50,
                CustomerID = 150,
                OrderNumber = 7,
                ShippingAddress = "Đức",
                Total = 123410,
                CreatedAt = DateTime.Parse("2019-03-08"),
                UpdatedAt = DateTime.Parse("2019-03-15"),
                DeletedAt = DateTime.Parse("2019-04-19"),
               Status = OrderStatus1.ACTIVE
            });
            
            
            
            
>>>>>>> Stashed changes
        }
}
