using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\Logs.log";
            
            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                List<string> output = new List<string>();
                StringBuilder sb = new StringBuilder();
                foreach (string line in lines)
                {
                    string[] entries = line.Split(new char[] {' '});
                    if (entries[2]=="Error"||entries[2]== "WARNING")
                    {                        
                        for (int i = 0; i < entries.Length; i++)
                        {
                            output.Add(entries[i]+" ");
                            sb.Append(entries[i] + " ");
                                                       
                        }
                        sb.Append("\n");                  

                    }                  
                    
                }
                using (TextWriter tw = new StreamWriter(Directory.GetCurrentDirectory() + "\\SavedList.txt"))
                {                    
                        tw.WriteLine(sb);
                }
            }
            else
            {
                Console.WriteLine("File Not found");
            }
        }
           
    }
}
