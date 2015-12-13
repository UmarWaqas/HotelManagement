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
using DMLibrary;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        DataFactory factory;
        EmployeeViewModel vmEmployee;
        Employee employee;
        public AddEmployee()
        {
            InitializeComponent();
            initializeEmployee();
            checkPassword();
                     
           
        }

        public void initializeEmployee()
        {
            factory = new DataFactory();
            vmEmployee = new EmployeeViewModel();
            employee = new Employee();
            this.DataContext = vmEmployee;
            List<Employee_Type> empTypeData = factory.selectAll(new Employee_Type());
            cbJobType.ItemsSource = empTypeData;
            cbJobType.DisplayMemberPath = "Type";
            cbJobType.SelectedValuePath = "Id";
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
            //txtPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtPhone.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtCnic.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            cbJobType.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            dpDateOfBirth.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
            dpJoiningDate.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
        }//end of method ForceValidation....
        private bool checkPassword()
        {
            if (string.IsNullOrEmpty(txtPassword.Password))
            {
                txtPassword.BorderBrush = Brushes.Red;
                borPassErr.Visibility = System.Windows.Visibility.Visible;
                return true;
            }
            else
            {
                txtPassword.BorderBrush = Brushes.Gray;
                borPassErr.Visibility = System.Windows.Visibility.Hidden;
            }
            return false;
        }
        private void onBtnClick(object sender, RoutedEventArgs e)
        {
            
            forceValidation();
            if (Validation.GetHasError(txtName) || Validation.GetHasError(txtEmail) || Validation.GetHasError(txtPassword)
               || Validation.GetHasError(txtPhone) || Validation.GetHasError(txtCnic) || Validation.GetHasError(txtAddress)
               || Validation.GetHasError(cbJobType) || Validation.GetHasError(dpDateOfBirth) || Validation.GetHasError(dpJoiningDate)
               || checkPassword() )
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {
                
                employee.Name = txtName.Text.Trim();
                employee.Email = txtEmail.Text.Trim();
                employee.Password = txtPassword.Password.Trim();                
                employee.Address = txtAddress.Text.Trim();
                employee.Cnic = txtCnic.Text.Trim();
                employee.Employee_Type = int.Parse(cbJobType.SelectedValue.ToString());
                employee.Joining_Date = dpJoiningDate.Value.Value;
                employee.Phone = txtPhone.Text.Trim();                
                employee.Date_of_Birth = dpDateOfBirth.Value.Value;
                //factory.insert(employee);

                if (factory.insert(employee))
                    MessageBox.Show("Inserted");
                else
                    MessageBox.Show("Not Inserted");

            }

        }

        private void onWindowLoaded(object sender, RoutedEventArgs e)
        {
           // Employee_Type employeeType = new Employee_Type();
            

        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            checkPassword();
        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }//end of method onWindowLoaded....
    }//end of class AddEmployee.....
}
