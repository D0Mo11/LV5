using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treci
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data1 = new Dataset("sensitiveData.csv");
            DataConsolePrinter printer = new DataConsolePrinter();
            User user1 = User.GenerateUser("Domagoj");
            User user2 = User.GenerateUser("Ivan");
            User user3 = User.GenerateUser("Luka");
            ProtectionProxyDataset proxy1 = new ProtectionProxyDataset(user1);
            ProtectionProxyDataset proxy2 = new ProtectionProxyDataset(user2);
            ProtectionProxyDataset proxy3 = new ProtectionProxyDataset(user3);
            VirtualProxyDataset proxy4 = new VirtualProxyDataset("sensitiveData.csv");
            Console.WriteLine(user1.Name);
            printer.Print(proxy1);
            Console.WriteLine();
            Console.WriteLine(user2.Name);
            printer.Print(proxy2);
            Console.WriteLine();
            Console.WriteLine(user3.Name);
            printer.Print(proxy3);
            Console.WriteLine();
            Console.WriteLine("Virtual");
            printer.Print(proxy4);
        }
    }
}
