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

namespace SZGYA_WPF_Quiz2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> elso = new List<string>();

            foreach (CheckBox c in stck1f.Children)
            {
                elso.Add(c.Content.ToString());
            }

            List<string> masodik = new List<string>();

            foreach (ListBoxItem l in lst2f.SelectedItems)
            {
                masodik.Add(l.Content.ToString());
            }

            string harmadik = string.Empty;

            foreach (RadioButton r in stck3f.Children)
            {
                if ((bool)r.IsChecked) harmadik = r.Content.ToString();
            }

            string negyedik = ((ComboBoxItem)cmb4f.SelectedItem).Content.ToString();

            string otodik = string.Empty;

            foreach (RadioButton r in stck5f.Children)
            {
                if ((bool)r.IsChecked) otodik = r.Content.ToString();
            }

            ErtekelesWindow ertWin = new ErtekelesWindow(elso, masodik, harmadik, negyedik, otodik);
            ertWin.Show();

        }
    }
}