using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Rookies
    {
        public static void findMale(List<Person> rookies){
            List<Person> newList = new List<Person>();
            foreach(var items in rookies){
                if(items.gender == "male" || items.gender == "Male"){
                    newList.Add(items);
                }
            }
            Person.Print(newList);
        }

        public static void fullName(List<Person> rookies){
            foreach(var items in rookies){
                Console.WriteLine("Full name: " + items.firstName + " " + items.lastName);
            }
        }

        public static void yearList(List<Person> rookies){
            List<Person> newList1 = new List<Person>();
            List<Person> newList2 = new List<Person>();
            List<Person> newList3 = new List<Person>();
            foreach(var items in rookies){
                if(items.dob.Year < 1998){
                    newList1.Add(items);   
                }
                if(items.dob.Year > 1998){
                    newList2.Add(items);   
                }
                if(items.dob.Year == 1998){
                    newList3.Add(items);   
                }
            }
            Console.WriteLine("List of members who has birth year is 1998: ");
            Person.Print(newList3);
            Console.WriteLine("List of members who has birth year greater than 1998: ");
            Person.Print(newList2);
            Console.WriteLine("List of members who has birth year less than 1998: ");
            Person.Print(newList1);
        }

        public static void getBirthPlace(List<Person> rookies){
            List<Person> newList = new List<Person>();
            foreach(var items in rookies){
                if(items.birthPlace == "Ha Noi")
                {
                    newList.Add(items);
                }
            }
            var first = newList[0];
            Console.WriteLine("First name: " + first.firstName + "\nLast name: " + first.lastName 
                + "\nGender: " + first.gender + "\nDate of birth: " 
                + first.dob.ToString("dd/MM/yyyy") + "\nPhone number: " + first.phoneNumber
                + "\nBirth place: " + first.birthPlace);
				
        }

        public static void joinClass(List<Member> rookies){
            DateTime dt1 = new DateTime(2021,3,22);
            List<Member> newList = new List<Member>();
            foreach(var items in rookies){
                if(DateTime.Compare(items.startDate, dt1) < 0){
                    Console.WriteLine("First name: " + items.firstName + "\nLast name: " + items.lastName 
                    + "\nGender: " + items.gender + "\nDate of birth: " 
                    + items.dob.ToString("dd/MM/yyyy") + "\nPhone number: " + items.phoneNumber
                    + "\nBirth place: " + items.birthPlace
                    + "\nStart date: " + items.startDate.ToString("dd/MM/yyyy") 
                    + "\nEnd date: " + items.endDate.ToString("dd/MM/yyyy")
                    + "\n---------------------------\n");
                }
            }
            
        }
    }
}
