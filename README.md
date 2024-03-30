Created a new Github account
made a new repo. named md
installed plugins and setup a code space
Made a solution file
created a console application: DecoratorDP
added the csproj file to solution file
Created all classes, interfaces and interfaces are implemented
Created plain decorator and solved the errors of constructor
dotnet run --project ./DecoratorDP/DecoratorDP.csproj 
Tried to run the project dotnet run --project ./DecoratorDP/DecoratorDP.csproj
got output HEllo, World!
missing logic in program.cs
After editing the program.cs i encountered this error
Unhandled exception. System.NotImplementedException: The method or operation is not implemented.
   at Decorator`1.GetText() in /workspaces/md/DecoratorDP/Decorator.cs:line 12
   at PlainDecorator.GetText() in /workspaces/md/DecoratorDP/PlainDecorator.cs:line 10
   at Program.<Main>$(String[] args) in /workspaces/md/DecoratorDP/Program.cs:line 6

Changed the 12th line of code "return component.GetText();" 

Made UppercaseDecorator and Colordecorator by copying the code from the Plain Decorator and edited the code as required
Edited the Program.cs file as required 