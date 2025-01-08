# No Traffic Mod for Night-Runners
Small BepInEx plugin to remove all traffic from the roads

## Using:
1. Install [BepInEx 6 Unity (IL2CPP) x64](https://builds.bepinex.dev/projects/bepinex_be/692/BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.692%2B851521c.zip), at least v647. Official site: [builds.bepinex.dev﻿](https://builds.bepinex.dev/projects/bepinex_be)
2. Download the mod from [releases page](https://github.com/reyeees/NoTrafficNPR/releases)
3. Place the dll to `BepInEx/plugins` folder inside game folder

## Building from source:
1. Download this repository
2. Install Visual Studio with .NET>6.0
3. Take this libs from game folder to `Libs` folder in the project:
   Path | Lib
   -|-
   |\BepInEx\core|0Harmony.dll|
   ||BepInEx.Core.dll|
   ||
   |\BepInEx\interop|Assembly-CSharp.dll|
   ||Il2Cppmscorlib.dll|
   ||UnityEngine.CoreModule.dll|
   ||UnityEngine.dll|
4. Open `NoTrafficModNRP.sln` in Visual Studio
5. Build the project
6. Enjoy
