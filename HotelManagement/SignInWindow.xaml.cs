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
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        DataFactory factory;
        EmployeeViewModel vmEmployee;
        Employee employee;
        public SignInWindow()
        {
            InitializeComponent();
            initialize();
            checkPassword();
        }
        public void initialize()
        {
            factory = new DataFactory();
            vmEmployee = new EmployeeViewModel();
            employee = new Employee();
            this.DataContext = vmEmployee;
            txtPassword.Password = "123";
            vmEmployee.Name = "umarwaqas2010@gmail.com";
            

        }//end of method initializeEmployee....
        private void forceValidation()
        {
            txtUserName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            
            //txtPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            
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
        private void onWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           // Environment.Exit(1);
            e.Cancel = true;
          //  this.Visibility = Visibility.
            
            this.Visibility = Visibility.Hidden;
        }

        private void onPasswordChange(object sender, RoutedEventArgs e)
        {
            checkPassword();
        }

        private void onbtnSignInClick(object sender, RoutedEventArgs e)
        {
            forceValidation();
            if (Validation.GetHasError(txtUserName) || checkPassword())
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {

                //employee.Name = txtUserName.Text.Trim();
                //employee.Password = txtPassword.Password.Trim();

                //factory.insert(employee);
                employee = factory.singleEmployee(txtUserName.Text.Trim(), txtPassword.Password.Trim());

                if (employee != null && employee.Employee_Type==1)
                {
                    this.Close();
                    //MessageBox.Show("Wellcome Admin ");
                    new MainWindow().ShowDialog();
                    

                }
                else if (employee != null && employee.Employee_Type==2)
                {
                    this.Close();
                    new ManagerViewMode().ShowDialog();
                }
                else if (employee != null && employee.Employee_Type==3)
                {
                    this.Close();
                    new ReceptionistViewMode().ShowDialog();
                }
                    

                else
                    MessageBox.Show("Employee Not  Found!");
            }
        }

        private void onbtnCancelClick(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = null;
            txtUserName.Text = null;

        }
    }
}
