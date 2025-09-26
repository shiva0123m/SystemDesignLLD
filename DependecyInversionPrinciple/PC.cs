using System;

    public class PC
    {
        private readonly IMouse _mouse;
        private readonly IKeyboard _keyboard;

        public PC(IMouse mouse, IKeyboard keyboard)
        {
            _mouse = mouse;
            _keyboard = keyboard;
        }

        public void work()
        {
            _mouse.work();
            _keyboard.work();
        }
    }
