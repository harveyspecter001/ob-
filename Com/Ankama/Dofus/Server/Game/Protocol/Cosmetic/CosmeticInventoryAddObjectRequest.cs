using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C97 RID: 3223
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryAddObjectRequest : IMessage<CosmeticInventoryAddObjectRequest>, IMessage, IEquatable<CosmeticInventoryAddObjectRequest>, IDeepCloneable<CosmeticInventoryAddObjectRequest>, IBufferMessage
	{
		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x0027F644 File Offset: 0x0027D844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CosmeticInventoryAddObjectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x0027F654 File Offset: 0x0027D854
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

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x0027F664 File Offset: 0x0027D864
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

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0027F674 File Offset: 0x0027D874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectRequest()
		{
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x0027F684 File Offset: 0x0027D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectRequest(CosmeticInventoryAddObjectRequest other)
		{
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x0027F694 File Offset: 0x0027D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x0027F6A4 File Offset: 0x0027D8A4
		// (set) Token: 0x06009AD8 RID: 39640 RVA: 0x0027F6B4 File Offset: 0x0027D8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Uid
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

		// Token: 0x06009AD9 RID: 39641 RVA: 0x0027F6C4 File Offset: 0x0027D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x0027F6D4 File Offset: 0x0027D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryAddObjectRequest other)
		{
			return true;
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x0027F6E4 File Offset: 0x0027D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x0027F6F4 File Offset: 0x0027D8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x0027F704 File Offset: 0x0027D904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009ADE RID: 39646 RVA: 0x0027F714 File Offset: 0x0027D914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009ADF RID: 39647 RVA: 0x0027F724 File Offset: 0x0027D924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009AE0 RID: 39648 RVA: 0x0027F734 File Offset: 0x0027D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryAddObjectRequest other)
		{
		}

		// Token: 0x06009AE1 RID: 39649 RVA: 0x0027F744 File Offset: 0x0027D944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x0027F754 File Offset: 0x0027D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x0027F764 File Offset: 0x0027D964
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryAddObjectRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CosmeticInventoryAddObjectRequest._parser = new MessageParser<CosmeticInventoryAddObjectRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x0027F848 File Offset: 0x0027DA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NoULL7Jxalbn4KbGayeM()
		{
			return true;
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x0027F850 File Offset: 0x0027DA50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryAddObjectRequest OlayP3Jx5rd1gcEAgwXb()
		{
			return null;
		}

		// Token: 0x04003983 RID: 14723
		private static readonly MessageParser<CosmeticInventoryAddObjectRequest> _parser;

		// Token: 0x04003984 RID: 14724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003985 RID: 14725
		public const int UidFieldNumber = 1;

		// Token: 0x04003986 RID: 14726
		private int uid_;

		// Token: 0x04003987 RID: 14727
		internal static CosmeticInventoryAddObjectRequest JmwFEBJx1txwOcp7NSie;
	}
}
