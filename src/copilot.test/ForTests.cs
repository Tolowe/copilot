using FluentAssertions;
using NUnit.Framework;

namespace copilot.test
{
    [TestFixture]
    public class ForTests
    {

    }
}


// TODO:
//   Maybe copilot is the builder. He builds PreflightChecklists. PreflightChecklists has the chain of Fors. When you call Check on PreflightChecklist, it returns a ConditionBuilder for For.

// new Copilot()
//   Check().For(func returning bool).Fix(action).ReportPass(Pass).ReportFail(Fail)