using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeWebAddInVerifier
{
    public static class Common
    {
        public const string ERROR_HEAD = "ERROR: ";
        public const string SUCCESS_HEAD = "SUCCESS: ";
        public const string FAIL_HEAD = "FAIL: ";
        public static string ToLogTime(this DateTime LobjNow)
        {
            return LobjNow.ToString("HH:mm:ss");
        }

        public static void Log(this Exception PobjEx, string PstrMsg)
        {
            MessageBox.Show(ERROR_HEAD + " " + PstrMsg + "\n\n" + PobjEx.Message, 
                            Application.ProductName, MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
        }
    }
}
