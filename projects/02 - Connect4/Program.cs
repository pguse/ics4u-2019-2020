using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pos = { {'-','-','-','-','-','-','-'},
                            {'-','-','-','-','-','-','-'},
                            {'-','-','-','-','-','-','-'},
                            {'-','-','-','-','-','-','-'},
                            {'-','-','-','-','-','-','-'},
                            {'-','-','-','-','-','-','-'}};

            char player = 'X';
            bool over = false;
            while (!over){
                Console.Clear();
                Draw(pos);
                player = Update(player,pos);
                over = GameOver(pos);
            }
        }
        
        static char Update(char piece, char[,] p){
            Console.Write("Where do you want to play (1-7)? ");
            int loc = int.Parse(Console.ReadLine());
            // Checks column specified by loc for the first open
            // space closest the bottom
            for(var i=5; i >= 0; i--){
                if (p[i, loc-1] == '-'){
                    p[i, loc-1] = piece;
                    break;
                }
            }
            if (piece == 'X'){
                return 'O';
            }
            else{
                return 'X';
            }
        }
        
        static bool GameOver(char[,] p){
            // Modify this function so that a win or tie is detected and then
            // the approprate message is written to the console.  e.g. X wins! or Tie!
            
            // This loop checks for a win in only the bottom row
            for(var i =0; i < 4; i++){
                if (p[5,i] != '-' && p[5,i]==p[5,i+1] && p[5,i+1]==p[5,i+2] && p[5,i+2]==p[5,i+3]){
                    Console.Clear();
                    Draw(p);
                    Console.WriteLine("{0} Wins! Game Over.",p[5,i]);
                    return true;
                }
            }
            return false;
        }
        
        static void Draw(char[,] p){
            string row = "| {0} | {1} | {2} | {3} | {4} | {5} | {6} |";
            string bottom = "|---|---|---|---|---|---|---|\n";
            for(var i=0; i < 6; i++){
                Console.WriteLine(row,p[i,0],p[i,1],p[i,2],p[i,3],p[i,4],p[i,5],p[i,6]);
            }
            Console.WriteLine(bottom);
        }
    }
}
