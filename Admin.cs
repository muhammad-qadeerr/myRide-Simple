using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYRIDE_HW_1
{
    public class Admin
    {
        public List<Driver> drivers { get; set; }

        public Admin()
        {
            drivers = new List<Driver>();
        }

        public void addDriver()
        {

            Console.Write("\t\tEnter ID: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int driID = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Age: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int age = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Gender: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string gender = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Address: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Vehical Type (Car, Bike, Rickshaw): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string type = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Vehical Model: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string model = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tLicense Plate: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string licensePlate = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tEnter Phone Number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string phoneNum = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tWhere do you live? (Latitude, Longitude): ");
            Console.ForegroundColor = ConsoleColor.Green;
            float lat = float.Parse(Console.ReadLine());
            float lon = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Location currLocation = new Location(lat, lon);
            Vehicle vehicle = new Vehicle(type, model, licensePlate);
            bool addDriverAval = true;
            Driver driver = new Driver(driID, name, age, gender,address, phoneNum, currLocation, vehicle, addDriverAval );

            drivers.Add(driver);  // Adding the driver in the list.

            //foreach (Driver driv in drivers)
            //{
            //    Console.WriteLine(driv.id);
            //}


            Console.WriteLine("\n\t\tDriver added successfully!\n");
        }

        public void removeDriver(int idToRemove)
        {
            Driver driver = drivers.Find(d => d.id == idToRemove);
            if (driver == null)
            {
                Console.WriteLine("\n\t\tDriver not found!\n");
                return;
            }
            else
            {
                drivers.Remove(driver);
                Console.WriteLine($"\n\t\tDriver with {driver.id} removed!\n");
            }
        }

        public void updateDriver(int driverId)
        {
            Driver driver = drivers.Find(d => d.id == driverId);
            if (driver == null)
            {
                Console.WriteLine("\n\t\tDriver not found!\n");
                return;
            }
            else
            {
                Console.WriteLine($"\n\t\t--------------- Driver with {driver.id} exists ---------------------\n");


                Console.WriteLine("\t\tSelect field to update: ");
                Console.WriteLine("\t\t1. Name");
                Console.WriteLine("\t\t2. Age");
                Console.WriteLine("\t\t3. Gender");
                Console.WriteLine("\t\t4. Address");
                Console.WriteLine("\t\t5. Phone Number");
                Console.WriteLine("\t\t6. Current Location (Latitude, Longitude)");
                Console.WriteLine("\t\t7. Vehicle Type");
                Console.WriteLine("\t\t8. Vehicle Model");
                Console.WriteLine("\t\t9. Vehicle License Plate");
                Console.Write("\t\tEnter 1 to 9 for updating an attribute: ");
                int updateChoice = int.Parse(Console.ReadLine());

                switch (updateChoice)
                {
                    case 1:
                        Console.Write("\t\tEnter New Name: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.name = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 2:
                        Console.Write("\t\t Enter New Age: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.age = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 3:
                        Console.Write("\t\tEnter New Gender: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.gender = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 4:
                        Console.Write("\t\tEnter New Address: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.address = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 5:
                        Console.Write("\t\tEnter New Phone Number: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.phoneNumber = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 6:
                        Console.Write("\t\tEnter New Current Location (Latitude,Longitude): ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        float newLat = float.Parse(Console.ReadLine());
                        float newLon = float.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        driver.currLocation.setLocation(newLat, newLon);
                        break;
                    case 7:
                        Console.Write("New Vehicle Type (Car, Bike, Rickshaw): ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.vehical.type = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 8:
                        Console.Write("New Vehicle Model: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.vehical.model = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 9:
                        Console.Write("New Vehicle License Plate: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        driver.vehical.licensePlate = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.WriteLine("Invalid Updation Asked!");
                        break;
                }
                Console.WriteLine("\n\t\tDriver Updated Successfully!\n");
            }
        }

        public void searchDriver(int driverId)
        {
            //Console.Write($"Drive ID: {driverId}.");

            List<Driver> driverList = drivers.FindAll(d => d.id == driverId);
            if (driverList.Count == 0)
            {
                Console.WriteLine("\n\t\tDriver not found!\n");
                return;
            }
            else
            {
                Console.WriteLine($"\n\t\t--------------- Search results for Driver with ID {driverId} ---------------------\n");
                Console.WriteLine("Name\t\tAge\t\tGender\t\tV.Type\t\tV.Model\t\tV.License");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                foreach (Driver driver in driverList)
                {
                    Console.WriteLine($"{driver.name}\t\t{driver.age}\t\t{driver.gender}\t\t{driver.vehical.type}\t\t{driver.vehical.model}\t\t{driver.vehical.licensePlate}");
                }
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }

        //public void exitAsAdmin()
        //{
        //    Console.WriteLine("Exiting Admin panel...");
        //    Program.Main(new string[0]); // redirect to Main function.
        //}









    }
}
