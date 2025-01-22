using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x0200080B RID: 2059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShowCellRequest : IMessage<ShowCellRequest>, IMessage, IEquatable<ShowCellRequest>, IDeepCloneable<ShowCellRequest>, IBufferMessage
	{
		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x002265C0 File Offset: 0x002247C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShowCellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x002265D0 File Offset: 0x002247D0
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x002265E0 File Offset: 0x002247E0
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

		// Token: 0x0600643F RID: 25663 RVA: 0x002265F0 File Offset: 0x002247F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellRequest()
		{
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x00226600 File Offset: 0x00224800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellRequest(ShowCellRequest other)
		{
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00226610 File Offset: 0x00224810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellRequest Clone()
		{
			return null;
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x00226620 File Offset: 0x00224820
		// (set) Token: 0x06006443 RID: 25667 RVA: 0x00226630 File Offset: 0x00224830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
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

		// Token: 0x06006444 RID: 25668 RVA: 0x00226640 File Offset: 0x00224840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x00226650 File Offset: 0x00224850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShowCellRequest other)
		{
			return true;
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x00226660 File Offset: 0x00224860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x00226670 File Offset: 0x00224870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x00226680 File Offset: 0x00224880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x00226690 File Offset: 0x00224890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x002266A0 File Offset: 0x002248A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x002266B0 File Offset: 0x002248B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShowCellRequest other)
		{
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x002266C0 File Offset: 0x002248C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x002266D0 File Offset: 0x002248D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x002266E0 File Offset: 0x002248E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShowCellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
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
				ShowCellRequest._parser = new MessageParser<ShowCellRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x002267C4 File Offset: 0x002249C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DC3nGgOzr4Xxi7pKf9yn()
		{
			return true;
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x002267CC File Offset: 0x002249CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShowCellRequest bjU8AFOzV2l4RS0wMo4J()
		{
			return null;
		}

		// Token: 0x0400233B RID: 9019
		private static readonly MessageParser<ShowCellRequest> _parser;

		// Token: 0x0400233C RID: 9020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400233D RID: 9021
		public const int CellIdFieldNumber = 1;

		// Token: 0x0400233E RID: 9022
		private int cellId_;

		// Token: 0x0400233F RID: 9023
		private static ShowCellRequest vedUYVOzhI3I5F4mOAhq;
	}
}
