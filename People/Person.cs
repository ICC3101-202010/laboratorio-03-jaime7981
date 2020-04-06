using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kornerchop.Workers
{
    class Person
    {

        private string firstname;
        private string lastname;
        private string nationality;
        private string rut;
        private string birthdate;
        private string gender;

        public Person()
        {

        }

        public Person(string firstname, string lastname, string nationality, string rut, string birthdate, string gender)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.nationality = nationality;
            this.rut = rut;
            this.birthdate = birthdate;
            this.gender = gender;
        }

        public void PersonInfo()
        {
            Console.WriteLine("\n Name:" + firstname + "\n Lastname:" + lastname + "\n Nationality:" + nationality
                + "\n RUT:" + rut + "\n Birth Date:" + birthdate + "\n Gender:" + gender + "\n Wage:" + "\n");
        }

        public void PersonInfo(int wagevalue, string possition, string workinghour)
        {
            Console.WriteLine("\n Name: " + firstname + "\n Lastname: " + lastname + "\n Nationality: " + nationality 
                + "\n RUT: " + rut + "\n Birth Date: " + birthdate + "\n Gender: " + gender + "\n Wage: " + wagevalue + "\n Position: " + possition + "\n Working Hour: " +  workinghour + "\n");
        }

    }
}
