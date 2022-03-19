using System;

namespace InterfacesApp
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string password;
    private string Password
    { 
      get {return password; }
      set
      {
         if(value.Length>=8) {password=value;}
          else {throw new Exception($"Not Enough Characters");}
      }
     }

    public bool Hidden
    { get; private set; }
    
    public string HeaderSymbol {get => "\r\nPassword\r\n--------\r\n" ;}


    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }
    
    public void Display()
    {
        
        Console.Write(HeaderSymbol);

        //if the flag is false, it will print the password
        if(Hidden==false)
        {
          if(Password!=null) Console.WriteLine(Password);
          
        }
        //If the flag hidden is true, it will print * for each char
        else
        {
          foreach(char ch in Password)
          {
            Console.Write("*");
          }
        }
    }
    
    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
    public void Reset(string password)
    {
      Password = password;
      Hidden = false;
    }
    public bool ChangePassword(string oldPassword, string newPassword)
      {
        if(oldPassword==Password)
        {
          Reset(newPassword);
          return true;
        }
        Console.WriteLine("\r\nFailed to change password. The password entered is incorrect.");
        return false;
      }
  }
}