﻿using MvvmCrossTemplate.Core.Interfaces.Models.User;
using MvvmCrossTemplate.Core.Models.User;
using MvvmCrossTemplate.Core.Tests.Builders.Base;
using MvvmCrossTemplate.Core.Tests.Builders.Utils;
using MvvmCrossTemplate.Core.Utils;

namespace MvvmCrossTemplate.Core.Tests.Builders.Models.User
{
    public class UserModelBuilder : BaseBuilder<UserModel>
    {
        private IPersonalDetails _personalDetails;
        private EntityId _entityId;

        public UserModelBuilder()
        {
            _personalDetails = new PersonalDetailsBuilder().CreateMock();
            _entityId = new EntityIdBuilder().Create();
        }

        public override UserModel Create()
        {
            return new UserModel(_entityId, _personalDetails);
        }

        public UserModelBuilder With_PersonalDetails(IPersonalDetails personalDetails)
        {
            _personalDetails = personalDetails;
            return this;
        }

        public UserModelBuilder With_EntityId(EntityId entityId)
        {
            _entityId = entityId;
            return this;
        }
    }
}