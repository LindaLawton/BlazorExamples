# BlazorExamples
Examples for Blazor


## Passing Method To a component

Shows how to pass a method into a Blazor component.  Example spawned from my question [Passing method to component](https://stackoverflow.com/q/56831266/1841839). Working example built upon the anwsers

- Button one uses EventCallback
- Button two uses Action 

Apparntly there is also an issue related to this [EventCallback: Updates to Event Handling and Binding](https://github.com/aspnet/AspNetCore/issues/6351)


## Using a component library

Createing a component library will give you the ablity to use your components across projects.

Create a new component libary using the cli.

    dotnet new blazorlib -n UsComponentLibrary.Lib

Remember to edit the _Imports.razor and add a using for your library 

    @using UsComponentLibrary.Lib.Components
