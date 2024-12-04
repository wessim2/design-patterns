﻿using Creational.Factory.Example.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Example.Levels
{
    public class CaveLevel : Level
    {
        public override IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}