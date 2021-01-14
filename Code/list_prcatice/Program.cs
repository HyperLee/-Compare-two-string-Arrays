using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_prcatice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> Ashuzu = new List<string>();
            Ashuzu.Add("1");
            Ashuzu.Add("2");
            Ashuzu.Add("3");
            List<string> Bshuzu = new List<string>();
            Bshuzu.Add("1");
            Bshuzu.Add("2");
            Bshuzu.Add("4");
            List<string> Cshuzu = new List<string>();
            foreach (string aitem in Ashuzu)
            {
                if (!Bshuzu.Contains(aitem))
                {
                    Cshuzu.Add(aitem);
                }
            }

            //Console.Write(Cshuzu.ToString());

            foreach (string aPart in Cshuzu)
            {
                Console.WriteLine(aPart);
            }

            */

            string[] target = new string[] { "1", "2", "4" };

            List<string[]> sources = new List<string[]>();
            sources.Add(new string[] { "1", "2", "3" });
            sources.Add(new string[] { "1", "2", "4" });
            sources.Add(new string[] { "1", "2", "3", "4" });
            sources.Add(new string[] { "1", "2", "3", "5" });
            sources.Add(new string[] { "1", "2", "3", "4", "5", "6" });
            sources.Add(new string[] { "1", "2" });
            sources.Add(new string[] { "1", "2", "3", "4", "8" });

            var results = sources.Where((x) => target.Except(x).Count() == 0);

            //以下為顯示結果用
            foreach (var item in results)
            {
                string result = string.Empty;
                foreach (var s in item)
                {
                    result += s + ",";
                }
                //MessageBox.Show("元素中含有 " + result + "包含了 1,2,4");
                Console.WriteLine("元素中含有 " + result + "包含了 1,2,4");
            }

        }
    }
}
