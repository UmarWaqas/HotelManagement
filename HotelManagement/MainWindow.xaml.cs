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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddReservation newReservation;
        AddEmployee newEmployee;
        AddRoom newRoom;
        AddRoomType newRoomType;
        AddJob newPosition;
        ReservationsList resList;
        EmployeeList empList;
        FreeRoomsList freeRoomList;
        ReservedRoomsList resRooms;
        CustomerList cstList;
        RoomsList rmList;
        EmployeeCatagoryList empCatagory;
        RoomCatagories rmCatagories;
        SignIn obj;
        public MainWindow()
        {
            InitializeComponent();
           //  obj = new SignIn();
            initializeCustomWindows();

        }

        private void MainWindow1_Activated(object sender, EventArgs e)
        {
           // stkTest.Children.Add(obj);
        }
        
       

        private void onReservationMenuItemClick(object sender, RoutedEventArgs e)
        {
            
            newReservation.ShowDialog();
        }

        private void onEmployeeMenuItemClick(object sender, RoutedEventArgs e)
        {
            
            newEmployee.ShowDialog();

        }

      
        private void onRoomMenuItemClick(object sender, RoutedEventArgs e)
        {
            
            newRoom.ShowDialog();

        }

        private void onRoomTypeMenuItemClick(object sender, RoutedEventArgs e)
        {
            
            newRoomType.ShowDialog();

        }

        private void onEmpPositionMenuItemClick(object sender, RoutedEventArgs e)
        {
            
            newPosition.ShowDialog();
        }

        private void onReservationListClick(object sender, RoutedEventArgs e)
        {
            
            resList.ShowDialog();

        }

        private void onEmployeeListClick(object sender, RoutedEventArgs e)
        {
           
            empList.ShowDialog();
        }

        private void onFreeRoomsListClick(object sender, RoutedEventArgs e)
        {
            
            freeRoomList.ShowDialog();

        }

        private void onReservedRoomsListClick(object sender, RoutedEventArgs e)
        {
            
            resRooms.ShowDialog();
        }

        private void onCustomerListClick(object sender, RoutedEventArgs e)
        {
            
            cstList.ShowDialog();

        }

        private void onRoomsListClick(object sender, RoutedEventArgs e)
        {
            
            rmList.ShowDialog();
        }

        private void onWindowLoaded(object sender, RoutedEventArgs e)
        {
        }
        
        public void initializeCustomWindows()
        {
            newReservation = new AddReservation();
            newEmployee = new AddEmployee();
            newRoom = new AddRoom();
            newRoomType = new AddRoomType();
            newPosition = new AddJob();
            resList = new ReservationsList();
            empList = new EmployeeList();
            freeRoomList = new FreeRoomsList();
            resRooms = new ReservedRoomsList();
            cstList = new CustomerList();
            rmList = new RoomsList();
            empCatagory = new EmployeeCatagoryList();
            rmCatagories = new RoomCatagories();

        }

        private void onEmpCatagoryListClick(object sender, RoutedEventArgs e)
        {
            empCatagory.ShowDialog();
        }

        private void onRoomCatagoryListClick(object sender, RoutedEventArgs e)
        {
            rmCatagories.ShowDialog();
        }
    }
}
