﻿#pragma warning disable 1587
/**
 * Copyright 2019-2020 Wingify Software Pvt. Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#pragma warning restore 1587

using System;
using Moq;

namespace VWOSdk.Tests
{
    internal class MockUserStorageService
    {
        internal static Mock<IUserStorageService> Get()
        {
            return new Mock<IUserStorageService>();
        }

        internal static void SetupGet(Mock<IUserStorageService> mockUserStorageService, UserStorageMap returnValue)
        {
            mockUserStorageService.Setup(mock => mock.Get(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string userId, string campaignKey) => {
                    returnValue.CampaignKey = campaignKey;
                    return returnValue;
                });
        }

        internal static void SetupSet(Mock<IUserStorageService> mockUserStorageService, Exception exception)
        {
            mockUserStorageService.Setup(mock => mock.Set(It.IsAny<UserStorageMap>()))
                .Throws(exception);
        }

        internal static void SetupGet(Mock<IUserStorageService> mockUserStorageService, Exception exception)
        {
            mockUserStorageService.Setup(mock => mock.Get(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(exception);
        }
    }
}
