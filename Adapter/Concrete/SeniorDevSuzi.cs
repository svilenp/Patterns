using System;
using Adapter.Contracts;

namespace Adapter.Concrete
{
    public class SeniorDevSuzi : IDeveloper
    {
        public void Code()
        {
            Console.WriteLine($"{ nameof(SeniorDevSuzi) }: I code all day long and I love it!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{ nameof(SeniorDevSuzi) }: Sleeping... not today.");
        }
    }
}
