using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFollowAlong.Commands
{
    public interface ICommand
    {
        void Execute(GameComponent go);
    }
}
