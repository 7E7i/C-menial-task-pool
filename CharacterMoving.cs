using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Character;

namespace Game.Character
{
    class CharacterMoving
    {
        private int redo = 0;
        private int sides = 0;
        private int ups = 0;

        public void CharacterMove()
        {
            ConsoleKeyInfo Keyinfo;

            do
            {
                Keyinfo = Console.ReadKey(true);
                Console.Clear();

                switch (Keyinfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        sides++;
                        Console.SetCursorPosition(sides, ups);
                        Console.Write("□");
                        break;
                    case ConsoleKey.LeftArrow:
                        sides--;
                        Console.SetCursorPosition(sides, ups);
                        Console.Write("□");
                        break;
                    case ConsoleKey.UpArrow:
                        ups--;
                        Console.SetCursorPosition(sides, ups);
                        Console.Write("□");
                        break;
                    case ConsoleKey.DownArrow:
                        ups++;
                        Console.SetCursorPosition(sides, ups);
                        Console.Write("□");
                        break;
                }
            } while (redo == 0);

            Console.ReadLine();
        }
    }
}
