namespace MovingObjects
{
    internal class TeleportingPlus : MovingObject
    {
        public TeleportingPlus(int col, int row, int speedCol, int speedRow)
        :base(col, row, speedCol, speedRow, '+')
        {
        }

        //public void Move()
        //{
        //    var w= Console.WindowWidth;
        //    var h = Console.WindowHeight;
        //    _col = (_col + _speedCol + w) % w;
        //    _row = (_row + _speedRow + h) % h;
        //}
    }
}
