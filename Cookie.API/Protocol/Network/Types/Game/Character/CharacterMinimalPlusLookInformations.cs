﻿using Cookie.API.Protocol.Network.Types.Game.Look;
using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Types.Game.Character
{
    public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
    {
        public new const short ProtocolId = 163;

        public CharacterMinimalPlusLookInformations()
        {
        }

        public CharacterMinimalPlusLookInformations(EntityLook entityLook)
        {
            EntityLook = entityLook;
        }

        public override short TypeID => ProtocolId;

        public EntityLook EntityLook { get; set; }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            EntityLook.Serialize(writer);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            EntityLook = new EntityLook();
            EntityLook.Deserialize(reader);
        }
    }
}