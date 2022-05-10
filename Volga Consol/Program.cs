using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Volga_Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Дмитрий\OneDrive\Рабочий стол\Volga IT\test.txt");
                line = sr.ReadToEnd();
                    int number = line.Count('<'.Equals);
                    for (int i = number; i >= 0; i = i - 1)
                    {
                        try
                        {
                            int start = 0;
                            int at, at_2;
                            at = line.IndexOf('<', start);
                            at_2 = line.IndexOf('>', start);
                            line = line.Remove(at, at_2 - (at - 1));
                        
                        }
                        catch
                        {
                            
                        }
                    }
                
                    try
                    {
                        int start_2 = 0;
                        int at_3, at_4;
                        at_3 = line.IndexOf('<', start_2);
                        at_4 = line.IndexOf('>', start_2);
                        line = line.Remove(at_3, at_4 - (at_3 - 1));

                    }
                    catch 
                    { 

                    }
                    int number_2 = line.Count('&'.Equals);
                    for (int i = number_2; i >= 0; i = i - 1)
                    {
                        try
                        {
                            int start_3 = 0;
                            int at_5, at_6;
                            at_5 = line.IndexOf('&', start_3);
                            at_6 = line.IndexOf(';', start_3);
                            line = line.Remove(at_5, at_6 - (at_5 - 1));

                        }
                        catch
                        {

                        }
                    }
                Console.Write(line);
                string line_2 = line;
                line = sr.ReadLine();
                Console.WriteLine("");
                var words = line_2.Split(' ', '-', ':', '.', '"', '\'', '!', '?').Where(q => !string.IsNullOrEmpty(q));
                var uniqWrds = words.Select(q => q.ToLower().Trim()).Distinct();
                var result = new Dictionary<string, int>();
                foreach (var word in uniqWrds)
                {
                    result.Add(word, words.Count(q => q.ToLower().Equals(word)));
                }
                result = result.OrderByDescending(q => q.Value).ToList().Take(5).ToDictionary(key => key.Key, value => value.Value);
                foreach (var word in result)
                {
                    Console.WriteLine($"Слово: {word.Key}. Колличество: {word.Value}");
                }
                Console.ReadKey();
            }

            catch 
            {

            }

        }
    }
}
