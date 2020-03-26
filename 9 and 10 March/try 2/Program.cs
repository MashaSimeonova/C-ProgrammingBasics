using System;

namespace try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int wontedJump = int.Parse(Console.ReadLine());
            int nextJump = wontedJump - 30;
            int jumpCounter = 0;
            int jump = 0;

            for (nextJump = wontedJump - 30; nextJump <= wontedJump; nextJump += 5)
            {
                jump = int.Parse(Console.ReadLine());
                jumpCounter += 1;

                if (jump > wontedJump)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {wontedJump}cm after {jumpCounter} jumps."); break;
                }

                if (jump <= nextJump)
                {

                    jump = int.Parse(Console.ReadLine());
                    jumpCounter += 1;

                    if (jump <= nextJump)
                    {

                        jump = int.Parse(Console.ReadLine());
                        jumpCounter += 1;

                        if (jump <= nextJump)
                        {
                            Console.WriteLine($"Tihomir failed at {nextJump}cm after {jumpCounter} jumps."); break;
                        }

                    }

                }

                if (jump > wontedJump)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {wontedJump}cm after {jumpCounter} jumps."); break;
                }

            }

        }
    }
}
