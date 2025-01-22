using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000998 RID: 2456
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BidActivitiesRequest : IMessage<BidActivitiesRequest>, IMessage, IEquatable<BidActivitiesRequest>, IDeepCloneable<BidActivitiesRequest>, IBufferMessage
	{
		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x00245020 File Offset: 0x00243220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BidActivitiesRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060076E2 RID: 30434 RVA: 0x00245030 File Offset: 0x00243230
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

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x00245040 File Offset: 0x00243240
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

		// Token: 0x060076E4 RID: 30436 RVA: 0x00245050 File Offset: 0x00243250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivitiesRequest()
		{
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00245060 File Offset: 0x00243260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivitiesRequest(BidActivitiesRequest other)
		{
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00245070 File Offset: 0x00243270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivitiesRequest Clone()
		{
			return null;
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00245080 File Offset: 0x00243280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00245090 File Offset: 0x00243290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BidActivitiesRequest other)
		{
			return true;
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x002450A0 File Offset: 0x002432A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x002450B0 File Offset: 0x002432B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x002450C0 File Offset: 0x002432C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x002450D0 File Offset: 0x002432D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x002450E0 File Offset: 0x002432E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x002450F0 File Offset: 0x002432F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BidActivitiesRequest other)
		{
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00245100 File Offset: 0x00243300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00245110 File Offset: 0x00243310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00245120 File Offset: 0x00243320
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BidActivitiesRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BidActivitiesRequest._parser = new MessageParser<BidActivitiesRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
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
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00245204 File Offset: 0x00243404
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bqH692JOOGkJCvaa5kLZ()
		{
			return true;
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x0024520C File Offset: 0x0024340C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BidActivitiesRequest jxYlMuJOJleSosNtYT0H()
		{
			return null;
		}

		// Token: 0x04002959 RID: 10585
		private static readonly MessageParser<BidActivitiesRequest> _parser;

		// Token: 0x0400295A RID: 10586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400295B RID: 10587
		private static BidActivitiesRequest bCl8nZJOROPR45RSqEFV;
	}
}
