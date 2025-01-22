using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B45 RID: 2885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonstersInGroupAlternativeInformation : IMessage<MonstersInGroupAlternativeInformation>, IMessage, IEquatable<MonstersInGroupAlternativeInformation>, IDeepCloneable<MonstersInGroupAlternativeInformation>, IBufferMessage
	{
		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06008A24 RID: 35364 RVA: 0x00268084 File Offset: 0x00266284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonstersInGroupAlternativeInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x00268094 File Offset: 0x00266294
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

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x002680A4 File Offset: 0x002662A4
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

		// Token: 0x06008A27 RID: 35367 RVA: 0x002680B4 File Offset: 0x002662B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonstersInGroupAlternativeInformation()
		{
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x002680C4 File Offset: 0x002662C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonstersInGroupAlternativeInformation(MonstersInGroupAlternativeInformation other)
		{
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x002680D4 File Offset: 0x002662D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonstersInGroupAlternativeInformation Clone()
		{
			return null;
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06008A2A RID: 35370 RVA: 0x002680E4 File Offset: 0x002662E4
		// (set) Token: 0x06008A2B RID: 35371 RVA: 0x002680F4 File Offset: 0x002662F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PlayerCount
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06008A2C RID: 35372 RVA: 0x00268104 File Offset: 0x00266304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<MonsterInGroupInformation> Monsters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x00268114 File Offset: 0x00266314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00268124 File Offset: 0x00266324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonstersInGroupAlternativeInformation other)
		{
			return true;
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x00268134 File Offset: 0x00266334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x00268144 File Offset: 0x00266344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x00268154 File Offset: 0x00266354
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x00268164 File Offset: 0x00266364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x00268174 File Offset: 0x00266374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x00268184 File Offset: 0x00266384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonstersInGroupAlternativeInformation other)
		{
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x00268194 File Offset: 0x00266394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x002681A4 File Offset: 0x002663A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x002681B4 File Offset: 0x002663B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonstersInGroupAlternativeInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					MonstersInGroupAlternativeInformation._repeated_monsters_codec = FieldCodec.ForMessage<MonsterInGroupInformation>(18U, IYZkmgBkFrHCMb0SZnvF.XVInXhlssT(IYZkmgBkFrHCMb0SZnvF.XOCBkzfLnx5));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					MonstersInGroupAlternativeInformation._parser = new MessageParser<MonstersInGroupAlternativeInformation>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x002682D0 File Offset: 0x002664D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YsKhGrJd7wHTVKByMNwu()
		{
			return true;
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x002682D8 File Offset: 0x002664D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonstersInGroupAlternativeInformation tOIRUQJdTmI8vZdIsOll()
		{
			return null;
		}

		// Token: 0x040032E4 RID: 13028
		private static readonly MessageParser<MonstersInGroupAlternativeInformation> _parser;

		// Token: 0x040032E5 RID: 13029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032E6 RID: 13030
		public const int PlayerCountFieldNumber = 1;

		// Token: 0x040032E7 RID: 13031
		private int playerCount_;

		// Token: 0x040032E8 RID: 13032
		public const int MonstersFieldNumber = 2;

		// Token: 0x040032E9 RID: 13033
		private static readonly FieldCodec<MonsterInGroupInformation> _repeated_monsters_codec;

		// Token: 0x040032EA RID: 13034
		private readonly RepeatedField<MonsterInGroupInformation> monsters_;

		// Token: 0x040032EB RID: 13035
		internal static MonstersInGroupAlternativeInformation rZLQVWJdQ0CCbEF2oDxk;
	}
}
