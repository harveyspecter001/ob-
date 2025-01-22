using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200098D RID: 2445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachBranchesEvent : IMessage<BreachBranchesEvent>, IMessage, IEquatable<BreachBranchesEvent>, IDeepCloneable<BreachBranchesEvent>, IBufferMessage
	{
		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06007659 RID: 30297 RVA: 0x00244114 File Offset: 0x00242314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachBranchesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x00244124 File Offset: 0x00242324
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

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600765B RID: 30299 RVA: 0x00244134 File Offset: 0x00242334
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

		// Token: 0x0600765C RID: 30300 RVA: 0x00244144 File Offset: 0x00242344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranchesEvent()
		{
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00244154 File Offset: 0x00242354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranchesEvent(BreachBranchesEvent other)
		{
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00244164 File Offset: 0x00242364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranchesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600765F RID: 30303 RVA: 0x00244174 File Offset: 0x00242374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BreachBranch> Branches
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00244184 File Offset: 0x00242384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00244194 File Offset: 0x00242394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachBranchesEvent other)
		{
			return true;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x002441A4 File Offset: 0x002423A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x002441B4 File Offset: 0x002423B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x002441C4 File Offset: 0x002423C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x002441D4 File Offset: 0x002423D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x002441E4 File Offset: 0x002423E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x002441F4 File Offset: 0x002423F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachBranchesEvent other)
		{
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00244204 File Offset: 0x00242404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00244214 File Offset: 0x00242414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00244224 File Offset: 0x00242424
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachBranchesEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					BreachBranchesEvent._parser = new MessageParser<BreachBranchesEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					BreachBranchesEvent._repeated_branches_codec = FieldCodec.ForMessage<BreachBranch>(10U, gowLQumwByDIN5xLnRgU.XVInXhlssT(gowLQumwByDIN5xLnRgU.cWrmweSVyai));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00244314 File Offset: 0x00242514
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ij8QybJRi4BOBBO8ZAff()
		{
			return true;
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x0024431C File Offset: 0x0024251C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachBranchesEvent s3Jd0hJRP9Qwdfsfwrgd()
		{
			return null;
		}

		// Token: 0x0400292E RID: 10542
		private static readonly MessageParser<BreachBranchesEvent> _parser;

		// Token: 0x0400292F RID: 10543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002930 RID: 10544
		public const int BranchesFieldNumber = 1;

		// Token: 0x04002931 RID: 10545
		private static readonly FieldCodec<BreachBranch> _repeated_branches_codec;

		// Token: 0x04002932 RID: 10546
		private readonly RepeatedField<BreachBranch> branches_;

		// Token: 0x04002933 RID: 10547
		internal static BreachBranchesEvent N0S3MwJRbb2KbTCU43SW;
	}
}
