using System;

namespace InterfacesApp
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;
    public string HeaderSymbol {get => "Todos\r\n--------\r\n" ;}


    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      if(nextOpenIndex<5)
      {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
      }

    }

    public void Display()
    {
      Console.Write(HeaderSymbol);
      foreach(string todo in Todos)
      {
        if(String.IsNullOrEmpty(todo))
        Console.WriteLine("[]");
        else Console.WriteLine(todo);
      }
      //Console.WriteLine("\r\n");
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

  }
}