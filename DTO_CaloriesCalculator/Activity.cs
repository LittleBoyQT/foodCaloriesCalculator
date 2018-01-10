using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CaloriesCalculator
{
    public class Activity
    {
        private string name;
        private float caloriesValue;

        public string Name { get => name; set => name = value; }
        public float CaloriesValue { get => caloriesValue; set => caloriesValue = value; }

        public Activity(string name, float caloriesValue)
        {
            Name = name;
            CaloriesValue = caloriesValue;
        }
    }
}
