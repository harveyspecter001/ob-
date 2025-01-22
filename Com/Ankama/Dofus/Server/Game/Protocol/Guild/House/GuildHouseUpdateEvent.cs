using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House
{
	// Token: 0x0200052F RID: 1327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildHouseUpdateEvent : IMessage<GuildHouseUpdateEvent>, IMessage, IEquatable<GuildHouseUpdateEvent>, IDeepCloneable<GuildHouseUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x001ED0B4 File Offset: 0x001EB2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildHouseUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x001ED0C4 File Offset: 0x001EB2C4
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

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x001ED0D4 File Offset: 0x001EB2D4
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

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001ED0E4 File Offset: 0x001EB2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseUpdateEvent()
		{
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x001ED0F4 File Offset: 0x001EB2F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseUpdateEvent(GuildHouseUpdateEvent other)
		{
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x001ED104 File Offset: 0x001EB304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHouseUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x001ED114 File Offset: 0x001EB314
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x001ED124 File Offset: 0x001EB324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public House House
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

		// Token: 0x06003FB8 RID: 16312 RVA: 0x001ED134 File Offset: 0x001EB334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x001ED144 File Offset: 0x001EB344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildHouseUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001ED154 File Offset: 0x001EB354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x001ED164 File Offset: 0x001EB364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x001ED174 File Offset: 0x001EB374
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x001ED184 File Offset: 0x001EB384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x001ED194 File Offset: 0x001EB394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x001ED1A4 File Offset: 0x001EB3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildHouseUpdateEvent other)
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x001ED1B4 File Offset: 0x001EB3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x001ED1C4 File Offset: 0x001EB3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x001ED1D4 File Offset: 0x001EB3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildHouseUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
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
					GuildHouseUpdateEvent._parser = new MessageParser<GuildHouseUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
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

		// Token: 0x06003FC3 RID: 16323 RVA: 0x001ED2A0 File Offset: 0x001EB4A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wOsheoOpdMFYR60Ta5QI()
		{
			return true;
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x001ED2A8 File Offset: 0x001EB4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildHouseUpdateEvent pmlGrLOp9eIqXd4c3DPv()
		{
			return null;
		}

		// Token: 0x0400160B RID: 5643
		private static readonly MessageParser<GuildHouseUpdateEvent> _parser;

		// Token: 0x0400160C RID: 5644
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400160D RID: 5645
		public const int HouseFieldNumber = 1;

		// Token: 0x0400160E RID: 5646
		private House house_;

		// Token: 0x0400160F RID: 5647
		internal static GuildHouseUpdateEvent GNIOdWOpsmangZVQKgIu;
	}
}
