using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Qonlab.EMail.Abstractions {
    [DataContract( IsReference = true )]
    public class SystemEMail : EMail {
        public SystemEMail( IList<string> to, IList<string> cc, IList<string> bcc, string subject, string body, params Attachment[] attachments )
            : base( from: "$SYSTEMADDRESS", to: to, cc: cc, bcc: bcc, subject: subject, body: body, attachments: attachments ) {

        }

        public SystemEMail( IList<string> to, IList<string> cc, string subject, string body, params Attachment[] attachments )
            : base( from: "$SYSTEMADDRESS", to: to, cc: cc, bcc: null, subject: subject, body: body, attachments: attachments ) {

        }

        public SystemEMail( IList<string> to, string subject, string body, params Attachment[] attachments )
            : base( from: "$SYSTEMADDRESS", to: to, cc: null, bcc: null, subject: subject, body: body, attachments: attachments ) {

        }
    }
}
