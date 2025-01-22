using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000508 RID: 1288
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildSummaryEvent : IMessage<GuildSummaryEvent>, IMessage, IEquatable<GuildSummaryEvent>, IDeepCloneable<GuildSummaryEvent>, IBufferMessage
	{
		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x001EA38C File Offset: 0x001E858C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildSummaryEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x001EA39C File Offset: 0x001E859C
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

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x001EA3AC File Offset: 0x001E85AC
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

		// Token: 0x06003DA5 RID: 15781 RVA: 0x001EA3BC File Offset: 0x001E85BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryEvent()
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x001EA3CC File Offset: 0x001E85CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryEvent(GuildSummaryEvent other)
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x001EA3DC File Offset: 0x001E85DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryEvent Clone()
		{
			return null;
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x001EA3EC File Offset: 0x001E85EC
		// (set) Token: 0x06003DA9 RID: 15785 RVA: 0x001EA3FC File Offset: 0x001E85FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Offset
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

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x001EA40C File Offset: 0x001E860C
		// (set) Token: 0x06003DAB RID: 15787 RVA: 0x001EA41C File Offset: 0x001E861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Count
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

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x001EA42C File Offset: 0x001E862C
		// (set) Token: 0x06003DAD RID: 15789 RVA: 0x001EA43C File Offset: 0x001E863C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Total
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

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x001EA44C File Offset: 0x001E864C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<GuildInformation> Guilds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x001EA45C File Offset: 0x001E865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001EA46C File Offset: 0x001E866C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildSummaryEvent other)
		{
			return true;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x001EA47C File Offset: 0x001E867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x001EA48C File Offset: 0x001E868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x001EA49C File Offset: 0x001E869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001EA4AC File Offset: 0x001E86AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x001EA4BC File Offset: 0x001E86BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001EA4CC File Offset: 0x001E86CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildSummaryEvent other)
		{
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001EA4DC File Offset: 0x001E86DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x001EA4EC File Offset: 0x001E86EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001EA4FC File Offset: 0x001E86FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildSummaryEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						GuildSummaryEvent._parser = new MessageParser<GuildSummaryEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 4;
						}
						break;
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 5;
						break;
					case 3:
						goto IL_72;
					case 4:
						GuildSummaryEvent._repeated_guilds_codec = FieldCodec.ForMessage<GuildInformation>(34U, MZZ6Exmk5BFbxJx9YgB0.XVInXhlssT(MZZ6Exmk5BFbxJx9YgB0.OmvmkyHdSvH));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
						{
							num2 = 1;
						}
						break;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_72:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x001EA608 File Offset: 0x001E8808
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UTKqIcOT2yNoM4rmbcZR()
		{
			return true;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x001EA610 File Offset: 0x001E8810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildSummaryEvent V2rbIrOTE7BJPf1gVpGm()
		{
			return null;
		}

		// Token: 0x04001560 RID: 5472
		private static readonly MessageParser<GuildSummaryEvent> _parser;

		// Token: 0x04001561 RID: 5473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001562 RID: 5474
		public const int OffsetFieldNumber = 1;

		// Token: 0x04001563 RID: 5475
		private long offset_;

		// Token: 0x04001564 RID: 5476
		public const int CountFieldNumber = 2;

		// Token: 0x04001565 RID: 5477
		private long count_;

		// Token: 0x04001566 RID: 5478
		public const int TotalFieldNumber = 3;

		// Token: 0x04001567 RID: 5479
		private long total_;

		// Token: 0x04001568 RID: 5480
		public const int GuildsFieldNumber = 4;

		// Token: 0x04001569 RID: 5481
		private static readonly FieldCodec<GuildInformation> _repeated_guilds_codec;

		// Token: 0x0400156A RID: 5482
		private readonly RepeatedField<GuildInformation> guilds_;

		// Token: 0x0400156B RID: 5483
		private static GuildSummaryEvent r13L3dOT9vunXBQNcIN1;
	}
}
