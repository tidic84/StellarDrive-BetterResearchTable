using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(BetterResearchTable.BuildInfo.Description)]
[assembly: AssemblyDescription(BetterResearchTable.BuildInfo.Description)]
[assembly: AssemblyCompany(BetterResearchTable.BuildInfo.Company)]
[assembly: AssemblyProduct(BetterResearchTable.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + BetterResearchTable.BuildInfo.Author)]
[assembly: AssemblyTrademark(BetterResearchTable.BuildInfo.Company)]
[assembly: AssemblyVersion(BetterResearchTable.BuildInfo.Version)]
[assembly: AssemblyFileVersion(BetterResearchTable.BuildInfo.Version)]
[assembly: MelonInfo(typeof(BetterResearchTable.BetterResearchTable), BetterResearchTable.BuildInfo.Name, BetterResearchTable.BuildInfo.Version, BetterResearchTable.BuildInfo.Author, BetterResearchTable.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("CuriousOwlGames", "StellarDrive")]