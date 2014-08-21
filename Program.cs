using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSort
{
    class Program
    {
        string storeName;
        static void Main(string[] args)
        {
            
            
            Store st129 = new Store();
            //Create an array of store objects
            Store[] storeArray = new Store[10];
            for (int i = 0; i < 10; i++)
            {
               storeArray[i] = new Store();
            }

            //random number generator
             Random rand = new Random();
            
            //stores a random number from 1 to 500
            //in the store array
            for (int i = 0; i < 10; i++)
            {
                storeArray[i].poNumber = rand.Next(1, 500);
            }

            //prints out the numbers in from array
            foreach (Store value in storeArray)
            {
                Console.WriteLine(value.poNumber);
            }

            Console.WriteLine();
            //Sorts the array
            Array.Sort(storeArray);
            //Prints out the sorted Array
            foreach (Store value in storeArray)
            {
                Console.WriteLine(value.poNumber);
            }


            

           
            //storeArray[0] = st129;
            //storeArray[1] = new Store();
            //storeArray[2] = new Store();
            //storeArray[1].poNumber = 100;
            //storeArray[2].poNumber = 200;
            //Console.WriteLine(storeArray[1].poNumber);
            //Console.WriteLine(storeArray[2].poNumber);
            //storeArray[1].poNumber = 2;
            //List<Store> StoreList = new List<Store>();
            //StoreList.Add(new Store { });
            Console.Read();
            
        }
    }
}
