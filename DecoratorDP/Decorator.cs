public abstract class Decorator<T> : IComponent<T>
{

    protected IComponent<T> component;
    public Decorator (IComponent<T> comp){

        component=comp;
        
    }
    public virtual T GetText()
    {
        throw new NotImplementedException();
    }
}