﻿using System.Runtime.Serialization;

namespace Qonlab.EMail.Abstractions {
    [DataContract( IsReference = true )]
    public class Attachment {
        [DataMember]
        public string FileName { get; private set; }
        [DataMember]
        public byte[] Data { get; private set; }

        public Attachment( string fileName, byte[] data ) {
            FileName = fileName;
            Data = data;
        }

    }
}
