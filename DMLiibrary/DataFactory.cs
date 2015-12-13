
using DMLibrary.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary
{
    public class DataFactory
    {
        CustomerDA cstobject;
        EmployeeTypeDA empType;
        EmployeeDA employee;
        Common common;
        public DataFactory()
        {
            cstobject = new CustomerDA();
            empType = new EmployeeTypeDA();
            employee = new EmployeeDA();
            common = new Common();

        }
        public List<ViewModel.EmployeeViewModel> selectMaintainers()
        {
            return employee.selectMaintainers();
        }
        public List<ViewModel.EmployeeViewModel> selectManagers()
        {
            return employee.selectManagers();
        }
        public List<ViewModel.EmployeeViewModel>selectAllEmployees()
        {
            return employee.SelectAllEmployees();
        }
        public bool insert<T>(T obj)
        {
            return common.insert(obj);
        }

        public List<Employee_Type>selectAllEmpTypes()
        {
            return empType.getAll();
        }
        public List<T> selectAll<T>(T tye)
        {
           // Employee_Type e = new Employee_Type();
            return common.getAll(tye);
        }

        public List<Employee_Type>selectAllEmp()
        {

            return empType.getAll();
        }


        public void insertaaa(Employee_Type obj)
        {
            empType.insert(obj);

        }

        public void update()
        {

        }

        public void delete()
        {

        }

        public void selectAll()
        {

        }

        public void select()
        {

        }

    }//end of class DataFactory....


}//end of namespace DMLibrary....
