using System.Collections.Generic;
using System.Threading.Tasks;
using NuKeeper.Configuration;
using NuKeeper.Inspection.Files;
using NuKeeper.Inspection.RepositoryInspection;
using NuKeeper.Inspection.Sources;

namespace NuKeeper.Local
{
    public interface ILocalUpdater
    {
        Task ApplyUpdates(
            IReadOnlyCollection<PackageUpdateSet> updates,
            IFolder workingFolder,
            NuGetSources sources,
            SettingsContainer settings);
    }
}
