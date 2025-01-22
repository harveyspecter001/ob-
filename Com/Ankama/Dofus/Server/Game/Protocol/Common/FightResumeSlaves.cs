using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AD9 RID: 2777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightResumeSlaves : IMessage<FightResumeSlaves>, IMessage, IEquatable<FightResumeSlaves>, IDeepCloneable<FightResumeSlaves>, IBufferMessage
	{
		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060084BF RID: 33983 RVA: 0x00264AE8 File Offset: 0x00262CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightResumeSlaves> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060084C0 RID: 33984 RVA: 0x00264AF8 File Offset: 0x00262CF8
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

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060084C1 RID: 33985 RVA: 0x00264B08 File Offset: 0x00262D08
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

		// Token: 0x060084C2 RID: 33986 RVA: 0x00264B18 File Offset: 0x00262D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResumeSlaves()
		{
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00264B28 File Offset: 0x00262D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResumeSlaves(FightResumeSlaves other)
		{
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x00264B38 File Offset: 0x00262D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResumeSlaves Clone()
		{
			return null;
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060084C5 RID: 33989 RVA: 0x00264B48 File Offset: 0x00262D48
		// (set) Token: 0x060084C6 RID: 33990 RVA: 0x00264B58 File Offset: 0x00262D58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SlaveId
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

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x00264B68 File Offset: 0x00262D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightSpellCoolDown> SpellCoolDowns
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060084C8 RID: 33992 RVA: 0x00264B78 File Offset: 0x00262D78
		// (set) Token: 0x060084C9 RID: 33993 RVA: 0x00264B88 File Offset: 0x00262D88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060084CA RID: 33994 RVA: 0x00264B98 File Offset: 0x00262D98
		// (set) Token: 0x060084CB RID: 33995 RVA: 0x00264BA8 File Offset: 0x00262DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060084CC RID: 33996 RVA: 0x00264BB8 File Offset: 0x00262DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00264BC8 File Offset: 0x00262DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightResumeSlaves other)
		{
			return true;
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x00264BD8 File Offset: 0x00262DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x00264BE8 File Offset: 0x00262DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x00264BF8 File Offset: 0x00262DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x00264C08 File Offset: 0x00262E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00264C18 File Offset: 0x00262E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x00264C28 File Offset: 0x00262E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightResumeSlaves other)
		{
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x00264C38 File Offset: 0x00262E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x00264C48 File Offset: 0x00262E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x00264C58 File Offset: 0x00262E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightResumeSlaves()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_39;
					case 4:
						FightResumeSlaves._parser = new MessageParser<FightResumeSlaves>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					goto Block_1;
				}
				IL_39:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				IL_9E:
				FightResumeSlaves._repeated_spellCoolDowns_codec = FieldCodec.ForMessage<FightSpellCoolDown>(18U, UPEbMBABEjtySQ5BMeko.XVInXhlssT(UPEbMBABEjtySQ5BMeko.WG3ABX9exxJ));
				num = 5;
				continue;
				Block_1:
				goto IL_9E;
			}
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x00264D50 File Offset: 0x00262F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o0kV28JsQ62hAm4NYiMi()
		{
			return true;
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x00264D58 File Offset: 0x00262F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightResumeSlaves NhpIxyJs7mMMtlobmMbc()
		{
			return null;
		}

		// Token: 0x0400308C RID: 12428
		private static readonly MessageParser<FightResumeSlaves> _parser;

		// Token: 0x0400308D RID: 12429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400308E RID: 12430
		public const int SlaveIdFieldNumber = 1;

		// Token: 0x0400308F RID: 12431
		private long slaveId_;

		// Token: 0x04003090 RID: 12432
		public const int SpellCoolDownsFieldNumber = 2;

		// Token: 0x04003091 RID: 12433
		private static readonly FieldCodec<FightSpellCoolDown> _repeated_spellCoolDowns_codec;

		// Token: 0x04003092 RID: 12434
		private readonly RepeatedField<FightSpellCoolDown> spellCoolDowns_;

		// Token: 0x04003093 RID: 12435
		public const int SummonCountFieldNumber = 3;

		// Token: 0x04003094 RID: 12436
		private int summonCount_;

		// Token: 0x04003095 RID: 12437
		public const int BombCountFieldNumber = 4;

		// Token: 0x04003096 RID: 12438
		private int bombCount_;

		// Token: 0x04003097 RID: 12439
		private static FightResumeSlaves UGiExFJswW53cZuPA9Em;
	}
}
