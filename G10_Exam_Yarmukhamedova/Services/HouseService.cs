using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using G10_Exam_Yarmukhamedova.Models;


namespace G10_Exam_Yarmukhamedova.Services
{
    public class HouseService
    {
        private List<House> houses;

        public HouseService() 
        { 
          houses = new List<House>();
        }

        public House AddHouse(House house)
        {
            house.Id = Guid.NewGuid();
            houses.Add(house);
            return house;
        }

        public House GetHouseById(Guid houseId)
        {
            foreach (var house in houses)
            {
                if (house.Id == houseId)
                    return house;
            }
            return null;
        }

        public bool DeleteHouse(Guid houseId)
        {
            var houseFromDb = GetHouseById(houseId);

            if (houseFromDb is null)
            {
                return false;
            }

            houses.Remove(houseFromDb);
            return true;

        }

        public bool UpdateHouse(House updateHouse)
        {
            var houseFromDb = GetHouseById(updateHouse.Id);
            if (houseFromDb is null)
            {
                return false;
            }
            var index = houses.IndexOf(houseFromDb);
            houses[index] = updateHouse;
            return true;

        }

        public List<House> GetAllHouses()
        {
            return houses;
        }
    }
}
