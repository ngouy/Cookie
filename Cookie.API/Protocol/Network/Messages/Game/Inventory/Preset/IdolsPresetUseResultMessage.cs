//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Preset
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class IdolsPresetUseResultMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6614;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_missingIdols;
        
        public virtual List<System.UInt16> MissingIdols
        {
            get
            {
                return m_missingIdols;
            }
            set
            {
                m_missingIdols = value;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        private byte m_code;
        
        public virtual byte Code
        {
            get
            {
                return m_code;
            }
            set
            {
                m_code = value;
            }
        }
        
        public IdolsPresetUseResultMessage(List<System.UInt16> missingIdols, byte presetId, byte code)
        {
            m_missingIdols = missingIdols;
            m_presetId = presetId;
            m_code = code;
        }
        
        public IdolsPresetUseResultMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_missingIdols.Count)));
            int missingIdolsIndex;
            for (missingIdolsIndex = 0; (missingIdolsIndex < m_missingIdols.Count); missingIdolsIndex = (missingIdolsIndex + 1))
            {
                writer.WriteVarUhShort(m_missingIdols[missingIdolsIndex]);
            }
            writer.WriteByte(m_presetId);
            writer.WriteByte(m_code);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int missingIdolsCount = reader.ReadUShort();
            int missingIdolsIndex;
            m_missingIdols = new System.Collections.Generic.List<ushort>();
            for (missingIdolsIndex = 0; (missingIdolsIndex < missingIdolsCount); missingIdolsIndex = (missingIdolsIndex + 1))
            {
                m_missingIdols.Add(reader.ReadVarUhShort());
            }
            m_presetId = reader.ReadByte();
            m_code = reader.ReadByte();
        }
    }
}