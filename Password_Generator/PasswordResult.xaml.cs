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
    /// Interaction logic for PasswordResult.xaml
    /// </summary>
    public partial class PasswordResult : Page
    {
        public PasswordResult(object data)
        {
            // Bind to expense report data.
            this.DataContext = data;
            InitializeComponent();
        }
    }
}