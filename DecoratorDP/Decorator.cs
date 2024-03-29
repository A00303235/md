public abstract class Decarator<T> : IComponent<T>
{

    protected IComponent<T> component;
    public Decarator (IComponent<T> comp){

        component=comp;
        
    }
    public virtual T GetText()
    {
        throw new NotImplementedException();
    }
}