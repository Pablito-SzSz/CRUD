using System;
using System.Collections.Generic;

namespace CRUD 
{
    public class User
    {

        public string UserName { get; set; }


        public int UserId { get; set; }


        public override string ToString()
        {
            return "ID: " + UserId + "   Name: " + UserName;
        }

          public static void AddUser(List<User> users)
        {
            string newUser;
            int newUserId;
            var user = new User();
            System.Console.WriteLine("User Name:");
            newUser = Console.ReadLine();
            System.Console.WriteLine("User ID");
            newUserId = Convert.ToInt32(Console.ReadLine());
            users.Add(new User() { UserName = newUser, UserId = newUserId });
        }
        public static void ShowList(List<User> users)
        {
            int i;
            i=0;
            foreach (User aUser in users)
            {
                i++;
                System.Console.WriteLine($"{i}.{aUser}");
            }
        }
      
        
    }
}
