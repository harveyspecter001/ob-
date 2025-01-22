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
	// Token: 0x020005A6 RID: 1446
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryInHouseInformation : IMessage<MapComplementaryInHouseInformation>, IMessage, IEquatable<MapComplementaryInHouseInformation>, IDeepCloneable<MapComplementaryInHouseInformation>, IBufferMessage
	{
		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x001F82B8 File Offset: 0x001F64B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapComplementaryInHouseInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x001F82C8 File Offset: 0x001F64C8
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

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001F82D8 File Offset: 0x001F64D8
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

		// Token: 0x060045D1 RID: 17873 RVA: 0x001F82E8 File Offset: 0x001F64E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInHouseInformation()
		{
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x001F82F8 File Offset: 0x001F64F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInHouseInformation(MapComplementaryInHouseInformation other)
		{
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x001F8308 File Offset: 0x001F6508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInHouseInformation Clone()
		{
			return null;
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x001F8318 File Offset: 0x001F6518
		// (set) Token: 0x060045D5 RID: 17877 RVA: 0x001F8328 File Offset: 0x001F6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public House CurrentHouse
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

		// Token: 0x060045D6 RID: 17878 RVA: 0x001F8338 File Offset: 0x001F6538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x001F8348 File Offset: 0x001F6548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryInHouseInformation other)
		{
			return true;
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x001F8358 File Offset: 0x001F6558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x001F8368 File Offset: 0x001F6568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x001F8378 File Offset: 0x001F6578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x001F8388 File Offset: 0x001F6588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x001F8398 File Offset: 0x001F6598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x001F83A8 File Offset: 0x001F65A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryInHouseInformation other)
		{
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001F83B8 File Offset: 0x001F65B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x001F83C8 File Offset: 0x001F65C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x001F83D8 File Offset: 0x001F65D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryInHouseInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MapComplementaryInHouseInformation._parser = new MessageParser<MapComplementaryInHouseInformation>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x001F84A4 File Offset: 0x001F66A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vWNWfvOYFIeRhZJVVBoc()
		{
			return true;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x001F84AC File Offset: 0x001F66AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryInHouseInformation uDBELMOYzaA9WdL6aUMm()
		{
			return null;
		}

		// Token: 0x04001825 RID: 6181
		private static readonly MessageParser<MapComplementaryInHouseInformation> _parser;

		// Token: 0x04001826 RID: 6182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001827 RID: 6183
		public const int CurrentHouseFieldNumber = 1;

		// Token: 0x04001828 RID: 6184
		private House currentHouse_;

		// Token: 0x04001829 RID: 6185
		internal static MapComplementaryInHouseInformation BZoUdfOYq6ADshdH1iqF;
	}
}
