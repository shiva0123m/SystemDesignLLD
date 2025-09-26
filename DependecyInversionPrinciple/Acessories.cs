using System;

    class Acessories
    {
        static void Main(string[] args)
        {
            IMouse mouse = new WiredMouse();
            IKeyboard keyboard = new WirelessKeyboard();

            PC pc = new PC(mouse, keyboard);
            pc.work();
            Console.WriteLine("Dependency Injection Principle Implementation");
        }
    }

