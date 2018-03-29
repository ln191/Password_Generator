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

namespace Password_Generator
{
    /// <summary>
    /// Interaction logic for PasswordGeneratorHome.xaml
    /// </summary>
    public partial class PasswordGeneratorHome : Page
    {
        public PasswordGeneratorHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate Password Button_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Go to Password generation page
            PasswordGenerationPage passwordGenerationPage = new PasswordGenerationPage();
            this.NavigationService.Navigate(passwordGenerationPage);
        }
    }
}