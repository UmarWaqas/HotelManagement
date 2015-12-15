using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary.DataLayer
{
    class EmployeeDA
    {
        MainDbContext dbContext;

        public EmployeeDA()
        {
            dbContext = new MainDbContext();
        }

        public List<ViewModel.EmployeeViewModel> selectManagers()
        {
            return (from s in dbContext.Employees.Where(e=> e.Employee_Type.Equals(2))
                    select new ViewModel.EmployeeViewModel
                    {
                        Name = s.Name,
                        

                    }).ToList();
        }

        public Employee findEmployee(string name,string password)
        {
            Employee emp = dbContext.Employees.Where(x => x.Email.Equals(name) && x.Password.Equals(password)).FirstOrDefault();
            if (emp != null)
            {
                return emp;
            }
            return null;
        }

        public List<ViewModel.EmployeeViewModel> selectMaintainers()
        {
            return (from s in dbContext.Employees.Where(e => e.Employee_Type.Equals(4))
                    select new ViewModel.EmployeeViewModel
                    {
                        Name = s.Name,


                    }).ToList();
        }
        public List<ViewModel.EmployeeViewModel> SelectAllEmployees()
        {
            return (from s in dbContext.Employees
                    select new ViewModel.EmployeeViewModel
                    {
                        Name = s.Name,
                        EmployeeType=s.Employee_Type,
                        Email=s.Email,
                        DateOfBirth=s.Date_of_Birth,
                        PhoneNumber=s.Phone,
                        CNIC=s.Cnic,
                        Address=s.Address,
                        JoiningDate=s.Joining_Date
                       
                    }).ToList();
        }

    }//end of class EmployeeDA...
}//end of namespace.....
