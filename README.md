# MauiFolderPickerBroken

### ![#f03c15](https://placehold.co/15x15/f03c15/f03c15.png)  !!! Change Platform to **_x64_** and Target to **_Self-Contained_** !!! ![#f03c15](https://placehold.co/15x15/f03c15/f03c15.png)

When running app with launchSetting command name Project, so a unpackaged standalone non-msix app. App runs fine but when attempting to show a folder picker you get a COMException. 

Also in log see the following error:
`mincore\com\oleaut32\dispatch\ups.cpp(2122)\OLEAUT32.dll!00007FFAD02AA726: (caller: 00007FFAD02A9B39) ReturnHr(1) tid(1bc24) 8002801D Library not registered.`

However, if you publish the MAUI app all works as expected.
`dotnet publish .\MauiFolderPickerBroken\MauiFolderPickerBroken.csproj -f:net9.0-windows10.0.19041.0 -p:TargetFrameworks=net9.0-windows10.0.19041.0 -p:Version=99.9.9.9 -p:Platform=x64 -c:Debug --output C:\a\folderpicker9\ -p:WindowsPackageType=None --self-contained`

Tried Release vs Debug, no difference. 
Net8 vs Net9, no difference.
MauiVersion 8.0.100 vs 8.0.3, no difference. Believe it used to work on 8.0.3 but maybe due to workload updates it no longer does.
Also Tried CommunityToolkit V11 and V10 and issue persists.

Left the example at MauiVersion 8.0.100 as thats what my app is currently locked at due to client support obligations, which is also the reason we have to build as standalone exe, not MSIX as windows store is disabled on client devices.

Running as normal "Windows Machine" MSIX and folder picker works fine.
Not sure if this is a maui, communitytoolkit, or winappruntime/winappsdk bug.

### Expected Behavior

Folder picker to open and allow you to pick a folder and return successful result.

### Steps To Reproduce

1. Open Solution
2. Change Platform to **x64** 
3. Change Target to **Self-Contained**
4. Build solution
5. Click Run "Self-Contained" button
6. Click "Pick Folder" Button in app
7. Observe Error in debug console
