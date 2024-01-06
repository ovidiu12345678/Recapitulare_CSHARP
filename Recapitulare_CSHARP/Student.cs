using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulare_CSHARP
{
    internal class Student
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Address Address { get; set; }

        public Guid Id { get; private set; }
       
        public Student()
        {
            this.Id = Guid.NewGuid();
        }

        public override string ToString() =>
            $"First Name : {FirstName}, Last Name : {LastName}, Age : {Age}, Address {Address}";
        

    }
}
