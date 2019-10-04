using System;
using System.Collections.Generic;
using Login.Models;

namespace Login
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Dictionary<string, User> users = new Dictionary<string, User>();
      User user1 = new User("Name", "Password");
      User zach = new User("Zach", "Password123");
      users.Add(user1.Name, user1);
      users.Add(zach.Name, zach);

      System.Console.Write("Username: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();


      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("You're Logged in");
      }
      else
      {
        System.Console.WriteLine("Username or password is incorrect");
      }

    }
  }
}
