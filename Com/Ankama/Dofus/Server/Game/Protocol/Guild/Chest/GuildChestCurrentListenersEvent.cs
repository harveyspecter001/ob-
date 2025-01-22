using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200054B RID: 1355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestCurrentListenersEvent : IMessage<GuildChestCurrentListenersEvent>, IMessage, IEquatable<GuildChestCurrentListenersEvent>, IDeepCloneable<GuildChestCurrentListenersEvent>, IBufferMessage
	{
		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x001EF3D0 File Offset: 0x001ED5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestCurrentListenersEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x001EF3E0 File Offset: 0x001ED5E0
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x001EF3F0 File Offset: 0x001ED5F0
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

		// Token: 0x06004114 RID: 16660 RVA: 0x001EF400 File Offset: 0x001ED600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersEvent()
		{
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x001EF410 File Offset: 0x001ED610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersEvent(GuildChestCurrentListenersEvent other)
		{
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x001EF420 File Offset: 0x001ED620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x001EF430 File Offset: 0x001ED630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Players
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x001EF440 File Offset: 0x001ED640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x001EF450 File Offset: 0x001ED650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestCurrentListenersEvent other)
		{
			return true;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x001EF460 File Offset: 0x001ED660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x001EF470 File Offset: 0x001ED670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001EF480 File Offset: 0x001ED680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x001EF490 File Offset: 0x001ED690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x001EF4A0 File Offset: 0x001ED6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x001EF4B0 File Offset: 0x001ED6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestCurrentListenersEvent other)
		{
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x001EF4C0 File Offset: 0x001ED6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x001EF4D0 File Offset: 0x001ED6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x001EF4E0 File Offset: 0x001ED6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestCurrentListenersEvent()
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
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					GuildChestCurrentListenersEvent._repeated_players_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(10U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
					num2 = 4;
					continue;
				case 4:
					return;
				case 5:
					GuildChestCurrentListenersEvent._parser = new MessageParser<GuildChestCurrentListenersEvent>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001EF5E0 File Offset: 0x001ED7E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oiQVxxOpiTnVDDY2cTCJ()
		{
			return true;
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x001EF5E8 File Offset: 0x001ED7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestCurrentListenersEvent F5iuKyOpPgAfvFkUnLyv()
		{
			return null;
		}

		// Token: 0x04001676 RID: 5750
		private static readonly MessageParser<GuildChestCurrentListenersEvent> _parser;

		// Token: 0x04001677 RID: 5751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001678 RID: 5752
		public const int PlayersFieldNumber = 1;

		// Token: 0x04001679 RID: 5753
		private static readonly FieldCodec<string> _repeated_players_codec;

		// Token: 0x0400167A RID: 5754
		private readonly RepeatedField<string> players_;

		// Token: 0x0400167B RID: 5755
		internal static GuildChestCurrentListenersEvent AcLsGkOpbUJZwQXtWHhi;
	}
}
