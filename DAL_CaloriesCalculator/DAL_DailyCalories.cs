
using DTO_CaloriesCalculator;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL_CaloriesCalculator
{
    public class DAL_DailyCalories
    {
        List<List<string>> listOfFoodsInfo = new List<List<string>>();
        List<string> listFoodByLine;
        String[] lines = null;
        List<Activity> listOfActivities;
        /// <summary>
        /// Get mon an
        /// </summary>
        /// <returns></returns>
        public List<List<string>> getDishes()
        {
            lines = File.ReadAllLines(@"C:\Users\LittleboyQti\Desktop\Dishes.txt");
            if (lines != null)
            {
                listFoodByLine = new List<string>();
                foreach (var line in lines)
                {
                    listFoodByLine = line.Split(
                        new string[] { "\t" },
                        StringSplitOptions.RemoveEmptyEntries
                    ).ToList();
                    listOfFoodsInfo.Add(listFoodByLine);
                }
            }
            return listOfFoodsInfo;
        }

        public List<Activity> getActivities()
        {
            listOfActivities = new List<Activity>
            {
                new Activity("Running", 3),
                new Activity("Cycling", 4)
            };
            return listOfActivities;
        }
    }
}
