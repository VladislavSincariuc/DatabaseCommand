namespace DatabaseCommand
{
    public abstract class DbConnection
    {
        public string Instruction { get; set; }
        public abstract void Execute();
    }
}