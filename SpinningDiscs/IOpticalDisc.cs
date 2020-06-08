using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        string Name { get; set; }
        double StorageCapacity { get; }
        double WriteSpeed { get; }
        string Contents { get; set; }
        void SpinDisc();

    }
}
