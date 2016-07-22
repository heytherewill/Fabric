using Android.Runtime;
using Java.Lang;

namespace Com.Twitter.Sdk.Android.Core.Internal.Scribe
{
	public partial class ScribeEvent
	{
		public partial class Transform
		{
			[Register("toBytes", "(Lcom/twitter/sdk/android/core/internal/scribe/ScribeEvent;)[B", "GetToBytes_Lcom_twitter_sdk_android_core_internal_scribe_ScribeEvent_Handler")]
			public virtual byte[] ToBytes(Object p0)
				=> ToBytes((ScribeEvent)p0);
		}
	}
}