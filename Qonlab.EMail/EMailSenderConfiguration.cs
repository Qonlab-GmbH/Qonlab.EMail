﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Qonlab.EMail.Abstractions;

namespace Qonlab.EMail {
    [DataContract( IsReference = true )]
    public class EMailSenderConfiguration : IEMailSenderConfiguration {
        [DataMember]
        public string SmtpServerAddress { get; private set; }
        [DataMember]
        public string SmtpServerUsername { get; set; }
        [DataMember]
        public string SmtpServerPassword { get; set; }
        [DataMember]
        public bool SmtpServerUsesSSL { get; set; }
        [DataMember]
        public int MailServerRecipientLimit { get; private set; }
        [DataMember]
        public string SystemMailAddress { get; private set; }
        [DataMember]
        public bool InSimulationMode { get; private set; }
        [DataMember]
        public IList<string> AdministratorEmailAddresses { get; private set; }
        [DataMember]
        public bool IsDisabled { get; private set; }

        public EMailSenderConfiguration( string smtpServerAddress, int mailServerRecipientLimit, string systemMailAddress, bool inSimulationMode, bool isDisabled = false, params string[] administratorEmailAddresses ) {
            SmtpServerAddress = smtpServerAddress;
            MailServerRecipientLimit = mailServerRecipientLimit;
            SystemMailAddress = systemMailAddress;
            InSimulationMode = inSimulationMode;
            AdministratorEmailAddresses = administratorEmailAddresses.ToList();
            IsDisabled = isDisabled;
        }





    }
}
