using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterProject
{
    internal class TriangularTower : Tower
    {
       public TriangularTower(double height,double width)
            : base(height,width)
        {

        }
        public override void calcScope()
        {
            double ribsLength = Math.Sqrt((base.Height * base.Height) + (base.Width / 2) * (base.Width / 2)) * 2;
           // Console.Write(Convert.ToInt32(r));
            Console.WriteLine("the TriangularTower scope is : {0}", base.Width+ ribsLength) ;
        }



        private void PrintStartTriangular()
        { 
            int sumOfLines = Convert.ToInt32(base.Height)-2;
            int kindOfNumbers = (Convert.ToInt32(base.Width) - 2) / 2;
            int restNumber = sumOfLines % kindOfNumbers;
            int currentNum=1;
            int Line;
            int amountLinesForNum;
            for (Line = 1; Line <= base.Height;)
            {
                amountLinesForNum = sumOfLines / kindOfNumbers;
                if (Line == base.Height|| Line == 1)
                    amountLinesForNum = 1;
                for (int l = 1; l <= amountLinesForNum; l++)
                { 
                    if ((Line == 2) && (restNumber != 0))
                    {
                        amountLinesForNum += restNumber;
                    }
                    for(int v=1;v<=((this.Width- currentNum) /2);v++)
                        Console.Write(" ");

                    for (int k = 1; k <= currentNum; k++)
                    {
                        Console.Write("*");
                    }
                    Line++;
                    Console.WriteLine();
                }
                currentNum += 2;
            }

        }
        
        public void printTheTriangular()
        {
            if((base.Width%2==0)||base.Height*2<this.Width||base.Width==3)
                Console.WriteLine("This triangle cannot be printed");
            else
            {
                this.PrintStartTriangular();
            }

        }

        
    }
}
