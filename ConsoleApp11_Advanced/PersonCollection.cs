using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp11_Advanced
{
    public class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();

        }


    }
}
