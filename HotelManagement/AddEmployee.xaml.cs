﻿using System;
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
        public AddEmployee()
        {
            InitializeComponent();
            initializeEmployee();
            factory = new DataFactory();
           
        }

        public void initializeEmployee()
        {
            vmEmployee = new EmployeeViewModel();
            this.DataContext = vmEmployee;
            vmEmployee.Name = "Full Name";
            vmEmployee.Password = "default";
            vmEmployee.Email = "Email";
            vmEmployee.Address = "Address";
            vmEmployee.CNIC = "CNIC";
            vmEmployee.PhoneNumber = "Phone Number";

        }//end of method initializeEmployee....

        private void forceValidation()
        {
            txtName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtEmail.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtPhone.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtCnic.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();
           
            cbJobType.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            dpDateOfBirth.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
            dpJoiningDate.GetBindingExpression(Xceed.Wpf.Toolkit.DateTimePicker.ValueProperty).UpdateSource();
        }//end of method ForceValidation....

        private void onBtnClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(txtName) || Validation.GetHasError(txtEmail) || Validation.GetHasError(txtPassword)
               || Validation.GetHasError(txtPhone) || Validation.GetHasError(txtCnic) || Validation.GetHasError(txtAddress)
               || Validation.GetHasError(cbJobType) || Validation.GetHasError(dpDateOfBirth) || Validation.GetHasError(dpJoiningDate))
            {
                MessageBox.Show("Error");
                return;
            }

        }

        private void onWindowLoaded(object sender, RoutedEventArgs e)
        {
            Employee_Type employeeType = new Employee_Type();
            List<Employee_Type> empTypeData=factory.selectAll(employeeType);
            cbJobType.ItemsSource = empTypeData;
            cbJobType.DisplayMemberPath = "Type";
            cbJobType.SelectedValuePath = "Id";

        }//end of method onBtnClick....
    }//end of class AddEmployee.....
}
