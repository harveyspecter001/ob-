using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration
{
	// Token: 0x02000CF3 RID: 3315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Alteration : IMessage<Alteration>, IMessage, IEquatable<Alteration>, IDeepCloneable<Alteration>, IBufferMessage
	{
		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x00285AC8 File Offset: 0x00283CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Alteration> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x00285AD8 File Offset: 0x00283CD8
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

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x00285AE8 File Offset: 0x00283CE8
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

		// Token: 0x06009F90 RID: 40848 RVA: 0x00285AF8 File Offset: 0x00283CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Alteration()
		{
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x00285B08 File Offset: 0x00283D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Alteration(Alteration other)
		{
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x00285B18 File Offset: 0x00283D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Alteration Clone()
		{
			return null;
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06009F93 RID: 40851 RVA: 0x00285B28 File Offset: 0x00283D28
		// (set) Token: 0x06009F94 RID: 40852 RVA: 0x00285B38 File Offset: 0x00283D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AlterationId
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

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x00285B48 File Offset: 0x00283D48
		// (set) Token: 0x06009F96 RID: 40854 RVA: 0x00285B58 File Offset: 0x00283D58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CreationTime
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

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x00285B68 File Offset: 0x00283D68
		// (set) Token: 0x06009F98 RID: 40856 RVA: 0x00285B7C File Offset: 0x00283D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Alteration.Types.AlterationExpirationType ExpirationType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Alteration.Types.AlterationExpirationType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06009F99 RID: 40857 RVA: 0x00285B8C File Offset: 0x00283D8C
		// (set) Token: 0x06009F9A RID: 40858 RVA: 0x00285B9C File Offset: 0x00283D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpirationValue
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

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x00285BAC File Offset: 0x00283DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x00285BBC File Offset: 0x00283DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x00285BCC File Offset: 0x00283DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Alteration other)
		{
			return true;
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00285BDC File Offset: 0x00283DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x00285BEC File Offset: 0x00283DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x00285BFC File Offset: 0x00283DFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x00285C0C File Offset: 0x00283E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x00285C1C File Offset: 0x00283E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x00285C2C File Offset: 0x00283E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Alteration other)
		{
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x00285C3C File Offset: 0x00283E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x00285C4C File Offset: 0x00283E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x00285C5C File Offset: 0x00283E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Alteration()
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
					num2 = 5;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				case 5:
					Alteration._parser = new MessageParser<Alteration>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				Alteration._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(42U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x00285D64 File Offset: 0x00283F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dK6Dl4Jjy8D7m1tpiX1v()
		{
			return true;
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x00285D6C File Offset: 0x00283F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Alteration icjJ9RJj6eC2ZF63LHl6()
		{
			return null;
		}

		// Token: 0x04003B12 RID: 15122
		private static readonly MessageParser<Alteration> _parser;

		// Token: 0x04003B13 RID: 15123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B14 RID: 15124
		public const int AlterationIdFieldNumber = 1;

		// Token: 0x04003B15 RID: 15125
		private long alterationId_;

		// Token: 0x04003B16 RID: 15126
		public const int CreationTimeFieldNumber = 2;

		// Token: 0x04003B17 RID: 15127
		private long creationTime_;

		// Token: 0x04003B18 RID: 15128
		public const int ExpirationTypeFieldNumber = 3;

		// Token: 0x04003B19 RID: 15129
		private Alteration.Types.AlterationExpirationType expirationType_;

		// Token: 0x04003B1A RID: 15130
		public const int ExpirationValueFieldNumber = 4;

		// Token: 0x04003B1B RID: 15131
		private long expirationValue_;

		// Token: 0x04003B1C RID: 15132
		public const int EffectsFieldNumber = 5;

		// Token: 0x04003B1D RID: 15133
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04003B1E RID: 15134
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04003B1F RID: 15135
		internal static Alteration PqNEL5Jj5eIcQeEExWVu;

		// Token: 0x02000CF4 RID: 3316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06009FA9 RID: 40873 RVA: 0x002EC894 File Offset: 0x002EAA94
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000CF5 RID: 3317
			public enum AlterationExpirationType
			{
				// Token: 0x04003B21 RID: 15137
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x04003B22 RID: 15138
				[OriginalName("INFINITE")]
				Infinite,
				// Token: 0x04003B23 RID: 15139
				[OriginalName("DATE")]
				Date,
				// Token: 0x04003B24 RID: 15140
				[OriginalName("FIGHT_COUNT")]
				FightCount,
				// Token: 0x04003B25 RID: 15141
				[OriginalName("FIGHTS_WON_COUNT")]
				FightsWonCount,
				// Token: 0x04003B26 RID: 15142
				[OriginalName("FIGHTS_LOST_COUNT")]
				FightsLostCount
			}
		}
	}
}
