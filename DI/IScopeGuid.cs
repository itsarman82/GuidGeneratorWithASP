namespace GuidGeneratorWithASP.DI
{
    public interface IScopeGuid
    {
        string GetGuid();
    }
    public class ScopeGuid : IScopeGuid
    {
        private readonly Guid _guid;

        public ScopeGuid()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
