using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD myDVD = new DVD();
            CD myCD = new CD();

            // TODO: Call each CD and DVD method to verify that they work as expected.
            myDVD.SpinDisc();
            myCD.SpinDisc();
        }
    }
}
