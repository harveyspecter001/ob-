using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x0200003C RID: 60
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntFlagRemoveRequest : IMessage<TreasureHuntFlagRemoveRequest>, IMessage, IEquatable<TreasureHuntFlagRemoveRequest>, IDeepCloneable<TreasureHuntFlagRemoveRequest>, IBufferMessage
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00186FBC File Offset: 0x001851BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntFlagRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00186FCC File Offset: 0x001851CC
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00186FDC File Offset: 0x001851DC
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

		// Token: 0x06000237 RID: 567 RVA: 0x00186FEC File Offset: 0x001851EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRemoveRequest()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00186FFC File Offset: 0x001851FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRemoveRequest(TreasureHuntFlagRemoveRequest other)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0018700C File Offset: 0x0018520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0018701C File Offset: 0x0018521C
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00187030 File Offset: 0x00185230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TreasureHuntType QuestType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00187040 File Offset: 0x00185240
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00187050 File Offset: 0x00185250
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Index
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

		// Token: 0x0600023E RID: 574 RVA: 0x00187060 File Offset: 0x00185260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00187070 File Offset: 0x00185270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntFlagRemoveRequest other)
		{
			return true;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00187080 File Offset: 0x00185280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00187090 File Offset: 0x00185290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x001870A0 File Offset: 0x001852A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x001870B0 File Offset: 0x001852B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x001870C0 File Offset: 0x001852C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x001870D0 File Offset: 0x001852D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntFlagRemoveRequest other)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x001870E0 File Offset: 0x001852E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x001870F0 File Offset: 0x001852F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00187100 File Offset: 0x00185300
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntFlagRemoveRequest()
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
						TreasureHuntFlagRemoveRequest._parser = new MessageParser<TreasureHuntFlagRemoveRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_35;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x001871D0 File Offset: 0x001853D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c4Ed0iOj6PsAn9M3MiKR()
		{
			return true;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x001871D8 File Offset: 0x001853D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntFlagRemoveRequest QfS4IDOjLLWNwHl6Du6h()
		{
			return null;
		}

		// Token: 0x040000E7 RID: 231
		private static readonly MessageParser<TreasureHuntFlagRemoveRequest> _parser;

		// Token: 0x040000E8 RID: 232
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000E9 RID: 233
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x040000EA RID: 234
		private TreasureHuntType questType_;

		// Token: 0x040000EB RID: 235
		public const int IndexFieldNumber = 2;

		// Token: 0x040000EC RID: 236
		private int index_;

		// Token: 0x040000ED RID: 237
		internal static TreasureHuntFlagRemoveRequest pQj80TOjydUoijpN9Qyt;
	}
}
