﻿using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Method of authentication for a Guardian Enrollment.
    /// </summary>
    public enum EnrollmentAuthMethod
    {
        [EnumMember(Value = "authentication")]
        Authentication,

        [EnumMember(Value = "guardian")]
        Guardian,

        [EnumMember(Value = "sms")]
        SMS
    }
}
