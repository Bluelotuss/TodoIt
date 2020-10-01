using System;

/*
6. Create a new class PersonSequencer in Data folder.
a. In PersonSequencer creates a private static int variable called personId.
b. Add a static method called nextPersonId that increment and return the next personId value.
c. Add a static method called reset() that sets the personId variable to 0.
d. Unit test PersonSequencer.
e. Commit changes.
*/

namespace TodoIt
{
    public static class testst
    {
        static int personId;

        public static int NextPersonId()
        {
            return ++personId;
        }
        
        public static void Reset()
        {
            personId = 0;
        }
        
        
    }
}