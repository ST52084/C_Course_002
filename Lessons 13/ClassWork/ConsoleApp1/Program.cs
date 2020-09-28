using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IFlyingObject
    {
        int MaxHeight { get; set; }
        int CurrentHeight { get; set; }
        void TakeUpper(int delta);
        void TakeLower(int delta);
    }

    interface IHelicopter : IFlyingObject
    {
        byte BladesCount { get; set; }
    }

    interface IPlane : IFlyingObject
    {
        byte EnginesCount { get; set; }
    }

    interface IPropertiesWriter
    {
        void WriteAllProperlines();
    }

    abstract class flyMashin: IFlyingObject
    {
        int maxHeight;
        public int MaxHeight
        {
            get; set;
        }
        int currentHeight;
        public int CurrentHeight
        {
            get; set;
        }
        public void TakeUpper(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (CurrentHeight + delta > MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
            {
                CurrentHeight = CurrentHeight + delta;
            }
        }
        public void TakeLower(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (CurrentHeight - delta > 0)
            {
                CurrentHeight = CurrentHeight - delta;
            }
            if (CurrentHeight - delta == 0)
            {
                CurrentHeight = 0;
            }
            if (CurrentHeight < 0)
            {
                throw new InvalidOperationException();
            }
        }
        public abstract void WriteAllProperlines();

    }
    class Helicopter : flyMashin, IHelicopter
    {
        public byte BladesCount { get; set; }
        public Helicopter(int maxHeight, byte bladesCount)
        {
            MaxHeight = maxHeight;
            BladesCount = bladesCount;
            CurrentHeight = 0;
            Console.WriteLine("It's a helicopter, welcon abord");
        }
        public override void WriteAllProperlines()
        {
            Console.WriteLine("BladesCount: /t" + BladesCount +
                "/n CurrentHeight: /t" + CurrentHeight +
                "/n MaxHeight: /t" + MaxHeight);
        }

    }
    class Planet : flyMashin, IPlane
    {
        public byte EnginesCount { get; set; }
        public Planet(int maxHeight, byte enginesCount)
        {
            MaxHeight = maxHeight;
            EnginesCount = enginesCount;
            CurrentHeight = 0;
            Console.WriteLine("It's a Plan, welcon abord");
        }
        public override void WriteAllProperlines()
        {
            Console.WriteLine("EnginesCount: /t" + EnginesCount +
                                "/n CurrentHeight: /t" + CurrentHeight +
                                "/n MaxHeight: /t" + MaxHeight);

        }
    }
}
