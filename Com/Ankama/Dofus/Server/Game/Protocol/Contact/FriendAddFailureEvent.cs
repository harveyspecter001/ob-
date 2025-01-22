using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200084C RID: 2124
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendAddFailureEvent : IMessage<FriendAddFailureEvent>, IMessage, IEquatable<FriendAddFailureEvent>, IDeepCloneable<FriendAddFailureEvent>, IBufferMessage
	{
		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x0022CC1C File Offset: 0x0022AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendAddFailureEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x0022CC2C File Offset: 0x0022AE2C
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

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x0022CC3C File Offset: 0x0022AE3C
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

		// Token: 0x06006745 RID: 26437 RVA: 0x0022CC4C File Offset: 0x0022AE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddFailureEvent()
		{
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x0022CC5C File Offset: 0x0022AE5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddFailureEvent(FriendAddFailureEvent other)
		{
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x0022CC6C File Offset: 0x0022AE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddFailureEvent Clone()
		{
			return null;
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x0022CC7C File Offset: 0x0022AE7C
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x0022CC90 File Offset: 0x0022AE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddFailureReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AddFailureReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x0022CCA0 File Offset: 0x0022AEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x0022CCB0 File Offset: 0x0022AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendAddFailureEvent other)
		{
			return true;
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x0022CCC0 File Offset: 0x0022AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x0022CCD0 File Offset: 0x0022AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x0022CCE0 File Offset: 0x0022AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x0022CCF0 File Offset: 0x0022AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x0022CD00 File Offset: 0x0022AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x0022CD10 File Offset: 0x0022AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendAddFailureEvent other)
		{
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x0022CD20 File Offset: 0x0022AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x0022CD30 File Offset: 0x0022AF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x0022CD40 File Offset: 0x0022AF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendAddFailureEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					FriendAddFailureEvent._parser = new MessageParser<FriendAddFailureEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x0022CE38 File Offset: 0x0022B038
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GdYFWlJnR5CHRR4fX1Um()
		{
			return true;
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x0022CE40 File Offset: 0x0022B040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendAddFailureEvent lIphSGJnOWauYFvc6XaU()
		{
			return null;
		}

		// Token: 0x0400242F RID: 9263
		private static readonly MessageParser<FriendAddFailureEvent> _parser;

		// Token: 0x04002430 RID: 9264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002431 RID: 9265
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002432 RID: 9266
		private AddFailureReason reason_;

		// Token: 0x04002433 RID: 9267
		internal static FriendAddFailureEvent LGCHZHJn3WXWhXLcoAxL;
	}
}
