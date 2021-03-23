using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Member : Person
    {
        public DateTime startDate{get;set;}
        public DateTime endDate{get;set;}

        public Member(string firstName, string lastName,string gender,DateTime dob, int phoneNumber, string birthPlace,DateTime startDate, DateTime endDate){
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dob = dob;
            this.phoneNumber = phoneNumber;
            this.birthPlace = birthPlace;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public Member(DateTime startDate,DateTime endDate){
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}