using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008BF RID: 2239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightChoiceSelectionEvent : IMessage<FightChoiceSelectionEvent>, IMessage, IEquatable<FightChoiceSelectionEvent>, IDeepCloneable<FightChoiceSelectionEvent>, IBufferMessage
	{
		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x0023382C File Offset: 0x00231A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightChoiceSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x0023383C File Offset: 0x00231A3C
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

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06006CC6 RID: 27846 RVA: 0x0023384C File Offset: 0x00231A4C
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

		// Token: 0x06006CC7 RID: 27847 RVA: 0x0023385C File Offset: 0x00231A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChoiceSelectionEvent()
		{
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x0023386C File Offset: 0x00231A6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChoiceSelectionEvent(FightChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x0023387C File Offset: 0x00231A7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChoiceSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x0023388C File Offset: 0x00231A8C
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x0023389C File Offset: 0x00231A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SelectionId
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

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x002338AC File Offset: 0x00231AAC
		// (set) Token: 0x06006CCD RID: 27853 RVA: 0x002338BC File Offset: 0x00231ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetProtocolId
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

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06006CCE RID: 27854 RVA: 0x002338CC File Offset: 0x00231ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Choice> Choices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x002338DC File Offset: 0x00231ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x002338EC File Offset: 0x00231AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightChoiceSelectionEvent other)
		{
			return true;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x002338FC File Offset: 0x00231AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x0023390C File Offset: 0x00231B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0023391C File Offset: 0x00231B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0023392C File Offset: 0x00231B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x0023393C File Offset: 0x00231B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x0023394C File Offset: 0x00231B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x0023395C File Offset: 0x00231B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0023396C File Offset: 0x00231B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x0023397C File Offset: 0x00231B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightChoiceSelectionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					FightChoiceSelectionEvent._parser = new MessageParser<FightChoiceSelectionEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 5:
					FightChoiceSelectionEvent._repeated_choices_codec = FieldCodec.ForMessage<Choice>(26U, XAvjf4AFsp8kAsD4PKSO.XVInXhlssT(XAvjf4AFsp8kAsD4PKSO.dZLAFd1pAov));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x00233AAC File Offset: 0x00231CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KrQDo1JA2MUHutpxODU5()
		{
			return true;
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00233AB4 File Offset: 0x00231CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightChoiceSelectionEvent uJVacqJAEtE1xhNUhNDM()
		{
			return null;
		}

		// Token: 0x040025EF RID: 9711
		private static readonly MessageParser<FightChoiceSelectionEvent> _parser;

		// Token: 0x040025F0 RID: 9712
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025F1 RID: 9713
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x040025F2 RID: 9714
		private int selectionId_;

		// Token: 0x040025F3 RID: 9715
		public const int TargetProtocolIdFieldNumber = 2;

		// Token: 0x040025F4 RID: 9716
		private long targetProtocolId_;

		// Token: 0x040025F5 RID: 9717
		public const int ChoicesFieldNumber = 3;

		// Token: 0x040025F6 RID: 9718
		private static readonly FieldCodec<Choice> _repeated_choices_codec;

		// Token: 0x040025F7 RID: 9719
		private readonly RepeatedField<Choice> choices_;

		// Token: 0x040025F8 RID: 9720
		internal static FightChoiceSelectionEvent CLysdiJA9cg2NwBpfJql;
	}
}
