using Java.Lang;

namespace Com.Crashlytics.Android.Core
{
	public partial class CrashlyticsCore
	{
		public override int CompareTo(Object another)
			=> CompareTo((IO.Fabric.Sdk.Android.Kit)another);
	}
}

