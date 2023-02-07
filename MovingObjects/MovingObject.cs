namespace MovingObjects
{
    internal class MovingObject
    {
        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;
        private char _symbol;

        public MovingObject(int col, int row, int speedCol, int speedRow, char symbol)
        {
            _symbol = symbol;
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write(_symbol);
        }

        public void Move()
        {
        }
    }
}
