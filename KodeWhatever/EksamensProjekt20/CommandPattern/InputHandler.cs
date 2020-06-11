using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.CommandPattern
{
    class InputHandler
    {
        private Dictionary<Keys, ICommand> keybinds = new Dictionary<Keys, ICommand>();
        private List<ICommand> mousebinds = new List<ICommand>();
        private MouseState mouseState;
        private MouseState preMouseState;
        public InputHandler()
        {
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(1, 0)));
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(-1, 0)));
            keybinds.Add(Keys.W, new JumpCommand(new Vector2(0, -100)));
            mousebinds.Add(new PrimaryAttackCommand());
            mousebinds.Add(new SecondaryAttackCommand());
        }

        public void Execute(Player player)
        {
            mouseState = Mouse.GetState();
            KeyboardState keyState = Keyboard.GetState();
            bool pressing = false ;
            foreach (Keys key in keybinds.Keys)
            {
                
                if (keyState.IsKeyDown(key))
                {
                    keybinds[key].Execute(player);
                    pressing = true;
                }
                
                
            }
            if(mouseState.LeftButton == ButtonState.Pressed && preMouseState.LeftButton != ButtonState.Pressed)
            {
                mousebinds[0].Execute(player);
            }
            if(mouseState.RightButton == ButtonState.Pressed && preMouseState.RightButton != ButtonState.Pressed)
            {
                mousebinds[1].Execute(player);
            }

            if (!pressing)
            {
                player.moveVector = new Vector2(0, 0);
            }
            preMouseState = mouseState;
        }
    }
}
