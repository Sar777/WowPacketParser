using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_3_0_16981
{
    public static class Opcodes_5_3_0
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            if (direction == Direction.ClientToServer || direction == Direction.BNClientToServer)
                return ClientOpcodes;
            if (direction == Direction.ServerToClient || direction == Direction.BNServerToClient)
                return ServerOpcodes;
            return MiscOpcodes;
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x0470},
            {Opcode.CMSG_AREA_TRIGGER, 0x04DB},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x1AA1},
            {Opcode.CMSG_AUTH_SESSION, 0x09F1},
            {Opcode.CMSG_CAST_SPELL, 0x01CE},
            {Opcode.CMSG_CHAT_CHANNEL_LIST, 0x047B},
            {Opcode.CMSG_CREATE_CHARACTER, 0x0404},
            {Opcode.CMSG_CHAR_DELETE, 0x010C},
            {Opcode.CMSG_ENUM_CHARACTERS, 0x0B1D},
            {Opcode.CMSG_QUERY_CREATURE, 0x050F},
            {Opcode.CMSG_DB_QUERY_BULK, 0x0149},
            {Opcode.CMSG_DISMISS_CONTROLLED_VEHICLE, 0x0A56},
            {Opcode.CMSG_SAVE_EQUIPMENT_SET, 0x1915},
            {Opcode.CMSG_FORCE_MOVE_ROOT_ACK, 0x08CE},
            {Opcode.CMSG_QUERY_GAME_OBJECT, 0x058F},
            {Opcode.CMSG_GOSSIP_HELLO, 0x1414},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x1341},
            {Opcode.CMSG_INSPECT, 0x1515},
            {Opcode.CMSG_LEARN_TALENT, 0x2002},
            {Opcode.CMSG_LOADING_SCREEN_NOTIFY, 0x0341},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x1150},
            {Opcode.CMSG_LOG_DISCONNECT, 0x09A2},
            {Opcode.CMSG_CHAT_ADDON_MESSAGE_PARTY, 0x117A},
            {Opcode.CMSG_CHAT_ADDON_MESSAGE_RAID, 0x0171},
            {Opcode.CMSG_CHAT_MESSAGE_AFK, 0x062B},
            {Opcode.CMSG_CHAT_MESSAGE_CHANNEL, 0x0132},
            {Opcode.CMSG_CHAT_MESSAGE_DND, 0x1271},
            {Opcode.CMSG_CHAT_MESSAGE_EMOTE, 0x0361},
            {Opcode.CMSG_CHAT_MESSAGE_GUILD, 0x1368},
            {Opcode.CMSG_CHAT_MESSAGE_INSTANCE_CHAT, 0x0160},
            {Opcode.CMSG_CHAT_MESSAGE_OFFICER, 0x023B},
            {Opcode.CMSG_CHAT_MESSAGE_PARTY, 0x0570},
            {Opcode.CMSG_CHAT_MESSAGE_RAID, 0x0168},
            {Opcode.CMSG_CHAT_MESSAGE_RAID_WARNING, 0x0033},
            {Opcode.CMSG_CHAT_MESSAGE_SAY, 0x016A},
            {Opcode.CMSG_CHAT_MESSAGE_WHISPER, 0x143A},
            {Opcode.CMSG_CHAT_MESSAGE_YELL, 0x1333},
            {Opcode.CMSG_MOVE_FALL_RESET, 0x0AC3},
            {Opcode.CMSG_MOVE_SET_FLY, 0x0ADF},
            {Opcode.CMSG_QUERY_NPC_TEXT, 0x009E},
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x0492},
            {Opcode.CMSG_QUERY_PAGE_TEXT, 0x055E},
            {Opcode.CMSG_PING, 0x08E3},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0A19},
            {Opcode.CMSG_QUERY_PLAYER_NAME, 0x0018},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x04D7},
            {Opcode.CMSG_GENERATE_RANDOM_CHARACTER_NAME, 0x091D},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x0755},
            {Opcode.CMSG_REALM_QUERY, 0x0209},
            {Opcode.CMSG_REALM_SPLIT, 0x0B48},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x0A82},
            {Opcode.CMSG_REQUEST_HONOR_STATS, 0x01D6},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x059B},
            {Opcode.CMSG_SEND_MAIL, 0x0550},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x0400},
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x0A53},
            {Opcode.CMSG_SET_PLAYER_DECLINED_NAMES, 0x0815},
            {Opcode.CMSG_SET_SELECTION, 0x1759},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x005B},
            {Opcode.CMSG_SEND_TEXT_EMOTE, 0x1444},
            {Opcode.CMSG_TIME_SYNC_RESPONSE, 0x0853},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x0405},
            {Opcode.CMSG_UNKNOWN_2979, 0x0BA3},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x0800},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x054B},
            {Opcode.CMSG_WHO, 0x0308},
            {Opcode.CMSG_ZONEUPDATE, 0x2000}
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0CD1},
            {Opcode.SMSG_ACCOUNT_INFO_RESPONSE, 0x0FC9},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x029D},
            {Opcode.SMSG_ADDON_INFO, 0x0C80},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x12D1},
            {Opcode.SMSG_AREA_TRIGGER_MOVEMENT_UPDATE, 0x0A91},
            {Opcode.SMSG_ARENA_TEAM_COMMAND_RESULT, 0x06C1},
            {Opcode.SMSG_ARENA_TEAM_ROSTER, 0x14C0},
            {Opcode.SMSG_ATTACKER_STATE_UPDATE, 0x05A5},
            {Opcode.SMSG_ATTACK_START, 0x11D5},
            {Opcode.SMSG_ATTACK_STOP, 0x0690},
            {Opcode.SMSG_AURA_UPDATE, 0x1675},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0221},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0890},
            {Opcode.SMSG_AVERAGE_ITEM_LEVEL_INFORM, 0x04C5},
            {Opcode.SMSG_BATTLEFIELD_LIST, 0x0ACC},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECTED, 0x0091},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECT_PENDING, 0x0095},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTERING, 0x06D9},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTRY_INVITE, 0x14D8},
            {Opcode.SMSG_BATTLEFIELD_MGR_EXIT_REQUEST, 0x05C5},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_INVITE, 0x0485},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_REQUEST_RESPONSE, 0x0D88},
            {Opcode.SMSG_BATTLEFIELD_MGR_STATE_CHANGE, 0x09C1},
            {Opcode.SMSG_BATTLEFIELD_PORT_DENIED, 0x0F90},
            {Opcode.SMSG_BATTLEFIELD_RATED_INFO, 0x079D},
            {Opcode.SMSG_BATTLEFIELD_STATUS_ACTIVE, 0x0CD8},
            {Opcode.SMSG_BATTLEFIELD_STATUS_FAILED, 0x0798},
            {Opcode.SMSG_BATTLEFIELD_STATUS_NEED_CONFIRMATION, 0x09D5},
            {Opcode.SMSG_BATTLEFIELD_STATUS_QUEUED, 0x11D1},
            {Opcode.SMSG_BATTLEFIELD_STATUS_WAIT_FOR_GROUPS, 0x0BDC},
            {Opcode.SMSG_BATTLEGROUND_INFO_THROTTLED, 0x0D9D},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_JOINED, 0x1281},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_LEFT, 0x1581},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_POSITIONS, 0x03CC},
            {Opcode.SMSG_BATTLE_PET_CHAT_RESTRICTED, 0x01DD},
            {Opcode.SMSG_BATTLE_PET_DELETED, 0x13D9},
            {Opcode.SMSG_BATTLE_PET_FULL_UPDATE, 0x0189},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x0AC0},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x0DCD},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_DENIED, 0x01C8},
            {Opcode.SMSG_BATTLE_PET_LICENSE_CHANGED, 0x1381},
            {Opcode.SMSG_BATTLE_PET_MAX_GAME_LENGTH_WARNING, 0x04C8},
            {Opcode.SMSG_BATTLE_PET_PET_HEALED, 0x10C4},
            {Opcode.SMSG_BATTLE_PET_PET_UPDATES, 0x14CC},
            {Opcode.SMSG_BATTLE_PET_SLOT_UPDATE, 0x149D},
            {Opcode.SMSG_BATTLE_PET_TRAP_LEVEL, 0x0A9D},
            {Opcode.SMSG_BIND_POINT_UPDATE, 0x04CC},
            {Opcode.SMSG_BUY_FAILED, 0x0D95},
            {Opcode.SMSG_CALENDAR_SEND_NUM_PENDING, 0x078C},
            {Opcode.SMSG_CANCEL_COMBAT, 0x0281},
            {Opcode.SMSG_CAST_FAILED, 0x1598},
            {Opcode.SMSG_CHANNEL_LIST, 0x052C},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x0825},
            {Opcode.SMSG_CREATE_CHAR, 0x1495},
            {Opcode.SMSG_DELETE_CHAR, 0x14C1},
            {Opcode.SMSG_ENUM_CHARACTERS_RESULT, 0x0FDD},
            {Opcode.SMSG_CHAT, 0x0699},
            {Opcode.SMSG_CHAT_IGNORED_ACCOUNT_MUTED, 0x02C5},
            {Opcode.SMSG_CLEAR_BOSS_EMOTES, 0x1395},
            {Opcode.SMSG_CACHE_VERSION, 0x1489},
            {Opcode.SMSG_CONTACT_LIST, 0x1924},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x13C9},
            {Opcode.SMSG_QUERY_CREATURE_RESPONSE, 0x06D8},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x1089},
            {Opcode.SMSG_CUSTOM_LOAD_SCREEN, 0x03DC},
            {Opcode.SMSG_DB_REPLY, 0x00DC},
            {Opcode.SMSG_RUNE_REGEN_DEBUG, 0x0C9C},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x14D0},
            {Opcode.SMSG_DESTROY_OBJECT, 0x04D1},
            {Opcode.SMSG_DIFFERENT_INSTANCE_FROM_PARTY, 0x0DD5},
            {Opcode.SMSG_DISENCHANT_CREDIT, 0x12C9},
            {Opcode.SMSG_DISMOUNT_RESULT, 0x0CC5},
            {Opcode.SMSG_DISPLAY_GAME_ERROR, 0x07D5},
            {Opcode.SMSG_DONT_AUTO_PUSH_SPELLS_TO_ACTION_BAR, 0x0BD9},
            {Opcode.SMSG_DUMP_RIDE_TICKETS_RESPONSE, 0x10D5},
            {Opcode.SMSG_EMOTE, 0x056D},
            {Opcode.SMSG_EQUIPMENT_SET_ID, 0x0888},
            {Opcode.SMSG_EXPLORATION_EXPERIENCE, 0x0D84},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x02CD},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x15D1},
            {Opcode.SMSG_GAME_OBJECT_CUSTOM_ANIM, 0x028D},
            {Opcode.SMSG_GAMEOBJECT_DESPAWN_ANIM, 0x0981},
            {Opcode.SMSG_QUERY_GAME_OBJECT_RESPONSE, 0x0290},
            {Opcode.SMSG_GAME_EVENT_DEBUG_LOG, 0x0190},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x13AD},
            {Opcode.SMSG_GOSSIP_POI, 0x15A7},
            {Opcode.SMSG_GROUP_ACTION_THROTTLED, 0x1394},
            {Opcode.SMSG_GROUP_INVITE, 0x11DD},
            {Opcode.SMSG_GUILD_EVENT, 0x11CC},
            {Opcode.SMSG_QUERY_GUILD_INFO_RESPONSE, 0x0E0A},
            {Opcode.SMSG_GUILD_RANKS, 0x0A5E},
            {Opcode.SMSG_GUILD_REPUTATION_WEEKLY_CAP, 0x1A83},
            {Opcode.SMSG_GUILD_ROSTER, 0x0C0A},
            {Opcode.SMSG_HEALTH_UPDATE, 0x13D8},
            {Opcode.SMSG_HOTFIX_NOTIFY, 0x0EDC},
            {Opcode.SMSG_HOTFIX_NOTIFY_BLOB, 0x1584},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x0598},
            {Opcode.SMSG_SEND_KNOWN_SPELLS, 0x173F},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0FDC},
            {Opcode.SMSG_INSPECT_HONOR_STATS, 0x109C},
            {Opcode.SMSG_INSPECT_RATED_BG_STATS, 0x1498},
            {Opcode.SMSG_INSPECT_RESULTS_UPDATE, 0x0B98},
            {Opcode.SMSG_INVALIDATE_PLAYER, 0x0ED5},
            {Opcode.SMSG_ITEM_ADD_PASSIVE, 0x1384},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x0799},
            {Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x0F81},
            {Opcode.SMSG_ITEM_PUSH_RESULT, 0x129D},
            {Opcode.SMSG_ITEM_PURCHASE_REFUND_RESULT, 0x06C5},
            {Opcode.SMSG_ITEM_REMOVE_PASSIVE, 0x1298},
            {Opcode.SMSG_ITEM_SEND_PASSIVE, 0x0DDD},
            {Opcode.SMSG_ITEM_TIME_UPDATE, 0x0CC0},
            {Opcode.SMSG_LEARNED_SPELLS, 0x058C},
            {Opcode.SMSG_LEVEL_UP_INFO, 0x00CD},
            {Opcode.SMSG_LFG_DISABLED, 0x0895},
            {Opcode.SMSG_LFG_JOIN_RESULT, 0x0291},
            {Opcode.SMSG_LFG_OFFER_CONTINUE, 0x12C4},
            {Opcode.SMSG_LFG_PARTY_INFO, 0x048D},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x07D9},
            {Opcode.SMSG_LFG_PLAYER_REWARD, 0x0E90},
            {Opcode.SMSG_LFG_PROPOSAL_UPDATE, 0x12C8},
            {Opcode.SMSG_LFG_QUEUE_STATUS, 0x0498},
            {Opcode.SMSG_LFG_ROLE_CHECK_UPDATE, 0x08D1},
            {Opcode.SMSG_LFG_SLOT_INVALID, 0x119D},
            {Opcode.SMSG_LFG_TELEPORT_DENIED, 0x049D},
            {Opcode.SMSG_LFG_UPDATE_STATUS, 0x0E98},
            {Opcode.SMSG_LFG_UPDATE_STATUS_NONE, 0x0A89},
            {Opcode.SMSG_VENDOR_INVENTORY, 0x128D},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x09CC},
            {Opcode.SMSG_LOGIN_SET_TIME_SPEED, 0x0C8D},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0434},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x05D5},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x15C9},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x14D5},
            {Opcode.SMSG_LOG_XP_GAIN, 0x09CD},
            {Opcode.SMSG_LOOT_ALL_PASSED, 0x0DC1},
            {Opcode.SMSG_LOOT_CONTENTS, 0x0580},
            {Opcode.SMSG_LOOT_LIST, 0x0CC4},
            {Opcode.SMSG_LOOT_MASTER_LIST, 0x0994},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x0180},
            {Opcode.SMSG_LOOT_RELEASE, 0x12C1},
            {Opcode.SMSG_LOOT_REMOVED, 0x0E8C},
            {Opcode.SMSG_LOOT_RESPONSE, 0x08CD},
            {Opcode.SMSG_LOOT_ROLL, 0x158C},
            {Opcode.SMSG_LOOT_ROLL_WON, 0x0985},
            {Opcode.SMSG_LOOT_START_ROLL, 0x10C8},
            //{Opcode.SMSG_LOOT_UPDATED, 0x15C4}, new
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x14C8},
            {Opcode.SMSG_MAP_OBJ_EVENTS, 0x0A84},
            {Opcode.SMSG_MESSAGE_BOX, 0x14D9},
            {Opcode.SMSG_MISSILE_CANCEL, 0x03CD},
            {Opcode.SMSG_MONEY_NOTIFY, 0x0DCC},
            {Opcode.SMSG_MOTD, 0x12DC},
            {Opcode.SMSG_MOUNT_RESULT, 0x15D0},
            {Opcode.SMSG_MOVE_ROOT, 0x0505},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x0F48},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x0E54},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x0758},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x0904},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x051D},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x034D},
            {Opcode.SMSG_MOVE_UPDATE, 0x1109},
            {Opcode.SMSG_QUERY_PLAYER_NAME_RESPONSE, 0x0BD0},
            {Opcode.SMSG_NEUTRAL_PLAYER_FACTION_SELECT_RESULT, 0x0480},
            {Opcode.SMSG_NEW_WORLD, 0x04D9},
            {Opcode.SMSG_NEW_WORLD_ABORT, 0x0399},
            {Opcode.SMSG_QUERY_NPC_TEXT_RESPONSE, 0x02CC},
            {Opcode.SMSG_ON_MONSTER_MOVE, 0x114C},
            {Opcode.SMSG_QUERY_PAGE_TEXT_RESPONSE, 0x0384},
            {Opcode.SMSG_SPELL_PERIODIC_AURA_LOG, 0x176C},
            {Opcode.SMSG_PETITION_ALREADY_SIGNED, 0x10CD},
            {Opcode.SMSG_PET_ACTION_FEEDBACK, 0x08C4},
            {Opcode.SMSG_PET_ACTION_SOUND, 0x13D1},
            {Opcode.SMSG_PET_ADDED, 0x0DD4},
            {Opcode.SMSG_PET_BATTLE_FINALIZE_LOCATION, 0x1280},
            {Opcode.SMSG_PET_BATTLE_FINAL_ROUND, 0x06CC},
            {Opcode.SMSG_PET_BATTLE_FINISHED, 0x0CCC},
            {Opcode.SMSG_PET_BATTLE_FIRST_ROUND, 0x1290},
            {Opcode.SMSG_PET_BATTLE_PVP_CHALLENGE, 0x0FC0},
            {Opcode.SMSG_PET_BATTLE_REPLACEMENTS_MADE, 0x0C91},
            {Opcode.SMSG_PET_BATTLE_REQUEST_FAILED, 0x118C},
            {Opcode.SMSG_PET_BATTLE_ROUND_RESULT, 0x0FC8},
            {Opcode.SMSG_PET_CAST_FAILED, 0x01D9},
            {Opcode.SMSG_PET_DISMISS_SOUND, 0x0ED1},
            {Opcode.SMSG_PET_GUIDS, 0x15CD},
            {Opcode.SMSG_PET_LEARNED_SPELLS, 0x1594},
            {Opcode.SMSG_PET_MODE, 0x0085},
            {Opcode.SMSG_PET_NAME_INVALID, 0x0380},
            {Opcode.SMSG_QUERY_PET_NAME_RESPONSE, 0x0198},
            {Opcode.SMSG_PET_SLOT_UPDATED, 0x03C0},
            {Opcode.SMSG_PET_TAME_FAILURE, 0x0689},
            {Opcode.SMSG_PET_UNLEARN_CONFIRM, 0x0F9D},
            {Opcode.SMSG_PLAYED_TIME, 0x0995},
            {Opcode.SMSG_PLAYER_BOUND, 0x12DD},
            {Opcode.SMSG_PLAY_SOUND, 0x017C},
            {Opcode.SMSG_PLAY_SPELL_VISUAL, 0x01C1},
            {Opcode.SMSG_PONG, 0x1121},
            {Opcode.SMSG_POWER_UPDATE, 0x0DC5},
            {Opcode.SMSG_PRINT_NOTIFICATION, 0x15CC},
            {Opcode.SMSG_PVP_LOG_DATA, 0x0795},
            {Opcode.SMSG_PVP_OPTIONS_ENABLED, 0x0381},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x0F91},
            {Opcode.SMSG_QUEST_GIVER_QUEST_DETAILS, 0x03ED},
            {Opcode.SMSG_QUEST_GIVER_REQUEST_ITEMS, 0x07F4},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x0EE4},
            {Opcode.SMSG_QUERY_QUEST_INFO_RESPONSE, 0x13BF},
            {Opcode.SMSG_RAID_MARKERS_CHANGED, 0x0595},
            {Opcode.SMSG_GENERATE_RANDOM_CHARACTER_NAME_RESULT, 0x0AD9},
            {Opcode.SMSG_RATED_BG_RATING, 0x05C8},
            {Opcode.SMSG_RATED_BATTLEFIELD_INFO, 0x0394},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x10CC},
            {Opcode.SMSG_REALM_SPLIT, 0x0F89},
            {Opcode.SMSG_CONNECT_TO, 0x0328},
            {Opcode.SMSG_REFORGE_RESULT, 0x03D5},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x1389},
            {Opcode.SMSG_REQUEST_PVP_REWARDS_RESPONSE, 0x0389},
            {Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x0DD1},
            {Opcode.SMSG_RESUME_COMMS, 0x0321},
            {Opcode.SMSG_RESURRECT_REQUEST, 0x0FD0},
            {Opcode.SMSG_ROLE_POLL_BEGIN, 0x0CDC},
            {Opcode.SMSG_SERVERTIME, 0x0789},
            {Opcode.SMSG_SERVER_INFO_RESPONSE, 0x0ED4},
            {Opcode.SMSG_CHAT_SERVER_MESSAGE, 0x0DB7},
            {Opcode.SMSG_SETUP_CURRENCY, 0x1595},
            {Opcode.SMSG_SET_DF_FAST_LAUNCH_RESULT, 0x01C0},
            {Opcode.SMSG_SET_FORCED_REACTIONS, 0x069D},
            {Opcode.SMSG_PHASE_SHIFT_CHANGE, 0x0BD4},
            {Opcode.SMSG_SET_PLAYER_DECLINED_NAMES_RESULT, 0x08CC},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x0A80},
            {Opcode.SMSG_SET_PROFICIENCY, 0x00C1},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x0390},
            {Opcode.SMSG_SHOW_BANK, 0x01C4},
            {Opcode.SMSG_SHOW_NEUTRAL_PLAYER_FACTION_SELECT_UI, 0x04C4},
            {Opcode.SMSG_SHOW_RATINGS, 0x0A85},
            {Opcode.SMSG_SOR_START_EXPERIENCE_INCOMPLETE, 0x11DC},
            {Opcode.SMSG_SPELL_FAILURE, 0x108C},
            {Opcode.SMSG_SPELL_GO, 0x036E},
            {Opcode.SMSG_SPELL_NON_MELEE_DAMAGE_LOG, 0x0B7F},
            {Opcode.SMSG_SPELL_START, 0x0765},
            {Opcode.SMSG_STABLE_RESULT, 0x118D},
            {Opcode.SMSG_STAND_STATE_UPDATE, 0x1399},
            {Opcode.SMSG_START_TIMER, 0x0988},
            {Opcode.SMSG_STREAMING_MOVIES, 0x0989},
            {Opcode.SMSG_SUMMON_REQUEST, 0x079C},
            {Opcode.SMSG_SUPERCEDED_SPELLS, 0x0F99},
            {Opcode.SMSG_SUPPRESS_NPC_GREETINGS, 0x0F85},
            {Opcode.SMSG_SUSPEND_TOKEN, 0x03DD},
            {Opcode.SMSG_TEXT_EMOTE, 0x1185},
            {Opcode.SMSG_THREAT_CLEAR, 0x0199},
            {Opcode.SMSG_THREAT_REMOVE, 0x0EC0},
            {Opcode.SMSG_THREAT_UPDATE, 0x1080},
            {Opcode.SMSG_TIME_ADJUSTMENT, 0x159C},
            {Opcode.SMSG_TIME_SYNC_REQUEST, 0x0AD4},
            {Opcode.SMSG_TITLE_EARNED, 0x02D0},
            {Opcode.SMSG_TITLE_LOST, 0x0484},
            {Opcode.SMSG_TRADE_STATUS, 0x0DC0},
            {Opcode.SMSG_TRAINER_BUY_FAILED, 0x08C5},
            {Opcode.SMSG_TRAINER_LIST, 0x08C9},
            {Opcode.SMSG_TRANSFER_PENDING, 0x13CD},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x15BE},
            {Opcode.SMSG_TRIGGER_MOVIE, 0x1198},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0D7E},
            {Opcode.SMSG_UNLEARNED_SPELLS, 0x02D9},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x0684},
            {Opcode.SMSG_UPDATE_ACTION_BUTTONS, 0x019C},
            {Opcode.SMSG_UPDATE_DUNGEON_ENCOUNTER_FOR_LOOT, 0x03D9},
            {Opcode.SMSG_UPDATE_INSTANCE_ENCOUNTER_UNIT, 0x196E},
            {Opcode.SMSG_UPDATE_OBJECT, 0x0C65},
            {Opcode.SMSG_UPDATE_SERVER_PLAYER_POSITION, 0x0E84},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x13C8},
            {Opcode.SMSG_USERLIST_ADD, 0x13C5},
            {Opcode.SMSG_USERLIST_REMOVE, 0x0899},
            {Opcode.SMSG_USERLIST_UPDATE, 0x0AC5},
            {Opcode.SMSG_USE_EQUIPMENT_SET_RESULT, 0x12CD},
            {Opcode.SMSG_VOICE_CHAT_STATUS, 0x07DC},
            {Opcode.SMSG_VOICE_PARENTAL_CONTROLS, 0x0CC9},
            {Opcode.SMSG_VOICE_SESSION_LEAVE, 0x08D0},
            {Opcode.SMSG_VOICE_SESSION_ROSTER_UPDATE, 0x1291},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x0F9C},
            {Opcode.SMSG_VOID_STORAGE_FAILED, 0x078D},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x06C9},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x05C9},
            {Opcode.SMSG_WAIT_QUEUE_FINISH, 0x06C8},
            {Opcode.SMSG_WAIT_QUEUE_UPDATE, 0x05D1},
            {Opcode.SMSG_WARDEN_DATA, 0x12D9},
            {Opcode.SMSG_WARGAME_REQUEST_SENT, 0x0E85},
            {Opcode.SMSG_WEATHER, 0x1391},
            {Opcode.SMSG_WEEKLY_LAST_RESET, 0x01D4},
            {Opcode.SMSG_WHO, 0x11C0},
            {Opcode.SMSG_WHO_IS, 0x0D89},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x1091},
            {Opcode.SMSG_XP_GAIN_ABORTED, 0x1188},
            {Opcode.SMSG_ZONE_UNDER_ATTACK, 0x053F}
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.MSG_MOVE_FALL_LAND, 0x0CCF},
            {Opcode.MSG_MOVE_HEARTBEAT, 0x0E0B},
            {Opcode.MSG_MOVE_JUMP, 0x0CCA},
            {Opcode.MSG_MOVE_SET_FACING, 0x0886},
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x081F},
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x0856},
            {Opcode.MSG_MOVE_START_ASCEND, 0x089F},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x08D2},
            {Opcode.MSG_MOVE_START_DESCEND, 0x0893},
            {Opcode.MSG_MOVE_START_FORWARD, 0x0A4B},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x0A12},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x0C02},
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0x0816},
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x0843},
            {Opcode.MSG_MOVE_START_SWIM, 0x0C13},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x0A9E},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x0A07},
            {Opcode.MSG_MOVE_STOP, 0x0813},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x0A47},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x0AC7},
            {Opcode.MSG_MOVE_STOP_STRAFE, 0x0A4A},
            {Opcode.MSG_MOVE_STOP_SWIM, 0x0C93},
            {Opcode.MSG_MOVE_STOP_TURN, 0x080A},
            {Opcode.MSG_MOVE_TELEPORT, 0x0C54},
            {Opcode.MSG_MOVE_TOGGLE_COLLISION_CHEAT, 0x0A5f},
            {Opcode.MSG_RAID_READY_CHECK, 0x0DDC},
            {Opcode.MSG_RAID_READY_CHECK_CONFIRM, 0x03C9},
            {Opcode.MSG_RAID_READY_CHECK_FINISHED, 0x1591},
            {Opcode.MSG_VERIFY_CONNECTIVITY, 0x4F57}
        };
    }
}
