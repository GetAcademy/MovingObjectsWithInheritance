using MovingObjects;

/*
 * interface - teknisk sett
 * "is a" vs "has a" - arv vs compositions
 * arv
 * dependency inversion
 *
 *
 * - arvehierarki => en ny mellomklasse
 * - base i metoder
 * - abstract metoder - abstract klasse
 */

var obj1 = new BouncingBall(15, 3, 1, 1);
var obj2 = new TeleportingPlus(15, 3, 1, -1);
var obj3 = new StandingT(10, 10);
//var obj3 = new MovingObject(10, 10, 0, 0, 'T');
var objects = new MovableAndShowableObject[] { obj1, obj2};//, obj3 };

Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    foreach (var obj in objects)
    {
        obj.Show();
        obj.Move();
    }
    Thread.Sleep(50);
}

/*
        if (obj is TeleportingPlus)
        {
            var teleportingPlus = (TeleportingPlus)obj;
            teleportingPlus.Show();
            teleportingPlus.Move();
        }
        else if (obj is BouncingBall)
        {
            var bouncingBall = (BouncingBall)obj;
            bouncingBall.Show();
            bouncingBall.Move();
        } 
 */