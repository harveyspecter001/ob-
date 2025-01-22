using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200083C RID: 2108
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BlockRequest : IMessage<BlockRequest>, IMessage, IEquatable<BlockRequest>, IDeepCloneable<BlockRequest>, IBufferMessage
	{
		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x0022BBA8 File Offset: 0x00229DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BlockRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x0022BBB8 File Offset: 0x00229DB8
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

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x0022BBC8 File Offset: 0x00229DC8
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

		// Token: 0x06006673 RID: 26227 RVA: 0x0022BBD8 File Offset: 0x00229DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockRequest()
		{
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x0022BBE8 File Offset: 0x00229DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockRequest(BlockRequest other)
		{
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x0022BBF8 File Offset: 0x00229DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockRequest Clone()
		{
			return null;
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x0022BC08 File Offset: 0x00229E08
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x0022BC18 File Offset: 0x00229E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSearch PlayerSearch
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

		// Token: 0x06006678 RID: 26232 RVA: 0x0022BC28 File Offset: 0x00229E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x0022BC38 File Offset: 0x00229E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BlockRequest other)
		{
			return true;
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x0022BC48 File Offset: 0x00229E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x0022BC58 File Offset: 0x00229E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x0022BC68 File Offset: 0x00229E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0022BC78 File Offset: 0x00229E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x0022BC88 File Offset: 0x00229E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x0022BC98 File Offset: 0x00229E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BlockRequest other)
		{
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x0022BCA8 File Offset: 0x00229EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x0022BCB8 File Offset: 0x00229EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x0022BCC8 File Offset: 0x00229EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
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
					BlockRequest._parser = new MessageParser<BlockRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x0022BD94 File Offset: 0x00229F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EKMuLEJfQF3vywvQD9TV()
		{
			return true;
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x0022BD9C File Offset: 0x00229F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BlockRequest KTyEWJJf7JUWjCuC13LY()
		{
			return null;
		}

		// Token: 0x040023F5 RID: 9205
		private static readonly MessageParser<BlockRequest> _parser;

		// Token: 0x040023F6 RID: 9206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F7 RID: 9207
		public const int PlayerSearchFieldNumber = 1;

		// Token: 0x040023F8 RID: 9208
		private PlayerSearch playerSearch_;

		// Token: 0x040023F9 RID: 9209
		private static BlockRequest d2qouKJfw2jTb0SQWgNe;
	}
}
