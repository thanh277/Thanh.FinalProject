using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Thanh.FinalProject
{
    [Dependency(ReplaceServices = true)]
    public class FinalProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FinalProject";
    }
}
