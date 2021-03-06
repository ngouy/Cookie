//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Job
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class JobLevelUpMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5656;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private JobDescription m_jobsDescription;
        
        public virtual JobDescription JobsDescription
        {
            get
            {
                return m_jobsDescription;
            }
            set
            {
                m_jobsDescription = value;
            }
        }
        
        private sbyte m_newLevel;
        
        public virtual sbyte NewLevel
        {
            get
            {
                return m_newLevel;
            }
            set
            {
                m_newLevel = value;
            }
        }
        
        public JobLevelUpMessage(JobDescription jobsDescription, sbyte newLevel)
        {
            m_jobsDescription = jobsDescription;
            m_newLevel = newLevel;
        }
        
        public JobLevelUpMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_newLevel);
            m_jobsDescription.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_newLevel = reader.ReadSByte();
            m_jobsDescription = new JobDescription();
            m_jobsDescription.Deserialize(reader);
        }
    }
}
