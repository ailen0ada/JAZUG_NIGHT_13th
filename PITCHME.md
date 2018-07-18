@title[Xamarin.Forms in Mid 2018]

##### 13th Tokyo Jazug Night
## Xamarin.Forms <br> in Mid 2018
##### Tsubasa HIRANO<br>[@fa[twitter] @ailen0ada](https://twitter.com/ailen0ada)

---
@title[Topics to Explore Today]

### @fa[bullseye] Topics to Explore Today

1. What Xamarin.Forms brings us or not
2. Constructing apps without templates
3. When to use or not

---
@title[A major premise]

### Xamarin.Forms
Create one UI @color[skyblue](for all platforms)
<br><br>
### Xamarin.Native
Create one UI @color[orange](per platform)

---
@title[Constructing without template]

### @fa[cogs] From empty project
It helps you to understand what's going on

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Core/App.cs&lang=csharp&title=Core.App

@[2](add namespace)
@[6](derives from Xamarin.Forms.Application)
@[10-11](specify your content as MainPage)

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Mac/AppDelegate.cs&lang=csharp&title=Mac.AppDelegate

@[3-5](add namespace)
@[9-10](derives from FormsApplicationDelegate)
@[12-22](instantiate main window)
@[24-29](initialize Core.App and launch)

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Mac/Main.cs&lang=csharp&title=Mac.Main

@[10](register our AppDelegate as Delegate of SharedApplication)

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Wpf/MainWindow.xaml&lang=xml&title=Wpf.MainWindow

@[1,5](derived from FormsApplicationPage)

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Wpf/MainWindow.xaml.cs&lang=csharp&title=Wpf.MainWindow

@[15,16,23](derived from FormsApplicationPage)
@[27-29](initialize Core.App and load it)

---?code=assets/first_step_codes/JAZUG.Sample/JAZUG.Sample.Gtk/Program.cs&lang=csharp&title=GtkSharp.Program

@[3-4](add namespace)
@[13,14,21](GTKSharp application cycle)
@[16-19](instantiate FormsWindow and load Core.App)

---
@title[DependencyService]

### @fa[cogs] DependencyService
Allows apps to call into platform-specific functionality from shared code

1. Define interface
2. Implementation per platform
3. Registration
4. Ask for implementations

---?code=assets/second_step_codes/JAZUG.Sample/JAZUG.Sample.Core/IFileSelector.cs&lang=csharp&title=Define interface

@[5-8](single file selection)

---?code=assets/second_step_codes/JAZUG.Sample/JAZUG.Sample.Core/MainPage.xaml.cs&lang=csharp&title=Ask for implementation

@[17-18](Ask for implementation and calling method)

---?code=assets/second_step_codes/JAZUG.Sample/JAZUG.Sample.Mac/NativeFileSelector.cs&lang=csharp&title=NativeFileSelector.Mac

@[11](derived from IFileSelector)
@[8](register per namespace)

---
@title[Demo]

### @fa[history] What I did
* Create Core project from scratch
* Create Platform projects
    * macOS
    * Gtk#
    * WPF
* Typical usage of DependencyService

---
@title[When to use]

### @fa[thumbs-up] When to use Xamarin.Forms
* Data entry apps
* Prototypes and proofs-of-concept
* Require little platform-specific functionality
* Where code sharing is more important than custom UI

---
@title[When not to use]

### @fa[exclamation-triangle] When not to use
* Apps that require specialized interactions
* Apps with highly polished design
* Apps that use many platform-specific APIs
* Where custom UI is more important than code sharing

---
@title[Conclusion]

### @fa[chevron-right] Conclusion
* It's just UI framework
* Should also consider
    * your team's background
    * performance
    * time until delivery
    * complexity of your app