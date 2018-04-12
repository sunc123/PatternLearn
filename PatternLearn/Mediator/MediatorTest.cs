using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class MediatorTest
    {
        public static void Test()
        {
            Mediator m = new LoginFrame("Mediator Sample");

            while (true)
            {
                Console.ReadKey();

                m.ColleagueChanged();
            }
        }
    }
}
