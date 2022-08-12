using System;
namespace PluginFramework.Services.PluginService
{
    public abstract class PluginComponent
    {
        public abstract string AddEffect(double sliderValue);
        public abstract string AddEffect(int textValue);
        public abstract string AddEffect();
    }
}

