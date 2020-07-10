using copilot.Impl;

namespace copilot
{
    public interface ICopilot
    {
        Report Run();
        ICopilot Check();
    }
}
