using System;

namespace MachineProblem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] userLogin = new int[5];
            int[] userPass = new int[5];
            bool[] userValid = new bool[5];
            

            Console.Write("Username: ");
            userValid[0] = Int32.TryParse(Console.ReadLine(),out userLogin[0]);
            userValid[1] = LoginCheck_User(userLogin[0]);


            while (userValid[0] == false || userValid[1] == false)
            {
                Console.Write("Username: ");
                userValid[0] = Int32.TryParse(Console.ReadLine(), out userLogin[0]);
                userValid[1] = LoginCheck_User(userLogin[0]);

            }


            




            Console.WriteLine("Password: ");

            userValid[0] = int.TryParse(Console.ReadLine(), out userPass[1]);
        }

        public static bool LoginCheck_User(int a)
        {
            
            if (a== 2020156520)
            {
                return true;
               

            }
            else
            {

                return false;
            }

            
            
        }
    }
}