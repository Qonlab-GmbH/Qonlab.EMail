using System.Collections.Generic;

namespace Qonlab.EMail.Abstractions {
    public interface IEMailSenderConfiguration {
        string SmtpServerAddress { get; }

        string SmtpServerUsername { get; }
        string SmtpServerPassword { get; }
        bool SmtpServerUsesSSL { get; }
        int MailServerRecipientLimit { get; }
        string SystemMailAddress { get; }
        bool InSimulationMode { get; }
        IList<string> AdministratorEmailAddresses { get; }
        bool IsDisabled { get; }
    }
}
