using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD()
        {
        }

        public CD(string name, double writespeed) : base(name, writespeed)
        {
        }

        public override void SpinDisc()
        {
            Console.WriteLine("Spinning CD");
        }
    }
}
