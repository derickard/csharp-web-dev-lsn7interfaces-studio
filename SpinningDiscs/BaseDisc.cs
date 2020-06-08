using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc : IOpticalDisc
    {
        public string Name { get; set; }

        public double StorageCapacity { get; private set; }

        public double WriteSpeed { get; private set; }

        public string Contents { get; set; }

        protected BaseDisc()
        {
        }

        public BaseDisc(string name, double writespeed)
        {
            Name = name;
            WriteSpeed = writespeed;
        }

        
        public virtual void SpinDisc()
        {
            Console.WriteLine("Spinning Disk");
        }

        public string Read()
        {
            return Contents;
        }

        public int Write(string contents)
        {
            try
            {
                Contents = contents;
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is BaseDisc disc &&
                   Contents == disc.Contents;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Contents);
        } 
    }
}
