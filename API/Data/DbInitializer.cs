using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
          {
       new Product
                {
                    Name = "IPhone 13",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 50000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/kg8avm80/mobile/y/7/n/apple-iphone-12-dummyapplefsn-original-imafwg8dqq7z8cgh.jpeg?q=70",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "Galaxy Tablet",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/612/612/kb5eikw0/tablet/6/h/g/samsung-sm-p615nzaainu-original-imafskyngvk7phfk.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "Tablet",
                    QuantityInStock = 100
                },
new Product 
                {
                    Name = "Galaxy A2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/416/416/k2jbyq80pkrrdj/mobile-refurbished/r/b/x/galaxy-a2-core-16-c-sm-a260gzkgins-samsung-1-original-imaffnw4bjqdmapm.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },

new Product
                {
                    Name = "Galaxy A1",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/kamtsi80/mobile/z/c/w/samsung-galaxy-a31-sm-a315fzbwins-original-imafs5p5kwscdurq.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "FeaturePhone",
                    QuantityInStock = 100
                },

               new Product
                {
                    Name = "IPad",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 27000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/k0lbdzk0pkrrdj/tablet/n/u/c/apple-muqx2hn-a-original-imaff849epq2fjj5.jpeg?q=70",
                    Brand = "Apple",
                    Type = "Tablet",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "IPhone 11",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 40000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/k2jbyq80pkrrdj/mobile-refurbished/z/a/f/iphone-11-pro-max-256-u-mwhm2hn-a-apple-0-original-imafkg2ftc5cze5n.jpeg?q=70",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "OnePlus 10",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 45000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/mobile/h/b/j/one-plus-one-na-original-imae8hh39tszhbbx.jpeg?q=70",
                    Brand = "OnePlus",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "OnePlus 5T",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/jpr86fk0/mobile-refurbished/r/q/t/aqua-lions-t1-plus-16-d-t1-plus-intex-2-original-imafbwev2kpehyfs.jpeg?q=70",
                    Brand = "OnePlus",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },

new Product
                {
                    Name = "OnePlus Nord",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 27000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/612/612/ku2zjww0/cases-covers/back-cover/q/5/c/1-nrd-nw-05-zynk-case-original-imag7ayczzgckcyc.jpeg?q=70",
                    Brand = "OnePlus",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },

new Product
                {
                    Name = "OnePlus Nord 2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 30000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/mobile/h/b/j/one-plus-one-na-original-imae8hh39tszhbbx.jpeg?q=70",
                    Brand = "OnePlus",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "Galaxy M21",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/312/312/kah413k0/mobile/z/m/g/samsung-galaxy-m21-b07hgjj55il-original-imafsfewggf3dqwc.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },

new Product
                {
                    Name = "Galaxy Tablet",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/612/612/kb5eikw0/tablet/6/h/g/samsung-sm-p615nzaainu-original-imafskyngvk7phfk.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "Tablet",
                    QuantityInStock = 100
                },

new Product
                {
                    Name = "Galaxy Tablet",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 23000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/612/612/kpvivm80/tablet/n/t/v/sm-t225nzsains-samsung-original-imag4yryasv6s7h3.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "Tablet",
                    QuantityInStock = 100
                },
new Product
                {
                    Name = "Galaxy Tablet 2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 24000,
                    PictureUrl = "https://rukminim1.flixcart.com/image/612/612/kpvivm80/tablet/r/x/9/sm-t225nzaains-samsung-original-imag4yrg8vahczvr.jpeg?q=70",
                    Brand = "Samsung",
                    Type = "Tablet",
                    QuantityInStock = 100
                }

          };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }

}