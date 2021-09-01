using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Notes
    {
        /*
         * Chapter 3:
         * Lesson 6: Delegates
         * 
         * Delegate 
         *      - A function as a variable
         *      - A function with no arguments and no return.
         *      - Calls function and calls an action
         *      - sometimes used like interfaces in functional programming
         *  
         *  
         *  How to use a delegate
         *      1. Declare a delegate
         *      2. delcare a variable of that delegate type
         *      3. assign a function
         *      4. call the delegate variable
         *  
         *  ex:
         *      public delegate void MyDelegate(input);
         *      MyDelegate action = FunctionThatImplementsMyDelegate;
         *      public void FunctionThatImplementsMyDelegate(){}
         *      //To Call
         *      action();
         *      
         *  Chaining Delegates
         *      delegates can be added together
         *      stacking the behavior of one on top of the other
         *      using += and -=
         *      
         *  ex: 
         *      MyDelegate action = FunctionThatImplementsMyDelegate;
         *      action += AnotherFunctionThatImplementsMyDelegate;
         *      
         *  Common Delegates
         *      - .Net has a collection of delegates predefined
         *      - 
         *  Action
         *      Action action1 = () => ConsoleWriteLine("Hello Anonymous!");
         *      Action action1<string> = (name) => ConsoleWriteLine("Hello {name}!");
         *  Func
         *      Returns any output based on input
         *      The last T is for output, all oithers are for input
         *      
               Func<bool> Function1 = () => true;
               Func<int, int, bool> areEqual = (a,b) => a == b;
         *      
         *  Predicate
         *      - A special delegate that takes an object
         *      - checks object properties and returns true or false
         *      
              Predicate<object> functionName = (object) => object.Equals > 1;
         *      
         *      
         *  Events
         *      - An expression for something that happened
         *      - A way to decouple things 
         *      - ApplicationStarted, WindowActivated, ApplicationCLosed, EnemyDied, TimeElapsed, KeyPressed 
         *      - A kind of delegate, that cannot be assigned
         *      - Can only be subscrived or unsubscribed
         *      
         *  Firing an event
         *      - Calling an event is the same as calling a delegate
         *      
         *  EventHandler
         *      - C# uses EventHandler or EventHandler<T>
         *      - uses event arguments to give context to what happened
         *      
         *               *      
         *      public class TriggeredEventArgs : EventArgs
         *      {
         *          public type propertyVariable {get;}
         *          public TriggeredEventArgs()
         *          {
         *              propertyVariable = value;
         *          {
         *      }
         *      public event EventHander<TriggeredEventArgs> function;
         *      
         *      we use the ? after the event to make sure something is listening (not Null)
         *      function?.Invoke(this,TriggeredEventArgs e)
         *      
         * Subscribing to event handlers
         *      - Subsctibing to EventHandler neesds a function which takes two args: object sender and EventArgs
         *      
         *      private static void EventTriggered(object sender, TriggeredEventArgs e)
         *      {
         *      }
         *      
         *  Unsubscribing to Events
         *      - Hacing an event subscribed will prevent it from properly cleaned up after it leaves the scope
         *      - This can cause memory leaks
         *      - Will live in Memory as long as the event is subscribed
         *      
         *      
         *  
         */


    }
}
