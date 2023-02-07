namespace MovingObjects
{
    internal class TeleportingPlus : MovableAndShowableObject
    {
        public TeleportingPlus(int col, int row, int speedCol, int speedRow)
        : base(col, row, speedCol, speedRow, '+')
        {
        }

        public override void Move()
        {
            base.Move();
            if (_col < 0) _col = Console.WindowWidth;
            if (_col > Console.WindowWidth) _col = 0;
            if (_row < 0) _row = Console.WindowHeight;
            if (_row > Console.WindowHeight) _col = 0;

        }
    }

    //class A : B
    //{
    //}

    //class B : C
    //{
    //}

    //class C
    //{
    //}
}
