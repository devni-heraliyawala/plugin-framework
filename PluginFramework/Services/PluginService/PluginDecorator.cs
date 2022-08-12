using System;
namespace PluginFramework.Services.PluginService
{
    public class PluginDecorator : PluginComponent
    {
        protected PluginComponent _component;

        public PluginDecorator(PluginComponent component)
        {
            _component = component;
        }

        public void SetComponent(PluginComponent component)
        {
            _component = component;
        }

        public override string AddEffect(double sliderValue)
        {
            if (_component != null)
            {
                return _component.AddEffect(sliderValue);
            }
            else
            {
                return string.Empty;
            }
        }

        public override string AddEffect(int textValue)
        {
            if (_component != null)
            {
                return _component.AddEffect(textValue);
            }
            else
            {
                return string.Empty;
            }
        }

        public override string AddEffect()
        {
            if (_component != null)
            {
                return _component.AddEffect();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

