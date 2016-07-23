using Android.Content;
using Android.Runtime;
using Java.Lang;
namespace Com.Crashlytics.Android.Beta
{
	public partial class DeviceTokenLoader
	{
		[Register("Load", "(Landroid/content/Context;)Ljava/lang/String;", "GetLoad_Landroid_content_Context_Handler")]
		public virtual Object Load(Context context)
			=> (Object)JavaLoad(context);
	}
}