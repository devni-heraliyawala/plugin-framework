using System;
namespace PluginFramework.Services.PluginService
{
    public interface IPluginService
    {
        Task<ServiceResponse<List<string>>> ImageManipulation(List<ImageFeatureSet>features);
    }
}

