using System;

namespace Qonlab.EMail.Abstractions {
    public class EMailSenderException : Exception {
        public EMailSenderException( string msg, Exception ex )
            : base( msg, ex ) {

        }

        public EMailSenderException( string msg )
            : base( msg ) {

        }
    }
}
