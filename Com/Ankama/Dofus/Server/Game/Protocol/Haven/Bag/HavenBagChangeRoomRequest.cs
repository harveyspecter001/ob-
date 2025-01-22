using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000479 RID: 1145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagChangeRoomRequest : IMessage<HavenBagChangeRoomRequest>, IMessage, IEquatable<HavenBagChangeRoomRequest>, IDeepCloneable<HavenBagChangeRoomRequest>, IBufferMessage
	{
		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x001DE790 File Offset: 0x001DC990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagChangeRoomRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x001DE7A0 File Offset: 0x001DC9A0
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x001DE7B0 File Offset: 0x001DC9B0
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

		// Token: 0x060036D2 RID: 14034 RVA: 0x001DE7C0 File Offset: 0x001DC9C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagChangeRoomRequest()
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x001DE7D0 File Offset: 0x001DC9D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagChangeRoomRequest(HavenBagChangeRoomRequest other)
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x001DE7E0 File Offset: 0x001DC9E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagChangeRoomRequest Clone()
		{
			return null;
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x001DE7F0 File Offset: 0x001DC9F0
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x001DE800 File Offset: 0x001DCA00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RoomId
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

		// Token: 0x060036D7 RID: 14039 RVA: 0x001DE810 File Offset: 0x001DCA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x001DE820 File Offset: 0x001DCA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagChangeRoomRequest other)
		{
			return true;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x001DE830 File Offset: 0x001DCA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x001DE840 File Offset: 0x001DCA40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x001DE850 File Offset: 0x001DCA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x001DE860 File Offset: 0x001DCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x001DE870 File Offset: 0x001DCA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x001DE880 File Offset: 0x001DCA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagChangeRoomRequest other)
		{
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x001DE890 File Offset: 0x001DCA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x001DE8A0 File Offset: 0x001DCAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x001DE8B0 File Offset: 0x001DCAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagChangeRoomRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagChangeRoomRequest._parser = new MessageParser<HavenBagChangeRoomRequest>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x001DE97C File Offset: 0x001DCB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t0YaXdOtulY7FAIycEpT()
		{
			return true;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x001DE984 File Offset: 0x001DCB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagChangeRoomRequest KDZIxsOt8dFp8ptfwN2f()
		{
			return null;
		}

		// Token: 0x04001342 RID: 4930
		private static readonly MessageParser<HavenBagChangeRoomRequest> _parser;

		// Token: 0x04001343 RID: 4931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001344 RID: 4932
		public const int RoomIdFieldNumber = 1;

		// Token: 0x04001345 RID: 4933
		private int roomId_;

		// Token: 0x04001346 RID: 4934
		internal static HavenBagChangeRoomRequest HVFEYyOtMg1u0Bp4wxYj;
	}
}
