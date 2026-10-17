using MelonLoader;

namespace BetterResearchTable
{
    public static class BuildInfo
    {
        public const string Name = "BetterResearchTable";
        public const string Description = "Better UI for ResearchTable";
        public const string Author = "Tidic";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class BetterResearchTable : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            // This checks if the game scene loaded
            if (buildIndex != 1) return;

            MelonLogger.Msg("This mod seems to work");
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            // This checks if the game scene unloaded
            if (buildIndex != 1) return;
        }
    }
}