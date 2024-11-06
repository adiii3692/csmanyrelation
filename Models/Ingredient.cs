namespace Menu.Models
{
    public class Ingredient
    {
        //Ingredient data
        public int Id { get; set; }
        public string Name { get; set; }

        // list of objects to connect the Ingredient to its Recipe
        public List<Recipe> Recipe { get; set; }
    }
}
