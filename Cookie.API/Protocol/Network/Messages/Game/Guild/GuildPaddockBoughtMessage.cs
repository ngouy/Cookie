//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using Cookie.API.Protocol.Network.Types.Game.Paddock;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildPaddockBoughtMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5952;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PaddockContentInformations m_paddockInfo;
        
        public virtual PaddockContentInformations PaddockInfo
        {
            get
            {
                return m_paddockInfo;
            }
            set
            {
                m_paddockInfo = value;
            }
        }
        
        public GuildPaddockBoughtMessage(PaddockContentInformations paddockInfo)
        {
            m_paddockInfo = paddockInfo;
        }
        
        public GuildPaddockBoughtMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_paddockInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paddockInfo = new PaddockContentInformations();
            m_paddockInfo.Deserialize(reader);
        }
    }
}
