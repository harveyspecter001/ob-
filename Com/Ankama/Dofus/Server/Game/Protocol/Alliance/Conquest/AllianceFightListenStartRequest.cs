using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D7F RID: 3455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightListenStartRequest : IMessage<AllianceFightListenStartRequest>, IMessage, IEquatable<AllianceFightListenStartRequest>, IDeepCloneable<AllianceFightListenStartRequest>, IBufferMessage
	{
		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600A687 RID: 42631 RVA: 0x00293328 File Offset: 0x00291528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightListenStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600A688 RID: 42632 RVA: 0x00293338 File Offset: 0x00291538
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

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x00293348 File Offset: 0x00291548
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

		// Token: 0x0600A68A RID: 42634 RVA: 0x00293358 File Offset: 0x00291558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStartRequest()
		{
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x00293368 File Offset: 0x00291568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStartRequest(AllianceFightListenStartRequest other)
		{
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x00293378 File Offset: 0x00291578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightListenStartRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x00293388 File Offset: 0x00291588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x00293398 File Offset: 0x00291598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightListenStartRequest other)
		{
			return true;
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x002933A8 File Offset: 0x002915A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x002933B8 File Offset: 0x002915B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x002933C8 File Offset: 0x002915C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x002933D8 File Offset: 0x002915D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x002933E8 File Offset: 0x002915E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x002933F8 File Offset: 0x002915F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightListenStartRequest other)
		{
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x00293408 File Offset: 0x00291608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x00293418 File Offset: 0x00291618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x00293428 File Offset: 0x00291628
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightListenStartRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				AllianceFightListenStartRequest._parser = new MessageParser<AllianceFightListenStartRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x0029350C File Offset: 0x0029170C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IfWR4MJk8XZo9wqYYfKr()
		{
			return true;
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x00293514 File Offset: 0x00291714
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightListenStartRequest kvYaDSJkZZNEeMebi4oS()
		{
			return null;
		}

		// Token: 0x04003D57 RID: 15703
		private static readonly MessageParser<AllianceFightListenStartRequest> _parser;

		// Token: 0x04003D58 RID: 15704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D59 RID: 15705
		internal static AllianceFightListenStartRequest UaIGKQJkurw03GuZOura;
	}
}
