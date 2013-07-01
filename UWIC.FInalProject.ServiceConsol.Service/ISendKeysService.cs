using System.ServiceModel;

namespace UWIC.FInalProject.ServiceConsol.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISendKeysService" in both code and config file together.
    [ServiceContract]
    public interface ISendKeysService
    {
        [OperationContract]
        void PostMessage(string message, double delay);
    }
}
