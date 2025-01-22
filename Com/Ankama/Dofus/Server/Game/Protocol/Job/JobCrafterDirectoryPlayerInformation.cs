using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003D7 RID: 983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryPlayerInformation : IMessage<JobCrafterDirectoryPlayerInformation>, IMessage, IEquatable<JobCrafterDirectoryPlayerInformation>, IDeepCloneable<JobCrafterDirectoryPlayerInformation>, IBufferMessage
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x001CEB24 File Offset: 0x001CCD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobCrafterDirectoryPlayerInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x001CEB34 File Offset: 0x001CCD34
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x001CEB44 File Offset: 0x001CCD44
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

		// Token: 0x06002E1D RID: 11805 RVA: 0x001CEB54 File Offset: 0x001CCD54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryPlayerInformation()
		{
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x001CEB64 File Offset: 0x001CCD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryPlayerInformation(JobCrafterDirectoryPlayerInformation other)
		{
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x001CEB74 File Offset: 0x001CCD74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryPlayerInformation Clone()
		{
			return null;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x001CEB84 File Offset: 0x001CCD84
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x001CEB94 File Offset: 0x001CCD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x001CEBA4 File Offset: 0x001CCDA4
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x001CEBB4 File Offset: 0x001CCDB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x001CEBC4 File Offset: 0x001CCDC4
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x001CEBD8 File Offset: 0x001CCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Alignment Alignment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Alignment)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x001CEBE8 File Offset: 0x001CCDE8
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x001CEBF8 File Offset: 0x001CCDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Breed
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x001CEC08 File Offset: 0x001CCE08
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x001CEC1C File Offset: 0x001CCE1C
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x001CEC2C File Offset: 0x001CCE2C
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x001CEC3C File Offset: 0x001CCE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInWorkshop
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x001CEC4C File Offset: 0x001CCE4C
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x001CEC5C File Offset: 0x001CCE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapExtendedCoordinates Coordinates
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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x001CEC6C File Offset: 0x001CCE6C
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x001CEC7C File Offset: 0x001CCE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanCraftLegendary
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x001CEC8C File Offset: 0x001CCE8C
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x001CEC9C File Offset: 0x001CCE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterStatus Status
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

		// Token: 0x06002E32 RID: 11826 RVA: 0x001CECAC File Offset: 0x001CCEAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x001CECBC File Offset: 0x001CCEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryPlayerInformation other)
		{
			return true;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x001CECCC File Offset: 0x001CCECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x001CECDC File Offset: 0x001CCEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x001CECEC File Offset: 0x001CCEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x001CECFC File Offset: 0x001CCEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x001CED0C File Offset: 0x001CCF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x001CED1C File Offset: 0x001CCF1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryPlayerInformation other)
		{
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x001CED2C File Offset: 0x001CCF2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x001CED3C File Offset: 0x001CCF3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x001CED4C File Offset: 0x001CCF4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryPlayerInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					JobCrafterDirectoryPlayerInformation._parser = new MessageParser<JobCrafterDirectoryPlayerInformation>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x001CEE30 File Offset: 0x001CD030
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool scripfO0mXt39yRh7FS1()
		{
			return true;
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x001CEE38 File Offset: 0x001CD038
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryPlayerInformation rxA0mNO0AmXLio52QCMu()
		{
			return null;
		}

		// Token: 0x04001033 RID: 4147
		private static readonly MessageParser<JobCrafterDirectoryPlayerInformation> _parser;

		// Token: 0x04001034 RID: 4148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001035 RID: 4149
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001036 RID: 4150
		private long playerId_;

		// Token: 0x04001037 RID: 4151
		public const int NameFieldNumber = 2;

		// Token: 0x04001038 RID: 4152
		private string name_;

		// Token: 0x04001039 RID: 4153
		public const int AlignmentFieldNumber = 3;

		// Token: 0x0400103A RID: 4154
		private Alignment alignment_;

		// Token: 0x0400103B RID: 4155
		public const int BreedFieldNumber = 4;

		// Token: 0x0400103C RID: 4156
		private int breed_;

		// Token: 0x0400103D RID: 4157
		public const int GenderFieldNumber = 5;

		// Token: 0x0400103E RID: 4158
		private Gender gender_;

		// Token: 0x0400103F RID: 4159
		public const int IsInWorkshopFieldNumber = 6;

		// Token: 0x04001040 RID: 4160
		private bool isInWorkshop_;

		// Token: 0x04001041 RID: 4161
		public const int CoordinatesFieldNumber = 7;

		// Token: 0x04001042 RID: 4162
		private MapExtendedCoordinates coordinates_;

		// Token: 0x04001043 RID: 4163
		public const int CanCraftLegendaryFieldNumber = 8;

		// Token: 0x04001044 RID: 4164
		private bool canCraftLegendary_;

		// Token: 0x04001045 RID: 4165
		public const int StatusFieldNumber = 9;

		// Token: 0x04001046 RID: 4166
		private CharacterStatus status_;

		// Token: 0x04001047 RID: 4167
		private static JobCrafterDirectoryPlayerInformation Uwtk1lO0nZFYxrJ5QreA;
	}
}
