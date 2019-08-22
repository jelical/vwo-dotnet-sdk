﻿using Xunit;

namespace VWOSdk.Tests
{
    public class ValidateTests
    {
        [Theory]
        [InlineData(-8, null, false)]
        [InlineData(0, null, false)]
        [InlineData(21, null, false)]
        [InlineData(-8, "", false)]
        [InlineData(0, "", false)]
        [InlineData(21, "", false)]
        [InlineData(-8, "2321", false)]
        [InlineData(0, "321", false)]
        [InlineData(3123, "321", true)]
        public void Validate_GetSettings_With_AccountId_And_SdkKey_As_Parameters(long accountId, string sdkKey, bool expectedResult)
        {
            bool result = new Validator().GetSettings(accountId, sdkKey);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, "", false)]
        [InlineData(null, "21", false)]
        [InlineData("", null, false)]
        [InlineData("", "", false)]
        [InlineData("", "21", false)]
        [InlineData("987654", null, false)]
        [InlineData("654654", "", false)]
        [InlineData("654654", "21", true)]
        public void Validate_GetVariation_With_InValid_AccountId_And_SdkKey(string campaignTestKey, string userId, bool expectedResult)
        {
            var result = new Validator().GetVariation(campaignTestKey, userId);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, "", false)]
        [InlineData(null, "21", false)]
        [InlineData("", null, false)]
        [InlineData("", "", false)]
        [InlineData("", "21", false)]
        [InlineData("987654", null, false)]
        [InlineData("654654", "", false)]
        [InlineData("654654", "21", true)]
        public void Validate_Activate_With_InValid_AccountId_And_SdkKey(string campaignTestKey, string userId, bool expectedResult)
        {
            var result = new Validator().Activate(campaignTestKey, userId);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null, null, null, null, false)]
        [InlineData(null, null, null, "", false)]
        [InlineData(null, null, null, "Revenue1122", false)]
        [InlineData(null, null, null, "-1", false)]
        [InlineData(null, null, null, "-1.345", false)]
        [InlineData(null, null, null, "0", false)]
        [InlineData(null, null, null, "0.0", false)]
        [InlineData(null, null, null, "1", false)]
        [InlineData(null, null, null, "1.3213", false)]
        [InlineData(null, null, "", null, false)]
        [InlineData(null, null, "", "", false)]
        [InlineData(null, null, "", "Revenue1122", false)]
        [InlineData(null, null, "", "-1", false)]
        [InlineData(null, null, "", "-1.345", false)]
        [InlineData(null, null, "", "0", false)]
        [InlineData(null, null, "", "0.0", false)]
        [InlineData(null, null, "", "1", false)]
        [InlineData(null, null, "", "1.3213", false)]
        [InlineData(null, null, "Goal1122", null, false)]
        [InlineData(null, null, "Goal1122", "", false)]
        [InlineData(null, null, "Goal1122", "Revenue1122", false)]
        [InlineData(null, null, "Goal1122", "-1", false)]
        [InlineData(null, null, "Goal1122", "-1.345", false)]
        [InlineData(null, null, "Goal1122", "0", false)]
        [InlineData(null, null, "Goal1122", "0.0", false)]
        [InlineData(null, null, "Goal1122", "1", false)]
        [InlineData(null, null, "Goal1122", "1.3213", false)]
        [InlineData(null, "", null, null, false)]
        [InlineData(null, "", null, "", false)]
        [InlineData(null, "", null, "Revenue1122", false)]
        [InlineData(null, "", null, "-1", false)]
        [InlineData(null, "", null, "-1.345", false)]
        [InlineData(null, "", null, "0", false)]
        [InlineData(null, "", null, "0.0", false)]
        [InlineData(null, "", null, "1", false)]
        [InlineData(null, "", null, "1.3213", false)]
        [InlineData(null, "", "", null, false)]
        [InlineData(null, "", "", "", false)]
        [InlineData(null, "", "", "Revenue1122", false)]
        [InlineData(null, "", "", "-1", false)]
        [InlineData(null, "", "", "-1.345", false)]
        [InlineData(null, "", "", "0", false)]
        [InlineData(null, "", "", "0.0", false)]
        [InlineData(null, "", "", "1", false)]
        [InlineData(null, "", "", "1.3213", false)]
        [InlineData(null, "", "Goal1122", null, false)]
        [InlineData(null, "", "Goal1122", "", false)]
        [InlineData(null, "", "Goal1122", "Revenue1122", false)]
        [InlineData(null, "", "Goal1122", "-1", false)]
        [InlineData(null, "", "Goal1122", "-1.345", false)]
        [InlineData(null, "", "Goal1122", "0", false)]
        [InlineData(null, "", "Goal1122", "0.0", false)]
        [InlineData(null, "", "Goal1122", "1", false)]
        [InlineData(null, "", "Goal1122", "1.3213", false)]
        [InlineData(null, "User1122", null, null, false)]
        [InlineData(null, "User1122", null, "", false)]
        [InlineData(null, "User1122", null, "Revenue1122", false)]
        [InlineData(null, "User1122", null, "-1", false)]
        [InlineData(null, "User1122", null, "-1.345", false)]
        [InlineData(null, "User1122", null, "0", false)]
        [InlineData(null, "User1122", null, "0.0", false)]
        [InlineData(null, "User1122", null, "1", false)]
        [InlineData(null, "User1122", null, "1.3213", false)]
        [InlineData(null, "User1122", "", null, false)]
        [InlineData(null, "User1122", "", "", false)]
        [InlineData(null, "User1122", "", "Revenue1122", false)]
        [InlineData(null, "User1122", "", "-1", false)]
        [InlineData(null, "User1122", "", "-1.345", false)]
        [InlineData(null, "User1122", "", "0", false)]
        [InlineData(null, "User1122", "", "0.0", false)]
        [InlineData(null, "User1122", "", "1", false)]
        [InlineData(null, "User1122", "", "1.3213", false)]
        [InlineData(null, "User1122", "Goal1122", null, false)]
        [InlineData(null, "User1122", "Goal1122", "", false)]
        [InlineData(null, "User1122", "Goal1122", "Revenue1122", false)]
        [InlineData(null, "User1122", "Goal1122", "-1", false)]
        [InlineData(null, "User1122", "Goal1122", "-1.345", false)]
        [InlineData(null, "User1122", "Goal1122", "0", false)]
        [InlineData(null, "User1122", "Goal1122", "0.0", false)]
        [InlineData(null, "User1122", "Goal1122", "1", false)]
        [InlineData(null, "User1122", "Goal1122", "1.3213", false)]
        [InlineData("", null, null, null, false)]
        [InlineData("", null, null, "", false)]
        [InlineData("", null, null, "Revenue1122", false)]
        [InlineData("", null, null, "-1", false)]
        [InlineData("", null, null, "-1.345", false)]
        [InlineData("", null, null, "0", false)]
        [InlineData("", null, null, "0.0", false)]
        [InlineData("", null, null, "1", false)]
        [InlineData("", null, null, "1.3213", false)]
        [InlineData("", null, "", null, false)]
        [InlineData("", null, "", "", false)]
        [InlineData("", null, "", "Revenue1122", false)]
        [InlineData("", null, "", "-1", false)]
        [InlineData("", null, "", "-1.345", false)]
        [InlineData("", null, "", "0", false)]
        [InlineData("", null, "", "0.0", false)]
        [InlineData("", null, "", "1", false)]
        [InlineData("", null, "", "1.3213", false)]
        [InlineData("", null, "Goal1122", null, false)]
        [InlineData("", null, "Goal1122", "", false)]
        [InlineData("", null, "Goal1122", "Revenue1122", false)]
        [InlineData("", null, "Goal1122", "-1", false)]
        [InlineData("", null, "Goal1122", "-1.345", false)]
        [InlineData("", null, "Goal1122", "0", false)]
        [InlineData("", null, "Goal1122", "0.0", false)]
        [InlineData("", null, "Goal1122", "1", false)]
        [InlineData("", null, "Goal1122", "1.3213", false)]
        [InlineData("", "", null, null, false)]
        [InlineData("", "", null, "", false)]
        [InlineData("", "", null, "Revenue1122", false)]
        [InlineData("", "", null, "-1", false)]
        [InlineData("", "", null, "-1.345", false)]
        [InlineData("", "", null, "0", false)]
        [InlineData("", "", null, "0.0", false)]
        [InlineData("", "", null, "1", false)]
        [InlineData("", "", null, "1.3213", false)]
        [InlineData("", "", "", null, false)]
        [InlineData("", "", "", "", false)]
        [InlineData("", "", "", "Revenue1122", false)]
        [InlineData("", "", "", "-1", false)]
        [InlineData("", "", "", "-1.345", false)]
        [InlineData("", "", "", "0", false)]
        [InlineData("", "", "", "0.0", false)]
        [InlineData("", "", "", "1", false)]
        [InlineData("", "", "", "1.3213", false)]
        [InlineData("", "", "Goal1122", null, false)]
        [InlineData("", "", "Goal1122", "", false)]
        [InlineData("", "", "Goal1122", "Revenue1122", false)]
        [InlineData("", "", "Goal1122", "-1", false)]
        [InlineData("", "", "Goal1122", "-1.345", false)]
        [InlineData("", "", "Goal1122", "0", false)]
        [InlineData("", "", "Goal1122", "0.0", false)]
        [InlineData("", "", "Goal1122", "1", false)]
        [InlineData("", "", "Goal1122", "1.3213", false)]
        [InlineData("", "User1122", null, null, false)]
        [InlineData("", "User1122", null, "", false)]
        [InlineData("", "User1122", null, "Revenue1122", false)]
        [InlineData("", "User1122", null, "-1", false)]
        [InlineData("", "User1122", null, "-1.345", false)]
        [InlineData("", "User1122", null, "0", false)]
        [InlineData("", "User1122", null, "0.0", false)]
        [InlineData("", "User1122", null, "1", false)]
        [InlineData("", "User1122", null, "1.3213", false)]
        [InlineData("", "User1122", "", null, false)]
        [InlineData("", "User1122", "", "", false)]
        [InlineData("", "User1122", "", "Revenue1122", false)]
        [InlineData("", "User1122", "", "-1", false)]
        [InlineData("", "User1122", "", "-1.345", false)]
        [InlineData("", "User1122", "", "0", false)]
        [InlineData("", "User1122", "", "0.0", false)]
        [InlineData("", "User1122", "", "1", false)]
        [InlineData("", "User1122", "", "1.3213", false)]
        [InlineData("", "User1122", "Goal1122", null, false)]
        [InlineData("", "User1122", "Goal1122", "", false)]
        [InlineData("", "User1122", "Goal1122", "Revenue1122", false)]
        [InlineData("", "User1122", "Goal1122", "-1", false)]
        [InlineData("", "User1122", "Goal1122", "-1.345", false)]
        [InlineData("", "User1122", "Goal1122", "0", false)]
        [InlineData("", "User1122", "Goal1122", "0.0", false)]
        [InlineData("", "User1122", "Goal1122", "1", false)]
        [InlineData("", "User1122", "Goal1122", "1.3213", false)]
        [InlineData("Campaign1122", null, null, null, false)]
        [InlineData("Campaign1122", null, null, "", false)]
        [InlineData("Campaign1122", null, null, "Revenue1122", false)]
        [InlineData("Campaign1122", null, null, "-1", false)]
        [InlineData("Campaign1122", null, null, "-1.345", false)]
        [InlineData("Campaign1122", null, null, "0", false)]
        [InlineData("Campaign1122", null, null, "0.0", false)]
        [InlineData("Campaign1122", null, null, "1", false)]
        [InlineData("Campaign1122", null, null, "1.3213", false)]
        [InlineData("Campaign1122", null, "", null, false)]
        [InlineData("Campaign1122", null, "", "", false)]
        [InlineData("Campaign1122", null, "", "Revenue1122", false)]
        [InlineData("Campaign1122", null, "", "-1", false)]
        [InlineData("Campaign1122", null, "", "-1.345", false)]
        [InlineData("Campaign1122", null, "", "0", false)]
        [InlineData("Campaign1122", null, "", "0.0", false)]
        [InlineData("Campaign1122", null, "", "1", false)]
        [InlineData("Campaign1122", null, "", "1.3213", false)]
        [InlineData("Campaign1122", null, "Goal1122", null, false)]
        [InlineData("Campaign1122", null, "Goal1122", "", false)]
        [InlineData("Campaign1122", null, "Goal1122", "Revenue1122", false)]
        [InlineData("Campaign1122", null, "Goal1122", "-1", false)]
        [InlineData("Campaign1122", null, "Goal1122", "-1.345", false)]
        [InlineData("Campaign1122", null, "Goal1122", "0", false)]
        [InlineData("Campaign1122", null, "Goal1122", "0.0", false)]
        [InlineData("Campaign1122", null, "Goal1122", "1", false)]
        [InlineData("Campaign1122", null, "Goal1122", "1.3213", false)]
        [InlineData("Campaign1122", "", null, null, false)]
        [InlineData("Campaign1122", "", null, "", false)]
        [InlineData("Campaign1122", "", null, "Revenue1122", false)]
        [InlineData("Campaign1122", "", null, "-1", false)]
        [InlineData("Campaign1122", "", null, "-1.345", false)]
        [InlineData("Campaign1122", "", null, "0", false)]
        [InlineData("Campaign1122", "", null, "0.0", false)]
        [InlineData("Campaign1122", "", null, "1", false)]
        [InlineData("Campaign1122", "", null, "1.3213", false)]
        [InlineData("Campaign1122", "", "", null, false)]
        [InlineData("Campaign1122", "", "", "", false)]
        [InlineData("Campaign1122", "", "", "Revenue1122", false)]
        [InlineData("Campaign1122", "", "", "-1", false)]
        [InlineData("Campaign1122", "", "", "-1.345", false)]
        [InlineData("Campaign1122", "", "", "0", false)]
        [InlineData("Campaign1122", "", "", "0.0", false)]
        [InlineData("Campaign1122", "", "", "1", false)]
        [InlineData("Campaign1122", "", "", "1.3213", false)]
        [InlineData("Campaign1122", "", "Goal1122", null, false)]
        [InlineData("Campaign1122", "", "Goal1122", "", false)]
        [InlineData("Campaign1122", "", "Goal1122", "Revenue1122", false)]
        [InlineData("Campaign1122", "", "Goal1122", "-1", false)]
        [InlineData("Campaign1122", "", "Goal1122", "-1.345", false)]
        [InlineData("Campaign1122", "", "Goal1122", "0", false)]
        [InlineData("Campaign1122", "", "Goal1122", "0.0", false)]
        [InlineData("Campaign1122", "", "Goal1122", "1", false)]
        [InlineData("Campaign1122", "", "Goal1122", "1.3213", false)]
        [InlineData("Campaign1122", "User1122", null, null, false)]
        [InlineData("Campaign1122", "User1122", null, "", false)]
        [InlineData("Campaign1122", "User1122", null, "Revenue1122", false)]
        [InlineData("Campaign1122", "User1122", null, "-1", false)]
        [InlineData("Campaign1122", "User1122", null, "-1.345", false)]
        [InlineData("Campaign1122", "User1122", null, "0", false)]
        [InlineData("Campaign1122", "User1122", null, "0.0", false)]
        [InlineData("Campaign1122", "User1122", null, "1", false)]
        [InlineData("Campaign1122", "User1122", null, "1.3213", false)]
        [InlineData("Campaign1122", "User1122", "", null, false)]
        [InlineData("Campaign1122", "User1122", "", "", false)]
        [InlineData("Campaign1122", "User1122", "", "Revenue1122", false)]
        [InlineData("Campaign1122", "User1122", "", "-1", false)]
        [InlineData("Campaign1122", "User1122", "", "-1.345", false)]
        [InlineData("Campaign1122", "User1122", "", "0", false)]
        [InlineData("Campaign1122", "User1122", "", "0.0", false)]
        [InlineData("Campaign1122", "User1122", "", "1", false)]
        [InlineData("Campaign1122", "User1122", "", "1.3213", false)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "", false)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "Revenue1122", false)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "-1", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "-1.345", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "0", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "0.0", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", null, true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "0.321", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "1", true)]
        [InlineData("Campaign1122", "User1122", "Goal1122", "1.3213", true)]
        public void Validate_Track_With_InValid_AccountId_And_SdkKey(string campaignTestKey, string userId, string goalIdentifier, string revenueValue, bool expectedResult)
        {
            var result = new Validator().Track(campaignTestKey, userId, goalIdentifier, revenueValue);
            Assert.Equal(expectedResult, result);
        }
    }
}