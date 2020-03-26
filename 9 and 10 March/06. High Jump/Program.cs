using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int wontedJump = int.Parse(Console.ReadLine());
            int nextJump = wontedJump - 30;
            int jumpCounter = 0;
            

            for (int i = 0; i < 100000; i++)
            {
                int jump = int.Parse(Console.ReadLine());
                jumpCounter += 1;

                if (jump>wontedJump)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {wontedJump}cm after {jumpCounter} jumps.");break;
                }

                if (jump<=nextJump)
                {
                    
                    jump = int.Parse(Console.ReadLine());
                    jumpCounter += 1;

                    if (jump <= nextJump)
                    {
                        
                        jump = int.Parse(Console.ReadLine());
                        jumpCounter += 1;
                        if (jump <= nextJump)
                        {
                            Console.WriteLine($"Tihomir failed at {nextJump}cm after {jumpCounter} jumps.");break;
                        }
                        else
                        {
                            nextJump += 5;
                        }

                    }
                    else
                    {
                        nextJump += 5;
                    }
                    
                }
                else
                {
                    nextJump += 5;
                }

            }

        }
    }
}
