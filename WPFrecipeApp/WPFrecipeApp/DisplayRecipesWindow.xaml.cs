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

namespace WPFrecipeApp
{
    public partial class DisplayRecipesWindow : Window
    {
        public DisplayRecipesWindow()
        {
            InitializeComponent();

            // Load recipes (you need to implement a way to get the recipes)
            // For example, you can load them from a static list in RecipeManager

            // Example:
            // foreach (var recipe in RecipeManager.Recipes)
            // {
            //     RecipesListBox.Items.Add(recipe.Name);
            // }
        }

        private void ShowRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (RecipesListBox.SelectedItem != null)
            {
                string recipeName = RecipesListBox.SelectedItem.ToString();

                // Find the recipe by name (you need to implement a way to get the recipe by name)
                // For example:
                // var recipe = RecipeManager.Recipes.FirstOrDefault(r => r.Name == recipeName);

                // Display the recipe (you need to implement a way to display the recipe)
                // For example, you can show a new window with the recipe details
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}