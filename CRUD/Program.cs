using System;
using System.Collections.Generic;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            

            for (; ; )
            {
                Console.WriteLine("Show useres[1], add user [2], edit list [3], save list[4], load list [5]");
                var inputMenu = Console.ReadLine();

                if (inputMenu == "1")
                {
                    //pokazanie listy
                    User.ShowList(users);
                }
                else if (inputMenu == "2")
                {
                    //dodawanie usera
                   User.AddUser(users);
                }
                else if (inputMenu == "3")
                {
                    Console.WriteLine("Select ID of person, who you want to remove");
                    User.ShowList(users);
                    int i; 
                    i = Convert.ToInt32(Console.ReadLine());
                    users.RemoveAll(r => r.UserId == i);
                    
                    
                    //usuwanie osoby
                }
                else if (inputMenu=="4")
                {

                    //zapisywanie
                    Console.ReadKey();
                }
                else
                {
                    //wypadki przy pracy
                    System.Console.WriteLine("Wrong!");
                    break;
                }
                
            }
            
        }

        
    }
}
