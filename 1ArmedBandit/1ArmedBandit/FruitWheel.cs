using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ArmedBandit
{
    class FruitWheel
    {
        public const int maxsize = 7;
        private FruitWheel[] contents;
        Random rnd = new Random();
       

        public FruitWheel()
        {
            contents = new FruitWheel[maxsize];
        }

        
    }

    class GenerateFruit
    {
        Random rnd = new Random();
        int intRandomNumber;
        int intGenerateFruit;
        intRandomNumber = rnd.Next(0,7);
        intGenerateFruit = Convert.ToInt32();
        
        
    }
}
