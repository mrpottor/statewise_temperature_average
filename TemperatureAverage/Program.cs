using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_state_wise_temperature_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*declare array for collecting temperature of cities of 3 states
             *
             *first state provides temperature of 3 cities
             *second state provides temperature of 7 cities
             *third state provides temperature of 4 cities
            */
            int[][] statesTemprature = new int[3][];
            statesTemprature[0] = new int[3];
            statesTemprature[1] = new int[7];
            statesTemprature[2] = new int[4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < statesTemprature[i].Length; j++)
                {
                    Console.WriteLine($"Give tempreture for city {j + 1} of state {i + 1} :");
                    statesTemprature[i][j] = int.Parse(Console.ReadLine());
                }
            }
            /*
             * Call GetStateWiseAverage() with state position and temperature data
             */
            Console.WriteLine("Which state's average do you want to calculate?  1, 2, 3 ");
            int stateNum = int.Parse(Console.ReadLine());
            int average = GetStateWiseAverage(stateNum, statesTemprature);
            Console.WriteLine($"the tempreture average for state {stateNum} is  {average}");

            /*
             * Display Average
             */
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public static int GetStateWiseAverage(int ststePosition, int[][] stateTemp)
        {
            // put here logic to calculate average
            int totalCity = stateTemp[ststePosition - 1].Length;
            int sum = 0;
            for (int i = 0; i < totalCity; i++)
            {
                sum += stateTemp[ststePosition - 1][i];
            }
            return sum / totalCity;
        }
    }
}


