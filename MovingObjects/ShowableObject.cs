namespace MovingObjects
{
    internal class ShowableObject
    {
        protected int _col;
        protected int _row;
        private char _symbol;

        public ShowableObject(int col, int row, char symbol)
        {
            _col = col;
            _row = row;
            _symbol = symbol;
        }

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write(_symbol);
        }
    }
}
