﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolkitCore.Interfaces;
using Verse;

namespace ToolkitCore
{
    public abstract class CommandInterfaceBase : GameComponent
    {
        public abstract void ParseCommand(ICommand command);
    }
}