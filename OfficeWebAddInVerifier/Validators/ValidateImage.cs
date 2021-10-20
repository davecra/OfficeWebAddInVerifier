using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OfficeWebAddInVerifier.Validators
{
    class ValidateImage : IValidator
    {
        private byte[] MobjImage;
        public ValidateImage(byte[] PobjImage)
        {
            MobjImage = PobjImage;
        }
        /// <summary>
        /// If we have a valid image file then when we try to load it
        /// into the Image class it will succeed, otherwise we get an
        /// exception because it is not an image
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            try
            {
                Image.FromStream(new MemoryStream(MobjImage));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
