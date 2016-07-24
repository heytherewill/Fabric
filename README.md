# Fabric
:bird: Modular Xamarin Bindings for Twitter Fabric

There are multiple implementations of bindings for Twitter Fabric. If you need to use more than one kit at a time, though, you'll start having namespace conflicts. This is bad. So I did the only possible thing: I created yet another set of bindings!

![You could easily replace my brain with a machine that quotes xkcd and no one would notice the difference](http://imgs.xkcd.com/comics/standards.png)

This project's purpose is to make the usage of Fabric modular and simple to extend. If you ever need bindings for a new kit, you can do so by referencing the `Fabric.Core` package. Like that, those consuming your bindings won't have to make namespace aliases if they need your kit and someone else's.

#Building

Extract the Javadocs before building:

``jar -tvf javadoc-file-name.jar``

Delete them afterwards:

``path/to/javadocs/ ! -name *.jar -delete``

# Installation

Install via NuGet using:

[TwitterCore](https://www.nuget.org/packages/Fabric.TwitterCore/)

``PM> Install-Package Fabric.TwitterCore``

[Crashlytics](https://www.nuget.org/packages/Fabric.Crashlytics/)

``PM> Install-Package Fabric.Crashlytics``

[Digits](https://www.nuget.org/packages/Fabric.Digits/)

``PM> Install-Package Fabric.Digits``

# Thanks
Special thanks to [@azchohfi](https://github.com/azchohfi)'s [Crashlytics.Droid](https://github.com/azchohfi/Crashlytics.Droid) and [@phischu](https://github.com/phischu/Android-Twitter-Core-Xamarin)'s [Android-Twitter-Core-Xamarin](https://github.com/phischu/Android-Twitter-Core-Xamarin). I've always used those libraries, but needing to use them both in the same project was what made me create this project.
