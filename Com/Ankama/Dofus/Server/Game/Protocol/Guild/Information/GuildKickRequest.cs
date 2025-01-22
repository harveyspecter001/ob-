using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004F8 RID: 1272
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildKickRequest : IMessage<GuildKickRequest>, IMessage, IEquatable<GuildKickRequest>, IDeepCloneable<GuildKickRequest>, IBufferMessage
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x001E9280 File Offset: 0x001E7480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x001E9290 File Offset: 0x001E7490
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

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x001E92A0 File Offset: 0x001E74A0
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

		// Token: 0x06003CD3 RID: 15571 RVA: 0x001E92B0 File Offset: 0x001E74B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildKickRequest()
		{
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x001E92C0 File Offset: 0x001E74C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildKickRequest(GuildKickRequest other)
		{
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x001E92D0 File Offset: 0x001E74D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildKickRequest Clone()
		{
			return null;
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x001E92E0 File Offset: 0x001E74E0
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x001E92F0 File Offset: 0x001E74F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KickedId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x001E9300 File Offset: 0x001E7500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x001E9310 File Offset: 0x001E7510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildKickRequest other)
		{
			return true;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x001E9320 File Offset: 0x001E7520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001E9330 File Offset: 0x001E7530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x001E9340 File Offset: 0x001E7540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x001E9350 File Offset: 0x001E7550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x001E9360 File Offset: 0x001E7560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x001E9370 File Offset: 0x001E7570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildKickRequest other)
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x001E9380 File Offset: 0x001E7580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x001E9390 File Offset: 0x001E7590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x001E93A0 File Offset: 0x001E75A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildKickRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				GuildKickRequest._parser = new MessageParser<GuildKickRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x001E9484 File Offset: 0x001E7684
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Je2Jq9O7PukcKkHGwOGr()
		{
			return true;
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x001E948C File Offset: 0x001E768C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildKickRequest aotsUKO7SLb2suH17l6I()
		{
			return null;
		}

		// Token: 0x04001522 RID: 5410
		private static readonly MessageParser<GuildKickRequest> _parser;

		// Token: 0x04001523 RID: 5411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001524 RID: 5412
		public const int KickedIdFieldNumber = 1;

		// Token: 0x04001525 RID: 5413
		private long kickedId_;

		// Token: 0x04001526 RID: 5414
		internal static GuildKickRequest CQAPjyO7iBvpVUYqRxhC;
	}
}
