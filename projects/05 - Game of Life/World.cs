using System;

namespace GameOfLife
{
    public class World
    {
        private int SIZE;
        private Cell[,] grid;

        public World(int s){
            SIZE = s;
            grid = new Cell[SIZE, SIZE];

            for(var i=0; i < SIZE; i++){
                for(var j=0; j < SIZE; j++){
                    grid[i,j] = new Cell();
                }
            }
        }

        public void Output(){
            for(var i=0; i < SIZE; i++){
                for(var j=0; j < SIZE; j++){
                    if (grid[i,j].CurrentState == 1){
                        Console.Write(" # ");
                    }
                    else{
                        Console.Write(" - ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public int NumNeighbours(Cell c){
            // Count the number of neighbours
            // surrounding a cell
            return 1;
        }

        public void Update(){
            // Implement Conway's Game of Life Rules
            // Determine future state of cells

            // Copy future state to current state
            return;
        }
    }
}