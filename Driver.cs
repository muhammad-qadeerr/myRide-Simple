using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYRIDE_HW_1
{
    public class Driver
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender;
        public string address { get; set; }

        public int id { get; set; }   // data member id declared to find and update driver's details.
        public string phoneNumber { get; set; }

        public Location currLocation;

        public Vehicle vehical;

        //public int[] rating = new int[10];
        public List<int> rating;

        public bool availability;

        public Driver()  // Default Constructor.
        {
            name = "";
            age = 0;
            gender = "";
            address = "";
            id = 0;
            phoneNumber = "";
            rating = new List<int>();
            vehical =new Vehicle();
            currLocation = new Location();
            availability = false;


        }
        public Driver(int id,string name, int age, string gender, string address, string phoneNumber, Location currLocation, Vehicle vehical, bool availibility)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.currLocation = currLocation;
            this.id = id;
            this.vehical = vehical;
            this.address = address;

           
            rating = new List<int>();

            this.availability = true;
        }


        public void updateAvailibility(bool aval)
        {
            availability = aval;
        }

        //public void getRating()
        //{
        //    Console.WriteLine("How was the ride? Rate the driver from 1 to 5 : ");

        //    int driverRating = int.Parse(Console.ReadLine());

        //    if(driverRating >= 1 && driverRating<=5) 
        //    {
        //        rating.Add(driverRating);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Rating! Please Enter Again!");

        //        getRating();
        //    }

        public double getRating()
        {
            if (rating.Count == 0)
            {
                return 0;
            }
            else
            {
                double sum = 0;
                foreach (int rating in rating)
                {
                    sum += rating;
                }
                return sum / rating.Count;
            }
        }
        public void updateLocation(Location newLoc)
        {
            currLocation = newLoc;
        }

    }

   









}
