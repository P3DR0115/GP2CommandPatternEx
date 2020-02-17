using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFollowAlong.Commands
{
    public interface ICommandWUndo : ICommand
    {
        UndoCommand UndoCommand { get; set; }
    }
}
