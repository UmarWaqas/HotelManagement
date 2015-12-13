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
    /// Interaction logic for ReservedRoomsList.xaml
    /// </summary>
    public partial class ReservedRoomsList : Window
    {
        public ReservedRoomsList()
        {
            InitializeComponent();
        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
