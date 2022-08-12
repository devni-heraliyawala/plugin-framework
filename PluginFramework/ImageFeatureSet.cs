using System;
namespace PluginFramework
{
    public class ImageFeatureSet
    {
        public string ImageName { get; set; }
        public byte[] Image { get; set; }
        public List<EffectsWithConfiguration> EffectsWithConfiguration { get; set; }

    }
}

