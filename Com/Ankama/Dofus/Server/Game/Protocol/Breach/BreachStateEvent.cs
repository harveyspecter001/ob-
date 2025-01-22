using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000983 RID: 2435
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachStateEvent : IMessage<BreachStateEvent>, IMessage, IEquatable<BreachStateEvent>, IDeepCloneable<BreachStateEvent>, IBufferMessage
	{
		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060075D3 RID: 30163 RVA: 0x0024362C File Offset: 0x0024182C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060075D4 RID: 30164 RVA: 0x0024363C File Offset: 0x0024183C
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060075D5 RID: 30165 RVA: 0x0024364C File Offset: 0x0024184C
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

		// Token: 0x060075D6 RID: 30166 RVA: 0x0024365C File Offset: 0x0024185C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachStateEvent()
		{
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x0024366C File Offset: 0x0024186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachStateEvent(BreachStateEvent other)
		{
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x0024367C File Offset: 0x0024187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachStateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060075D9 RID: 30169 RVA: 0x0024368C File Offset: 0x0024188C
		// (set) Token: 0x060075DA RID: 30170 RVA: 0x0024369C File Offset: 0x0024189C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character Owner
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

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060075DB RID: 30171 RVA: 0x002436AC File Offset: 0x002418AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectEffect> Bonuses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x002436BC File Offset: 0x002418BC
		// (set) Token: 0x060075DD RID: 30173 RVA: 0x002436CC File Offset: 0x002418CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Budget
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

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x002436DC File Offset: 0x002418DC
		// (set) Token: 0x060075DF RID: 30175 RVA: 0x002436EC File Offset: 0x002418EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Saved
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

		// Token: 0x060075E0 RID: 30176 RVA: 0x002436FC File Offset: 0x002418FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x0024370C File Offset: 0x0024190C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachStateEvent other)
		{
			return true;
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x0024371C File Offset: 0x0024191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x0024372C File Offset: 0x0024192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x0024373C File Offset: 0x0024193C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x0024374C File Offset: 0x0024194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x0024375C File Offset: 0x0024195C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x0024376C File Offset: 0x0024196C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachStateEvent other)
		{
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x0024377C File Offset: 0x0024197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x0024378C File Offset: 0x0024198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x0024379C File Offset: 0x0024199C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachStateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BreachStateEvent._repeated_bonuses_codec = FieldCodec.ForMessage<ObjectEffect>(18U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					BreachStateEvent._parser = new MessageParser<BreachStateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x002438A4 File Offset: 0x00241AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DPs55YJRhXdvLX9ZSj5k()
		{
			return true;
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x002438AC File Offset: 0x00241AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachStateEvent E3QOtwJRrRYYhKR17ZOO()
		{
			return null;
		}

		// Token: 0x04002903 RID: 10499
		private static readonly MessageParser<BreachStateEvent> _parser;

		// Token: 0x04002904 RID: 10500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002905 RID: 10501
		public const int OwnerFieldNumber = 1;

		// Token: 0x04002906 RID: 10502
		private Character owner_;

		// Token: 0x04002907 RID: 10503
		public const int BonusesFieldNumber = 2;

		// Token: 0x04002908 RID: 10504
		private static readonly FieldCodec<ObjectEffect> _repeated_bonuses_codec;

		// Token: 0x04002909 RID: 10505
		private readonly RepeatedField<ObjectEffect> bonuses_;

		// Token: 0x0400290A RID: 10506
		public const int BudgetFieldNumber = 3;

		// Token: 0x0400290B RID: 10507
		private int budget_;

		// Token: 0x0400290C RID: 10508
		public const int SavedFieldNumber = 4;

		// Token: 0x0400290D RID: 10509
		private bool saved_;

		// Token: 0x0400290E RID: 10510
		private static BreachStateEvent gDFj9YJRWXqcOQamQacc;
	}
}
