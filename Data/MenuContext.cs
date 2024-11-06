using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Data
{
    public class MenuContext:DbContext
    {
        //Constructor for the context
        public MenuContext(DbContextOptions<MenuContext> options):base(options) { }

        //Used to specify the relationship between the recipe, the dish and the ingredient
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Specify the relationship between the dish and the ingredient models - Many to many
            modelBuilder.Entity<Recipe>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });

            modelBuilder.Entity<Recipe>().HasOne(d => d.Dish).WithMany(di => di.Recipe).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<Recipe>().HasOne(i => i.Ingredient).WithMany(r => r.Recipe).HasForeignKey(i => i.IngredientId);

            //Add data to the models
            modelBuilder.Entity<Dish>().HasData(
                    new Dish { Id:1,Name="Margharita",Description="A pizza made from scratch",Price=20.5,ImageUrl= "https://cookieandkate.com/images/2021/07/classic-margherita-pizza.jpg" }
                );

            modelBuilder.Entity<Ingredient>
            base.OnModelCreating(modelBuilder);
        }

        //Make the DbSets now
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
    }
}
