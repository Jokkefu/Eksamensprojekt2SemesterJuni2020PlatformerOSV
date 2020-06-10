using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Characters;

namespace EksamensProjekt20.StatePattern
{
    interface IEnemyState
    {
        void Enter(Enemy enemy);
        void Exit();
        void Execute(double deltatime);


    }
}
