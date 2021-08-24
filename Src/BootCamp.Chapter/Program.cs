using System;

namespace BootCamp.Chapter
{

    /*
     * Virtual Methods (polymorphism) - 
     *      Virtual is a Keyword meaning that method is not final and implementation can be changed in a child, 
     *      means that it can be overriden!
     *      Virtual Method can be called from the child class using base.method()
     *      
     *      
     *  Abstract 
     *      Can be used for either classes or methods (virtual can only be used in methods.)
     *      class - cannot be instantiated on its own, needs a child class to instantiate
     *      
     *      method - declared in parent, and implemented in child.  A type of virtual method
     *      
     *      The procted access modifier is used for abstract class mathods, because it will never be used pubilicly
     *      and will always only be called by the child class.
     *      
     *  Virtual methods should be avoided when possible, except when it feels very natural and with good justification
     *  
     *  Abstract is a better option than virtual, but the use of it shouldn't be forced.
     *  
     */
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalityExample();
            //TeachersExample();
            MysteriousTeacherExample();
        }

        private static void MysteriousTeacherExample()
        {
            Teacher[] teachers =
            {
                new Teacher(),
                new MysteriousTeacher()
            };

            foreach (Teacher teacher in teachers)
            {
                teacher.Work();
            }
        }

        private static void TeachersExample()
        {
            Teacher[] teachers =
            {
                new Teacher(),
                new GoodTeacher(),
                new BadTeacher(),
                new SuperbTeacher()
            };

            foreach (Teacher teacher in teachers)
            {
                teacher.Work();
            }
        }

        private static void PersonalityExample()
        {
            Personality[] personalities =
            {
                new Pessimist(),
                new Optimist(),
                new SadOptimist()
            };

            foreach (Personality personality in personalities)
            {
                Console.WriteLine(personality.GetName());
                personality.PrintStatus();
            }
        }
    }

    public class Teacher
    {
        public virtual void Work()
        {
            Console.WriteLine("Teaching.");
        }
    }

    public class MysteriousTeacher : Teacher
    {
        public void Work()
        {
            Console.WriteLine("Myteriously teaching.");
        }
    }
    public class GoodTeacher : Teacher
    {
        public override void Work()
        {
            Console.WriteLine("Learning with my students.");
        }
    }
    public class SuperbTeacher : GoodTeacher
    {
        public override void Work()
        {
            Console.WriteLine("Preparing specialized material for students.");
            base.Work();
            Console.WriteLine("Loving my job.");
        }
    }
    public class BadTeacher : Teacher
    {
        public override void Work()
        {
            Console.WriteLine("I know more than you all. No questions!");
        }
    }


    abstract class Personality
    {
        private readonly string _name;
        public string GetName()
        {
            return _name;
        }

        //procted is used for abstract class mathods, because it will never be used pubilicly and will always only be called by the child class.
        protected Personality(string name)
        {
            Console.WriteLine("1) Personality");
            _name = name;
        }

        public abstract void PrintStatus();
    }

    class Pessimist : Personality
    {
        public Pessimist() : base("Pessimist")
        {
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Today sucks... I don't want to go to work...");
        }
    }
    class Optimist : Personality
    {
        public Optimist() : base("Optimist")
        {
            Console.WriteLine("2) Optimist");
        }

        public override void PrintStatus()
        {
            Console.WriteLine("What a beautiful day! Be my friend! :)");
        }
    }
    class SadOptimist : Optimist
    {
        public SadOptimist()
        {
            Console.WriteLine("3) SadOptimist");
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Sad");
            base.PrintStatus();
        }
    }
}
