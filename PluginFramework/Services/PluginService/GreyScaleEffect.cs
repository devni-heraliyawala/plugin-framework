using System;
namespace PluginFramework.Services.PluginService
{
    class GreyScaleEffect : PluginDecorator
    {
        public GreyScaleEffect(PluginComponent component) : base(component)
        {
        }

        public override string AddEffect(double sliderValue)
        {
            Console.WriteLine("GreyScale Effect || AddEffect || Double : {0} || ", sliderValue);
            return "Grey scaling the image, AddEffect(double)";
        }

        public override string AddEffect(int textValue)
        {
            Console.WriteLine("GreyScale Effect || AddEffect || Int : {0} || ", textValue);
            return "Grey scaling the image, AddEffect(double)";
        }

        public override string AddEffect()
        {
            Console.WriteLine("GreyScale Effect || AddEffect");
            return "Grey scaling the image, AddEffect(double)";
        }
    }
}

