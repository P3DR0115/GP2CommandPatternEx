namespace CommandFollowAlong.Commands
{
    public abstract class UndoCommand : Command
    {
        public UndoCommand(CommandWUndo command)
        {
            this.CommandName = "Undo " + command.CommandName;
        }
    }
}