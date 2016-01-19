﻿using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("item_appearance")]
    public sealed class ItemAppearance : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("DisplayID")]
        public uint? DisplayID;

        [DBFieldName("IconFileDataID")]
        public uint? IconFileDataID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
