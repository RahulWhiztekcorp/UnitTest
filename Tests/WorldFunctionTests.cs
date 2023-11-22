using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleApp
{
    public class WorldFunctionTests
    {
        // Naming Convenctions = ClassName_MethodName_ExepecctedResult

        public static void WorldFunction_ReturnRahulIfZero_ReturnString()
        {
            try
            {
                // Arrange - Go get your variable , whatever you need ,you classes ,go get fuctions
                int num = 1;
                WorldFunction worldFunction = new WorldFunction();

                // Art - Execute this function
                string result = worldFunction.ReturnRahulIfZero(num);

                // Assert - Whatever ever is returned is it what you want.
                if (result == "Rahul")
                {
                    Console.WriteLine("PASSED: WorldFunction_ReturnRahulIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldFunction_ReturnRahulIfZero_ReturnString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
