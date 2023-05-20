using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '5', '6', '7', '8', '9', '0' };
        static int player = 1;
        static int choice;
        static int flag;

        static void DrawBoard()
        {
            Console.WriteLine("      |       |         ");
            Console.WriteLine("   {0}   |    {1}   |     {2}   ",   spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("______|_______|_________");
            Console.WriteLine("      |       |         ");
            Console.WriteLine("   {0}   |    {1}   |     {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("______|_______|_________");
            Console.WriteLine("      |       |         ");
            Console.WriteLine("   {0}   |    {1}   |     {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("      |       |         ");
        }
        static int Check()
        {
            if (spaces[0] == spaces[1] &&
                spaces[1] == spaces[2] ||    //row 1
                spaces[3] == spaces[4] &&
                spaces[4] == spaces[5] ||   // row 2
                spaces[6] == spaces[7] &&
                spaces[7] == spaces[8] ||  // row 3
                spaces[0] == spaces[3] &&
                spaces[3] == spaces[6] ||  // colum 1
                spaces[1] == spaces[4] &&
                spaces[4] == spaces[7] ||  //colum 2
                spaces[2] == spaces[5] &&
                spaces[5] == spaces[8] || //colum 3
                spaces[0] == spaces[4] &&
                spaces[4] == spaces[8] ||  // diagonal 1
                spaces[2] == spaces[4] &&
                spaces[4] == spaces[6])  // diagonal 2
            {
                return 1;
            }
            else if (spaces[0] != '1' &&
                     spaces[1] != '2' &&
                     spaces[2] != '3' &&
                     spaces[3] != '4' &&
                     spaces[4] != '5' &&
                     spaces[5] != '6' &&
                     spaces[6] != '7' &&
                     spaces[7] != '8' &&
                     spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

            static void  DrawO(int pos)
            {
                spaces[pos] = 'O';
            }
                
                
        }
        public static void Main(string[] args)
        {

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine();
            //}

            //Person person = new Person();
            //person.Name = "Old Person";
            //Prace(person);
            //Console.WriteLine(person.Name);
        }

       

        
        
      
    }
}
