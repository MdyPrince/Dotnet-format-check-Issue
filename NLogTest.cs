
namespace DotNetUtilities
{
    namespace LoggerUtility
    {
        public class NLogLoggerUtility
        {
            private static readonly NLog.Logger s_log = NLog.LogManager.GetCurrentClassLogger();

            ~NLogLoggerUtility()
            {

            }

        }
    }
}
