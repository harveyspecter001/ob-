using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D89 RID: 3465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightsInformationEvent : IMessage<AllianceFightsInformationEvent>, IMessage, IEquatable<AllianceFightsInformationEvent>, IDeepCloneable<AllianceFightsInformationEvent>, IBufferMessage
	{
		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600A707 RID: 42759 RVA: 0x00293D48 File Offset: 0x00291F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightsInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x00293D58 File Offset: 0x00291F58
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

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x0600A709 RID: 42761 RVA: 0x00293D68 File Offset: 0x00291F68
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

		// Token: 0x0600A70A RID: 42762 RVA: 0x00293D78 File Offset: 0x00291F78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightsInformationEvent()
		{
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x00293D88 File Offset: 0x00291F88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightsInformationEvent(AllianceFightsInformationEvent other)
		{
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x00293D98 File Offset: 0x00291F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightsInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600A70D RID: 42765 RVA: 0x00293DA8 File Offset: 0x00291FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialFight> AllianceFights
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x00293DB8 File Offset: 0x00291FB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x00293DC8 File Offset: 0x00291FC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightsInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x00293DD8 File Offset: 0x00291FD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A711 RID: 42769 RVA: 0x00293DE8 File Offset: 0x00291FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A712 RID: 42770 RVA: 0x00293DF8 File Offset: 0x00291FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x00293E08 File Offset: 0x00292008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x00293E18 File Offset: 0x00292018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x00293E28 File Offset: 0x00292028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightsInformationEvent other)
		{
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x00293E38 File Offset: 0x00292038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x00293E48 File Offset: 0x00292048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x00293E58 File Offset: 0x00292058
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightsInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					AllianceFightsInformationEvent._repeated_allianceFights_codec = FieldCodec.ForMessage<SocialFight>(10U, pKSE6KBIBhM9plOXMC19.XVInXhlssT(pKSE6KBIBhM9plOXMC19.o6JBIevZ5BB));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceFightsInformationEvent._parser = new MessageParser<AllianceFightsInformationEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x00293F48 File Offset: 0x00292148
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JXVFAIJlGMSr5TNCxalO()
		{
			return true;
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x00293F50 File Offset: 0x00292150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightsInformationEvent f3ZM0tJlg4KprB7QGMPx()
		{
			return null;
		}

		// Token: 0x04003D78 RID: 15736
		private static readonly MessageParser<AllianceFightsInformationEvent> _parser;

		// Token: 0x04003D79 RID: 15737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7A RID: 15738
		public const int AllianceFightsFieldNumber = 1;

		// Token: 0x04003D7B RID: 15739
		private static readonly FieldCodec<SocialFight> _repeated_allianceFights_codec;

		// Token: 0x04003D7C RID: 15740
		private readonly RepeatedField<SocialFight> allianceFights_;

		// Token: 0x04003D7D RID: 15741
		private static AllianceFightsInformationEvent UUy9CGJlJxVpf5tmJykf;
	}
}
