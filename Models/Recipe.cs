namespace Menu.Models
{
    //Connects a dish to its respective ingredients
    public class Recipe
    {
        //Dish data
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        //Ingredient data
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
