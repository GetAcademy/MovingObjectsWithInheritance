namespace MovingObjects
{
    internal class MovableAndShowableObject : ShowableObject
    {
        protected int _speedCol;
        protected int _speedRow;


        public MovableAndShowableObject(int col, int row, int speedCol, int speedRow, char symbol)
        : base(col, row, symbol)
        {
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public virtual void Move()
        {
            _col += _speedCol;
            _row += _speedRow;
        }
    }
}
