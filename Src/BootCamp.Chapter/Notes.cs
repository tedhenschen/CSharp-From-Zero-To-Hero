using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Notes
    {
        /*
         * Chapter 3:
         * Lesson 4: Generics
         * 
         * Generics - 
         * 
         *  We use <T> to identify generics
         *  Like Interfaces we use T instead of I
         * 
         * Generic Method is a method that accepts every type unless constrained
         *      
         *      ex:
         *      public static void Add<T>(T item)
         *      
         *  Generic Interface - Like a method it means that it can accept any type, however upon intialization ti will only take that specific type
         *      
         *      ex:
         *      interface ICreator<T>
         *      {
         *          T Create();
         *      }
         *      ex2:
         *      public interface IConverter <TFrom, TTO>
         *      {
         *          TTo Convert<TFrom, TTo>(TFrom from);
         *      }
         *      
         *  Generic Class - same as interface, once instantiated it will only accept that type. 
         *  
         *      ex:
         *          class Creator<T> : ICreator<T>
         *          {
         *              public T Create()
         *          }
         *      
         *          class ObjectsCreate : Creator<object>
         *              - instatiates a creator of objects
         *          class employeesCreate : Creator<employee>
         *              - instatiates a creator of employees
         *          
         *      ex2:
         *          class IntToStringConverter : IConverter<int, string>
         *          {
         *              public string Convert(int @from) => return @from.Tostring();
         *          }
         *          
         *  Type Constraints
         *      Added using where keyword
         *      new() constraint - means something can be created and has a default creator.  Gives the ability to create something generic
         *      ex:
         *      class Creator<T> : ICreator<T> where T: class
         *      {
         *          public T Create()
         *      }
         *      
         *      ex2:
         *      class Creator<T> : ICreator<T> where T: class, new()
         *      {
         *          public T Create()
         *          {
         *              return new T();
         *          }
         *      }
         *      
         *  Covariance & Contravariance
         *  
         *      generics cannot inherintly assume a more generalized or more specific version of itself
         *      
         *      Covariance
         *          - We can generalize a child derived from parent, then we can still treat child as parent (standard polymorphism)
         *          - To do this we use the out modifier
         *          - interface IContravariance<out T> {}
         *          
         *      Contravariance
         *          - we can specify a parent to a child, and treat that parent like a child
         *          - To do this we use the in modifier
         *          - interface IContravariance<in T> {}
         */


    }
}
