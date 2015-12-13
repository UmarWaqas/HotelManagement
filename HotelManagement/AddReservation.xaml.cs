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
    /// Interaction logic for AddReservation.xaml
    /// </summary>
    public partial class AddReservation : Window
    {
        DataFactory factory;
        ReservationViewModel vmReservation;
        Reservation reservation;
        Customer customer;
        public AddReservation()
        {
            InitializeComponent();
            initializeReservation();
        }

        public void initializeReservation()
        {
            factory = new DataFactory();
            vmReservation = new ReservationViewModel();
            reservation = new Reservation();
            customer = new Customer();
            this.DataContext = vmReservation;
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
            txtName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtEmail.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            NudNights.GetBindingExpression(Xceed.Wpf.Toolkit.IntegerUpDown.ValueProperty).UpdateSource();
            txtPhone.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtCnic.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            cbRoomType.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            cbRoomNumber.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            dpCheckIn.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
            dpCheckOut.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
            dpDateOfBirth.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
        }//end of method forceValidation....


        

        private void onBtnClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(txtName) || Validation.GetHasError(txtEmail) || Validation.GetHasError(NudNights)
               || Validation.GetHasError(txtPhone) || Validation.GetHasError(txtCnic) || Validation.GetHasError(txtAddress)
               //|| Validation.GetHasError(cbRoomType) || Validation.GetHasError(cbRoomNumber) || Validation.GetHasError(dpCheckIn) 
               || Validation.GetHasError(dpCheckIn) || Validation.GetHasError(dpCheckOut) || Validation.GetHasError(dpDateOfBirth))
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {

                customer.Name = txtName.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Cnic = txtCnic.Text.Trim();
                customer.Date_of_Birth = dpDateOfBirth.Value.Value;
                if (factory.insert(customer))
                    MessageBox.Show("Customer is Inserted");
                else
                    MessageBox.Show("Not Inserted");
               // reservation.Employee_Type = int.Parse(cbJobType.SelectedValue.ToString());
                reservation.Nights = (int)NudNights.Value;
                reservation.Start_Date = dpCheckIn.Value.Value;
                
                reservation.End_Date = dpCheckOut.Value.Value;
                //factory.insert(employee);

            /*    if (factory.insert(reservation))
                    MessageBox.Show("Inserted");
                else
                    MessageBox.Show("Not Inserted");*/

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*  List<Employee_Type> empTypeData = factory.selectAll(new Employee_Type());
            cbJobType.ItemsSource = empTypeData;
            cbJobType.DisplayMemberPath = "Type";
            cbJobType.SelectedValuePath = "Id";*/

        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }//end of method Window_Loaded....
    }//end of class AddReservation....

}//end of namespace....

