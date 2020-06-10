﻿using EksamensProjekt20.Characters;
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
        private Dictionary<MouseState, ICommand> mousebinds = new Dictionary<MouseState, ICommand>();

        public InputHandler()
        {
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(1, 0)));
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(-1, 0)));
            keybinds.Add(Keys.W, new JumpCommand(new Vector2(0, -80)));
            //keybinds.Add(Keys.J, new PrimaryAttackCommand);
            //keybinds.Add(Keys.K, new SecondaryAttackCommand);

        }

        public void Execute(Player player)
        {
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
            if (!pressing)
            {
                player.moveVector = new Vector2(0, 0);
            }

        }
    }
}
