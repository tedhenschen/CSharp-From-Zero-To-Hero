using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Notes
    {
        /*
         * Chapter 3 - 
         * Lesson 3 - Null related operators and more sugar
         * 
         * Ternary Operator (?)
         *      Condition ? valueIfTrue : ValueIfFalse
         *      a short hand if statement for simple conditions
         *      
         *  Null - conditional operator (?.)
         *      object?.Method() or object?.property == true;
         *      if the object isn't null then run the method or comparing the paramater to a value, if it is null don't call the method
         *      a shoprthand for if (object != null)
         *      
         *  Null-Coalescing Operartor (??)
         *      expression with null check ?? value if null
         *      
         *      ie:  totalWeight += person?.Weight ?? 0;
         *      if the object exists, add the weight to the total, else return 0
         *      
         *      also good for validation
         *      Property = value ?? throw new Exception
         *      example:
         *      Name = name ?? throw new ArgumentNullException("");
         *      This can replace a simple try or if null statement
         *      
         *  Nullable Values - 
         *      type? variable = null;
         *      by adding a ? after a value/primitive type (such as int) it becomes a reference type and can now be null
         *      
         *  .GetType() - 
         *      Returns the type of object that object is
         *      
         *  is operator
         *      if (variable is Object) 
         *      example if(dog1 is Dog)
         *      
         *  Property Initializers
         *      we can set a value to a property immediately without the user passing value
         *      
         *      when declaring the property      
         *          public int Number {get;} = 1;
         *          public string Word {get;} = "someWord";
         *          
         *      or when constructing the object (which would be overridden if an age was given when the constructor is called)
         *          public class(type variable = defaultValue)
         *          public person(int age = 0)
         *          {
         *              Age = age;
         *          }
         *      
         *  nameof(variable)
         *      returns a string of the name of the variable or type
         *      
         *  Pattern Matching
         *      a switch case shorthand
         *      type variable1 = variable2 switch
         *      {
         *          0 => "Zero",
         *          1 => "One",
         *          2 => "Two",
         *          _ => "?"
         *      };
         *  
         *  
         *      
         * 
         */





    }
}
