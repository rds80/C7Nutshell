using static System.Console;

namespace C7Nutshell
{
    public interface IUndoable { void Undo(); }

    public class TextBox : IUndoable
    {
        public void Undo() => WriteLine("TextBox.Undo");
    }

    public class RichTextBox : TextBox, IUndoable
    {
        public void Undo() => WriteLine("RichTextBox.Undo");
    }
}