﻿using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.CommandPattern
{
    interface ICommand
    {
        void Execute(Player player);
    }
}
