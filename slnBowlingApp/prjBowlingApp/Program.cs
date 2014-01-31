using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBowlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lScores = new List<int>();
            int total = 0;
            
            while (true)
            {
                //reset the variables
                lScores.Clear();
                total = 0;

                while (lScores.Count < 20 || lScores.Count > 21)//run until you get the right number of inputs
                {
                    //get the score from the user
                    Console.WriteLine("Please enter the game score, all values seperated by a comma (,)");
                    string sScores = Console.ReadLine();

                    //convert the input into an array of ints
                    foreach (var s in sScores.Split(','))
                    {
                        int score;
                        //int.TryParse(s, out score);

                        if (int.TryParse(s, out score) == false)//check that input is an int
                        {
                            Console.WriteLine("Please use only whole numbers");
                            break;
                        }
                        else if (score < 0 || score > 10)//check that the score is between 0-10
                        {
                            Console.WriteLine("Values must be between 0 an 10");
                            break;
                        }
                        else
                        {
                            lScores.Add(score); 
                        }
                        
                    }

                    if (lScores.Count < 20 || lScores.Count > 21)//give feedback for poor input and reset the list
                    {
                        lScores.Clear();
                        Console.WriteLine("You must enter 20 or 21 values");
                    }

                }

                //add the scores together
                foreach (int score in lScores)
                {
                    total += score;
                }

                //output the result
                Console.WriteLine("Your score is:" + total);
                Console.ReadLine();
            }          
        }
    }
}
