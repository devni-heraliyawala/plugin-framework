using System;
namespace PluginFramework.Services.PluginService
{

    class ResizeEffect : PluginDecorator
    {
        public ResizeEffect(PluginComponent component) : base(component)
        {
        }

        // No need to mention all the methods, Can use specific method only according to the plugin configruation
        // I have implemented like this to emphasize the extensablility.
        public override string AddEffect(double sliderValue)
        {
            Console.WriteLine("Resize Effect || AddEffect || Double : {0} || ", sliderValue);
            //return $"Resizing the image, {base.AddEffect(sliderValue)}";
            return "Resizing the image, AddEffect(double)";
        }

        public override string AddEffect(int textValue)
        {
            Console.WriteLine("Resize Effect || AddEffect || Int : {0} || ", textValue);
            return "Resizing the image, AddEffect(int)";
        }

        public override string AddEffect()
        {
            Console.WriteLine("Resize Effect || AddEffect");
            return "Resizing the image, AddEffect()";
        }
    }
}

