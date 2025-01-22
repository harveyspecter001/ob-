using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B76 RID: 2934
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismLocalizedInformation : IMessage<PrismLocalizedInformation>, IMessage, IEquatable<PrismLocalizedInformation>, IDeepCloneable<PrismLocalizedInformation>, IBufferMessage
	{
		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x00269DE4 File Offset: 0x00267FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismLocalizedInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06008CC0 RID: 36032 RVA: 0x00269DF4 File Offset: 0x00267FF4
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

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x00269E04 File Offset: 0x00268004
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

		// Token: 0x06008CC2 RID: 36034 RVA: 0x00269E14 File Offset: 0x00268014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismLocalizedInformation()
		{
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00269E24 File Offset: 0x00268024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismLocalizedInformation(PrismLocalizedInformation other)
		{
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x00269E34 File Offset: 0x00268034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismLocalizedInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x00269E44 File Offset: 0x00268044
		// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x00269E54 File Offset: 0x00268054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubAreaId
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

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x00269E64 File Offset: 0x00268064
		// (set) Token: 0x06008CC8 RID: 36040 RVA: 0x00269E74 File Offset: 0x00268074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AllianceUid
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

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06008CC9 RID: 36041 RVA: 0x00269E84 File Offset: 0x00268084
		// (set) Token: 0x06008CCA RID: 36042 RVA: 0x00269E94 File Offset: 0x00268094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCoordinates MapCoordinates
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

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x00269EA4 File Offset: 0x002680A4
		// (set) Token: 0x06008CCC RID: 36044 RVA: 0x00269EB4 File Offset: 0x002680B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x00269EC4 File Offset: 0x002680C4
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x00269ED4 File Offset: 0x002680D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismInformation Prism
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

		// Token: 0x06008CCF RID: 36047 RVA: 0x00269EE4 File Offset: 0x002680E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x00269EF4 File Offset: 0x002680F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismLocalizedInformation other)
		{
			return true;
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x00269F04 File Offset: 0x00268104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008CD2 RID: 36050 RVA: 0x00269F14 File Offset: 0x00268114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008CD3 RID: 36051 RVA: 0x00269F24 File Offset: 0x00268124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008CD4 RID: 36052 RVA: 0x00269F34 File Offset: 0x00268134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x00269F44 File Offset: 0x00268144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x00269F54 File Offset: 0x00268154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismLocalizedInformation other)
		{
		}

		// Token: 0x06008CD7 RID: 36055 RVA: 0x00269F64 File Offset: 0x00268164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x00269F74 File Offset: 0x00268174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x00269F84 File Offset: 0x00268184
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismLocalizedInformation()
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
						return;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
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
						goto IL_AC;
					}
					PrismLocalizedInformation._parser = new MessageParser<PrismLocalizedInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 1;
					}
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06008CDA RID: 36058 RVA: 0x0026A054 File Offset: 0x00268254
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zyHgR2J9X0CM2AKbefkX()
		{
			return true;
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x0026A05C File Offset: 0x0026825C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismLocalizedInformation T9TUtoJ9NicAl6kixdt5()
		{
			return null;
		}

		// Token: 0x04003410 RID: 13328
		private static readonly MessageParser<PrismLocalizedInformation> _parser;

		// Token: 0x04003411 RID: 13329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003412 RID: 13330
		public const int SubAreaIdFieldNumber = 1;

		// Token: 0x04003413 RID: 13331
		private int subAreaId_;

		// Token: 0x04003414 RID: 13332
		public const int AllianceUidFieldNumber = 2;

		// Token: 0x04003415 RID: 13333
		private string allianceUid_;

		// Token: 0x04003416 RID: 13334
		public const int MapCoordinatesFieldNumber = 3;

		// Token: 0x04003417 RID: 13335
		private MapCoordinates mapCoordinates_;

		// Token: 0x04003418 RID: 13336
		public const int MapIdFieldNumber = 4;

		// Token: 0x04003419 RID: 13337
		private long mapId_;

		// Token: 0x0400341A RID: 13338
		public const int PrismFieldNumber = 5;

		// Token: 0x0400341B RID: 13339
		private PrismInformation prism_;

		// Token: 0x0400341C RID: 13340
		private static PrismLocalizedInformation sy08tjJ9EOnYXQMEZq5a;
	}
}
