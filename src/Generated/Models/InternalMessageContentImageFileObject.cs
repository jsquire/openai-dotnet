// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageContentImageFileObject : MessageContent
    {
        internal InternalMessageContentImageFileObject(InternalMessageContentItemFileObjectImageFile imageFile) : base(InternalMessageContentType.ImageFile)
        {
            Argument.AssertNotNull(imageFile, nameof(imageFile));

            ImageFile = imageFile;
        }

        internal InternalMessageContentImageFileObject(InternalMessageContentType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalMessageContentItemFileObjectImageFile imageFile) : base(kind, additionalBinaryDataProperties)
        {
            ImageFile = imageFile;
        }

        internal InternalMessageContentItemFileObjectImageFile ImageFile { get; set; }
    }
}
