using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200050C RID: 1292
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildModificationStartedEvent : IMessage<GuildModificationStartedEvent>, IMessage, IEquatable<GuildModificationStartedEvent>, IDeepCloneable<GuildModificationStartedEvent>, IBufferMessage
	{
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x001EA80C File Offset: 0x001E8A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildModificationStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x001EA81C File Offset: 0x001E8A1C
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

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x001EA82C File Offset: 0x001E8A2C
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

		// Token: 0x06003DDC RID: 15836 RVA: 0x001EA83C File Offset: 0x001E8A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationStartedEvent()
		{
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x001EA84C File Offset: 0x001E8A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationStartedEvent(GuildModificationStartedEvent other)
		{
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x001EA85C File Offset: 0x001E8A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x001EA86C File Offset: 0x001E8A6C
		// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x001EA87C File Offset: 0x001E8A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChangeName
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

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x001EA88C File Offset: 0x001E8A8C
		// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x001EA89C File Offset: 0x001E8A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChangeEmblem
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

		// Token: 0x06003DE3 RID: 15843 RVA: 0x001EA8AC File Offset: 0x001E8AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x001EA8BC File Offset: 0x001E8ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildModificationStartedEvent other)
		{
			return true;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x001EA8CC File Offset: 0x001E8ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x001EA8DC File Offset: 0x001E8ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x001EA8EC File Offset: 0x001E8AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x001EA8FC File Offset: 0x001E8AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x001EA90C File Offset: 0x001E8B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x001EA91C File Offset: 0x001E8B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildModificationStartedEvent other)
		{
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x001EA92C File Offset: 0x001E8B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x001EA93C File Offset: 0x001E8B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x001EA94C File Offset: 0x001E8B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildModificationStartedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildModificationStartedEvent._parser = new MessageParser<GuildModificationStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x001EAA44 File Offset: 0x001E8C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LNWcK3OTjnptOkKioQ1G()
		{
			return true;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x001EAA4C File Offset: 0x001E8C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildModificationStartedEvent wbBWBVOTK1mQvhO95tp5()
		{
			return null;
		}

		// Token: 0x04001573 RID: 5491
		private static readonly MessageParser<GuildModificationStartedEvent> _parser;

		// Token: 0x04001574 RID: 5492
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001575 RID: 5493
		public const int CanChangeNameFieldNumber = 1;

		// Token: 0x04001576 RID: 5494
		private bool canChangeName_;

		// Token: 0x04001577 RID: 5495
		public const int CanChangeEmblemFieldNumber = 2;

		// Token: 0x04001578 RID: 5496
		private bool canChangeEmblem_;

		// Token: 0x04001579 RID: 5497
		private static GuildModificationStartedEvent yLilNROT42yIpcMsgYKc;
	}
}
