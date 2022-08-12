using System;
namespace PluginFramework
{
    public abstract class PluginComponent
    {
        public abstract string ApplyOperation();

    }

    class ConcreteComponent : PluginComponent
    {
        public override string ApplyOperation()
        {
            return "Concrete Component";
        }
    }


    class Decorator : PluginComponent
    {
        protected PluginComponent _component;

        public Decorator(PluginComponent component)
        {
            _component = component;
        }

        public void SetComponent(PluginComponent component)
        {
            _component = component;
        }

        public override string ApplyOperation()
        {
            if (_component != null)
            {
                return _component.ApplyOperation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(PluginComponent component) : base(component)
        {
        }
        public override string ApplyOperation()
        {
            return $"ConcreteDecoratorA({base.ApplyOperation()})";
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(PluginComponent component) : base(component)
        {
        }
        public override string ApplyOperation()
        {
            return $"ConcreteDecoratorB({base.ApplyOperation()})";
        }
    }

}

