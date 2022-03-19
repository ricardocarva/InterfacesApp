using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 This program users two interfaces to make the classes PasswordManager and TodoList behave a certain way.
                 The TodoList can only have 5 inputs so far. If we reset it, it prints "[]"
                 The PasswordManager takes only passwords with more than 8 characters. If the flag Hidden is true, it wont print the password.

                 This program does not:
                   1. Create users
                   2. Take user inputs to change passwords. WIP:commented code lines below
                   3. Ensure the user enters passwords with enough characters
                   4. Expands the TodoList
                   5. Complete items from the TodoList
                   6. More...

                             Author: Ricardo Carvalheira
                 */
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Drive");
            tdl.Add("Paint the walls");
            tdl.Add("Game");

      /*
      The code below asking to enter a password is an unfinished draft that I intend to continue writing in a near future

      Console.WriteLine("Enter 1 to create a new password: ");
      
      string input = Console.ReadLine();
      bool success = Int32.TryParse(input, out int inputInt);
      string password = "iluvpie123";
      if(success) 
        if(inputInt==1)
        {
          Console.WriteLine("Enter your password: ");
          password = Console.ReadLine();
        
        }      
      PasswordManager pm = new PasswordManager(password, true);
      */
      PasswordManager pm = new PasswordManager("iluvpie123", true);

        tdl.Display();
      pm.Display();

      pm.ChangePassword("iluvpie123", "012345678");
      pm.Display();


            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
