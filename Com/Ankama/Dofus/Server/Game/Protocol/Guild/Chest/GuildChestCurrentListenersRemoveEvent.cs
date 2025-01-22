using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200054F RID: 1359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestCurrentListenersRemoveEvent : IMessage<GuildChestCurrentListenersRemoveEvent>, IMessage, IEquatable<GuildChestCurrentListenersRemoveEvent>, IDeepCloneable<GuildChestCurrentListenersRemoveEvent>, IBufferMessage
	{
		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x001EF7EC File Offset: 0x001ED9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestCurrentListenersRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x001EF7FC File Offset: 0x001ED9FC
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

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x001EF80C File Offset: 0x001EDA0C
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

		// Token: 0x06004147 RID: 16711 RVA: 0x001EF81C File Offset: 0x001EDA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersRemoveEvent()
		{
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x001EF82C File Offset: 0x001EDA2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersRemoveEvent(GuildChestCurrentListenersRemoveEvent other)
		{
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x001EF83C File Offset: 0x001EDA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x001EF84C File Offset: 0x001EDA4C
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x001EF85C File Offset: 0x001EDA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Players
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

		// Token: 0x0600414C RID: 16716 RVA: 0x001EF86C File Offset: 0x001EDA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x001EF87C File Offset: 0x001EDA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestCurrentListenersRemoveEvent other)
		{
			return true;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x001EF88C File Offset: 0x001EDA8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x001EF89C File Offset: 0x001EDA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x001EF8AC File Offset: 0x001EDAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x001EF8BC File Offset: 0x001EDABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001EF8CC File Offset: 0x001EDACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x001EF8DC File Offset: 0x001EDADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestCurrentListenersRemoveEvent other)
		{
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x001EF8EC File Offset: 0x001EDAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x001EF8FC File Offset: 0x001EDAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x001EF90C File Offset: 0x001EDB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestCurrentListenersRemoveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				GuildChestCurrentListenersRemoveEvent._parser = new MessageParser<GuildChestCurrentListenersRemoveEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x001EFA04 File Offset: 0x001EDC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IReyi0OpZtHCqV7kD3Gb()
		{
			return true;
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x001EFA0C File Offset: 0x001EDC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestCurrentListenersRemoveEvent B67yHnOpqYkEOfeA4GGS()
		{
			return null;
		}

		// Token: 0x04001685 RID: 5765
		private static readonly MessageParser<GuildChestCurrentListenersRemoveEvent> _parser;

		// Token: 0x04001686 RID: 5766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001687 RID: 5767
		public const int PlayersFieldNumber = 1;

		// Token: 0x04001688 RID: 5768
		private string players_;

		// Token: 0x04001689 RID: 5769
		private static GuildChestCurrentListenersRemoveEvent vFRucIOp8Kx6Lnx69pMS;
	}
}
