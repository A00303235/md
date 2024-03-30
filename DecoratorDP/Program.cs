using System.Data;

IComponent<string> conComp = new ConcreteComponent();
Console.WriteLine(conComp.GetText());

IComponent<string> plainDecorator= new PlainDecorator(conComp);
Console.WriteLine(plainDecorator.GetText());

IComponent<string> uppercaseDecorator= new UppercaseDecorator(conComp);
Console.WriteLine(uppercaseDecorator.GetText());

IComponent<string> colorDecorator= new ColorDecorator(conComp);
Console.WriteLine(colorDecorator.GetText());