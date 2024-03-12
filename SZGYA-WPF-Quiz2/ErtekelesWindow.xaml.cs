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

namespace SZGYA_WPF_Quiz2
{
    /// <summary>
    /// Interaction logic for ErtekelesWindow.xaml
    /// </summary>
    public partial class ErtekelesWindow : Window
    {
        public ErtekelesWindow()
        {
            InitializeComponent();
        }

        public ErtekelesWindow(List<string> elso, List<string> masodik, string harmadik, string negyedik, string otodik)
        {
            InitializeComponent();

            lst1v.ItemsSource = elso;
            lst2v.ItemsSource = masodik;
            lbl3v.Content = harmadik;
            lbl4v.Content = negyedik;
            lbl5v.Content = otodik;
        }
    }
}
