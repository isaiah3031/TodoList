using System;
using System.Collections.Generic;

/*Program that allows users to add to their todo list and d
  Will show the list after any input.
  Maybe add a difference btw logging out and quitting.
  add a delete function that reads strings and converts them to lower case
  add a login class(method?) that will keep a record of all of the users using it. Maybe a nested list to keep user data straight.
*/

public class TodoList
{
    public static void Main(String[] args)
    {
        List<string> fullList = new List<string>();
        int listLength = 0;
        bool isLoggedIn = true;
        string cmnd;
        while (isLoggedIn)
        {
            Console.WriteLine("Add to TodoList or type delete or logout to stop");
            cmnd = Console.ReadLine();
            if (cmnd.ToLower() == "logout")
            {
                Console.WriteLine("You are logged out");
                isLoggedIn = false;
                break;
            }
            else
            {
                fullList.Add(cmnd);
                fullList.ForEach(Console.WriteLine);             
            }
           
        }
    }
}

