using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A93 RID: 2707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterLightInformation : IMessage<FighterLightInformation>, IMessage, IEquatable<FighterLightInformation>, IDeepCloneable<FighterLightInformation>, IBufferMessage
	{
		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06008135 RID: 33077 RVA: 0x00260E4C File Offset: 0x0025F04C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FighterLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x00260E5C File Offset: 0x0025F05C
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

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06008137 RID: 33079 RVA: 0x00260E6C File Offset: 0x0025F06C
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

		// Token: 0x06008138 RID: 33080 RVA: 0x00260E7C File Offset: 0x0025F07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterLightInformation()
		{
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x00260E8C File Offset: 0x0025F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterLightInformation(FighterLightInformation other)
		{
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x00260E9C File Offset: 0x0025F09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterLightInformation Clone()
		{
			return null;
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x0600813B RID: 33083 RVA: 0x00260EAC File Offset: 0x0025F0AC
		// (set) Token: 0x0600813C RID: 33084 RVA: 0x00260EBC File Offset: 0x0025F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x0600813D RID: 33085 RVA: 0x00260ECC File Offset: 0x0025F0CC
		// (set) Token: 0x0600813E RID: 33086 RVA: 0x00260EDC File Offset: 0x0025F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Wave
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

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x0600813F RID: 33087 RVA: 0x00260EEC File Offset: 0x0025F0EC
		// (set) Token: 0x06008140 RID: 33088 RVA: 0x00260EFC File Offset: 0x0025F0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06008141 RID: 33089 RVA: 0x00260F0C File Offset: 0x0025F10C
		// (set) Token: 0x06008142 RID: 33090 RVA: 0x00260F1C File Offset: 0x0025F11C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BreedId
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

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06008143 RID: 33091 RVA: 0x00260F2C File Offset: 0x0025F12C
		// (set) Token: 0x06008144 RID: 33092 RVA: 0x00260F40 File Offset: 0x0025F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06008145 RID: 33093 RVA: 0x00260F50 File Offset: 0x0025F150
		// (set) Token: 0x06008146 RID: 33094 RVA: 0x00260F60 File Offset: 0x0025F160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Alive
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

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06008147 RID: 33095 RVA: 0x00260F70 File Offset: 0x0025F170
		// (set) Token: 0x06008148 RID: 33096 RVA: 0x00260F80 File Offset: 0x0025F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterMonsterLightInformation MonsterInformation
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

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06008149 RID: 33097 RVA: 0x00260F90 File Offset: 0x0025F190
		// (set) Token: 0x0600814A RID: 33098 RVA: 0x00260FA0 File Offset: 0x0025F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterEntityLightInformation EntityInformation
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x0600814B RID: 33099 RVA: 0x00260FB0 File Offset: 0x0025F1B0
		// (set) Token: 0x0600814C RID: 33100 RVA: 0x00260FC0 File Offset: 0x0025F1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterTaxCollectorLightInformation TaxCollectorInformation
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

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600814D RID: 33101 RVA: 0x00260FD0 File Offset: 0x0025F1D0
		// (set) Token: 0x0600814E RID: 33102 RVA: 0x00260FE0 File Offset: 0x0025F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterNamedLightInformation NamedInformation
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

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600814F RID: 33103 RVA: 0x00260FF0 File Offset: 0x0025F1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FighterLightInformation.FighterInfoOneofCase FighterInfoCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FighterLightInformation.FighterInfoOneofCase)null;
			}
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x00261004 File Offset: 0x0025F204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearFighterInfo()
		{
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x00261014 File Offset: 0x0025F214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00261024 File Offset: 0x0025F224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterLightInformation other)
		{
			return true;
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x00261034 File Offset: 0x0025F234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x00261044 File Offset: 0x0025F244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00261054 File Offset: 0x0025F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x00261064 File Offset: 0x0025F264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x00261074 File Offset: 0x0025F274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x00261084 File Offset: 0x0025F284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterLightInformation other)
		{
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x00261094 File Offset: 0x0025F294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x002610A4 File Offset: 0x0025F2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x002610B4 File Offset: 0x0025F2B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterLightInformation()
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
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_82;
					}
					FighterLightInformation._parser = new MessageParser<FighterLightInformation>(() => null);
					num2 = 2;
				}
				IL_82:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x00261184 File Offset: 0x0025F384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lE95NkJgLgKdgQ0oco0l()
		{
			return true;
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x0026118C File Offset: 0x0025F38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterLightInformation pLwWbwJgWJBCLeqMJVSe()
		{
			return null;
		}

		// Token: 0x04002EF9 RID: 12025
		private static readonly MessageParser<FighterLightInformation> _parser;

		// Token: 0x04002EFA RID: 12026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EFB RID: 12027
		public const int IdFieldNumber = 1;

		// Token: 0x04002EFC RID: 12028
		private long id_;

		// Token: 0x04002EFD RID: 12029
		public const int WaveFieldNumber = 2;

		// Token: 0x04002EFE RID: 12030
		private int wave_;

		// Token: 0x04002EFF RID: 12031
		public const int LevelFieldNumber = 3;

		// Token: 0x04002F00 RID: 12032
		private int level_;

		// Token: 0x04002F01 RID: 12033
		public const int BreedIdFieldNumber = 4;

		// Token: 0x04002F02 RID: 12034
		private int breedId_;

		// Token: 0x04002F03 RID: 12035
		public const int GenderFieldNumber = 5;

		// Token: 0x04002F04 RID: 12036
		private Gender gender_;

		// Token: 0x04002F05 RID: 12037
		public const int AliveFieldNumber = 6;

		// Token: 0x04002F06 RID: 12038
		private bool alive_;

		// Token: 0x04002F07 RID: 12039
		public const int MonsterInformationFieldNumber = 7;

		// Token: 0x04002F08 RID: 12040
		public const int EntityInformationFieldNumber = 8;

		// Token: 0x04002F09 RID: 12041
		public const int TaxCollectorInformationFieldNumber = 9;

		// Token: 0x04002F0A RID: 12042
		public const int NamedInformationFieldNumber = 10;

		// Token: 0x04002F0B RID: 12043
		private object fighterInfo_;

		// Token: 0x04002F0C RID: 12044
		private FighterLightInformation.FighterInfoOneofCase fighterInfoCase_;

		// Token: 0x04002F0D RID: 12045
		private static FighterLightInformation Y3jm7xJg6lwv2D1ycJ13;

		// Token: 0x02000A94 RID: 2708
		public enum FighterInfoOneofCase
		{
			// Token: 0x04002F0F RID: 12047
			None,
			// Token: 0x04002F10 RID: 12048
			MonsterInformation = 7,
			// Token: 0x04002F11 RID: 12049
			EntityInformation,
			// Token: 0x04002F12 RID: 12050
			TaxCollectorInformation,
			// Token: 0x04002F13 RID: 12051
			NamedInformation
		}
	}
}
