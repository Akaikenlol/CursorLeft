using System;

namespace CursorLeft
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;
        protected static void WriteAt(string s ,int x ,int y)
        {
        try
        {
            Console.SetCursorPosition(origCol+x,origRow+y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
        }
        public static void Main (string[] args )
        {
            Console.Clear();
            origRow=Console.CursorTop;
            origCol=Console.CursorLeft;

            WriteAt("+",0,0);
            WriteAt("|",0,1);
            WriteAt("|",0,2);
            WriteAt("|",0,3);
            WriteAt("+",0,4);

            WriteAt("-",1,4);
            WriteAt("-",2,4);
            WriteAt("-",3,4);
            WriteAt("+",4,4);

            WriteAt("|",4,3);
            WriteAt("|",4,2);
            WriteAt("|",4,1);
            WriteAt("+",4,0);

            WriteAt("-",3,0);
            WriteAt("-",2,0);
            WriteAt("-",1,0);

            WriteAt("All done!",0,6);
            Console.WriteLine();
        }
    }
}
