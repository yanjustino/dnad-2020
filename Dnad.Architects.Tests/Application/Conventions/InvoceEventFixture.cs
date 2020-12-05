using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using Dnad.Architects.Adapters.SqlServer;
using Dnad.Architects.Application.Ports.Database;
using Dnad.Architects.MeetingManagement.Application.Eventos;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Dnad.Architects.Tests.Application.Conventions
{
    public partial class InvoceEventTest
    {
        private static System.Reflection.Assembly[] Assemblies => new[]
        {
            typeof(InvoiceEventExecute).Assembly,
            typeof(SqlServerHolder).Assembly,
            typeof(IDatabaseHolder).Assembly
        };
        
        private static Architecture Architecture =>
            new ArchLoader().LoadAssemblies(Assemblies).Build();

        private static IObjectProvider<IType> ApplicationEventsClasses =>
            Types()
                .That()
                .ResideInNamespace("Dnad.Architects.MeetingManagement.Application.Events")
                .As("Application Events Layer");

        private static IObjectProvider<IType> ForbiddenApplicationEventClasses =>
            Types()
                .That()
                .ResideInNamespace("Dnad.Architects.MeetingManagement.Application.Eventos", true)
                .As("Forbidden Application Layer");
    }
}
