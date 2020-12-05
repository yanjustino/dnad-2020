using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Dnad.Architects.Tests.Application.Conventions
{
    public partial class InvoceEventTest
    {
        [Fact]
        public void ClassesShouldHaveCorrectName()
        {
            Classes()
                .That().AreAssignableTo(ApplicationEventsClasses)
                .Should()
                .HaveNameEndingWith("EventHandler")
                .Check(Architecture);
        }

        [Fact]
        public void ClassesShouldNotExistsInEventoFolder()
        {
            Classes()
                .That()
                .AreAssignableTo(ForbiddenApplicationEventClasses)
                .Should()
                .NotExist().Because("it's forbidden")
                .Check(Architecture);
        }
    }
}
