//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Alliance
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Types.Game.Prism;
    using Cookie.API.Protocol.Network.Types.Game.Social;
    using System.Collections.Generic;


    public class AllianceInsiderInfoMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6403;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AllianceFactSheetInformations m_allianceInfos;
        
        public virtual AllianceFactSheetInformations AllianceInfos
        {
            get
            {
                return m_allianceInfos;
            }
            set
            {
                m_allianceInfos = value;
            }
        }
        
        private List<GuildInsiderFactSheetInformations> m_guilds;
        
        public virtual List<GuildInsiderFactSheetInformations> Guilds
        {
            get
            {
                return m_guilds;
            }
            set
            {
                m_guilds = value;
            }
        }
        
        private List<PrismSubareaEmptyInfo> m_prisms;
        
        public virtual List<PrismSubareaEmptyInfo> Prisms
        {
            get
            {
                return m_prisms;
            }
            set
            {
                m_prisms = value;
            }
        }
        
        public AllianceInsiderInfoMessage(AllianceFactSheetInformations allianceInfos, List<GuildInsiderFactSheetInformations> guilds, List<PrismSubareaEmptyInfo> prisms)
        {
            m_allianceInfos = allianceInfos;
            m_guilds = guilds;
            m_prisms = prisms;
        }
        
        public AllianceInsiderInfoMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_allianceInfos.Serialize(writer);
            writer.WriteShort(((short)(m_guilds.Count)));
            int guildsIndex;
            for (guildsIndex = 0; (guildsIndex < m_guilds.Count); guildsIndex = (guildsIndex + 1))
            {
                GuildInsiderFactSheetInformations objectToSend = m_guilds[guildsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_prisms.Count)));
            int prismsIndex;
            for (prismsIndex = 0; (prismsIndex < m_prisms.Count); prismsIndex = (prismsIndex + 1))
            {
                PrismSubareaEmptyInfo objectToSend = m_prisms[prismsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allianceInfos = new AllianceFactSheetInformations();
            m_allianceInfos.Deserialize(reader);
            int guildsCount = reader.ReadUShort();
            int guildsIndex;
            m_guilds = new System.Collections.Generic.List<GuildInsiderFactSheetInformations>();
            for (guildsIndex = 0; (guildsIndex < guildsCount); guildsIndex = (guildsIndex + 1))
            {
                GuildInsiderFactSheetInformations objectToAdd = new GuildInsiderFactSheetInformations();
                objectToAdd.Deserialize(reader);
                m_guilds.Add(objectToAdd);
            }
            int prismsCount = reader.ReadUShort();
            int prismsIndex;
            m_prisms = new System.Collections.Generic.List<PrismSubareaEmptyInfo>();
            for (prismsIndex = 0; (prismsIndex < prismsCount); prismsIndex = (prismsIndex + 1))
            {
                PrismSubareaEmptyInfo objectToAdd = ProtocolTypeManager.GetInstance<PrismSubareaEmptyInfo>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_prisms.Add(objectToAdd);
            }
        }
    }
}
