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

namespace WPFrecipeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
        }

        private void DisplayRecipes_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipesWindow displayRecipesWindow = new DisplayRecipesWindow();
            displayRecipesWindow.Show();
        }

        private void AdjustRecipe_Click(object sender, RoutedEventArgs e)
        {
            AdjustRecipeWindow adjustRecipeWindow = new AdjustRecipeWindow();
            adjustRecipeWindow.Show();
        }

        private void ResetQuantities_Click(object sender, RoutedEventArgs e)
        {
            ResetQuantitiesWindow resetQuantitiesWindow = new ResetQuantitiesWindow();
            resetQuantitiesWindow.Show();
        }

        private void ClearRecipe_Click(object sender, RoutedEventArgs e)
        {
            ClearRecipeWindow clearRecipeWindow = new ClearRecipeWindow();
            clearRecipeWindow.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}