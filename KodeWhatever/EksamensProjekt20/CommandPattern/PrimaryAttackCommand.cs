using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.CommandPattern
{
    class PrimaryAttackCommand : ICommand
    {
        public PrimaryAttackCommand()
        {

        }

        public void Execute(Player player)
        {
            player.Attack();
        }
    }
    

    }

