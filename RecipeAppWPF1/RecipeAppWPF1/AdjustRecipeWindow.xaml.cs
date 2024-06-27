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
    public partial class AdjustRecipeWindow : Window
    {
        private Recipe recipe;

        public AdjustRecipeWindow(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
        }

        private void Scale_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(FactorTextBox.Text, out double factor))
            {
                recipe.ScaleRecipe(factor);
                MessageBox.Show($"Recipe {recipe.Name} has been scaled by a factor of {factor}.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid scaling factor.");
            }
        }
    }
}
