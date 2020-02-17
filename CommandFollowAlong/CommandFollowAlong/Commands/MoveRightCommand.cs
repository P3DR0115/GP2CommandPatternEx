﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFollowAlong.Commands
{
    public class MoveRightCommand : Command
    {
        public MoveRightCommand()
        {
            this.CommandName = "Move Right";
        }

        public override void Execute(GameComponent go)
        {
            go.MoveRight();
            base.Execute(go);
        }
    }
}
