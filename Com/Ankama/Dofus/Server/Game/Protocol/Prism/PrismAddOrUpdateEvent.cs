using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001D3 RID: 467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismAddOrUpdateEvent : IMessage<PrismAddOrUpdateEvent>, IMessage, IEquatable<PrismAddOrUpdateEvent>, IDeepCloneable<PrismAddOrUpdateEvent>, IBufferMessage
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x001A7760 File Offset: 0x001A5960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismAddOrUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x001A7770 File Offset: 0x001A5970
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x001A7780 File Offset: 0x001A5980
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

		// Token: 0x060015CE RID: 5582 RVA: 0x001A7790 File Offset: 0x001A5990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAddOrUpdateEvent()
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x001A77A0 File Offset: 0x001A59A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAddOrUpdateEvent(PrismAddOrUpdateEvent other)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x001A77B0 File Offset: 0x001A59B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAddOrUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x001A77C0 File Offset: 0x001A59C0
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x001A77D0 File Offset: 0x001A59D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismLocalizedInformation PrismLocalizedInformation
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

		// Token: 0x060015D3 RID: 5587 RVA: 0x001A77E0 File Offset: 0x001A59E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x001A77F0 File Offset: 0x001A59F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismAddOrUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x001A7800 File Offset: 0x001A5A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x001A7810 File Offset: 0x001A5A10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x001A7820 File Offset: 0x001A5A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x001A7830 File Offset: 0x001A5A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x001A7840 File Offset: 0x001A5A40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x001A7850 File Offset: 0x001A5A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismAddOrUpdateEvent other)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x001A7860 File Offset: 0x001A5A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x001A7870 File Offset: 0x001A5A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x001A7880 File Offset: 0x001A5A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismAddOrUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
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
						PrismAddOrUpdateEvent._parser = new MessageParser<PrismAddOrUpdateEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				IL_AC:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				goto IL_AC;
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x001A7950 File Offset: 0x001A5B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rug4OnO1lXE6hCDB2qnX()
		{
			return true;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x001A7958 File Offset: 0x001A5B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismAddOrUpdateEvent c11OWPO1cyDSiQKGcqpI()
		{
			return null;
		}

		// Token: 0x040007B9 RID: 1977
		private static readonly MessageParser<PrismAddOrUpdateEvent> _parser;

		// Token: 0x040007BA RID: 1978
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007BB RID: 1979
		public const int PrismLocalizedInformationFieldNumber = 1;

		// Token: 0x040007BC RID: 1980
		private PrismLocalizedInformation prismLocalizedInformation_;

		// Token: 0x040007BD RID: 1981
		private static PrismAddOrUpdateEvent f0VjeZO1kaX12wNxCGfZ;
	}
}
