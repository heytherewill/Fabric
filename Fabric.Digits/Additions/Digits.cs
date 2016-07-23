using Android.Runtime;
using Java.Lang;

namespace Com.Digits.Sdk.Android
{
	public partial class Digits
	{
		public override int CompareTo(Object another)
			=> CompareTo((IO.Fabric.Sdk.Android.Kit)another);
	
		[Register("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
		protected override unsafe global::Java.Lang.Object DoInBackground()
			=> JavaDoInBackground();
	}
}

