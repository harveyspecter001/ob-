using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004D5 RID: 1237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMembersEvent : IMessage<GuildMembersEvent>, IMessage, IEquatable<GuildMembersEvent>, IDeepCloneable<GuildMembersEvent>, IBufferMessage
	{
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x001E5120 File Offset: 0x001E3320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMembersEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x001E5130 File Offset: 0x001E3330
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x001E5140 File Offset: 0x001E3340
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

		// Token: 0x06003B25 RID: 15141 RVA: 0x001E5150 File Offset: 0x001E3350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembersEvent()
		{
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x001E5160 File Offset: 0x001E3360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembersEvent(GuildMembersEvent other)
		{
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x001E5170 File Offset: 0x001E3370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembersEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x001E5180 File Offset: 0x001E3380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Character> Members
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x001E5190 File Offset: 0x001E3390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x001E51A0 File Offset: 0x001E33A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMembersEvent other)
		{
			return true;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x001E51B0 File Offset: 0x001E33B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x001E51C0 File Offset: 0x001E33C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x001E51D0 File Offset: 0x001E33D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x001E51E0 File Offset: 0x001E33E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x001E51F0 File Offset: 0x001E33F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x001E5200 File Offset: 0x001E3400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMembersEvent other)
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x001E5210 File Offset: 0x001E3410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001E5220 File Offset: 0x001E3420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x001E5230 File Offset: 0x001E3430
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMembersEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						GuildMembersEvent._repeated_members_codec = FieldCodec.ForMessage<Character>(10U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
						num2 = 2;
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 5;
						continue;
					case 4:
						goto IL_39;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					GuildMembersEvent._parser = new MessageParser<GuildMembersEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 0;
					}
				}
				IL_39:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x001E5324 File Offset: 0x001E3524
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HVsYx4O7eA3PbpW8kkDF()
		{
			return true;
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x001E532C File Offset: 0x001E352C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMembersEvent XnFn5CO73FBthYsZixFU()
		{
			return null;
		}

		// Token: 0x04001482 RID: 5250
		private static readonly MessageParser<GuildMembersEvent> _parser;

		// Token: 0x04001483 RID: 5251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001484 RID: 5252
		public const int MembersFieldNumber = 1;

		// Token: 0x04001485 RID: 5253
		private static readonly FieldCodec<Character> _repeated_members_codec;

		// Token: 0x04001486 RID: 5254
		private readonly RepeatedField<Character> members_;

		// Token: 0x04001487 RID: 5255
		private static GuildMembersEvent Et4YW5O7BuyhwDUwHxho;
	}
}
