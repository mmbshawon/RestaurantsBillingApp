using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsBilling.Model
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemNumber { get; set; }
        public string ItemCategory { get; set; }
    }
}
