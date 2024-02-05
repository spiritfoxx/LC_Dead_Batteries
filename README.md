# Dead Batteries


### Battery Items are discharged by default.

Why would the company send you a fully charged flashlight?
Hopefully you get to at least confuse your friends with this mod.

## Building Instructions

### .Net SDK
You'll want to download and install the latest .Net 7 SDK version from this page.
https://dotnet.microsoft.com/en-us/download/dotnet/7.0

### Adding Game Assemblies

First download the source code either by cloning the GitHub repository or downloading from Releases.

> You will need to add the game's `Assembly-CSharp.dll` to the libs folder.

You can find this by right-clicking on the Lethal Company game in Steam. Click on *Manage* > *Browse local files.*

Copy the file into `libs\` in the project folder.
`...\Lethal Company_Data\Managed\Assembly-CSharp.dll`

### Build the Thing

Finally, run `dotnet build --configuration Release`

Your .dll will be located here.
`bin\Release\netstandard2.1\DeadBatteries.dll`
