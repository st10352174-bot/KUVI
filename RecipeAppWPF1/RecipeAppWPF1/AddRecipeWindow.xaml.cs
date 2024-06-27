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
using System.Windows.Shapes;

namespace RecipeAppWPF1
{
    public partial class AddRecipeWindow : Window
    {
        private RecipeManager recipeManager;
        private Recipe newRecipe;

        public AddRecipeWindow(RecipeManager manager)
        {
            InitializeComponent();
            recipeManager = manager;
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var addIngredientWindow = new AddIngredientWindow(newRecipe);
            addIngredientWindow.ShowDialog();
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            if (string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            newRecipe = new Recipe(recipeName);
            recipeManager.AddRecipe(newRecipe);
            this.Close();
        }
    }
}