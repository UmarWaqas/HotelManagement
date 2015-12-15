using DMLibrary;
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

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for EmployeeCatagoryList.xaml
    /// </summary>
    public partial class EmployeeCatagoryList : Window
    {
        public EmployeeCatagoryList()
        {
            InitializeComponent();
            dgEmployeeCatagories.ItemsSource = new DataFactory().selectAll(new Employee_Type());
        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
