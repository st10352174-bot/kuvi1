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
    public partial class AddRecipeWindow : Window
    {
        private Recipe recipe;
        private List<Ingredient> ingredients;
        private List<string> steps;

        public AddRecipeWindow()
        {
            InitializeComponent();
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            double quantity = double.Parse(IngredientQuantityTextBox.Text);
            string unit = IngredientUnitTextBox.Text;
            double calories = double.Parse(IngredientCaloriesTextBox.Text);
            string foodGroup = IngredientFoodGroupTextBox.Text;

            ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
            IngredientNameTextBox.Clear();
            IngredientQuantityTextBox.Clear();
            IngredientUnitTextBox.Clear();
            IngredientCaloriesTextBox.Clear();
            IngredientFoodGroupTextBox.Clear();
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            steps.Add(StepTextBox.Text);
            StepTextBox.Clear();
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            recipe = new Recipe(recipeName);

            foreach (var ingredient in ingredients)
            {
                recipe.AddIngredient(ingredient);
            }

            foreach (var step in steps)
            {
                recipe.AddStep(step);
            }

            // Save the recipe (you need to implement a way to store the recipe)
            // For example, you can store it in a static list in RecipeManager

            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}