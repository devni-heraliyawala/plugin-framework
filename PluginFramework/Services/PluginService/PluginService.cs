using System;
namespace PluginFramework.Services.PluginService
{
    public class PluginService : IPluginService
    {
        public PluginService()
        {
        }

        public async Task<ServiceResponse<List<string>>> ImageManipulation(List<ImageFeatureSet> features)
        {
            List<string> result = new List<string>();

            foreach (var item in features)
            {
                PluginComponent component = new ConcreteComponent();

                foreach (var effect in item.EffectsWithConfiguration)
                {
                    switch (effect.Effect)
                    {
                        case Effect.Resize:
                            component = new ResizeEffect(component);
                            break;
                        case Effect.Blur:
                            component = new BlurEffect(component);
                            break;
                        case Effect.GrayScale:
                            component = new GreyScaleEffect(component);
                            break;
                        default:
                            break;
                    }

                    switch (effect.EffectKind)
                    {
                        case EffectKind.None:
                            result.Add(component.AddEffect());
                            break;
                        case EffectKind.Slider:
                            result.Add(component.AddEffect(Convert.ToDouble(effect.EffectValue)));
                            break;
                        case EffectKind.InputBox:
                            result.Add(component.AddEffect(Convert.ToInt32(effect.EffectValue)));
                            break;
                        default: component.AddEffect(); break;
                    }

                }
            }

            return new ServiceResponse<List<string>> { Data = result }; ;
        }
    }
}

