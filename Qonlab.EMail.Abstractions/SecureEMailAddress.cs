using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Qonlab.EMail.Abstractions {
    public class SecureEMailAddress {
        public string Address { get; private set; }
        public X509Certificate2 Certificate { get; private set; }

        private SecureEMailAddress( string address ) {
            if ( string.IsNullOrEmpty( address ) )
                throw new ArgumentNullException( "address" );

            this.Address = address;
        }

        public SecureEMailAddress( string address, string certFilePath )
            : this( address ) {
            if ( !File.Exists( certFilePath ) )
                throw new FileNotFoundException( certFilePath );

            this.Certificate = new X509Certificate2( certFilePath );
        }

        public SecureEMailAddress( string address, byte[] certBytes )
            : this( address ) {
            if ( certBytes == null )
                throw new ArgumentNullException( "certBytes" );

            this.Certificate = new X509Certificate2( certBytes );
        }
    }
}