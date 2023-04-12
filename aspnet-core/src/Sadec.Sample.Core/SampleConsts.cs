using Sadec.Sample.Debugging;

namespace Sadec.Sample
{
    public class SampleConsts
    {
        public const string LocalizationSourceName = "Sample";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a4373e90f13c4d329ead21ac092c5531";
    }
}
