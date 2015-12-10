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
    /// Interaction logic for AddRoomType.xaml
    /// </summary>
    public partial class AddRoomType : Window
    {
        DataFactory factory;
        RoomTypeViewModel vmRoomType;
        Room_Type roomType;
        public AddRoomType()
        {
            InitializeComponent();
             initializeReservation();
            
        }

        public void initializeReservation()
        {
            factory = new DataFactory();
            vmRoomType = new RoomTypeViewModel();
            roomType = new Room_Type();

            this.DataContext = vmRoomType;
            /* vmEmployee.Name = "Full Name";
             vmEmployee.Password = "default";
             vmEmployee.Email = "Email";
             vmEmployee.Address = "Address";
             vmEmployee.CNIC = "CNIC";
             vmEmployee.PhoneNumber = "Phone Number";
             vmEmployee.EmployeeType = 0;*/

        }//end of method initializeEmployee....
        private void forceValidation()
        {
            txtRoomType.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtCharges.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            NudAllowedGuests.GetBindingExpression(Xceed.Wpf.Toolkit.IntegerUpDown.ValueProperty).UpdateSource();
           
        }

        private void onBtnClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(txtRoomType) || Validation.GetHasError(txtCharges) || Validation.GetHasError(NudAllowedGuests))
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {

                roomType.Type = txtRoomType.Text.Trim();
                roomType.Capacity = (int)NudAllowedGuests.Value;
                roomType.Charges = Convert.ToDecimal(txtCharges.Text.Trim());

                if (factory.insert(roomType))
                    MessageBox.Show("Customer is Inserted");
                else
                    MessageBox.Show("Not Inserted");
                

            }
        }//end of method forceValidation....

    }//end of class AddRoomType....


}//end of namespace....
