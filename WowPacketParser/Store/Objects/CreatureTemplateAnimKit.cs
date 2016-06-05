using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    public class CreatureTemplateAnimkit : IDataModel
    {
        [DBFieldName("entry", true)]
        public uint? Entry;

        [DBFieldName("AiID")]
        public uint? AIID;

        [DBFieldName("MovementID")]
        public uint? MovementID;

        [DBFieldName("MeleeID")]
        public uint? MeleeID;
    }
}
