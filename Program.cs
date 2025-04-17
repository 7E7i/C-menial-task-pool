using System.Runtime.CompilerServices;
using Game.Character;

namespace UnitMoving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterMoving character = new CharacterMoving();
            character.CharacterMove();
        }
    }
}
