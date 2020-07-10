using copilot.Impl;

namespace copilot.Impl
{
    public class Copilot : ICopilot
    {
        private IFor _preflightChecklistChain;

        public Copilot()
        {
            _preflightChecklist = null;
        }

        // Maybe use a ForBuilder here
        public ICopilot Check(IFor nextChainLink)
        {
            var chainLink = _preflightChecklistChain;
            while(chainLink != null)
            {
                // check inner
            }
            chainLink = nextChainLink;
            return this;
        }

        public Report Run()
        {
            return new Report();
        }
    }
}
