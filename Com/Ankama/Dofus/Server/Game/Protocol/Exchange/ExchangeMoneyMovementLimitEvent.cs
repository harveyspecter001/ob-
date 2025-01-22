using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000713 RID: 1811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMoneyMovementLimitEvent : IMessage<ExchangeMoneyMovementLimitEvent>, IMessage, IEquatable<ExchangeMoneyMovementLimitEvent>, IDeepCloneable<ExchangeMoneyMovementLimitEvent>, IBufferMessage
	{
		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x0021653C File Offset: 0x0021473C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeMoneyMovementLimitEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x0021654C File Offset: 0x0021474C
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

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x0021655C File Offset: 0x0021475C
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

		// Token: 0x0600589C RID: 22684 RVA: 0x0021656C File Offset: 0x0021476C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoneyMovementLimitEvent()
		{
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x0021657C File Offset: 0x0021477C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoneyMovementLimitEvent(ExchangeMoneyMovementLimitEvent other)
		{
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x0021658C File Offset: 0x0021478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoneyMovementLimitEvent Clone()
		{
			return null;
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x0021659C File Offset: 0x0021479C
		// (set) Token: 0x060058A0 RID: 22688 RVA: 0x002165AC File Offset: 0x002147AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Limit
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

		// Token: 0x060058A1 RID: 22689 RVA: 0x002165BC File Offset: 0x002147BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x002165CC File Offset: 0x002147CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMoneyMovementLimitEvent other)
		{
			return true;
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x002165DC File Offset: 0x002147DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x002165EC File Offset: 0x002147EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x002165FC File Offset: 0x002147FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x0021660C File Offset: 0x0021480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0021661C File Offset: 0x0021481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0021662C File Offset: 0x0021482C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMoneyMovementLimitEvent other)
		{
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0021663C File Offset: 0x0021483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x0021664C File Offset: 0x0021484C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x0021665C File Offset: 0x0021485C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMoneyMovementLimitEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangeMoneyMovementLimitEvent._parser = new MessageParser<ExchangeMoneyMovementLimitEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x00216728 File Offset: 0x00214928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G2IVRgOuyCf6NiEjSbHH()
		{
			return true;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x00216730 File Offset: 0x00214930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMoneyMovementLimitEvent zIC9cMOu6y1JJCiG24qH()
		{
			return null;
		}

		// Token: 0x04001F0A RID: 7946
		private static readonly MessageParser<ExchangeMoneyMovementLimitEvent> _parser;

		// Token: 0x04001F0B RID: 7947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F0C RID: 7948
		public const int LimitFieldNumber = 1;

		// Token: 0x04001F0D RID: 7949
		private long limit_;

		// Token: 0x04001F0E RID: 7950
		private static ExchangeMoneyMovementLimitEvent WaffBQOu5l64uDtJVvV2;
	}
}
