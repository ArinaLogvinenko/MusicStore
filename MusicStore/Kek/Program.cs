using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kek
{
    class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            var user = userRepository.GetById(1);
            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
