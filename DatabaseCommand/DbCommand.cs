using System;

namespace DatabaseCommand
{
    public class DbCommand
    {
        public DbCommand(DbConnection connectionType, string instruction)
        {
            if (connectionType == null || string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Null Reference or Instruction passed is not valid");
            connectionType.Instruction = instruction;
            connectionType.Execute();
        }
    }
}