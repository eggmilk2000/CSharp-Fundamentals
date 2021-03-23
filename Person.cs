using System;
using System.Collections.Generic;

namespace Program
{
    class Person{
        public string firstName{get;set;}
        public string lastName{get;set;}
        public string gender{get;set;}
        public DateTime dob{get;set;}
        public int phoneNumber{get;set;}
        public string birthPlace{get;set;}

        public Person(){}

        public Person(string firstName, string lastName,string gender,DateTime dob, int phoneNumber, string birthPlace){
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dob = dob;
            this.phoneNumber = phoneNumber;
            this.birthPlace = birthPlace;
        }

        public static void Print(List<Person> rookies){
            foreach(var items in rookies){
            Console.WriteLine("First name: " + items.firstName + "\nLast name: " + items.lastName 
                + "\nGender: " + items.gender + "\nDate of birth: " 
                + items.dob.ToString("dd/MM/yyyy") + "\nPhone number: " + items.phoneNumber
                + "\nBirth place: " + items.birthPlace 
                + "\n---------------------------\n");
            }
        }
    }
}
