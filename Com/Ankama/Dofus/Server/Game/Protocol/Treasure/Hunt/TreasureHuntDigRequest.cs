using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000038 RID: 56
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntDigRequest : IMessage<TreasureHuntDigRequest>, IMessage, IEquatable<TreasureHuntDigRequest>, IDeepCloneable<TreasureHuntDigRequest>, IBufferMessage
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00186B84 File Offset: 0x00184D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntDigRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00186B94 File Offset: 0x00184D94
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00186BA4 File Offset: 0x00184DA4
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

		// Token: 0x06000201 RID: 513 RVA: 0x00186BB4 File Offset: 0x00184DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigRequest()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00186BC4 File Offset: 0x00184DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigRequest(TreasureHuntDigRequest other)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00186BD4 File Offset: 0x00184DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigRequest Clone()
		{
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00186BE4 File Offset: 0x00184DE4
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00186BF8 File Offset: 0x00184DF8
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

		// Token: 0x06000206 RID: 518 RVA: 0x00186C08 File Offset: 0x00184E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00186C18 File Offset: 0x00184E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntDigRequest other)
		{
			return true;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00186C28 File Offset: 0x00184E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00186C38 File Offset: 0x00184E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00186C48 File Offset: 0x00184E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00186C58 File Offset: 0x00184E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00186C68 File Offset: 0x00184E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00186C78 File Offset: 0x00184E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntDigRequest other)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00186C88 File Offset: 0x00184E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00186C98 File Offset: 0x00184E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00186CA8 File Offset: 0x00184EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntDigRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TreasureHuntDigRequest._parser = new MessageParser<TreasureHuntDigRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00186D8C File Offset: 0x00184F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qB9JiGOjvGQBIbVjAft7()
		{
			return true;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00186D94 File Offset: 0x00184F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntDigRequest obbfPMOjooAwh0mhvs2i()
		{
			return null;
		}

		// Token: 0x040000D7 RID: 215
		private static readonly MessageParser<TreasureHuntDigRequest> _parser;

		// Token: 0x040000D8 RID: 216
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000D9 RID: 217
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x040000DA RID: 218
		private TreasureHuntType questType_;

		// Token: 0x040000DB RID: 219
		internal static TreasureHuntDigRequest XdJTIcOjUkAWDtBK4DfH;
	}
}
