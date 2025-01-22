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
	// Token: 0x020005A8 RID: 1448
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryWithCoordsInformation : IMessage<MapComplementaryWithCoordsInformation>, IMessage, IEquatable<MapComplementaryWithCoordsInformation>, IDeepCloneable<MapComplementaryWithCoordsInformation>, IBufferMessage
	{
		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x001F84B4 File Offset: 0x001F66B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapComplementaryWithCoordsInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x001F84C4 File Offset: 0x001F66C4
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x001F84D4 File Offset: 0x001F66D4
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

		// Token: 0x060045EB RID: 17899 RVA: 0x001F84E4 File Offset: 0x001F66E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryWithCoordsInformation()
		{
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x001F84F4 File Offset: 0x001F66F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryWithCoordsInformation(MapComplementaryWithCoordsInformation other)
		{
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x001F8504 File Offset: 0x001F6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryWithCoordsInformation Clone()
		{
			return null;
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x001F8514 File Offset: 0x001F6714
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x001F8524 File Offset: 0x001F6724
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

		// Token: 0x060045F0 RID: 17904 RVA: 0x001F8534 File Offset: 0x001F6734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x001F8544 File Offset: 0x001F6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryWithCoordsInformation other)
		{
			return true;
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x001F8554 File Offset: 0x001F6754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x001F8564 File Offset: 0x001F6764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x001F8574 File Offset: 0x001F6774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x001F8584 File Offset: 0x001F6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x001F8594 File Offset: 0x001F6794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x001F85A4 File Offset: 0x001F67A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryWithCoordsInformation other)
		{
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x001F85B4 File Offset: 0x001F67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x001F85C4 File Offset: 0x001F67C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x001F85D4 File Offset: 0x001F67D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryWithCoordsInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					MapComplementaryWithCoordsInformation._parser = new MessageParser<MapComplementaryWithCoordsInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x001F86CC File Offset: 0x001F68CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y8CygcObnFyhPjLQym0J()
		{
			return true;
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x001F86D4 File Offset: 0x001F68D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryWithCoordsInformation lTm4YFObmsNwFQuvJmmc()
		{
			return null;
		}

		// Token: 0x0400182C RID: 6188
		private static readonly MessageParser<MapComplementaryWithCoordsInformation> _parser;

		// Token: 0x0400182D RID: 6189
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400182E RID: 6190
		public const int CoordinatesFieldNumber = 1;

		// Token: 0x0400182F RID: 6191
		private MapCoordinates coordinates_;

		// Token: 0x04001830 RID: 6192
		private static MapComplementaryWithCoordsInformation ANqYSFObfdoU1VjQky4Z;
	}
}
