using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace sleep_sort {
    class SleepSort {
        /// <summary>
        /// log a number to console after [number] amount of seconds
        /// </summary>
        /// <param name="data">number to log</param>
        public static void LogNumber(Object data) {

            Thread.Sleep((int)data * 1000);
            Console.WriteLine(data);
        }
        /// <summary>
        /// sort (log) an array in ascending order
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array) { 
        
            foreach(int number in array) {

                new Thread(LogNumber).Start(number);
            }
        }
    }
}