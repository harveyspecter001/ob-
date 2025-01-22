using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation
{
	// Token: 0x02000399 RID: 921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PopupWarningClosedEvent : IMessage<PopupWarningClosedEvent>, IMessage, IEquatable<PopupWarningClosedEvent>, IDeepCloneable<PopupWarningClosedEvent>, IBufferMessage
	{
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x001C9E54 File Offset: 0x001C8054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PopupWarningClosedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x001C9E64 File Offset: 0x001C8064
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

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x001C9E74 File Offset: 0x001C8074
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

		// Token: 0x06002B28 RID: 11048 RVA: 0x001C9E84 File Offset: 0x001C8084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningClosedEvent()
		{
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x001C9E94 File Offset: 0x001C8094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningClosedEvent(PopupWarningClosedEvent other)
		{
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x001C9EA4 File Offset: 0x001C80A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningClosedEvent Clone()
		{
			return null;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x001C9EB4 File Offset: 0x001C80B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x001C9EC4 File Offset: 0x001C80C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PopupWarningClosedEvent other)
		{
			return true;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x001C9ED4 File Offset: 0x001C80D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x001C9EE4 File Offset: 0x001C80E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x001C9EF4 File Offset: 0x001C80F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x001C9F04 File Offset: 0x001C8104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x001C9F14 File Offset: 0x001C8114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x001C9F24 File Offset: 0x001C8124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PopupWarningClosedEvent other)
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x001C9F34 File Offset: 0x001C8134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x001C9F44 File Offset: 0x001C8144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x001C9F54 File Offset: 0x001C8154
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PopupWarningClosedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					PopupWarningClosedEvent._parser = new MessageParser<PopupWarningClosedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x001CA038 File Offset: 0x001C8238
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RgiROhOr8Zt09j2trQIS()
		{
			return true;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x001CA040 File Offset: 0x001C8240
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PopupWarningClosedEvent SNwhNjOrZkHWM7dp7wq5()
		{
			return null;
		}

		// Token: 0x04000F36 RID: 3894
		private static readonly MessageParser<PopupWarningClosedEvent> _parser;

		// Token: 0x04000F37 RID: 3895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F38 RID: 3896
		private static PopupWarningClosedEvent yKV4gPOru1fbFbEqNJCM;
	}
}
