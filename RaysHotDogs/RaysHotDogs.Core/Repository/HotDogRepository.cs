using RaysHotDogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId = 1, Title = "Meat Lovers", ImagePath = "",HotDogs = new List<HotDog>()
                {
                      new HotDog()
                       {
                          HotDogId = 1,
                          Name = "Regular Hot Dog",
                          ShortDescription = "Best",
                          Description = "cheesy",
                          ImagePath = "hotdog1",
                          Avaliable = true,
                          PrepTime = 10,
                          Ingredients = new List<string> () {"regular ham" },
                          Price = 8,
                          IsFavorite = true
                       },
                      new HotDog()
                      {
                          HotDogId = 3,
                          Name = "Extra Long",
                          ShortDescription = "for when",
                          Description = "Capicola",
                          ImagePath = "hotdog3",
                          Avaliable = true,
                          PrepTime = 10,
                          Ingredients = new List<string>() {"Extrea Long" },
                          Price = 8,
                          IsFavorite = true
                      },
                      new HotDog()
                      {
                          HotDogId = 2,
                          Name = "hAUTE dOG ",
                          ShortDescription = "classy one",
                          Description = "bacon",
                          ImagePath = "hotdog2",
                          Avaliable = true,
                          PrepTime = 15,
                          Ingredients = new List<string>() {"Baked bun" },
                          Price = 10,
                          IsFavorite = false
                      }
                }
            },//Hot Dog Group
        new HotDogGroup() {
             HotDogGroupId = 2, Title = "Veggie Lovers", ImagePath = "",HotDogs = new List<HotDog>()
             {
                 new HotDog()
                 {
                           HotDogId = 4,
                          Name = "Veggie hAUTE dOG ",
                          ShortDescription = "American for non meat-lovers",
                          Description = "veggies",
                          ImagePath = "hotdog4",
                          Avaliable = true,
                          PrepTime = 10,
                          Ingredients = new List<string>() {"Vegitarian Sausage" },
                          Price = 8,
                          IsFavorite = false
                 }
            }
        }
      }; //hot dog group 2




    }//end HotDogRepositoryClass


} //end namespace

