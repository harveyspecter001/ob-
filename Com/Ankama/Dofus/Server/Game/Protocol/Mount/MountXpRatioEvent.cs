using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000379 RID: 889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountXpRatioEvent : IMessage<MountXpRatioEvent>, IMessage, IEquatable<MountXpRatioEvent>, IDeepCloneable<MountXpRatioEvent>, IBufferMessage
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x001C8228 File Offset: 0x001C6428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountXpRatioEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x001C8238 File Offset: 0x001C6438
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x001C8248 File Offset: 0x001C6448
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

		// Token: 0x060029C4 RID: 10692 RVA: 0x001C8258 File Offset: 0x001C6458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountXpRatioEvent()
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x001C8268 File Offset: 0x001C6468
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountXpRatioEvent(MountXpRatioEvent other)
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x001C8278 File Offset: 0x001C6478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountXpRatioEvent Clone()
		{
			return null;
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x001C8288 File Offset: 0x001C6488
		// (set) Token: 0x060029C8 RID: 10696 RVA: 0x001C8298 File Offset: 0x001C6498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ratio
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

		// Token: 0x060029C9 RID: 10697 RVA: 0x001C82A8 File Offset: 0x001C64A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x001C82B8 File Offset: 0x001C64B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountXpRatioEvent other)
		{
			return true;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x001C82C8 File Offset: 0x001C64C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x001C82D8 File Offset: 0x001C64D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x001C82E8 File Offset: 0x001C64E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x001C82F8 File Offset: 0x001C64F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x001C8308 File Offset: 0x001C6508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x001C8318 File Offset: 0x001C6518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountXpRatioEvent other)
		{
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x001C8328 File Offset: 0x001C6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x001C8338 File Offset: 0x001C6538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x001C8348 File Offset: 0x001C6548
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountXpRatioEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					MountXpRatioEvent._parser = new MessageParser<MountXpRatioEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x001C842C File Offset: 0x001C662C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ByBbw7OrNLn9uEUyL5g7()
		{
			return true;
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x001C8434 File Offset: 0x001C6634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountXpRatioEvent BZKWwBOrxVrwMvMObEkt()
		{
			return null;
		}

		// Token: 0x04000EC3 RID: 3779
		private static readonly MessageParser<MountXpRatioEvent> _parser;

		// Token: 0x04000EC4 RID: 3780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EC5 RID: 3781
		public const int RatioFieldNumber = 1;

		// Token: 0x04000EC6 RID: 3782
		private int ratio_;

		// Token: 0x04000EC7 RID: 3783
		private static MountXpRatioEvent SoHk3GOrXDNRI2TX622q;
	}
}
