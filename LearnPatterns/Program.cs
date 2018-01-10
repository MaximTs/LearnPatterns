using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnPatterns.Strategy;

namespace LearnPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPattern();
        }

        private static void StrategyPattern()
        {
            try
            {
                var service = new StrategyService(new VostokDocumentCreator());
                service.CheckDocument();
                Console.WriteLine(service.GetDocumentParamsAsString());

                service = new StrategyService(new VodafoneDocumentCreator("2"));
                service.CheckDocument();
                Console.WriteLine(service.GetDocumentParamsAsString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
