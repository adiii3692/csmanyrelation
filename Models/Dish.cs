namespace Menu.Models
{
    public class Dish
    {
        //Dish data
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
         
        //Make a List (a list of objects) to connect the Dish to its Recipe
        public List<Recipe> Recipe { get; set; }

    }
}
