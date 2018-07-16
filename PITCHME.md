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