using System;

namespace DatabaseCommand
{
    public class SqlConnection : DbConnection
    {
        public override void Execute()
        {
            Console.WriteLine("Opening Connection");
            Console.WriteLine(Instruction + " is now executing...");
            Console.WriteLine("Connection is now closing");
        }
    }
}