using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Treci
{
    class DataConsolePrinter
    {
        public DataConsolePrinter() { }
        public void Print(IDataset data)
        {
            IReadOnlyCollection<List<string>> Data = data.GetData();
            if (Data == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            foreach (List<string> lines in Data)
            {
                foreach (string line in lines)
                {
                    Console.Write(line + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
