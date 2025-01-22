using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x0200099A RID: 2458
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BidActivityResponse : IMessage<BidActivityResponse>, IMessage, IEquatable<BidActivityResponse>, IDeepCloneable<BidActivityResponse>, IBufferMessage
	{
		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x00245214 File Offset: 0x00243414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BidActivityResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060076FA RID: 30458 RVA: 0x00245224 File Offset: 0x00243424
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

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x00245234 File Offset: 0x00243434
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

		// Token: 0x060076FC RID: 30460 RVA: 0x00245244 File Offset: 0x00243444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivityResponse()
		{
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x00245254 File Offset: 0x00243454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivityResponse(BidActivityResponse other)
		{
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00245264 File Offset: 0x00243464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivityResponse Clone()
		{
			return null;
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x060076FF RID: 30463 RVA: 0x00245274 File Offset: 0x00243474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<BidActivity> BidActivities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00245284 File Offset: 0x00243484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00245294 File Offset: 0x00243494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BidActivityResponse other)
		{
			return true;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x002452A4 File Offset: 0x002434A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x002452B4 File Offset: 0x002434B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x002452C4 File Offset: 0x002434C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x002452D4 File Offset: 0x002434D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x002452E4 File Offset: 0x002434E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x002452F4 File Offset: 0x002434F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BidActivityResponse other)
		{
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00245304 File Offset: 0x00243504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00245314 File Offset: 0x00243514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00245324 File Offset: 0x00243524
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BidActivityResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BidActivityResponse._parser = new MessageParser<BidActivityResponse>(() => null);
					num2 = 2;
					continue;
				case 2:
					BidActivityResponse._repeated_bidActivities_codec = FieldCodec.ForMessage<BidActivity>(10U, jrcC7SB49K7XDI22t5Ff.XVInXhlssT(jrcC7SB49K7XDI22t5Ff.t8uB42Ps37C));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x0024542C File Offset: 0x0024362C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BVWr6fJOgeIkWCEZDCIB()
		{
			return true;
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00245434 File Offset: 0x00243634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BidActivityResponse n6BIkVJOsXbRPFwRwVBq()
		{
			return null;
		}

		// Token: 0x0400295E RID: 10590
		private static readonly MessageParser<BidActivityResponse> _parser;

		// Token: 0x0400295F RID: 10591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002960 RID: 10592
		public const int BidActivitiesFieldNumber = 1;

		// Token: 0x04002961 RID: 10593
		private static readonly FieldCodec<BidActivity> _repeated_bidActivities_codec;

		// Token: 0x04002962 RID: 10594
		private readonly RepeatedField<BidActivity> bidActivities_;

		// Token: 0x04002963 RID: 10595
		private static BidActivityResponse PajHwZJOGntfRTQ7AUgj;
	}
}
