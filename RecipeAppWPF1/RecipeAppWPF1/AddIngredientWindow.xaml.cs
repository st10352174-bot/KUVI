using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeAppWPF1 {
    public partial class AddIngredientWindow : Window
    {
        private Recipe recipe;

        public AddIngredientWindow(Recipe recipe)
        {
            InitializeComponent();

            // Debugging output to check recipe initialization
            if (recipe == null)
            {
                Debug.WriteLine("Recipe object passed to AddIngredientWindow is null.");
            }
            else
            {
                Debug.WriteLine($"Recipe object passed to AddIngredientWindow: {recipe.Name}"); // Adjust this based on your Recipe class properties
            }

            this.recipe = recipe;
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            if (double.TryParse(QuantityTextBox.Text, out double quantity) &&
                double.TryParse(CaloriesTextBox.Text, out double calories))
            {
                string unit = UnitTextBox.Text;
                string foodGroup = FoodGroupTextBox.Text;

                Ingredient ingredient = new Ingredient(name, quantity, unit, calories, foodGroup);

                // Debugging output to check ingredient creation
                Debug.WriteLine($"Adding ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Calories: {ingredient.Calories}, Unit: {ingredient.Unit}, Food Group: {ingredient.FoodGroup}");

                // Check if recipe object is initialized before adding ingredient
                if (recipe != null)
                {
                    recipe.AddIngredient(ingredient);
                    MessageBox.Show("Ingredient added successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Recipe object is not initialized.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for quantity and calories.");
            }
        }
    }
}