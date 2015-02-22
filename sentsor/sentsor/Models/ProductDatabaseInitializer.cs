using System.Collections.Generic;
using System.Data.Entity;

namespace sentsor.Models
{
  public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
               new Category
                {
                    CategoryID = 1,
                    CategoryName = "Abstract"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Conceptual"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Landscape"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Objects"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Figurative"
                },
            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
        var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Red-Striped Tie",
                    Description = "Suitable to be placed in the living room of a comtemporary apartment." + 
                                  "Give you the energy of the young ones!", 
                    ImagePath="abstractart1.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Queen-Of-Forest",
                    Description = "Suitable to hang in the balcony shed in the garden during summer",
                    ImagePath="abstractart2.png",
                    UnitPrice = 35.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "The Aura",
                    Description = "For those who are spiritually serene suitable to be placed in a meditation room.",
                    ImagePath="abstractart3.png",
                    UnitPrice = 48.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Jazz-Man",
                    Description = "Instill the Musical creativity in you , good to be placed above a piano",
                    ImagePath="abstractart4.png",
                    UnitPrice = 66.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "The Blocker",
                    Description = "Those who loved puzzle solving , most suitable to be hanged on the wall of a study room." ,
                    ImagePath="abstractart5.png",
                    UnitPrice = 74.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "The Death Theme",
                    Description = "If heavy metal is your music, this picture it your right companion!!!.",
                    ImagePath="abstractart6.png",
                    UnitPrice = 95.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Tribal Man",
                    Description = "It is very exhilirating to have this picture hanging on the wall of the kitchen.",
                    ImagePath="abstractart7.png",
                    UnitPrice = 49.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "The Larva",
                    Description = "Rippling effect of the Volcano larva flowing from the mountain top.s",
                    ImagePath="abstractart8.png",
                    UnitPrice = 102.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "My Ex",
                    Description = "This romantic picture reminds you of all the good moments , suitable to be in the bedroom.",
                    ImagePath="abstractart9.png",
                    UnitPrice = 32.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Meteorite",
                    Description = "This crushing and clashing colour of a meterite before it crashes to the earth,suits to be in a laboratory.",
                    ImagePath="abstractart10.png",
                    UnitPrice = 150.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "The Scrooger",
                    Description = "For the fans of impressionsionist art with a conceptual context.",
                    ImagePath="konsep11.png",
                    UnitPrice = 66.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Poltergeist House",
                    Description = "For who wants the fun of imaginative art in their house.",
                    ImagePath="konsep12.png",
                    UnitPrice = 99.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="konsep13.png",
                    UnitPrice = 195.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Medusa Stylist",
                    Description = "Wow what a tremendous colour for a comtemporary woman!" + 
                                  "Some kind of phenomena.",
                    ImagePath="konsep14.png",
                    UnitPrice = 204.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Aztec Sun",
                    Description = "what a wonderful design of sand pattern with yellow paint.",
                    ImagePath="konsep15.png",
                    UnitPrice = 242.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Heli Bug",
                    Description = "The advent of spring is here with ehis presence of this marvellous picture.",
                    ImagePath="konsep16.png",
                    UnitPrice = 122.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Ze Corn",
                    Description = "The dryness of the drought that produce these crops are portrayed.",
                    ImagePath="konsep17.png",
                    UnitPrice = 122.95,
                    CategoryID = 2
                },

          new Product
                {
                    ProductID = 18,
                    ProductName = "Flying Dinosaur",
                    Description = "The enigma of the third dimension of the dinosaur world.",
                    ImagePath="konsep18.png",
                    UnitPrice = 222.95,
                    CategoryID = 2
                },
                 new Product
                {
                    ProductID = 19,
                    ProductName = "DNA",
                    Description = "Structures of DNA cells are in colour 3d.",
                    ImagePath="konsep19.png",
                    UnitPrice = 62.95,
                    CategoryID = 2
                },
                 new Product
                {
                    ProductID = 20,
                    ProductName = "Legoart",
                    Description = "Very creative yet mysterious.",                    
                    ImagePath="konsep20.png",
                    UnitPrice = 62.95,
                    CategoryID = 2
                },
                 new Product
                {
                    ProductID = 21,
                    ProductName = "Green Trees",
                    Description = "Landscape of tree in rows with a pleasant mountain background. ",
                    ImagePath="lscape21.png",
                    UnitPrice = 82.95,
                    CategoryID = 3
                },
                 new Product
                {
                    ProductID = 22,
                    ProductName = "Alaska Artic",
                    Description = "Icy water of the mountain in the wintery months.",
                    ImagePath="lscape22.png",
                    UnitPrice = 322.95,
                    CategoryID = 3
                },
                 new Product
                {
                    ProductID = 23,
                    ProductName = "The Cliffy",
                    Description = "Landscape of cliffs in the european countries.",
                    ImagePath="lscape23.png",
                    UnitPrice = 322.95,
                    CategoryID = 3
                },
                 new Product
                {
                    ProductID = 24,
                    ProductName = "Brazillian trees",
                    Description = "Trees that are close to each other in the rainy forest areas.",
                    ImagePath="lscape24.png",
                    UnitPrice = 189.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "Chirpy Nest",
                    Description = "Very pleasing sound of the spring where birds build nest on a safe tree.",
                    ImagePath="lscape25.png",
                    UnitPrice = 72.95,
                    CategoryID = 3
                }

                
            };

        return products;
    }
  }
}