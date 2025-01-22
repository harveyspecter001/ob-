using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000690 RID: 1680
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightResume : IMessage<FightResume>, IMessage, IEquatable<FightResume>, IDeepCloneable<FightResume>, IBufferMessage
	{
		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x0020687C File Offset: 0x00204A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightResume> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x0020688C File Offset: 0x00204A8C
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x0020689C File Offset: 0x00204A9C
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

		// Token: 0x060051E3 RID: 20963 RVA: 0x002068AC File Offset: 0x00204AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResume()
		{
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x002068BC File Offset: 0x00204ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResume(FightResume other)
		{
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x002068CC File Offset: 0x00204ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResume Clone()
		{
			return null;
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x002068DC File Offset: 0x00204ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightSpellCoolDown> SpellsCoolDown
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x002068EC File Offset: 0x00204AEC
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x002068FC File Offset: 0x00204AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonCount
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

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x0020690C File Offset: 0x00204B0C
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x0020691C File Offset: 0x00204B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BombCount
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

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x0020692C File Offset: 0x00204B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FightResumeSlaves> SlavesInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x0020693C File Offset: 0x00204B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x0020694C File Offset: 0x00204B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightResume other)
		{
			return true;
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x0020695C File Offset: 0x00204B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x0020696C File Offset: 0x00204B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x0020697C File Offset: 0x00204B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x0020698C File Offset: 0x00204B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x0020699C File Offset: 0x00204B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x002069AC File Offset: 0x00204BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightResume other)
		{
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x002069BC File Offset: 0x00204BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x002069CC File Offset: 0x00204BCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x002069DC File Offset: 0x00204BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightResume()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 6;
						continue;
					case 2:
						goto IL_55;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_3D;
					case 5:
						FightResume._repeated_slavesInformation_codec = FieldCodec.ForMessage<FightResumeSlaves>(34U, Id4irQABNMfc5ArIDaHc.XVInXhlssT(Id4irQABNMfc5ArIDaHc.TUBABxrUwBV));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						FightResume._parser = new MessageParser<FightResume>(() => null);
						num2 = 2;
						continue;
					}
					return;
				}
				IL_3D:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				IL_55:
				FightResume._repeated_spellsCoolDown_codec = FieldCodec.ForMessage<FightSpellCoolDown>(10U, UPEbMBABEjtySQ5BMeko.XVInXhlssT(UPEbMBABEjtySQ5BMeko.WG3ABX9exxJ));
				num = 5;
			}
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00206AF8 File Offset: 0x00204CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HXy5etOPUORXHo22rTbq()
		{
			return true;
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00206B00 File Offset: 0x00204D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightResume QeTAXLOPvkelgrBs5gIP()
		{
			return null;
		}

		// Token: 0x04001CDA RID: 7386
		private static readonly MessageParser<FightResume> _parser;

		// Token: 0x04001CDB RID: 7387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CDC RID: 7388
		public const int SpellsCoolDownFieldNumber = 1;

		// Token: 0x04001CDD RID: 7389
		private static readonly FieldCodec<FightSpellCoolDown> _repeated_spellsCoolDown_codec;

		// Token: 0x04001CDE RID: 7390
		private readonly RepeatedField<FightSpellCoolDown> spellsCoolDown_;

		// Token: 0x04001CDF RID: 7391
		public const int SummonCountFieldNumber = 2;

		// Token: 0x04001CE0 RID: 7392
		private int summonCount_;

		// Token: 0x04001CE1 RID: 7393
		public const int BombCountFieldNumber = 3;

		// Token: 0x04001CE2 RID: 7394
		private int bombCount_;

		// Token: 0x04001CE3 RID: 7395
		public const int SlavesInformationFieldNumber = 4;

		// Token: 0x04001CE4 RID: 7396
		private static readonly FieldCodec<FightResumeSlaves> _repeated_slavesInformation_codec;

		// Token: 0x04001CE5 RID: 7397
		private readonly RepeatedField<FightResumeSlaves> slavesInformation_;

		// Token: 0x04001CE6 RID: 7398
		internal static FightResume R5lBoqOPcWYTOTCeC1SE;
	}
}
