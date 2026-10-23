using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void x1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                result.Text = (int.Parse(x1.Text) * int.Parse(x2.Text)).ToString();
            }
            catch { } //делить на ноль нельзя
        }
    }
}