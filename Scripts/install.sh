#! /bin/sh

echo 'Downloading from http://netstorage.unity3d.com/unity/44735ea161b3/MacEditorInstaller/Unity-5.2.1f1.pkg'
curl -O http://netstorage.unity3d.com/unity/44735ea161b3/MacEditorInstaller/Unity-5.2.1f1.pkg

echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity-5.2.1f1.pkg-target /