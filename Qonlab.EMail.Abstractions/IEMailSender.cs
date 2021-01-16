
namespace Qonlab.EMail.Abstractions {
    public interface IEMailSender {
        void SendEncryptedEMail( EncryptedEMail encryptedEmail );
        void SendEMail( EMail email );
        void SendSystemEMail( SystemEMail systemEmail );
        void SendPublicAccouncementSystemEMail( PublicAnnouncementSystemEMail publicAnnouncementEmail );
    }
}
