using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004DF RID: 1247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildJoinedEvent : IMessage<GuildJoinedEvent>, IMessage, IEquatable<GuildJoinedEvent>, IDeepCloneable<GuildJoinedEvent>, IBufferMessage
	{
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x001E5B8C File Offset: 0x001E3D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildJoinedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x001E5B9C File Offset: 0x001E3D9C
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

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x001E5BAC File Offset: 0x001E3DAC
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

		// Token: 0x06003BA8 RID: 15272 RVA: 0x001E5BBC File Offset: 0x001E3DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinedEvent()
		{
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x001E5BCC File Offset: 0x001E3DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinedEvent(GuildJoinedEvent other)
		{
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x001E5BDC File Offset: 0x001E3DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x001E5BEC File Offset: 0x001E3DEC
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x001E5BFC File Offset: 0x001E3DFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation GuildInformation
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

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x001E5C0C File Offset: 0x001E3E0C
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x001E5C1C File Offset: 0x001E3E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x001E5C2C File Offset: 0x001E3E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x001E5C3C File Offset: 0x001E3E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildJoinedEvent other)
		{
			return true;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x001E5C4C File Offset: 0x001E3E4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001E5C5C File Offset: 0x001E3E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x001E5C6C File Offset: 0x001E3E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x001E5C7C File Offset: 0x001E3E7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x001E5C8C File Offset: 0x001E3E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x001E5C9C File Offset: 0x001E3E9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildJoinedEvent other)
		{
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x001E5CAC File Offset: 0x001E3EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001E5CBC File Offset: 0x001E3EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x001E5CCC File Offset: 0x001E3ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildJoinedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				GuildJoinedEvent._parser = new MessageParser<GuildJoinedEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x001E5DB0 File Offset: 0x001E3FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QMETAXO74MNQhi6bD5Vs()
		{
			return true;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x001E5DB8 File Offset: 0x001E3FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildJoinedEvent nnWpVtO7jXGEhrYqIFRC()
		{
			return null;
		}

		// Token: 0x040014A8 RID: 5288
		private static readonly MessageParser<GuildJoinedEvent> _parser;

		// Token: 0x040014A9 RID: 5289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014AA RID: 5290
		public const int GuildInformationFieldNumber = 1;

		// Token: 0x040014AB RID: 5291
		private GuildInformation guildInformation_;

		// Token: 0x040014AC RID: 5292
		public const int RankIdFieldNumber = 2;

		// Token: 0x040014AD RID: 5293
		private int rankId_;

		// Token: 0x040014AE RID: 5294
		private static GuildJoinedEvent iXVvLkO7x6AsPU951Uk0;
	}
}
