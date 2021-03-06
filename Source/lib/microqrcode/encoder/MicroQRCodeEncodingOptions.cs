﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace ZXing.MicroQrCode.Internal
{
    /// <summary>
    /// The class holds the available options for the QrCodeWriter
    /// </summary>
    [Serializable]
    public class MicroQrCodeEncodingOptions : EncodingOptions
    {
        /// <summary>
        /// Specifies what degree of error correction to use, for example in QR Codes.
        /// Type depends on the encoder. For example for QR codes it's type
        /// {@link com.google.zxing.qrcode.decoder.ErrorCorrectionLevel ErrorCorrectionLevel}.
        /// </summary>
        public ErrorCorrectionLevel ErrorCorrection
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.ERROR_CORRECTION))
                {
                    return (ErrorCorrectionLevel)Hints[EncodeHintType.ERROR_CORRECTION];
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    if (Hints.ContainsKey(EncodeHintType.ERROR_CORRECTION))
                        Hints.Remove(EncodeHintType.ERROR_CORRECTION);
                }
                else
                {
                    Hints[EncodeHintType.ERROR_CORRECTION] = value;
                }
            }
        }

        /// <summary>
        /// Specifies what character encoding to use where applicable (type {@link String})
        /// </summary>
        public string CharacterSet
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.CHARACTER_SET))
                {
                    return (string)Hints[EncodeHintType.CHARACTER_SET];
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    if (Hints.ContainsKey(EncodeHintType.CHARACTER_SET))
                        Hints.Remove(EncodeHintType.CHARACTER_SET);
                }
                else
                {
                    Hints[EncodeHintType.CHARACTER_SET] = value;
                }
            }
        }

        /// <summary>
        /// Specifies what character encoding to use where applicable (type {@link String})
        /// </summary>
        public int Version
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.MICROQRCODE_VERSION))
                {
                    return (int)Hints[EncodeHintType.MICROQRCODE_VERSION];
                }
                return 0;
            }
            set
            {
                if (value == null)
                {
                    if (Hints.ContainsKey(EncodeHintType.MICROQRCODE_VERSION))
                        Hints.Remove(EncodeHintType.MICROQRCODE_VERSION);
                }
                else
                {
                    Hints[EncodeHintType.MICROQRCODE_VERSION] = value;
                }
            }
        }

        /// <summary>
        /// Explicitly disables ECI segment when generating QR Code
        /// That is against the specification of QR Code but some
        /// readers have problems if the charset is switched from
        /// ISO-8859-1 (default) to UTF-8 with the necessary ECI segment.
        /// If you set the property to true you can use UTF-8 encoding
        /// and the ECI segment is omitted.
        /// </summary>
        public bool DisableECI
        {
            get
            {
                if (Hints.ContainsKey(EncodeHintType.DISABLE_ECI))
                {
                    return (bool)Hints[EncodeHintType.DISABLE_ECI];
                }
                return false;
            }
            set
            {
                Hints[EncodeHintType.DISABLE_ECI] = value;
            }
        }
    }
}
