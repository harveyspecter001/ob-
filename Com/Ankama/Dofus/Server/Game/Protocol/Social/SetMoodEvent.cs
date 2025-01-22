using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000137 RID: 311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMoodEvent : IMessage<SetMoodEvent>, IMessage, IEquatable<SetMoodEvent>, IDeepCloneable<SetMoodEvent>, IBufferMessage
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0019B6F8 File Offset: 0x001998F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMoodEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0019B708 File Offset: 0x00199908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0019B718 File Offset: 0x00199918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0019B728 File Offset: 0x00199928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodEvent()
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0019B738 File Offset: 0x00199938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodEvent(SetMoodEvent other)
		{
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0019B748 File Offset: 0x00199948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodEvent Clone()
		{
			return null;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0019B758 File Offset: 0x00199958
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0019B76C File Offset: 0x0019996C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMoodEvent.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SetMoodEvent.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0019B77C File Offset: 0x0019997C
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0019B78C File Offset: 0x0019998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SmileyId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0019B79C File Offset: 0x0019999C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0019B7AC File Offset: 0x001999AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SetMoodEvent other)
		{
			return true;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0019B7BC File Offset: 0x001999BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0019B7CC File Offset: 0x001999CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0019B7DC File Offset: 0x001999DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0019B7EC File Offset: 0x001999EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0019B7FC File Offset: 0x001999FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0019B80C File Offset: 0x00199A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SetMoodEvent other)
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0019B81C File Offset: 0x00199A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0019B82C File Offset: 0x00199A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0019B83C File Offset: 0x00199A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SetMoodEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					SetMoodEvent._parser = new MessageParser<SetMoodEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0019B920 File Offset: 0x00199B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VhBYpmOcFIjWkcAn4XuC()
		{
			return true;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0019B928 File Offset: 0x00199B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SetMoodEvent MvgcbYOcz3ca3UAceASq()
		{
			return null;
		}

		// Token: 0x0400052A RID: 1322
		private static readonly MessageParser<SetMoodEvent> _parser;

		// Token: 0x0400052B RID: 1323
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400052C RID: 1324
		public const int ResultFieldNumber = 1;

		// Token: 0x0400052D RID: 1325
		private SetMoodEvent.Types.Result result_;

		// Token: 0x0400052E RID: 1326
		public const int SmileyIdFieldNumber = 2;

		// Token: 0x0400052F RID: 1327
		private int smileyId_;

		// Token: 0x04000530 RID: 1328
		internal static SetMoodEvent tNap1tOcqHHtSgSF5JEx;

		// Token: 0x02000138 RID: 312
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06000E3F RID: 3647 RVA: 0x002AC1E8 File Offset: 0x002AA3E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000139 RID: 313
			public enum Result
			{
				// Token: 0x04000532 RID: 1330
				[OriginalName("OK")]
				Ok,
				// Token: 0x04000533 RID: 1331
				[OriginalName("ERROR_UNKNOWN")]
				ErrorUnknown,
				// Token: 0x04000534 RID: 1332
				[OriginalName("ERROR_FLOOD")]
				ErrorFlood
			}
		}
	}
}
