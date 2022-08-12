using System;
namespace PluginFramework.Services.PluginService
{
    class BlurEffect : PluginDecorator
    {
        public BlurEffect(PluginComponent component) : base(component)
        {
        }

        public override string AddEffect(double sliderValue)
        {
            Console.WriteLine("Blur Effect || AddEffect || Double : {0} || ", sliderValue);
            return "Blurring the image, AddEffect(double)";
        }

        public override string AddEffect(int textValue)
        {
            Console.WriteLine("Blur Effect || AddEffect || Int : {0} || ", textValue);
            return "Blurring the image, AddEffect(double)";
        }

        public override string AddEffect()
        {
            Console.WriteLine("Blur Effect || AddEffect");
            return "Blurring the image, AddEffect(double)";
        }
    }
}

