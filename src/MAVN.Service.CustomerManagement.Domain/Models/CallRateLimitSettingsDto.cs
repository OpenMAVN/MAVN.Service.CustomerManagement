using System;

namespace MAVN.Service.CustomerManagement.Domain.Models
{
    public class CallRateLimitSettingsDto
    {
        public int EmailVerificationMaxAllowedRequestsNumber { get; set; }
        public TimeSpan EmailVerificationCallsMonitoredPeriod { get; set; }
        public int PhoneVerificationMaxAllowedRequestsNumber { get; set; }
        public TimeSpan PhoneVerificationCallsMonitoredPeriod { get; set; }

    }
}
