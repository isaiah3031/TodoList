using System;
using System.Collections.Generic;

/*TodoList allows the user to view, add to and delete their todo list.
  Maybe add a difference btw logging out and quitting.

  add a login class(method?) that will keep a record of all of the 
  users using it. Maybe a nested list to keep user data straight.
*/

public class TodoList
{
    public static void Main(String[] args)
    {
        List<string> fullList = new List<string>();
        bool isLoggedIn = true;
        string cmnd;
        
        /*The while loop allows the user to make more than one change
          without getting logged out.
          
          Eventually this will first prompt the user to login to their profile
          or exit the program entirely
        */
        while (isLoggedIn)
        {
            //Welcomes the user and introduces the function of the program.
            Console.WriteLine("Add to TodoList or type delete or logout to stop");
            cmnd = Console.ReadLine();
            
            //Maybe change this whole messy if then thing to a case switch with a String variable
            
            /*Right now changin the variable cmnd to logout ends the loop
              and closes the program.
            
              Eventually, when I link a text file and add a user data base
              and saved data, it will just return to the welcome screen.
            */
            if (cmnd.ToLower() == "logout")
            {
                Console.WriteLine("You are logged out");
                isLoggedIn = false;
                break;
            }
            /*The program prints a numbered todo list and prompts the user to enter
              the number to delete an entry.
            */
            
            else if (cmnd.ToLower() == "delete")
            {
                Console.WriteLine("Which entry? (use a number)");
                int count = 0;
                foreach(string listIndex in fullList)
                {
                    count++;
                    Console.WriteLine($"{count}.......{listIndex}");
                }
                cmnd = Console.ReadLine();    
                bool isNum = Int32.TryParse(cmnd, out int delete);
                if (isNum)
                {
                    fullList.RemoveAt(delete + 1);
                    fullList.ForEach(Console.WriteLine);
                    
                } 
                /* If the user types a string or a number that is too large they 
                are returned to the welcome screen
                */
                
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
            /* This adds to the todo list.
            
            I do think this looks too messy and confusing with all the ifs.
            case switch is in progress.
            */
            
            else
            {
                fullList.Add(cmnd);
                fullList.ForEach(Console.WriteLine);             
            }
           
        }
    }
}

