using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace lab_119_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new HashSetToExcel();

            hash.HashSetToExcelTest(1, 2, 4);
        }
    }
    
    public class HashSetToExcel
    {
        public Custom HashSetToExcelTest(int a, int b, int c)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            int[] arr = new int[3] { a, b, c };

            LinkedList<int> numLinkList = new LinkedList<int>();
            foreach (var item in arr)
            {
                numLinkList.AddFirst(item * 2);                
            }

            HashSet<int> hash = new HashSet<int>();
            foreach (var item in numLinkList)
            {
                hash.Add(item * 2);
            }
             
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < 3; i++)
            {
                dict.Add(i, (hash.ElementAt((i)) + 15) * 3);
            }

            s.Stop();
            long time = s.ElapsedMilliseconds;
            string headers = "Time taken(ms):,Value 1:,Value 2:,Value 3:\n";


            if (!File.Exists("data.csv"))
            {
                File.WriteAllText("data.csv", headers);
            }
            
            File.AppendAllText("data.csv", $"{time},{dict[0]},{dict[1]},{dict[2]}\n");
            Process.Start("data.csv");
            return new Custom(time, dict[0], dict[1], dict[2]);
            
        }                       
    }

    public class Custom
    {
        public long Time { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public Custom(long Time, int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.Time = Time; 
        }
        
    }
}
