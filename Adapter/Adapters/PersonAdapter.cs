using System;
using Adapter.Contracts;

namespace Adapter.Adapters
{
    public class PersonAdapter : IDeveloper
    {
        private IPerson _person;

        public PersonAdapter(IPerson person)
        {
            _person = person;
        }

        public void Code()
        {
            _person.Work();
        }

        public void Sleep()
        {
            _person.Sleep();
            Console.WriteLine(" ...Sometimes even more");
        }
    }
}
