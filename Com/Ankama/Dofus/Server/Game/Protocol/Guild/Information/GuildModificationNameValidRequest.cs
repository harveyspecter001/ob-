using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004EC RID: 1260
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildModificationNameValidRequest : IMessage<GuildModificationNameValidRequest>, IMessage, IEquatable<GuildModificationNameValidRequest>, IDeepCloneable<GuildModificationNameValidRequest>, IBufferMessage
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x001E85E0 File Offset: 0x001E67E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildModificationNameValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x001E85F0 File Offset: 0x001E67F0
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

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x001E8600 File Offset: 0x001E6800
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

		// Token: 0x06003C33 RID: 15411 RVA: 0x001E8610 File Offset: 0x001E6810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationNameValidRequest()
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x001E8620 File Offset: 0x001E6820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationNameValidRequest(GuildModificationNameValidRequest other)
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x001E8630 File Offset: 0x001E6830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationNameValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x001E8640 File Offset: 0x001E6840
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x001E8650 File Offset: 0x001E6850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x06003C38 RID: 15416 RVA: 0x001E8660 File Offset: 0x001E6860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x001E8670 File Offset: 0x001E6870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildModificationNameValidRequest other)
		{
			return true;
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x001E8680 File Offset: 0x001E6880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x001E8690 File Offset: 0x001E6890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x001E86A0 File Offset: 0x001E68A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x001E86B0 File Offset: 0x001E68B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x001E86C0 File Offset: 0x001E68C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x001E86D0 File Offset: 0x001E68D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildModificationNameValidRequest other)
		{
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x001E86E0 File Offset: 0x001E68E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x001E86F0 File Offset: 0x001E68F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001E8700 File Offset: 0x001E6900
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildModificationNameValidRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					GuildModificationNameValidRequest._parser = new MessageParser<GuildModificationNameValidRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x001E87CC File Offset: 0x001E69CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OPk9nuO7L5BVsc4tpEJP()
		{
			return true;
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x001E87D4 File Offset: 0x001E69D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildModificationNameValidRequest X7uGjgO7WX1o0RZaJQts()
		{
			return null;
		}

		// Token: 0x040014F4 RID: 5364
		private static readonly MessageParser<GuildModificationNameValidRequest> _parser;

		// Token: 0x040014F5 RID: 5365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014F6 RID: 5366
		public const int NameFieldNumber = 1;

		// Token: 0x040014F7 RID: 5367
		private string name_;

		// Token: 0x040014F8 RID: 5368
		internal static GuildModificationNameValidRequest NWVvo1O76Q8WFhdnkNAQ;
	}
}
