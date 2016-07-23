using Android.Runtime;
using Java.Lang;

namespace Com.Digits.Sdk.Android
{
	public partial class DigitsSession
	{
		public partial class Serializer
		{
			[Register ("deserialize", "(Ljava/lang/String;)Lcom/digits/sdk/android/DigitsSession;", "GetDeserialize_Ljava_lang_String_Handler")]
			public virtual Object Deserialize(string serializedSession)
				=> (Object)JavaDeserialize(serializedSession);

			[Register ("serialize", "(Lcom/digits/sdk/android/DigitsSession;)Ljava/lang/String;", "GetSerialize_Lcom_digits_sdk_android_DigitsSession_Handler")]
			public virtual unsafe string Serialize (Object session)
				=> JavaSerialize((DigitsSession)session);
		}
	}
}