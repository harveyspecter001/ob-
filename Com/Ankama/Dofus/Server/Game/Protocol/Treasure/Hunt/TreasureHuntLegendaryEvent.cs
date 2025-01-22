using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000042 RID: 66
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntLegendaryEvent : IMessage<TreasureHuntLegendaryEvent>, IMessage, IEquatable<TreasureHuntLegendaryEvent>, IDeepCloneable<TreasureHuntLegendaryEvent>, IBufferMessage
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00187620 File Offset: 0x00185820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureHuntLegendaryEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00187630 File Offset: 0x00185830
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00187640 File Offset: 0x00185840
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

		// Token: 0x06000287 RID: 647 RVA: 0x00187650 File Offset: 0x00185850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryEvent()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00187660 File Offset: 0x00185860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryEvent(TreasureHuntLegendaryEvent other)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00187670 File Offset: 0x00185870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryEvent Clone()
		{
			return null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00187680 File Offset: 0x00185880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AvailableLegendaryIds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00187690 File Offset: 0x00185890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x001876A0 File Offset: 0x001858A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntLegendaryEvent other)
		{
			return true;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x001876B0 File Offset: 0x001858B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x001876C0 File Offset: 0x001858C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x001876D0 File Offset: 0x001858D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x001876E0 File Offset: 0x001858E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x001876F0 File Offset: 0x001858F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00187700 File Offset: 0x00185900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntLegendaryEvent other)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00187710 File Offset: 0x00185910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00187720 File Offset: 0x00185920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00187730 File Offset: 0x00185930
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntLegendaryEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
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
						TreasureHuntLegendaryEvent._parser = new MessageParser<TreasureHuntLegendaryEvent>(() => null);
						num2 = 3;
						continue;
					case 3:
						TreasureHuntLegendaryEvent._repeated_availableLegendaryIds_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						continue;
					}
					break;
				}
				IL_86:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
				continue;
				goto IL_86;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00187820 File Offset: 0x00185A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QWYoBROjtUVLytwPcP06()
		{
			return true;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00187828 File Offset: 0x00185A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntLegendaryEvent Fxm0nTOjwO8BBAWMlDCI()
		{
			return null;
		}

		// Token: 0x040000FE RID: 254
		private static readonly MessageParser<TreasureHuntLegendaryEvent> _parser;

		// Token: 0x040000FF RID: 255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000100 RID: 256
		public const int AvailableLegendaryIdsFieldNumber = 1;

		// Token: 0x04000101 RID: 257
		private static readonly FieldCodec<int> _repeated_availableLegendaryIds_codec;

		// Token: 0x04000102 RID: 258
		private readonly RepeatedField<int> availableLegendaryIds_;

		// Token: 0x04000103 RID: 259
		internal static TreasureHuntLegendaryEvent Ovk4W8OjDbIPud5Ex8nc;
	}
}
