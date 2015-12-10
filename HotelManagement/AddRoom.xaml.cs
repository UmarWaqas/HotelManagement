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
using ViewModel;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Window
    {
        DataFactory factory;
        RoomViewModel vmRoom;
        Room newRoom;
        public AddRoom()
        {
            InitializeComponent();
            initializeRoom();
                
                
                    
       
        }

        public void initializeRoom()
        {
            factory = new DataFactory();
            vmRoom = new RoomViewModel();
            newRoom = new Room();
            this.DataContext = vmRoom;
            

        }//end of method initializeEmployee....
        private void forceValidation()
        {

            NudRoomNumber.GetBindingExpression(Xceed.Wpf.Toolkit.IntegerUpDown.ValueProperty).UpdateSource();
            

            cbRoomType.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            cbMaintainer.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            cbManager.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            
        }

        private void onBtnClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(NudRoomNumber) || Validation.GetHasError(cbRoomType) || Validation.GetHasError(cbMaintainer)
               || Validation.GetHasError(cbManager))
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {

                newRoom.Room_Number = (int)NudRoomNumber.Value;
                newRoom.Type = (int)cbRoomType.SelectedValue;
                newRoom.ManageBy = (int)cbManager.SelectedValue;
                newRoom.Maintainer = (int)cbMaintainer.SelectedValue;

                if (factory.insert(newRoom))
                    MessageBox.Show("Customer is Inserted");
                else
                    MessageBox.Show("Not Inserted");
               
            }
        }//end of method forceValidation....

    }
}
