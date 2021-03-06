//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Prism
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class PrismSetSabotagedRefusedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6466;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private byte m_reason;
        
        public virtual byte Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                m_reason = value;
            }
        }
        
        public PrismSetSabotagedRefusedMessage(ushort subAreaId, byte reason)
        {
            m_subAreaId = subAreaId;
            m_reason = reason;
        }
        
        public PrismSetSabotagedRefusedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteByte(m_reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
            m_reason = reader.ReadByte();
        }
    }
}
