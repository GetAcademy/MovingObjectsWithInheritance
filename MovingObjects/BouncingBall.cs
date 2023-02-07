namespace MovingObjects
{
    internal class BouncingBall : MovableAndShowableObject
    {
        public BouncingBall(int col, int row, int speedCol, int speedRow)
            : base(col, row, speedCol, speedRow, 'O')
        {
        }
        public override void Move()
        {
            base.Move();
            if (_col <= 0 || _col >= Console.WindowWidth - 1) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
        }

        //public BouncingBall( int a, int b)
        //{
        //}

        //public BouncingBall(int a)
        // : this(a, 1)
        //{
        //}

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Add(int a)
        //{
        //    return Add(a, 1);
        //}
    }
}
