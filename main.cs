using System;

class Program {
  
  public static void Main (string[] args) 
  { 
    //Message variable
    string message;

    //Ask the user to enter a message
     Console.WriteLine("Please enter your message:");

    //Read the message from the user
     message = Console.ReadLine();

    //Notify the user that their message has been posted or rejected.
     Console.WriteLine("Your message was: " +  Message_length_check(message));
    
  }
  
  // Function to check the length of the message
  static string Message_length_check(string message)
  {
    // We will just return the message if it is less than or equal to 140 characters
      Int32 Max_lenght = 140; 
      if (message.Length <= Max_lenght) 
      {
          return "Posted"; // Return "Posted" if the message is less than or equal to 140 characters
      }
      else
      {
          return "Rejected"; // Return "Rejected" if the message is more than 140 characters
      }
  }
  
  
  }