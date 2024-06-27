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
    public partial class SelectRecipeWindow : Window
    {
        private RecipeManager recipeManager;
        public Recipe SelectedRecipe { get; private set; }

        public SelectRecipeWindow(RecipeManager manager)
        {
            InitializeComponent();
            recipeManager = manager;
            RecipeListView.ItemsSource = recipeManager.Recipes;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            SelectedRecipe = (Recipe)RecipeListView.SelectedItem;
            this.Close();
        }
    }
}
