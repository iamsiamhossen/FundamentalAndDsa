// using System;

// abstract class Controller
// {
//     public abstract void Action();
// }

// class Attack : Controller
// {
//     public override void Action()
//     {
//         Console.WriteLine("attack");
//     }
// }

// class Defend : Controller
// {
//     public override void Action()
//     {
//         Console.WriteLine("defend");
//     }
// }

// class Jump : Controller
// {
//     public override void Action()
//     {
//         Console.WriteLine("jump");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Controller c1 = new Attack();
//         Controller c2 = new Defend();
//         Controller c3 = new Jump();

//         c1.Action();
//         c2.Action();
//         c3.Action();
//     }
// }