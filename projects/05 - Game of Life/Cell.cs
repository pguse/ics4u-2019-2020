using System;

namespace GameOfLife
{
    public class Cell
    {
        public int CurrentState {get; set;}
        public int FutureState {get; set;}

        public Cell()
        {
            Random rnd = new Random();
            CurrentState = rnd.Next(0,2);
        }
    }
}