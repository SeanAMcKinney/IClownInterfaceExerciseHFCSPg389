using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClownInterfaceExerciseHFCSPg389
{
    //interfaces
    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }//end IClown

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }//end IScaryClown

    //classes

    class FunnyFunny : IClown
    {
        private readonly string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}.");
        }
    }//end class

    class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;
        public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }

        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }

    }//end class

    class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if (fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            }
        }//end main
    }//end class
}//end namespace
