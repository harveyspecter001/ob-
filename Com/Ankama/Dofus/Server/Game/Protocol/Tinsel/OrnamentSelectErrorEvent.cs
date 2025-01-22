using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x0200007B RID: 123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OrnamentSelectErrorEvent : IMessage<OrnamentSelectErrorEvent>, IMessage, IEquatable<OrnamentSelectErrorEvent>, IDeepCloneable<OrnamentSelectErrorEvent>, IBufferMessage
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00189DDC File Offset: 0x00187FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OrnamentSelectErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00189DEC File Offset: 0x00187FEC
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00189DFC File Offset: 0x00187FFC
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

		// Token: 0x060004F0 RID: 1264 RVA: 0x00189E0C File Offset: 0x0018800C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectErrorEvent()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00189E1C File Offset: 0x0018801C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectErrorEvent(OrnamentSelectErrorEvent other)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00189E2C File Offset: 0x0018802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentSelectErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00189E3C File Offset: 0x0018803C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00189E50 File Offset: 0x00188050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TinselSelectError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TinselSelectError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00189E60 File Offset: 0x00188060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00189E70 File Offset: 0x00188070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OrnamentSelectErrorEvent other)
		{
			return true;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00189E80 File Offset: 0x00188080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00189E90 File Offset: 0x00188090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00189EA0 File Offset: 0x001880A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00189EB0 File Offset: 0x001880B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00189EC0 File Offset: 0x001880C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00189ED0 File Offset: 0x001880D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OrnamentSelectErrorEvent other)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00189EE0 File Offset: 0x001880E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00189EF0 File Offset: 0x001880F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00189F00 File Offset: 0x00188100
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OrnamentSelectErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OrnamentSelectErrorEvent._parser = new MessageParser<OrnamentSelectErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00189FCC File Offset: 0x001881CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kYvbuoOK5PyQLPXVu4Ec()
		{
			return true;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00189FD4 File Offset: 0x001881D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OrnamentSelectErrorEvent hdn1yGOKyH8m5LNLfXhq()
		{
			return null;
		}

		// Token: 0x040001E8 RID: 488
		private static readonly MessageParser<OrnamentSelectErrorEvent> _parser;

		// Token: 0x040001E9 RID: 489
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001EA RID: 490
		public const int ReasonFieldNumber = 1;

		// Token: 0x040001EB RID: 491
		private TinselSelectError reason_;

		// Token: 0x040001EC RID: 492
		private static OrnamentSelectErrorEvent peRs0JOKa0dUWeTQs70d;
	}
}
