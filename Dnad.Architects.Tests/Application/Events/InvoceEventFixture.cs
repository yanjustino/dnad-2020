using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using Dnad.Architects.Adapters.SqlServer;
using Dnad.Architects.Application.Ports.Database;
using Dnad.Architects.MeetingManagement.Application.Events;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Dnad.Architects.Tests.Application.Events
{
    public partial class InvoceEventTest
    {
        private static System.Reflection.Assembly[] Assemblies => new[]
        {
            typeof(InvoiceEventHandler).Assembly,
            typeof(SqlServerHolder).Assembly,
            typeof(IDatabaseHolder).Assembly
        };
        
        private static Architecture Architecture =>
            new ArchLoader().LoadAssemblies(Assemblies).Build();

        private static IObjectProvider<IType> ApplicationEventsClasses =>
            Types()
                .That()
                .ResideInNamespace("Dnad.Architects.MeetingManagement.Events")
                .As("Application Events Layer");

        private static IObjectProvider<IType> ForbiddenApplicationEventClasses =>
            Types()
                .That()
                .ResideInNamespace("Dnad.Architects.MeetingManagement.Evento", true)
                .As("Forbidden Application Layer");
    }
}
