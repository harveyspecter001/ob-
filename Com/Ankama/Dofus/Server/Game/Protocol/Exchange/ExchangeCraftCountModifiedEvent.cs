using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000715 RID: 1813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftCountModifiedEvent : IMessage<ExchangeCraftCountModifiedEvent>, IMessage, IEquatable<ExchangeCraftCountModifiedEvent>, IDeepCloneable<ExchangeCraftCountModifiedEvent>, IBufferMessage
	{
		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x00216738 File Offset: 0x00214938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeCraftCountModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060058B4 RID: 22708 RVA: 0x00216748 File Offset: 0x00214948
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

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x00216758 File Offset: 0x00214958
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

		// Token: 0x060058B6 RID: 22710 RVA: 0x00216768 File Offset: 0x00214968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountModifiedEvent()
		{
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00216778 File Offset: 0x00214978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountModifiedEvent(ExchangeCraftCountModifiedEvent other)
		{
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00216788 File Offset: 0x00214988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftCountModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060058B9 RID: 22713 RVA: 0x00216798 File Offset: 0x00214998
		// (set) Token: 0x060058BA RID: 22714 RVA: 0x002167A8 File Offset: 0x002149A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Count
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

		// Token: 0x060058BB RID: 22715 RVA: 0x002167B8 File Offset: 0x002149B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x002167C8 File Offset: 0x002149C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftCountModifiedEvent other)
		{
			return true;
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x002167D8 File Offset: 0x002149D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x002167E8 File Offset: 0x002149E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x002167F8 File Offset: 0x002149F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00216808 File Offset: 0x00214A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00216818 File Offset: 0x00214A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00216828 File Offset: 0x00214A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftCountModifiedEvent other)
		{
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00216838 File Offset: 0x00214A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00216848 File Offset: 0x00214A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00216858 File Offset: 0x00214A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftCountModifiedEvent()
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
						ExchangeCraftCountModifiedEvent._parser = new MessageParser<ExchangeCraftCountModifiedEvent>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_87;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
					}
				}
				IL_87:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00216940 File Offset: 0x00214B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vmKLtoOuWru0fVipn1ss()
		{
			return true;
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00216948 File Offset: 0x00214B48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftCountModifiedEvent sTgTKjOuhtd7oSPmukOf()
		{
			return null;
		}

		// Token: 0x04001F11 RID: 7953
		private static readonly MessageParser<ExchangeCraftCountModifiedEvent> _parser;

		// Token: 0x04001F12 RID: 7954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F13 RID: 7955
		public const int CountFieldNumber = 1;

		// Token: 0x04001F14 RID: 7956
		private int count_;

		// Token: 0x04001F15 RID: 7957
		internal static ExchangeCraftCountModifiedEvent Y0IgKeOuLjnp5rXpaulj;
	}
}
