using System.Data;

IComponent<string> conComp = new ConcreteComponent();

IComponent<string> plainDecorator= new PlainDecorator(conComp);
Console.WriteLine(plainDecorator.GetText());