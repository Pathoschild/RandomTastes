using System;
using RandomTastes.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace RandomTastes
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        Editor editor;

        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            editor = new Editor(helper, Monitor);
            Helper.Content.AssetEditors.Add(editor);
            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
        }

        /// <summary>Raised after the player loads a save slot and the world is initialised.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            Helper.Content.InvalidateCache("Data/NPCGiftTastes"); // Clear old NPCGiftTastes cache, to be updated w/ the Editor.
        }
    }
}
