using ContentIncludeRepo.Interfaces;

namespace ContentIncludeRepro.ProjectB
{
    public class StringReturner : IStringReturner
    {
        public string GetString()
        {
            return "Project B";
        }
    }
}