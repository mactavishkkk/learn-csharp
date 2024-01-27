namespace PrimeiroProjeto.Classes
{
    internal class LogRegister
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRegister))
            {
                return false;
            }

            LogRegister other = obj as LogRegister;
            return UserName.Equals(other.UserName);
        }
    }
}
