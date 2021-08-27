using System;
using BootCamp.Chapter.Combat.Combatants;
using BootCamp.Chapter.Examples;

/*
 *  Interface - A contract that telss what a class has to do.
 *          - most lightweight abstraction, and a way to have loosely coupled code
 *          - classes can do many things, therefore it can implement many interfaces.
 *          
 *  Semantics
 *      - needs keyword interfface
 *      - has access modifier
 *      - has methods (without access modifier - and are all public)
 *      - methods cannot have a body
 *      - by convention start with an I
 *      
 *  Implementation
 *      - similar to inheritance
 *      - not overridable, but interface methods are virtual
 *      
 *  Abstraction - exposing only the neeeded interface (not the interface type, just any abstraction) in order to interact with a software component
 *      - hides details from those that don't need it
 *      - turns logical compnenets into concepts - human understandable language.
 *      - Interface is the highest level of abstraction.
 */

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chapter 2. Lesson 4: interface- the ultimate abstraction";

            //TrapSimulator.Run();
            DuelingSimulator.Run();
        }



    }
}
