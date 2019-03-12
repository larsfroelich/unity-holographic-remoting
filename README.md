# README #

### What? ###
This project demonstrates - with the least amount of code and scene elements possible - the usage of (Tap)-Gestures in conjunction with Unity's "Holographic Remoting"-feature.
It consists of no more than a single 30-lines-of-code script-file and a cube in an empty scene whose colour is changed upon receiving a tap-gesture.

### Why? ###
Gesture-Recognition is known to **fail** when used in combination with the holographic remoting feature in a UWP-app from Windows10-Desktop. This project demonstrates this exact issue in an attempt to facilitate discussions, debugging and testing surrounding it.


### How? ###
To set-up, and test the project:

- import the project using the Unity-version of your choice (2018.2.** - 2018.3.5f1)
- open the scene "DemoScene"
- launch the holographic remoting player app on the hololens
- change the "HololensIP"-attribute of the "Demo-Script"-component on the "Script"-gameObject to the IP-address of your HoloLens
- you can now press "Play" in the Unity-Editor to test the app,

To build the project as standalone UWP-app and experience the bug:

- build the project as x64 XAML application
- once built, open the project using VisualStudio
- remove the "UNITY_HOLOGRAPHIC" preprocessor-definition (otherwise, the Windows mixed reality portal will launch instead of a standard UWP-window)
- build the appx-package (select sideloading for testing purposes)
- from the build-project's AppPackages-folder, install the certificate on your machiene's "trusted root certification authorities" certificate store
- install the appx-package
- launch the app


### Who do I talk to? ###
Check out this [thread](https://forum.unity.com/threads/hololens-remoting-build-gestures-not-recognized.541444/) on the unity forums, contribute on [github](https://github.com/xlfpx/unity-holographic-remoting/) or email the project's creator at [lars.froelich@viscopic.de](lars.froelich@viscopic.de)