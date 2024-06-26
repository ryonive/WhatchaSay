using Dalamud.Configuration;
using Dalamud.Game.Text;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;

namespace WhatchaSay
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {

        public int Version { get; set; } = 0;

        public bool Enabled { get; set; } = false;
        public bool Data_Saver { get; set; } = true;
        public bool Translate_Self { get; set; } = false;
        public int Language { get; set; } = 0;
        public int Service { get; set; } = 0;
        public string Api_Key { get; set; } = "";
        public int LibreTranslateMirror { get; set; } = 0;
        public Dictionary<XivChatType, bool> ChatTypeEnabled { get; set; } = new Dictionary<XivChatType, bool>()
        {
            {XivChatType.Say, false },
            {XivChatType.Shout, false },
            {XivChatType.Yell, false },
            {XivChatType.Party, false },
            {XivChatType.CrossParty, false },
            {XivChatType.PvPTeam, false },
            {XivChatType.TellIncoming, false },
            {XivChatType.Alliance, false },
            {XivChatType.FreeCompany, false },
            {XivChatType.Ls1, false },
            {XivChatType.Ls2, false },
            {XivChatType.Ls3, false },
            {XivChatType.Ls4, false },
            {XivChatType.Ls5, false },
            {XivChatType.Ls6, false },
            {XivChatType.Ls7, false },
            {XivChatType.Ls8, false },
            {XivChatType.NoviceNetwork, false },
            {XivChatType.CustomEmote, false },
            {XivChatType.StandardEmote, false },
            {XivChatType.CrossLinkShell1, false },
            {XivChatType.CrossLinkShell2, false },
            {XivChatType.CrossLinkShell3, false },
            {XivChatType.CrossLinkShell4, false },
            {XivChatType.CrossLinkShell5, false },
            {XivChatType.CrossLinkShell6, false },
            {XivChatType.CrossLinkShell7, false },
            {XivChatType.CrossLinkShell8, false }
        };

        public string CustomLibre { get; set; } = "";

        // the below exist just to make saving less cumbersome
        [NonSerialized]
        private DalamudPluginInterface? PluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.PluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.PluginInterface!.SavePluginConfig(this);
        }
    }
}
