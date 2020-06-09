using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.CommandPattern
{
    class JumpCommand : ICommand
    {
        private Vector2 velocity;
        public JumpCommand(Vector2 velocity)
        {
            this.velocity = velocity;
        }
        public void Execute(Player player)
        {
            player.Jump(velocity);
        }
    }
}
