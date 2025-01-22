using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AF6 RID: 2806
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NamedPartyTeamWithOutcome : IMessage<NamedPartyTeamWithOutcome>, IMessage, IEquatable<NamedPartyTeamWithOutcome>, IDeepCloneable<NamedPartyTeamWithOutcome>, IBufferMessage
	{
		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x00264FD8 File Offset: 0x002631D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NamedPartyTeamWithOutcome> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x00264FE8 File Offset: 0x002631E8
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

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x00264FF8 File Offset: 0x002631F8
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

		// Token: 0x06008624 RID: 34340 RVA: 0x00265008 File Offset: 0x00263208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeamWithOutcome()
		{
		}

		// Token: 0x06008625 RID: 34341 RVA: 0x00265018 File Offset: 0x00263218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeamWithOutcome(NamedPartyTeamWithOutcome other)
		{
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x00265028 File Offset: 0x00263228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeamWithOutcome Clone()
		{
			return null;
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06008627 RID: 34343 RVA: 0x00265038 File Offset: 0x00263238
		// (set) Token: 0x06008628 RID: 34344 RVA: 0x00265048 File Offset: 0x00263248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NamedPartyTeam Team
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

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06008629 RID: 34345 RVA: 0x00265058 File Offset: 0x00263258
		// (set) Token: 0x0600862A RID: 34346 RVA: 0x0026506C File Offset: 0x0026326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightOutcome Outcome
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightOutcome)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x0026507C File Offset: 0x0026327C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x0026508C File Offset: 0x0026328C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NamedPartyTeamWithOutcome other)
		{
			return true;
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x0026509C File Offset: 0x0026329C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x002650AC File Offset: 0x002632AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x002650BC File Offset: 0x002632BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x002650CC File Offset: 0x002632CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x002650DC File Offset: 0x002632DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x002650EC File Offset: 0x002632EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NamedPartyTeamWithOutcome other)
		{
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x002650FC File Offset: 0x002632FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x0026510C File Offset: 0x0026330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x0026511C File Offset: 0x0026331C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NamedPartyTeamWithOutcome()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				NamedPartyTeamWithOutcome._parser = new MessageParser<NamedPartyTeamWithOutcome>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x00265200 File Offset: 0x00263400
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fYH4aLJsb7BkWI73SiP2()
		{
			return true;
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x00265208 File Offset: 0x00263408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NamedPartyTeamWithOutcome ymmH67Jsi6YupLkfK5Ga()
		{
			return null;
		}

		// Token: 0x04003122 RID: 12578
		private static readonly MessageParser<NamedPartyTeamWithOutcome> _parser;

		// Token: 0x04003123 RID: 12579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003124 RID: 12580
		public const int TeamFieldNumber = 1;

		// Token: 0x04003125 RID: 12581
		private NamedPartyTeam team_;

		// Token: 0x04003126 RID: 12582
		public const int OutcomeFieldNumber = 2;

		// Token: 0x04003127 RID: 12583
		private FightOutcome outcome_;

		// Token: 0x04003128 RID: 12584
		private static NamedPartyTeamWithOutcome TMOYUSJsYI5ic1A0f7gT;
	}
}
