using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200014A RID: 330
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubscribeSpouseCompassRequest : IMessage<SubscribeSpouseCompassRequest>, IMessage, IEquatable<SubscribeSpouseCompassRequest>, IDeepCloneable<SubscribeSpouseCompassRequest>, IBufferMessage
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0019C6C4 File Offset: 0x0019A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubscribeSpouseCompassRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0019C6D4 File Offset: 0x0019A8D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0019C6E4 File Offset: 0x0019A8E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0019C6F4 File Offset: 0x0019A8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeSpouseCompassRequest()
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0019C704 File Offset: 0x0019A904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeSpouseCompassRequest(SubscribeSpouseCompassRequest other)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0019C714 File Offset: 0x0019A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeSpouseCompassRequest Clone()
		{
			return null;
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0019C724 File Offset: 0x0019A924
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x0019C734 File Offset: 0x0019A934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0019C744 File Offset: 0x0019A944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0019C754 File Offset: 0x0019A954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubscribeSpouseCompassRequest other)
		{
			return true;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0019C764 File Offset: 0x0019A964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0019C774 File Offset: 0x0019A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0019C784 File Offset: 0x0019A984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0019C794 File Offset: 0x0019A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0019C7A4 File Offset: 0x0019A9A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0019C7B4 File Offset: 0x0019A9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubscribeSpouseCompassRequest other)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0019C7C4 File Offset: 0x0019A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0019C7D4 File Offset: 0x0019A9D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0019C7E4 File Offset: 0x0019A9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubscribeSpouseCompassRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				SubscribeSpouseCompassRequest._parser = new MessageParser<SubscribeSpouseCompassRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0019C8DC File Offset: 0x0019AADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ye04jjOUxa083Zr952q6()
		{
			return true;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0019C8E4 File Offset: 0x0019AAE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubscribeSpouseCompassRequest bY1xWQOU4oVRv2ebxmDy()
		{
			return null;
		}

		// Token: 0x04000584 RID: 1412
		private static readonly MessageParser<SubscribeSpouseCompassRequest> _parser;

		// Token: 0x04000585 RID: 1413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000586 RID: 1414
		public const int EnableFieldNumber = 1;

		// Token: 0x04000587 RID: 1415
		private bool enable_;

		// Token: 0x04000588 RID: 1416
		internal static SubscribeSpouseCompassRequest e4XBZ9OUNZp24u5It2v4;
	}
}
