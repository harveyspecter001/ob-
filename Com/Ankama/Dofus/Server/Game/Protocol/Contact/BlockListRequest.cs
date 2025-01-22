using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200083A RID: 2106
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BlockListRequest : IMessage<BlockListRequest>, IMessage, IEquatable<BlockListRequest>, IDeepCloneable<BlockListRequest>, IBufferMessage
	{
		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06006658 RID: 26200 RVA: 0x0022B9A0 File Offset: 0x00229BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlockListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x0022B9B0 File Offset: 0x00229BB0
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

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600665A RID: 26202 RVA: 0x0022B9C0 File Offset: 0x00229BC0
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

		// Token: 0x0600665B RID: 26203 RVA: 0x0022B9D0 File Offset: 0x00229BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListRequest()
		{
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x0022B9E0 File Offset: 0x00229BE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListRequest(BlockListRequest other)
		{
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0022B9F0 File Offset: 0x00229BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListRequest Clone()
		{
			return null;
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x0022BA00 File Offset: 0x00229C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x0022BA10 File Offset: 0x00229C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BlockListRequest other)
		{
			return true;
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x0022BA20 File Offset: 0x00229C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x0022BA30 File Offset: 0x00229C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x0022BA40 File Offset: 0x00229C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x0022BA50 File Offset: 0x00229C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x0022BA60 File Offset: 0x00229C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x0022BA70 File Offset: 0x00229C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BlockListRequest other)
		{
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x0022BA80 File Offset: 0x00229C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x0022BA90 File Offset: 0x00229C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x0022BAA0 File Offset: 0x00229CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockListRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				BlockListRequest._parser = new MessageParser<BlockListRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x0022BB98 File Offset: 0x00229D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bJS5AkJfDFkLOhDJUAin()
		{
			return true;
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x0022BBA0 File Offset: 0x00229DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BlockListRequest prlWmiJft3XnmWCqVC13()
		{
			return null;
		}

		// Token: 0x040023F0 RID: 9200
		private static readonly MessageParser<BlockListRequest> _parser;

		// Token: 0x040023F1 RID: 9201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F2 RID: 9202
		internal static BlockListRequest cl6otOJfCsOqRi1OdVh6;
	}
}
