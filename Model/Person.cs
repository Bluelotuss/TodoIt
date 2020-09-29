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
                if(string.IsNullOrEmpty(firstName))
                {
                throw new Exception("First name cannot be null or empty");
                }
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        string lastName;
        public string LasttName
        {
            get
            {
                if(string.IsNullOrEmpty(lastName))
                {
                throw new Exception("Last name cannot be null or empty");
                }
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        //constructor
        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            this.lastName = lastName;
        }

    }
}
