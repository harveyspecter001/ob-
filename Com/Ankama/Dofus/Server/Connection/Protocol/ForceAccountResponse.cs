using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E33 RID: 3635
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForceAccountResponse : IMessage<ForceAccountResponse>, IMessage, IEquatable<ForceAccountResponse>, IDeepCloneable<ForceAccountResponse>, IBufferMessage
	{
		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x002A0564 File Offset: 0x0029E764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForceAccountResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600AEA2 RID: 44706 RVA: 0x002A0574 File Offset: 0x0029E774
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

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x002A0584 File Offset: 0x0029E784
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

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x002A0594 File Offset: 0x0029E794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountResponse()
		{
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002A05A4 File Offset: 0x0029E7A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountResponse(ForceAccountResponse other)
		{
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x002A05B4 File Offset: 0x0029E7B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountResponse Clone()
		{
			return null;
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x002A05C4 File Offset: 0x0029E7C4
		// (set) Token: 0x0600AEA8 RID: 44712 RVA: 0x002A05D4 File Offset: 0x0029E7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceAccountStatus Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x002A05E4 File Offset: 0x0029E7E4
		// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x002A05F4 File Offset: 0x0029E7F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ForceAccountError Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x002A0604 File Offset: 0x0029E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceAccountResponse.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForceAccountResponse.ContentOneofCase)null;
			}
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x002A0618 File Offset: 0x0029E818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x002A0628 File Offset: 0x0029E828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x002A0638 File Offset: 0x0029E838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForceAccountResponse other)
		{
			return true;
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x002A0648 File Offset: 0x0029E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x002A0658 File Offset: 0x0029E858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x002A0668 File Offset: 0x0029E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x002A0678 File Offset: 0x0029E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x002A0688 File Offset: 0x0029E888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AEB4 RID: 44724 RVA: 0x002A0698 File Offset: 0x0029E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForceAccountResponse other)
		{
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x002A06A8 File Offset: 0x0029E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x002A06B8 File Offset: 0x0029E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x002A06C8 File Offset: 0x0029E8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForceAccountResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					ForceAccountResponse._parser = new MessageParser<ForceAccountResponse>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x002A07C0 File Offset: 0x0029E9C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RTpOj8JvGKSFR4HbZ80G()
		{
			return true;
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x002A07C8 File Offset: 0x0029E9C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForceAccountResponse vepW9hJvgMpOFIEdZVXJ()
		{
			return null;
		}

		// Token: 0x0400404A RID: 16458
		private static readonly MessageParser<ForceAccountResponse> _parser;

		// Token: 0x0400404B RID: 16459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400404C RID: 16460
		public const int SuccessFieldNumber = 2;

		// Token: 0x0400404D RID: 16461
		public const int ErrorFieldNumber = 3;

		// Token: 0x0400404E RID: 16462
		private object content_;

		// Token: 0x0400404F RID: 16463
		private ForceAccountResponse.ContentOneofCase contentCase_;

		// Token: 0x04004050 RID: 16464
		internal static ForceAccountResponse wMN0poJvJ2JsMp8SgQII;

		// Token: 0x02000E34 RID: 3636
		public enum ContentOneofCase
		{
			// Token: 0x04004052 RID: 16466
			None,
			// Token: 0x04004053 RID: 16467
			Success = 2,
			// Token: 0x04004054 RID: 16468
			Error
		}
	}
}
