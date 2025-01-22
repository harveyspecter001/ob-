using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AC9 RID: 2761
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTemporarySpellImmunityEffect : IMessage<FightTemporarySpellImmunityEffect>, IMessage, IEquatable<FightTemporarySpellImmunityEffect>, IDeepCloneable<FightTemporarySpellImmunityEffect>, IBufferMessage
	{
		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06008400 RID: 33792 RVA: 0x00263E98 File Offset: 0x00262098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTemporarySpellImmunityEffect> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06008401 RID: 33793 RVA: 0x00263EA8 File Offset: 0x002620A8
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

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06008402 RID: 33794 RVA: 0x00263EB8 File Offset: 0x002620B8
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

		// Token: 0x06008403 RID: 33795 RVA: 0x00263EC8 File Offset: 0x002620C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporarySpellImmunityEffect()
		{
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x00263ED8 File Offset: 0x002620D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporarySpellImmunityEffect(FightTemporarySpellImmunityEffect other)
		{
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x00263EE8 File Offset: 0x002620E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporarySpellImmunityEffect Clone()
		{
			return null;
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06008406 RID: 33798 RVA: 0x00263EF8 File Offset: 0x002620F8
		// (set) Token: 0x06008407 RID: 33799 RVA: 0x00263F08 File Offset: 0x00262108
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ImmuneSpellId
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

		// Token: 0x06008408 RID: 33800 RVA: 0x00263F18 File Offset: 0x00262118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x00263F28 File Offset: 0x00262128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTemporarySpellImmunityEffect other)
		{
			return true;
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x00263F38 File Offset: 0x00262138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x00263F48 File Offset: 0x00262148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00263F58 File Offset: 0x00262158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00263F68 File Offset: 0x00262168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x00263F78 File Offset: 0x00262178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x00263F88 File Offset: 0x00262188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTemporarySpellImmunityEffect other)
		{
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00263F98 File Offset: 0x00262198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x00263FA8 File Offset: 0x002621A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x00263FB8 File Offset: 0x002621B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTemporarySpellImmunityEffect()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightTemporarySpellImmunityEffect._parser = new MessageParser<FightTemporarySpellImmunityEffect>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x0026409C File Offset: 0x0026229C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aHv8q8Js1BbmDBegHpRk()
		{
			return true;
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x002640A4 File Offset: 0x002622A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTemporarySpellImmunityEffect mEoetTJsaPQBs0PcaOWE()
		{
			return null;
		}

		// Token: 0x04003035 RID: 12341
		private static readonly MessageParser<FightTemporarySpellImmunityEffect> _parser;

		// Token: 0x04003036 RID: 12342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003037 RID: 12343
		public const int ImmuneSpellIdFieldNumber = 1;

		// Token: 0x04003038 RID: 12344
		private int immuneSpellId_;

		// Token: 0x04003039 RID: 12345
		internal static FightTemporarySpellImmunityEffect OVTZLOJsoOSw8mJwSN60;
	}
}
