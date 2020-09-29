using System;

namespace TodoIt.Model
{
    public class Person
    {
        //fields
        readonly int personId;
        string firstName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(firstName))
                {
                throw new Exception("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }
        string lastName;
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(string.IsNullOrEmpty(lastName))
                {
                throw new Exception("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        //constructor
        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
