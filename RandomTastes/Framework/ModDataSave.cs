using System.Collections.Generic;

namespace RandomTastes.Framework
{
    public class ModDataSave
    {
        public ModDataEntry[] entries = { };
        public string saveName = "";
        public bool enabled = true;

        public ModDataSave() { }
        public ModDataSave(ModDataEntry[] entries) { this.entries = entries; }
        public ModDataSave(List<ModDataEntry> entries) { this.entries = entries.ToArray(); }
    }
}
