namespace BlackWasp.Builder
{
    public class Meal
    {
        public string Sandwich { get; set; }
        public string SideOrder { get; set; }
        public string Drink { get; set; }
        public string Offer { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4:f2}", Sandwich, SideOrder, Drink, Offer, Price);
        }
    }

    public abstract class MealBuilder
    {
        public abstract void AddSandwich();
        public abstract void AddSideOrder();
        public abstract void AddDrink();
        public abstract void AddOfferItem();
        public abstract void SetPrice();
        public abstract Meal GetMeal();
    }

    public class MealDirector
    {
        public void MakeMeal(MealBuilder builder)
        {
            builder.AddSandwich();
            builder.AddSideOrder();
            builder.AddDrink();
            builder.AddOfferItem();
            builder.SetPrice();
        }
    }

    public class JollyVegetarianMealBuilder : MealBuilder
    {
        private readonly Meal _meal;

        public JollyVegetarianMealBuilder()
        {
            _meal = new Meal();
        }

        public override void AddSandwich()
        {
            _meal.Sandwich = "Veggieburger";
        }

        public override void AddSideOrder()
        {
            _meal.SideOrder = "Fries";
        }

        public override void AddDrink()
        {
            _meal.Drink = "Orange Juice";
        }

        public override void AddOfferItem()
        {
            _meal.Offer = "Doughnut Voucher";
        }

        public override void SetPrice()
        {
            _meal.Price = 4.99;
        }

        public override Meal GetMeal()
        {
            return _meal;
        }
    }

    public class MischievousMexicanBuilder : MealBuilder
    {
        private Meal _meal;

        public MischievousMexicanBuilder()
        {
            _meal = new Meal();
        }

        public override void AddSandwich()
        {
            _meal.Sandwich = "Spicy Burger";
        }

        public override void AddSideOrder()
        {
            _meal.SideOrder = "Nachos";
        }

        public override void AddDrink()
        {
            _meal.Drink = "Tequila";
        }

        public override void AddOfferItem()
        {
            _meal.Offer = "Sombrero";
        }

        public override void SetPrice()
        {
            _meal.Price = 5.49;
        }

        public override Meal GetMeal()
        {
            return _meal;
        }
    }
}
