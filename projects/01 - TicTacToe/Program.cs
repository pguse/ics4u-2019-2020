using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] pos = {'-','-','-','-','-','-','-','-','-'};
            char player = 'X';
            bool over = false;
            while (!over){
                Console.Clear();
                Draw(pos);
                player = Update(player,pos);
                over = GameOver(pos);
            }
        }
        
        static char Update(char piece, char[] p){
            Console.Write("Where do you want to play? ");
            int loc = int.Parse(Console.ReadLine());
            p[loc-1] = piece;
            if (piece == 'X'){
                return 'O';
            }
            else{
                return 'X';
            }
        }
        
        static bool GameOver(char[] p){
            // Modify this function so that a win or tie is detected and then
            // the approprate message is written to the console.  e.g. X wins! or Tie!
            
            // This loop checks for a win in only the top row
            if (p[0] != '-' && p[0]==p[1] && p[1]==p[2]){
                Console.Clear();
                Draw(p);
                Console.WriteLine("{0} Wins! Game Over.",p[0]);
                return true;
            }
            return false;
        }
        static void Draw(char[] p){
            string row0 = "  {0}  |  {1}  |  {2}  \n";
            string row1 = "  {3}  |  {4}  |  {5}  \n";
            string row2 = "  {6}  |  {7}  |  {8}  \n";
            string line = "-----|-----|-----\n";
            string board = row0 + line + row1 + line + row2;
            Console.WriteLine(board,p[0],p[1],p[2],p[3],p[4],p[5],p[6],p[7],p[8]);
        }
    }
}
