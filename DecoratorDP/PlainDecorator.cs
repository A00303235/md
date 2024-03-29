public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> comp) : base(comp)
    {

    }

    public override string GetText()
    {
        return "Hello it's Pratham!" +base.GetText();
    }
}