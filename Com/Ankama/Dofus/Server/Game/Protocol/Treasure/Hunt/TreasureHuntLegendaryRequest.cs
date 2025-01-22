using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000036 RID: 54
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntLegendaryRequest : IMessage<TreasureHuntLegendaryRequest>, IMessage, IEquatable<TreasureHuntLegendaryRequest>, IDeepCloneable<TreasureHuntLegendaryRequest>, IBufferMessage
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00186988 File Offset: 0x00184B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntLegendaryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00186998 File Offset: 0x00184B98
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x001869A8 File Offset: 0x00184BA8
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

		// Token: 0x060001E7 RID: 487 RVA: 0x001869B8 File Offset: 0x00184BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryRequest()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x001869C8 File Offset: 0x00184BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryRequest(TreasureHuntLegendaryRequest other)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x001869D8 File Offset: 0x00184BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntLegendaryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001EA RID: 490 RVA: 0x001869E8 File Offset: 0x00184BE8
		// (set) Token: 0x060001EB RID: 491 RVA: 0x001869F8 File Offset: 0x00184BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegendaryId
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

		// Token: 0x060001EC RID: 492 RVA: 0x00186A08 File Offset: 0x00184C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00186A18 File Offset: 0x00184C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntLegendaryRequest other)
		{
			return true;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00186A28 File Offset: 0x00184C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00186A38 File Offset: 0x00184C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00186A48 File Offset: 0x00184C48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00186A58 File Offset: 0x00184C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00186A68 File Offset: 0x00184C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00186A78 File Offset: 0x00184C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntLegendaryRequest other)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00186A88 File Offset: 0x00184C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00186A98 File Offset: 0x00184C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00186AA8 File Offset: 0x00184CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntLegendaryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					TreasureHuntLegendaryRequest._parser = new MessageParser<TreasureHuntLegendaryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00186B74 File Offset: 0x00184D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iRJPZ1OjlI7Ig3tTxuNw()
		{
			return true;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00186B7C File Offset: 0x00184D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntLegendaryRequest Ge3G7nOjc9enx072vOvA()
		{
			return null;
		}

		// Token: 0x040000D0 RID: 208
		private static readonly MessageParser<TreasureHuntLegendaryRequest> _parser;

		// Token: 0x040000D1 RID: 209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000D2 RID: 210
		public const int LegendaryIdFieldNumber = 1;

		// Token: 0x040000D3 RID: 211
		private int legendaryId_;

		// Token: 0x040000D4 RID: 212
		internal static TreasureHuntLegendaryRequest fUmFeDOjks980YqPtYa5;
	}
}
