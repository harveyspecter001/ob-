using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005A3 RID: 1443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMapInformationEvent : IMessage<FightMapInformationEvent>, IMessage, IEquatable<FightMapInformationEvent>, IDeepCloneable<FightMapInformationEvent>, IBufferMessage
	{
		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x001F7FEC File Offset: 0x001F61EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMapInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x001F7FFC File Offset: 0x001F61FC
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x001F800C File Offset: 0x001F620C
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

		// Token: 0x060045AD RID: 17837 RVA: 0x001F801C File Offset: 0x001F621C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationEvent()
		{
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x001F802C File Offset: 0x001F622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationEvent(FightMapInformationEvent other)
		{
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x001F803C File Offset: 0x001F623C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x001F804C File Offset: 0x001F624C
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x001F805C File Offset: 0x001F625C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubareaId
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x001F806C File Offset: 0x001F626C
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x001F807C File Offset: 0x001F627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001F808C File Offset: 0x001F628C
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x001F809C File Offset: 0x001F629C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapCoordinates Coordinates
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x001F80AC File Offset: 0x001F62AC
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x001F80BC File Offset: 0x001F62BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapComplementaryBreachInformation BreachInformation
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x001F80CC File Offset: 0x001F62CC
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x001F80DC File Offset: 0x001F62DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapComplementaryAnomalyInformation AnomalyInformation
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x001F80EC File Offset: 0x001F62EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMapInformationEvent.SpecificComplementaryInformationOneofCase SpecificComplementaryInformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightMapInformationEvent.SpecificComplementaryInformationOneofCase)null;
			}
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x001F8100 File Offset: 0x001F6300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSpecificComplementaryInformation()
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x001F8110 File Offset: 0x001F6310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x001F8120 File Offset: 0x001F6320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightMapInformationEvent other)
		{
			return true;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x001F8130 File Offset: 0x001F6330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001F8140 File Offset: 0x001F6340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x001F8150 File Offset: 0x001F6350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x001F8160 File Offset: 0x001F6360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x001F8170 File Offset: 0x001F6370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x001F8180 File Offset: 0x001F6380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightMapInformationEvent other)
		{
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x001F8190 File Offset: 0x001F6390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x001F81A0 File Offset: 0x001F63A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x001F81B0 File Offset: 0x001F63B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightMapInformationEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					FightMapInformationEvent._parser = new MessageParser<FightMapInformationEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x001F82A8 File Offset: 0x001F64A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KCySjFOY8eNAtU2K0eaf()
		{
			return true;
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x001F82B0 File Offset: 0x001F64B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightMapInformationEvent SjtebwOYZGaR35k1ZT06()
		{
			return null;
		}

		// Token: 0x04001812 RID: 6162
		private static readonly MessageParser<FightMapInformationEvent> _parser;

		// Token: 0x04001813 RID: 6163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001814 RID: 6164
		public const int SubareaIdFieldNumber = 1;

		// Token: 0x04001815 RID: 6165
		private int subareaId_;

		// Token: 0x04001816 RID: 6166
		public const int MapIdFieldNumber = 2;

		// Token: 0x04001817 RID: 6167
		private long mapId_;

		// Token: 0x04001818 RID: 6168
		public const int CoordinatesFieldNumber = 3;

		// Token: 0x04001819 RID: 6169
		public const int BreachInformationFieldNumber = 4;

		// Token: 0x0400181A RID: 6170
		public const int AnomalyInformationFieldNumber = 5;

		// Token: 0x0400181B RID: 6171
		private object specificComplementaryInformation_;

		// Token: 0x0400181C RID: 6172
		private FightMapInformationEvent.SpecificComplementaryInformationOneofCase specificComplementaryInformationCase_;

		// Token: 0x0400181D RID: 6173
		internal static FightMapInformationEvent MrjaZYOYuS78TOSgRu2K;

		// Token: 0x020005A4 RID: 1444
		public enum SpecificComplementaryInformationOneofCase
		{
			// Token: 0x0400181F RID: 6175
			None,
			// Token: 0x04001820 RID: 6176
			Coordinates = 3,
			// Token: 0x04001821 RID: 6177
			BreachInformation,
			// Token: 0x04001822 RID: 6178
			AnomalyInformation
		}
	}
}
