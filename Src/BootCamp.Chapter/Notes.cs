using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Notes
    {
        /*
         * Chapter 3 (C# Language Specific Features)
         *  Lesson 1 Property, List, enums, and indexers
         *  
         * These will help write cleaner code and more efficient code
         * 
         * Lists:
         *      A data structure designed for the same purpose as an array
         *      Handles all the resizing work behind the scenes
         *      Does not require us to know the size before we use it
         *      
         *      Lists can be given a capacity when it is created to improve optimization, but isn't required and isn't critical to add.
         *      If a capacity is given it doesn't restrict that list to being that size, it just tells the system to go ahead and give 
         *      the list that space so that it doesn't have to create it every time.
         *      
         *      List is a generic class
         *      <T> means that the generic type can be anything, but it must be specified
         * 
         *      var numbers = new List<int> {1,2,3};
         *      numbers.Add(4);  // Adds the value in parenthesis at the end of the list
         *      numbers.Remove(4); // removes the value given
         *      numbers.RemoveAt(0); //removes the value at the specified index
         *      numbers.Clear;
         *      
         * Properties
         *      Property is a method used to get and/or set a field
         *      Can be customized, but not critical
         *      
         *      Will look the same as a field when calling it, but we use properties because of encapsulation and readability
         *      
         *      //Auto
         *      public string Name {get;set}
         *      
         *              or
         *              
         *      //Expression Bodied
         *      private string _name;
         *      public string Name
         *      {
         *          set{_name = value;}
         *          get{ _name;}
         *      }
         *      
         *              or
         *              
         *      //Custom
         *      private string _name;
         *      public string Name
         *      {
         *          get {return $"{property1} {property2}"}
         *      }
         *      
         * 
         * Indexer (type of property)
         *      A special property
         *      A handy way to access something inside the class
         *      
         *      // see Inventory class in Program.CS file
         *          public int this[string type]
         *          {
         *              return ;
         *          }
         *          
         *          
         *  Enum
         *      A collection of tags
         *      is a type with a set of predefined values
         *      similar to constant
         *      
         *      indexing:
         *      Starts from 0
         *      Can be custom assigned
         *      can be casted to int
         *      
         *      
         *      enum Gender
         *      {
         *          Male,
         *          Female,
         *          Other
         *      {
         *      
         *      var myGender = Gender.Male;
         * 
         */



    }
}
