# Holographic Remoting - Project Setup Checklist

- in *File -> Build Settings*
	- select *Universal Windows Platform*
	- select *x64* as target architecture
	- select *XAML* as build-type
- in *Edit -> ProjectSettings -> Player -> XR-Settings*
	- check "Virtual Reality Supported"
	- make sure to have a single device in the *Virtual Reality SDKs* list, called *Windows Mixed Reality*
	- check *WSA Holographic Remoting supported*
- in *Edit -> ProjectSettings -> Player -> Publishing Settings -> Capabilities*
	- ensure that the "InternetClient" capability is enabled
	- ensure that the "InternetClientServer" capability is enabled
	- ensure that the "PrivateNetworkClientServer" capability is enabled
	- ensure that the "SpatialPerception" capability is enabled
- in *Window -> XR -> Holographic Emulation* make sure *Remote to Device* is selected (relevant for running projects in the Unity-Editor)
- in *Window -> Package Manager* make sure the "Windows Mixed Reality" package is installed
- in the VisualStudio-project that's generated when building the project, make sure the *UNITY_HOLOGRAPHIC* preprocessor-definition is removed
