﻿#nullable enable

namespace Demo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class ReadMessages_Message_MessageFromMessageEntityMapper
        : global::StrawberryShake.IEntityMapper<MessageEntity, ReadMessages_Message_Message>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<PersonEntity, GetMessages_PersonByEmail_Messages_Nodes_Recipient_Person> _getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<PersonEntity, GetMessages_PersonByEmail_Messages_Nodes_Sender_Person> _getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper;

        public ReadMessages_Message_MessageFromMessageEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<PersonEntity, GetMessages_PersonByEmail_Messages_Nodes_Recipient_Person> getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper,
            global::StrawberryShake.IEntityMapper<PersonEntity, GetMessages_PersonByEmail_Messages_Nodes_Sender_Person> getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper = getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper));
            _getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper = getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper));
        }

        public ReadMessages_Message_Message Map(MessageEntity entity)
        {
            return new ReadMessages_Message_Message(
                entity.Id,
                entity.Text,
                entity.Direction,
                MapNonNullableIGetMessages_PersonByEmail_Messages_Nodes_Recipient(entity.Recipient),
                MapNonNullableIGetMessages_PersonByEmail_Messages_Nodes_Sender(entity.Sender),
                entity.Sent);
        }

        private IGetMessages_PersonByEmail_Messages_Nodes_Recipient MapNonNullableIGetMessages_PersonByEmail_Messages_Nodes_Recipient(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals("Person", global::System.StringComparison.Ordinal))
            {
                return _getMessages_PersonByEmail_Messages_Nodes_Recipient_PersonFromPersonEntityMapper.Map(
                    _entityStore.GetEntity<PersonEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private IGetMessages_PersonByEmail_Messages_Nodes_Sender MapNonNullableIGetMessages_PersonByEmail_Messages_Nodes_Sender(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals("Person", global::System.StringComparison.Ordinal))
            {
                return _getMessages_PersonByEmail_Messages_Nodes_Sender_PersonFromPersonEntityMapper.Map(
                    _entityStore.GetEntity<PersonEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
