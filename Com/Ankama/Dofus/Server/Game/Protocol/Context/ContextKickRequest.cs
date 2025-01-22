using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000809 RID: 2057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextKickRequest : IMessage<ContextKickRequest>, IMessage, IEquatable<ContextKickRequest>, IDeepCloneable<ContextKickRequest>, IBufferMessage
	{
		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06006422 RID: 25634 RVA: 0x002263C4 File Offset: 0x002245C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06006423 RID: 25635 RVA: 0x002263D4 File Offset: 0x002245D4
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

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06006424 RID: 25636 RVA: 0x002263E4 File Offset: 0x002245E4
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

		// Token: 0x06006425 RID: 25637 RVA: 0x002263F4 File Offset: 0x002245F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextKickRequest()
		{
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x00226404 File Offset: 0x00224604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextKickRequest(ContextKickRequest other)
		{
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x00226414 File Offset: 0x00224614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextKickRequest Clone()
		{
			return null;
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x00226424 File Offset: 0x00224624
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x00226434 File Offset: 0x00224634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
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

		// Token: 0x0600642A RID: 25642 RVA: 0x00226444 File Offset: 0x00224644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x00226454 File Offset: 0x00224654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextKickRequest other)
		{
			return true;
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x00226464 File Offset: 0x00224664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x00226474 File Offset: 0x00224674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x00226484 File Offset: 0x00224684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x00226494 File Offset: 0x00224694
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x002264A4 File Offset: 0x002246A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x002264B4 File Offset: 0x002246B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextKickRequest other)
		{
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x002264C4 File Offset: 0x002246C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x002264D4 File Offset: 0x002246D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x002264E4 File Offset: 0x002246E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextKickRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ContextKickRequest._parser = new MessageParser<ContextKickRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x002265B0 File Offset: 0x002247B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DpxX4lOzLiwNe61u33aj()
		{
			return true;
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x002265B8 File Offset: 0x002247B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextKickRequest LfsoM0OzWbOMuUsjy9Za()
		{
			return null;
		}

		// Token: 0x04002334 RID: 9012
		private static readonly MessageParser<ContextKickRequest> _parser;

		// Token: 0x04002335 RID: 9013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002336 RID: 9014
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04002337 RID: 9015
		private long targetId_;

		// Token: 0x04002338 RID: 9016
		private static ContextKickRequest j3mHKcOz6BEnpXg75WY9;
	}
}
