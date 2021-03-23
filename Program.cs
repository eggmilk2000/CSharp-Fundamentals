using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        

        static void Main(string[] args)
        {  
            Person person1 = new Person("Tuan","Minh","male",new DateTime(2000,2,1),1234,"Ha Noi");
            Person person2 = new Person("Thu","Ha","female",new DateTime(1997,5,10),5678,"Thai Binh");
            Person person3 = new Person("Lam","Truong","male",new DateTime(1994,8,25),94565454,"Ha Noi");
            Person person4 = new Person("Thuy","Hang","female",new DateTime(1998,8,25),94565454,"Ha Noi");
            
            Member member1 = new Member("Ha","An","female",new DateTime(1998,8,25),164862444,"Cao Bang",new DateTime(2009,6,2),new DateTime(2023,11,25));
            Member member2 = new Member("Le","Toan","male",new DateTime(1998,8,25),94565454,"Thai Nguyen",new DateTime(2021,3,20),new DateTime(2025,9,12));

            List<Person> rookies = new List<Person>();
            List<Member> rookies2 = new List<Member>();
            rookies.Add(person1);
            
            rookies.Add(person2);
            rookies.Add(person3);
            rookies.Add(person4);

            rookies2.Add(member1);
            rookies2.Add(member2);
            

            //Rookies.findMale(rookies);
            //Rookies.fullName(rookies);
            //Rookies.yearList(rookies);
            //Rookies.getBirthPlace(rookies);
            Rookies.joinClass(rookies2);
        }
    }
}
