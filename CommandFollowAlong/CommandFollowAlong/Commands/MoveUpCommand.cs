﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFollowAlong.Commands
{
    public class MoveUpCommand : Command, ICommandWUndo
    {
        public MoveUpCommand()
        {
            this.CommandName = "Move Up";
        }

        public UndoCommand UndoCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Execute(GameComponent go)
        {
            go.MoveUp();
            base.Execute(go);
        }
    }
}
