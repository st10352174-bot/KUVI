using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeAppWPF1
{
    public partial class MainWindow : Window
    {
        private RecipeManager recipeManager = new RecipeManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            var addRecipeWindow = new AddRecipeWindow(recipeManager);
            addRecipeWindow.ShowDialog();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = SelectRecipe();
            if (selectedRecipe != null)
            {
                IngredientsListView.ItemsSource = selectedRecipe.Ingredients;
                StepsListView.ItemsSource = selectedRecipe.Steps;
            }
        }

        private void AdjustRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = SelectRecipe();
            if (selectedRecipe != null)
            {
                var adjustRecipeWindow = new AdjustRecipeWindow(selectedRecipe);
                adjustRecipeWindow.ShowDialog();
            }
        }

        private void ResetQuantities_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = SelectRecipe();
            if (selectedRecipe != null)
            {
                selectedRecipe.ResetQuantities();
                MessageBox.Show($"Quantities for recipe {selectedRecipe.Name} have been reset.");
            }
        }

        private void ClearRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = SelectRecipe();
            if (selectedRecipe != null)
            {
                recipeManager.ClearRecipe(selectedRecipe);
                IngredientsListView.ItemsSource = null;
                StepsListView.ItemsSource = null;
                MessageBox.Show($"Recipe {selectedRecipe.Name} has been cleared.");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private Recipe SelectRecipe()
        {
            if (recipeManager.Recipes.Count == 0)
            {
                MessageBox.Show("No recipes available.");
                return null;
            }

            var selectRecipeWindow = new SelectRecipeWindow(recipeManager);
            selectRecipeWindow.ShowDialog();

            return selectRecipeWindow.SelectedRecipe;
        }

        private void NotifyCaloriesExceeded(string recipeName)
        {
            MessageBox.Show($"Warning: The recipe {recipeName} exceeds 300 calories.");
        }
    }

    public class Recipe
    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public List<string> Steps { get; } = new List<string>();

        public event Action<string> OnCaloriesExceeded;

        public Recipe(string name)
        {
            Name = name;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            if (GetTotalCalories() > 300)
            {
                OnCaloriesExceeded?.Invoke(Name);
            }
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Scale(factor);
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Reset();
            }
        }

        private double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Quantity * ingredient.Calories;
            }
            return totalCalories;
        }
    }

    public class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; set; }
        public string Unit { get; }
        public double Calories { get; }
        public string FoodGroup { get; }
        private double originalQuantity;

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
            originalQuantity = quantity;
        }

        public void Scale(double factor)
        {
            Quantity *= factor;
        }

        public void Reset()
        {
            Quantity = originalQuantity;
        }
    }

    public class RecipeManager
    {
        public List<Recipe> Recipes { get; } = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void ClearRecipe(Recipe recipe)
        {
            Recipes.Remove(recipe);
        }
    }
}
