using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E31 RID: 3633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForceAccountRequest : IMessage<ForceAccountRequest>, IMessage, IEquatable<ForceAccountRequest>, IDeepCloneable<ForceAccountRequest>, IBufferMessage
	{
		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600AE87 RID: 44679 RVA: 0x002A0368 File Offset: 0x0029E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForceAccountRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x002A0378 File Offset: 0x0029E578
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

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600AE89 RID: 44681 RVA: 0x002A0388 File Offset: 0x0029E588
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

		// Token: 0x0600AE8A RID: 44682 RVA: 0x002A0398 File Offset: 0x0029E598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountRequest()
		{
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x002A03A8 File Offset: 0x0029E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountRequest(ForceAccountRequest other)
		{
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x002A03B8 File Offset: 0x0029E5B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountRequest Clone()
		{
			return null;
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600AE8D RID: 44685 RVA: 0x002A03C8 File Offset: 0x0029E5C8
		// (set) Token: 0x0600AE8E RID: 44686 RVA: 0x002A03D8 File Offset: 0x0029E5D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
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

		// Token: 0x0600AE8F RID: 44687 RVA: 0x002A03E8 File Offset: 0x0029E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AE90 RID: 44688 RVA: 0x002A03F8 File Offset: 0x0029E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForceAccountRequest other)
		{
			return true;
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x002A0408 File Offset: 0x0029E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x002A0418 File Offset: 0x0029E618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x002A0428 File Offset: 0x0029E628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x002A0438 File Offset: 0x0029E638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x002A0448 File Offset: 0x0029E648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x002A0458 File Offset: 0x0029E658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForceAccountRequest other)
		{
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x002A0468 File Offset: 0x0029E668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AE98 RID: 44696 RVA: 0x002A0478 File Offset: 0x0029E678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AE99 RID: 44697 RVA: 0x002A0488 File Offset: 0x0029E688
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForceAccountRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 2:
					ForceAccountRequest._parser = new MessageParser<ForceAccountRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x002A0554 File Offset: 0x0029E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SUSIN6JvR5ih6dFbbVn2()
		{
			return true;
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x002A055C File Offset: 0x0029E75C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForceAccountRequest eCwmLPJvOLfc8TAv7jbW()
		{
			return null;
		}

		// Token: 0x04004043 RID: 16451
		private static readonly MessageParser<ForceAccountRequest> _parser;

		// Token: 0x04004044 RID: 16452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004045 RID: 16453
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04004046 RID: 16454
		private long accountId_;

		// Token: 0x04004047 RID: 16455
		private static ForceAccountRequest tYdKRvJv3mXx2AAR5dNK;
	}
}
