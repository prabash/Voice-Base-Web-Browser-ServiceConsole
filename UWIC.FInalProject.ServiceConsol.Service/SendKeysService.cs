namespace UWIC.FInalProject.ServiceConsol.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SendKeysService" in both code and config file together.
    public class SendKeysService : ISendKeysService
    {
        public void PostMessage(string message, double delay)
        {
            new SendKeysHandler().SendKeys(message, delay);
        }
    }
}
