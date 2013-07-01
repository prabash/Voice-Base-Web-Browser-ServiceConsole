using System;
using System.Threading;

namespace UWIC.FInalProject.ServiceConsol.Service
{
    class SendKeysHandler
    {
        public void SendKeys(string message, double delay)
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(delay));
                var iHandle = NativeWin32.FindWindow(null, "Vocem Browser");
                NativeWin32.SetForegroundWindow(iHandle);
                System.Windows.Forms.SendKeys.Send(message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
