﻿using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V6_0_2_19033.Parsers
{
    public static class MovementHandler
    {
        [Parser(Opcode.SMSG_LOGIN_VERIFY_WORLD)]
        public static void HandleLoginVerifyWorld(Packet packet)
        {
            var pos = new Vector4();

            CoreParsers.MovementHandler.CurrentMapId = (uint)packet.ReadEntry<Int32>(StoreNameType.Map, "Map");
            pos.X = packet.ReadSingle();
            pos.Y = packet.ReadSingle();
            pos.Z = packet.ReadSingle();
            pos.O = packet.ReadSingle();
            packet.ReadUInt32("Reason");

            packet.AddValue("Position", pos);
            packet.AddSniffData(StoreNameType.Map, (int)CoreParsers.MovementHandler.CurrentMapId, "NEW_WORLD");
        }

        [Parser(Opcode.CMSG_MOVE_TIME_SKIPPED)]
        public static void HandleMoveTimeSkipped(Packet packet)
        {
            packet.ReadPackedGuid128("GUID");
            packet.ReadInt32("Time");
        }

        [Parser(Opcode.SMSG_PLAYER_MOVE)]
        public static void HandlePlayerMove(Packet packet)
        {
            packet.ReadPackedGuid128("Guid");

            packet.ReadUInt32("Id");
            packet.ReadVector4("Position");

            packet.ReadSingle("Pitch");
            packet.ReadSingle("Spline Elevation");

            var int152 = packet.ReadInt32("Int152");
            packet.ReadInt32("Int168");

            for (var i = 0; i < int152; i++)
                packet.ReadPackedGuid128("Guid156");

            packet.ReadEnum<MovementFlag>("Movement Flags", 30);
            packet.ReadEnum<MovementFlagExtra>("Extra Movement Flags", 15);

            var bit104 = packet.ReadBit("Has Transport Data");
            var bit140 = packet.ReadBit("Has Fall Data");
            packet.ReadBit("bit148");
            packet.ReadBit("bit149");

            if (bit104)
            {
                packet.ReadPackedGuid128("Transport Guid");
                packet.ReadVector4("Transport Position");
                packet.ReadSByte("Transport Seat");
                packet.ReadInt32("Transport Time");

                packet.ResetBitReader();
                var bit44 = packet.ReadBit("Has Transport Time 2");
                var bit52 = packet.ReadBit("Has Transport Time 3");
                if (bit44)
                    packet.ReadUInt32("Transport Time 2");

                if (bit52)
                    packet.ReadUInt32("Transport Time 3");
            }

            if (bit140)
            {
                packet.ReadUInt32("Fall Time");
                packet.ReadSingle("Vertical Speed");

                packet.ResetBitReader();
                var bit20 = packet.ReadBit("Has Fall Direction");
                if (bit20)
                {
                    packet.ReadVector2("Fall");
                    packet.ReadSingle("Horizontal Speed");
                }
            }
        }

        [Parser(Opcode.SMSG_MONSTER_MOVE)]
        public static void HandleMonsterMove(Packet packet)
        {
            packet.ReadPackedGuid128("MoverGUID");

            var pos = packet.ReadVector3("Position");
            packet.ReadUInt32("Id");
            packet.ReadVector3("Destination");

            packet.ReadEnum<SplineFlag434>("Spline Flags", TypeCode.Int32);
            packet.ReadByte("AnimTier");
            packet.ReadUInt32("TierTransStartTime");
            packet.ReadUInt32("Elapsed");
            packet.ReadUInt32("MoveTime");
            packet.ReadSingle("JumpGravity");
            packet.ReadUInt32("SpecialTime");
            var points = packet.ReadInt32("Waypoints");

            packet.ReadByte("Mode");
            packet.ReadByte("VehicleExitVoluntary");

            packet.ReadPackedGuid128("TransportGUID");
            packet.ReadByte("VehicleSeat");

            var packedDeltas = packet.ReadInt32();

            Vector3 endpos = new Vector3();
            for (int i = 0; i < points; i++)
            {
                var spot = packet.ReadVector3();

                // client always taking first point
                if (i == 0)
                    endpos = spot;

                packet.AddValue("Waypoint", spot, i);
            }

            var waypoints = new Vector3[packedDeltas];
            for (int i = 0; i < packedDeltas; i++)
            {
                var vec = packet.ReadPackedVector3();
                waypoints[i].X = vec.X;
                waypoints[i].Y = vec.Y;
                waypoints[i].Z = vec.Z;
            }


            var type = packet.ReadBits("Face", 2);
            var monsterSplineFilter = packet.ReadBit("Has MonsterSplineFilter");

            switch (type)
            {
                case 2:
                {
                   packet.ReadVector3("FaceSpot");
                   break;
                }
                case 3:
                {
                    packet.ReadPackedGuid128("Facing GUID");
                    break;
                }
                case 4:
                {
                    packet.ReadSingle("FaceDirection");
                    break;
                }
            }

            if (monsterSplineFilter)
            {
                var count = packet.ReadUInt32("MonsterSplineFilterKey");
                packet.ReadSingle("BaseSpeed");
                packet.ReadInt16("StartOffset");
                packet.ReadSingle("DistToPrevFilterKey");

                for (int i = 0; i < count; i++)
                {
                    packet.ReadInt16("IDx", i);
                    packet.ReadInt16("Speed", i);
                }

                packet.ReadInt16("AddedToStart");
                packet.ReadBits("FilterFlags", 2);
            }

            packet.ResetBitReader();
            packet.ReadBit("CrzTeleport");
            packet.ReadBits("Unk Bit", 2);

            // Calculate mid pos
            var mid = new Vector3();
            mid.X = (pos.X + endpos.X) * 0.5f;
            mid.Y = (pos.Y + endpos.Y) * 0.5f;
            mid.Z = (pos.Z + endpos.Z) * 0.5f;
            for (var i = 0; i < packedDeltas; ++i)
            {
                var vec = new Vector3
                {
                    X = mid.X - waypoints[i].X,
                    Y = mid.Y - waypoints[i].Y,
                    Z = mid.Z - waypoints[i].Z,
                };
                packet.AddValue("Waypoint", vec, i);
            }
        }
    }
}