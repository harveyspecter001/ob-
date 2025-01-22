using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004D9 RID: 1241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberLeaveEvent : IMessage<GuildMemberLeaveEvent>, IMessage, IEquatable<GuildMemberLeaveEvent>, IDeepCloneable<GuildMemberLeaveEvent>, IBufferMessage
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x001E5548 File Offset: 0x001E3748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMemberLeaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x001E5558 File Offset: 0x001E3758
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

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x001E5568 File Offset: 0x001E3768
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

		// Token: 0x06003B58 RID: 15192 RVA: 0x001E5578 File Offset: 0x001E3778
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberLeaveEvent()
		{
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x001E5588 File Offset: 0x001E3788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberLeaveEvent(GuildMemberLeaveEvent other)
		{
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x001E5598 File Offset: 0x001E3798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberLeaveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x001E55A8 File Offset: 0x001E37A8
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x001E55B8 File Offset: 0x001E37B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Kicked
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

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x001E55C8 File Offset: 0x001E37C8
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x001E55D8 File Offset: 0x001E37D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06003B5F RID: 15199 RVA: 0x001E55E8 File Offset: 0x001E37E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x001E55F8 File Offset: 0x001E37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberLeaveEvent other)
		{
			return true;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001E5608 File Offset: 0x001E3808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x001E5618 File Offset: 0x001E3818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x001E5628 File Offset: 0x001E3828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001E5638 File Offset: 0x001E3838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x001E5648 File Offset: 0x001E3848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x001E5658 File Offset: 0x001E3858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberLeaveEvent other)
		{
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x001E5668 File Offset: 0x001E3868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x001E5678 File Offset: 0x001E3878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x001E5688 File Offset: 0x001E3888
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberLeaveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					GuildMemberLeaveEvent._parser = new MessageParser<GuildMemberLeaveEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001E576C File Offset: 0x001E396C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CxBlW9O7gZAbTghxYM9r()
		{
			return true;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x001E5774 File Offset: 0x001E3974
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberLeaveEvent PGYC7BO7sdAo2qFUpYTd()
		{
			return null;
		}

		// Token: 0x04001491 RID: 5265
		private static readonly MessageParser<GuildMemberLeaveEvent> _parser;

		// Token: 0x04001492 RID: 5266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001493 RID: 5267
		public const int KickedFieldNumber = 1;

		// Token: 0x04001494 RID: 5268
		private bool kicked_;

		// Token: 0x04001495 RID: 5269
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04001496 RID: 5270
		private long playerId_;

		// Token: 0x04001497 RID: 5271
		internal static GuildMemberLeaveEvent hlXgndO7Gdt7hC9vlWyZ;
	}
}
