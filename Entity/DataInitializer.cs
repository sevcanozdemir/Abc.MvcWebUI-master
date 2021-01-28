using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            

            var kategoriler = new List<Category>()
            {
                new Category(){Name="Topuklu Ayakkabı", Description="Topuklu Ayakkabı Ürünleri"},
                new Category(){Name="Spor Ayakkabı", Description="Spor Ayakkabı Ürünleri" },
                new Category(){Name="Babet",Description="Babet Ürünleri"},
                new Category(){Name="Çizme",Description="Çizme Ürünleri"},
                new Category(){Name="Terlik",Description="Terlik Ürünleri"}


            };
            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Taşlı Siyah Stiletto",Description="Siyah Kadın Klasik Topuklu Ayakkabı TAKAW20TO0121", Price=350, Stock=1200 , IsApproved=false , CategoryId=1,IsHome=true, Image="1.jpg" },
                new Product(){Name="Kırmızı Bantlı Topuklu Ayakkabı",Description="Kırmızı Kadın Ayakkabı 01AYH127780A750", Price=200 , Stock= 100, IsApproved=false , CategoryId=1,IsHome=true , Image="2.jpg"},
                new Product(){Name="Fox Shoes",Description="Siyah Kadın Topuklu Ayakkabı B922112609", Price=150 , Stock=50 , IsApproved=true , CategoryId=1 ,IsHome=true, Image="3.jpg"},
                new Product(){Name="Bershka",Description="Kadın Siyah İnce Topuklu Ayakkabı 15510031", Price= 250, Stock=45, IsApproved=true , CategoryId=1 , Image="4.jpg"},
                new Product(){Name="Hotiç",Description="Hakiki Deri Mor Kadın Abiye Ayakkabı 01AYH128060A660", Price=350 , Stock=25 , IsApproved=true , CategoryId=1, Image="5.jpg" },


                new Product(){Name="Du Jour Paris",Description="Beyaz Platin Kadın Spor Ayakkabı 4000-19-101001", Price=400 , Stock=55 , IsApproved=true , CategoryId=2,IsHome=true , Image="6.jpg"},
                new Product(){Name="Puma",Description="Unisex Spor Ayakkabı - Puma Smash v2 Buck Jr - 36518212", Price=450 , Stock=15 , IsApproved=true , CategoryId=2 , Image="7.jpg"},
                new Product(){Name="Tonny Black",Description="Beyaz Kadın Sneaker TB704-1", Price=520 , Stock=60 , IsApproved= true, CategoryId=2 ,IsHome=true, Image="8.jpg"},
                new Product(){Name="New Balance",Description="Kadın Spor Ayakkabı - Lifestyle - WL515GBP", Price=400, Stock=20 , IsApproved=true , CategoryId=2, Image="9.jpg"},
                new Product(){Name="HUMMEL",Description="Ayakkabı Messmer 206308-9001", Price=350 , Stock=25 , IsApproved= true, CategoryId=2 ,IsHome=true, Image="10.jpg"},

                new Product(){Name="Graceland",Description="Deichmann Kadın Siyah Babet 1104818", Price=100 , Stock=30 , IsApproved= true, CategoryId=3,IsHome=true , Image="11.jpg"},
                new Product(){Name="Bambi",Description="Pudra Kadın Babet F0378161972", Price=150 , Stock=10 , IsApproved=true , CategoryId=3,IsHome=true, Image="12.jpg" },
                new Product(){Name="Bruno Shoes",Description="1253 KADIN KAUÇUK TABAN AYAKKABI - SARI T03YBAY0008-SARI", Price=200 , Stock=70 , IsApproved=true , CategoryId=3, Image="13.jpg" },
                new Product(){Name="Bambi",Description="Turuncu Kadın Babet F0365300072", Price=150 , Stock=20 , IsApproved=true , CategoryId=3,IsHome=true , Image="14.jpg"},
                new Product(){Name="Loggalin",Description="Siyah Kadın Babet ST_782268_027", Price=120 , Stock=13 , IsApproved=true , CategoryId=3, Image="15.jpg" },

                new Product(){Name="Nizar Deniz",Description="Taba Kadın Bot & Bootie 4070000", Price=500 , Stock=50, IsApproved= true, CategoryId=4 ,IsHome=true, Image="16.jpg"},
                new Product(){Name="Nizar Deniz",Description="Siyah Kadın Çizme 6030000", Price=600 , Stock=80 , IsApproved=true , CategoryId= 4,IsHome=true, Image="17.jpg"},
                new Product(){Name="Bershka",Description="Kadın Siyah Yüksek Topuklu Elastik Bilekte Bot 15143031", Price=250 , Stock=60 , IsApproved=true , CategoryId= 4, Image="18.jpg"},
                new Product(){Name="Bambi",Description="Siyah Kadın Bot K06391151", Price=150 , Stock=90 , IsApproved=true , CategoryId=4,IsHome=true, Image="19.jpg" },
                new Product(){Name="Pull & Bear",Description="Kadın Siyah Orta Boy Topuklu Diz Altı Siyah Çizme 15003011", Price=280, Stock=80 , IsApproved= true, CategoryId=4, Image="20.jpg" }
               

            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);


        }

    }
}