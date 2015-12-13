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
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        DataFactory factory;
        public EmployeeList()
        {
            InitializeComponent();
            factory = new DataFactory();
            //dgEmployees.ItemsSource=factory.selectAll(new Employee());
            dgEmployees.ItemsSource = factory.selectAllEmployees();
        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
