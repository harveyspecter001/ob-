using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D81 RID: 3457
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightListenStopRequest : IMessage<AllianceFightListenStopRequest>, IMessage, IEquatable<AllianceFightListenStopRequest>, IDeepCloneable<AllianceFightListenStopRequest>, IBufferMessage
	{
		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600A69F RID: 42655 RVA: 0x0029351C File Offset: 0x0029171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightListenStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x0029352C File Offset: 0x0029172C
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

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x0029353C File Offset: 0x0029173C
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

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x0029354C File Offset: 0x0029174C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStopRequest()
		{
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x0029355C File Offset: 0x0029175C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStopRequest(AllianceFightListenStopRequest other)
		{
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x0029356C File Offset: 0x0029176C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStopRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x0029357C File Offset: 0x0029177C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x0029358C File Offset: 0x0029178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightListenStopRequest other)
		{
			return true;
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x0029359C File Offset: 0x0029179C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x002935AC File Offset: 0x002917AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x002935BC File Offset: 0x002917BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x002935CC File Offset: 0x002917CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x002935DC File Offset: 0x002917DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x002935EC File Offset: 0x002917EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightListenStopRequest other)
		{
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x002935FC File Offset: 0x002917FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x0029360C File Offset: 0x0029180C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x0029361C File Offset: 0x0029181C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightListenStopRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AllianceFightListenStopRequest._parser = new MessageParser<AllianceFightListenStopRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x00293700 File Offset: 0x00291900
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XUmbgdJkFET32A7XPbqR()
		{
			return true;
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x00293708 File Offset: 0x00291908
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightListenStopRequest PF4L1nJkzCHRTItWgDxk()
		{
			return null;
		}

		// Token: 0x04003D5C RID: 15708
		private static readonly MessageParser<AllianceFightListenStopRequest> _parser;

		// Token: 0x04003D5D RID: 15709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D5E RID: 15710
		private static AllianceFightListenStopRequest d1OdbcJkq2kFoGoXeZyF;
	}
}
