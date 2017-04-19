using System;

namespace DatabaseCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chose the database you want to connect: ");
            Console.WriteLine("0 for SQL Connection\n1 for ORACLE Connection");
            
            var input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    new DbCommand(new SqlConnection(), "SQL COMMAND");
                    break;
                case "1":
                    new DbCommand(new OracleConnection(), "ORACLE COMMAND");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}