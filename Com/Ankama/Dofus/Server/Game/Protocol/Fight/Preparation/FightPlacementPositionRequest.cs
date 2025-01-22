using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x02000699 RID: 1689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementPositionRequest : IMessage<FightPlacementPositionRequest>, IMessage, IEquatable<FightPlacementPositionRequest>, IDeepCloneable<FightPlacementPositionRequest>, IBufferMessage
	{
		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x00208534 File Offset: 0x00206734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightPlacementPositionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x00208544 File Offset: 0x00206744
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x00208554 File Offset: 0x00206754
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

		// Token: 0x06005259 RID: 21081 RVA: 0x00208564 File Offset: 0x00206764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPositionRequest()
		{
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00208574 File Offset: 0x00206774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPositionRequest(FightPlacementPositionRequest other)
		{
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00208584 File Offset: 0x00206784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPositionRequest Clone()
		{
			return null;
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x00208594 File Offset: 0x00206794
		// (set) Token: 0x0600525D RID: 21085 RVA: 0x002085A4 File Offset: 0x002067A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x002085B4 File Offset: 0x002067B4
		// (set) Token: 0x0600525F RID: 21087 RVA: 0x002085C4 File Offset: 0x002067C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x06005260 RID: 21088 RVA: 0x002085D4 File Offset: 0x002067D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x002085E4 File Offset: 0x002067E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementPositionRequest other)
		{
			return true;
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x002085F4 File Offset: 0x002067F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00208604 File Offset: 0x00206804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00208614 File Offset: 0x00206814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00208624 File Offset: 0x00206824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00208634 File Offset: 0x00206834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00208644 File Offset: 0x00206844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementPositionRequest other)
		{
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00208654 File Offset: 0x00206854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00208664 File Offset: 0x00206864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00208674 File Offset: 0x00206874
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementPositionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						FightPlacementPositionRequest._parser = new MessageParser<FightPlacementPositionRequest>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						goto IL_35;
					}
					goto Block_1;
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				IL_4D:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
				continue;
				Block_1:
				goto IL_4D;
			}
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00208748 File Offset: 0x00206948
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XTxFnnOPDwDILYEhnZaM()
		{
			return true;
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00208750 File Offset: 0x00206950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementPositionRequest Td8JqjOPtSNfExKishYp()
		{
			return null;
		}

		// Token: 0x04001D06 RID: 7430
		private static readonly MessageParser<FightPlacementPositionRequest> _parser;

		// Token: 0x04001D07 RID: 7431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D08 RID: 7432
		public const int CellIdFieldNumber = 1;

		// Token: 0x04001D09 RID: 7433
		private int cellId_;

		// Token: 0x04001D0A RID: 7434
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04001D0B RID: 7435
		private long entityId_;

		// Token: 0x04001D0C RID: 7436
		internal static FightPlacementPositionRequest mHlvZWOPClOnmT5lCPkK;
	}
}
