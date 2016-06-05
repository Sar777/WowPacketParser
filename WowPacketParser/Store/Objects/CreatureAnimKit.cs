using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    public sealed class CreatureAnimkit : IDataModel
    {
        [DBFieldName("guid", true)]
        public string GUID;

        [DBFieldName("AiID")]
        public uint? AIID;

        [DBFieldName("MovementID")]
        public uint? MovementID;

        [DBFieldName("MeleeID")]
        public uint? MeleeID;
    }
}
