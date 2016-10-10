using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysHotDogs.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository hotdogrepository = new HotDogRepository();

        public List<HotDog> GetAllHotDogs()
        {
            return hotdogrepository.GetAllHotDogs();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotdogrepository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup(int hotdogGroupId)
        {
            return hotdogrepository.GetHotDogsForGroup(hotdogGroupId);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return hotdogrepository.GetFavoriteHotDogs();
        }

        public HotDog GetHotDogById(int hotdogId)
        {
            return hotdogrepository.GetHotDogById(hotdogId);
        }
    }
}
