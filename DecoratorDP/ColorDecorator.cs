public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> comp) : base(comp)
    {

    }

    public override string GetText()
    {
        return $"\u001b[31m{base.GetText()}\u001b[0m";
    }
}