namespace Decorator
{
    public abstract class BaseDecorator : IComponent
    {
        private IComponent component;

        protected BaseDecorator(IComponent component)
        {
            this.component = component;
        }
        public virtual  void Execute()
        {
            component.Execute();
        }
    }
}