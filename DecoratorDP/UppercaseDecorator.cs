public class UppercaseDecorator : Decorator<string>
{
    public UppercaseDecorator(IComponent<string> comp) : base(comp)
    {

    }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}