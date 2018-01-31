using ContentIncludeRepro.Interfaces;

namespace ContentIncludeRepro.ProjectA
{
    public class StringReturner : IStringReturner
    {
        public string GetString()
        {
            return "Project A";
        }
    }
}