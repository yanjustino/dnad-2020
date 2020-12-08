using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Dnad.Architects.CertificateManagement.Domain.Models.ValueObjects;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;


namespace Dnad.Architects.Tests.Application.Conventions
{
    public class CertificateUriDownloadTests
    {
        private System.Reflection.Assembly[] Assemblies => new[]
        {
            typeof(CertificateUriDownload).Assembly,
        };
        
        private Architecture Architecture =>
            new ArchLoader().LoadAssemblies(Assemblies).Build();         
        
        [Fact]
        public void ClassesShouldHaveCorrectName()
        {
            var c = Types()
                .That()
                .ResideInNamespace("Dnad.Architects.CertificateManagement.Domain.Models.ValueObjects")
                .As("Application Events Layer");

            PropertyMembers()
                .That()
                .AreDeclaredIn(c)
                .Should()
                .NotHavePublicSetter()
                .Check(Architecture);
        }        
    }
}