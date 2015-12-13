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
using DMLibrary;
using ViewModel;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for AddJob.xaml
    /// </summary>
    public partial class AddJob : Window
    {
        DataFactory factory ;//= new DataFactory();
        EmpTypeViewModel vmEmpType;
        Employee_Type employeeType;
        public AddJob()
        {
            InitializeComponent();
            initializeEmployeeType();
        }
        public void initializeEmployeeType()
        {
            factory = new DataFactory();
            vmEmpType = new EmpTypeViewModel();
            employeeType = new Employee_Type();
            this.DataContext = vmEmpType;
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
            txtJobType.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtSalary.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            
        }//end of method ForceValidation....
       

        private void onClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(txtJobType) || Validation.GetHasError(txtSalary))
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {

                employeeType.Type = txtJobType.Text.Trim();
                employeeType.Salary = Convert.ToDecimal(txtSalary.Text.Trim());
                //factory.insert(employee);

                if (factory.insert(employeeType))
                    MessageBox.Show("Inserted");
                else
                    MessageBox.Show("Not Inserted");

            }//end of else statement....
           
            
           
        }

        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }//end of onClick method.....
         

    }//end of class AddJob....

}//end of namespace HotelManagement.....
