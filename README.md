# my small .NET projects
## Contents
So far this repository is comprised of three small programs:
-   simple tree display
-   some experimenting with types
-   and GUI Calculator made in WinForms

...and some of my notes
---
<details>
<summary>My notes</summary>

- What is .NET and C#?
    - C# is strictly programming language
    - .NET is framework, that is used to build applications on Windows
    -   it can be used with C#, but also other programming languages such as F# and VisualBasic.NET

-  .NET can be used to build variety of things: from desktop apps with .NET Core, cross-platform apps with Xamarin, web apps with Blazor to games in Unity.

- .NET consists of CLR (common runtime language), and Class Library


- With older languages from C family their code was directly compiled into machine code


- That means, that compiling targets directly architecture that you used it on


- C# solves that problem borrowing its solution from Java (JVM) - it compiles code into IL Code (Intermediate Language).\
It’s independent from architecture that code was compiled on.


- How do you “translate” code from IL Code to architecture’s specific machine code?\
Using CLR!


- .CLR is essentially application that sits in memory - whose job is to translate code as it runs. That is called JIT - Just In Time compilation.


- .NET applications are comprised of building blocks - Classes


- Classes work the same way to classes in Python:\
Attributes - which are class’ data\
and Methods - which are class’ functions


- As number of classes increases it’s beneficial to organize them in some sort of way

- We can achieve this by using namespaces.


- In .NET framework there are a lot of namespaces. For example, there are namespaces related to working with data using databases, and namespaces used to work with images.


- We can also divide groups of namespaces - in containers called Assembly


- Assembly is file on your disk - executable (EXE), or dynamically linked library (DLL)


- When you build your application compiler builds one, or more Asseblies depending on how you partition your code.


- While working on C# code you can import class, or whole namespace with keywork using. This works similar to python.
</details>

<details>
<summary>Sources</summary>

- https://www.youtube.com/watch?v=YrtFtdTTfv0
- https://www.youtube.com/watch?v=ravLFzIguCM
</details>