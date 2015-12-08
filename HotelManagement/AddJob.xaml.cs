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

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for AddJob.xaml
    /// </summary>
    public partial class AddJob : Window
    {
        DataFactory factory ;//= new DataFactory();
        public AddJob()
        {
            InitializeComponent();
            factory = new DataFactory();
        }

       

        private void onClick(object sender, RoutedEventArgs e)
        {
            Employee_Type employeeType = new Employee_Type();
            factory.selectAll(employeeType);
           // factory.selectAllEmp();
            MessageBox.Show("Job Type is Added.");
            #region Validations

            if (string.IsNullOrEmpty(txtJobType.Text))
            {
                //errorProvider1.SetError(txtName, "Name is required");
                txtJobType.Focus();
                
                return;
            }

            if (string.IsNullOrEmpty(txtSalary.Text))
            {
                //errorProvider1.SetError(txtRegNo, "RegNo is Required");
                txtSalary.Focus();
                return;
            }
            else
            {
                int tempReg;
                if (!int.TryParse(txtSalary.Text, out tempReg))
                {
                   // errorProvider1.SetError(txtRegNo, "RegNo is incorrect");
                    txtSalary.Focus();
                    return;
                }
            }


            #endregion

            
            employeeType.Type = txtJobType.Text.Trim();
            employeeType.Salary = Convert.ToDecimal(txtSalary.Text.Trim());
          //  factory.insert(employeeType);
            factory.insert(employeeType);
           
        }//end of onClick method.....
         

    }//end of class AddJob....

}//end of namespace HotelManagement.....
