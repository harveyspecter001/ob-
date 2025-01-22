using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C16 RID: 3094
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaFightPropositionEvent : IMessage<ArenaFightPropositionEvent>, IMessage, IEquatable<ArenaFightPropositionEvent>, IDeepCloneable<ArenaFightPropositionEvent>, IBufferMessage
	{
		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06009498 RID: 38040 RVA: 0x00276614 File Offset: 0x00274814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ArenaFightPropositionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x00276624 File Offset: 0x00274824
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

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x00276634 File Offset: 0x00274834
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

		// Token: 0x0600949B RID: 38043 RVA: 0x00276644 File Offset: 0x00274844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightPropositionEvent()
		{
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00276654 File Offset: 0x00274854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightPropositionEvent(ArenaFightPropositionEvent other)
		{
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00276664 File Offset: 0x00274864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightPropositionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600949E RID: 38046 RVA: 0x00276674 File Offset: 0x00274874
		// (set) Token: 0x0600949F RID: 38047 RVA: 0x00276684 File Offset: 0x00274884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x060094A0 RID: 38048 RVA: 0x00276694 File Offset: 0x00274894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> Allies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x060094A1 RID: 38049 RVA: 0x002766A4 File Offset: 0x002748A4
		// (set) Token: 0x060094A2 RID: 38050 RVA: 0x002766B4 File Offset: 0x002748B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Duration
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

		// Token: 0x060094A3 RID: 38051 RVA: 0x002766C4 File Offset: 0x002748C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x002766D4 File Offset: 0x002748D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaFightPropositionEvent other)
		{
			return true;
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x002766E4 File Offset: 0x002748E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x002766F4 File Offset: 0x002748F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00276704 File Offset: 0x00274904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00276714 File Offset: 0x00274914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00276724 File Offset: 0x00274924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x00276734 File Offset: 0x00274934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaFightPropositionEvent other)
		{
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x00276744 File Offset: 0x00274944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x00276754 File Offset: 0x00274954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00276764 File Offset: 0x00274964
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaFightPropositionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					ArenaFightPropositionEvent._repeated_allies_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(18U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					ArenaFightPropositionEvent._parser = new MessageParser<ArenaFightPropositionEvent>(() => null);
					num2 = 3;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x00276864 File Offset: 0x00274A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aNcSwHJXI3wD0RZbbq9I()
		{
			return true;
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x0027686C File Offset: 0x00274A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaFightPropositionEvent gjF1NHJXkmsEjCiKRLfA()
		{
			return null;
		}

		// Token: 0x0400374F RID: 14159
		private static readonly MessageParser<ArenaFightPropositionEvent> _parser;

		// Token: 0x04003750 RID: 14160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003751 RID: 14161
		public const int FightIdFieldNumber = 1;

		// Token: 0x04003752 RID: 14162
		private int fightId_;

		// Token: 0x04003753 RID: 14163
		public const int AlliesFieldNumber = 2;

		// Token: 0x04003754 RID: 14164
		private static readonly FieldCodec<long> _repeated_allies_codec;

		// Token: 0x04003755 RID: 14165
		private readonly RepeatedField<long> allies_;

		// Token: 0x04003756 RID: 14166
		public const int DurationFieldNumber = 3;

		// Token: 0x04003757 RID: 14167
		private int duration_;

		// Token: 0x04003758 RID: 14168
		internal static ArenaFightPropositionEvent zgp1TyJXKnQ53pqhLiqd;
	}
}
