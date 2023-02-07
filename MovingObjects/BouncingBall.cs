namespace MovingObjects
{
    internal class BouncingBall : MovingObject
    {
        public BouncingBall(int col, int row, int speedCol, int speedRow)
            : base(col, row, speedCol, speedRow, 'O')
        {
        }

        //public BouncingBall( int a, int b)
        //{
        //}

        //public BouncingBall(int a)
        // : this(a, 1)
        //{
        //}

        //public void Move()
        //{
        //    _col += _speedCol;
        //    _row += _speedRow;
        //    if (_col <= 0 || _col >= Console.WindowWidth - 1) _speedCol = -_speedCol;
        //    if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
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
