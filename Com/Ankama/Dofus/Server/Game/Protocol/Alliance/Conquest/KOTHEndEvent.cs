using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DA1 RID: 3489
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KOTHEndEvent : IMessage<KOTHEndEvent>, IMessage, IEquatable<KOTHEndEvent>, IDeepCloneable<KOTHEndEvent>, IBufferMessage
	{
		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600A826 RID: 43046 RVA: 0x00294CDC File Offset: 0x00292EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KOTHEndEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600A827 RID: 43047 RVA: 0x00294CEC File Offset: 0x00292EEC
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600A828 RID: 43048 RVA: 0x00294CFC File Offset: 0x00292EFC
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

		// Token: 0x0600A829 RID: 43049 RVA: 0x00294D0C File Offset: 0x00292F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHEndEvent()
		{
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x00294D1C File Offset: 0x00292F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHEndEvent(KOTHEndEvent other)
		{
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x00294D2C File Offset: 0x00292F2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHEndEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600A82C RID: 43052 RVA: 0x00294D3C File Offset: 0x00292F3C
		// (set) Token: 0x0600A82D RID: 43053 RVA: 0x00294D4C File Offset: 0x00292F4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceInformation Winner
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x00294D5C File Offset: 0x00292F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x00294D6C File Offset: 0x00292F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(KOTHEndEvent other)
		{
			return true;
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x00294D7C File Offset: 0x00292F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x00294D8C File Offset: 0x00292F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x00294D9C File Offset: 0x00292F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x00294DAC File Offset: 0x00292FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x00294DBC File Offset: 0x00292FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x00294DCC File Offset: 0x00292FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(KOTHEndEvent other)
		{
		}

		// Token: 0x0600A836 RID: 43062 RVA: 0x00294DDC File Offset: 0x00292FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x00294DEC File Offset: 0x00292FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x00294DFC File Offset: 0x00292FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static KOTHEndEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					KOTHEndEvent._parser = new MessageParser<KOTHEndEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x00294EC8 File Offset: 0x002930C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WxX5tHJlalGjAl4yQhJT()
		{
			return true;
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x00294ED0 File Offset: 0x002930D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KOTHEndEvent lc18UvJl5qrv5ycVyjdM()
		{
			return null;
		}

		// Token: 0x04003DE2 RID: 15842
		private static readonly MessageParser<KOTHEndEvent> _parser;

		// Token: 0x04003DE3 RID: 15843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DE4 RID: 15844
		public const int WinnerFieldNumber = 1;

		// Token: 0x04003DE5 RID: 15845
		private AllianceInformation winner_;

		// Token: 0x04003DE6 RID: 15846
		internal static KOTHEndEvent VsYtSAJl1WZsUlYJyV6o;
	}
}
