using Common;
using System.ComponentModel.DataAnnotations;

namespace FruitData
{
    public class Fruit
    {
        public enum fruits
        {
            [Display(Name = "Banana")]
            Banana,
            [Display(Name = "Apple")]
            Apple,
            [Display(Name = "Cherry")]
            Cherry,
            [Display(Name = "Coconut")]
            Coconut,
            [Display(Name = "Strawberry")]
            Strawberry,
            [Display(Name = "Kiwi")]
            Kiwi
        }

        private bool isEdible = true;
        private fruits fruitType;
        private string fruitName = "";


        public double Weight { get; set; }

        public string Color { get; set; } = "";

        public double Price { get; set; }

        public DateTime DatePicked { get; set; }

        public bool HasSeeds { get; set; }

        public fruits FruitType
        {
            get { return fruitType; }
            set {
                fruitType = value;
                fruitName = value.GetDisplayName();
            }
        }

        public string FruitName
        {
            get { return fruitName; }
            set { fruitName = value; }
        }

        public void MakeEdible(bool edible)
        {
            if (edible) { 
                isEdible = true; }
            else
            {
                isEdible = false;
            } 
        }
    }


}
