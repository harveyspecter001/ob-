using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000EA RID: 234
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddTagObjectResponse : IMessage<AddTagObjectResponse>, IMessage, IEquatable<AddTagObjectResponse>, IDeepCloneable<AddTagObjectResponse>, IBufferMessage
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00194554 File Offset: 0x00192754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddTagObjectResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00194564 File Offset: 0x00192764
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00194574 File Offset: 0x00192774
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

		// Token: 0x06000A90 RID: 2704 RVA: 0x00194584 File Offset: 0x00192784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectResponse()
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00194594 File Offset: 0x00192794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectResponse(AddTagObjectResponse other)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x001945A4 File Offset: 0x001927A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectResponse Clone()
		{
			return null;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x001945B4 File Offset: 0x001927B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectIds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x001945C4 File Offset: 0x001927C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x001945D4 File Offset: 0x001927D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AddTagObjectResponse other)
		{
			return true;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x001945E4 File Offset: 0x001927E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x001945F4 File Offset: 0x001927F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00194604 File Offset: 0x00192804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00194614 File Offset: 0x00192814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00194624 File Offset: 0x00192824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00194634 File Offset: 0x00192834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AddTagObjectResponse other)
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00194644 File Offset: 0x00192844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00194654 File Offset: 0x00192854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00194664 File Offset: 0x00192864
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddTagObjectResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AddTagObjectResponse._parser = new MessageParser<AddTagObjectResponse>(() => null);
					num2 = 2;
					break;
				case 2:
					AddTagObjectResponse._repeated_objectIds_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0019477C File Offset: 0x0019297C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gR4lqROlOl71YsffR29N()
		{
			return true;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00194784 File Offset: 0x00192984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AddTagObjectResponse darc40OlJc4c74YSxb8m()
		{
			return null;
		}

		// Token: 0x040003E2 RID: 994
		private static readonly MessageParser<AddTagObjectResponse> _parser;

		// Token: 0x040003E3 RID: 995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003E4 RID: 996
		public const int ObjectIdsFieldNumber = 1;

		// Token: 0x040003E5 RID: 997
		private static readonly FieldCodec<int> _repeated_objectIds_codec;

		// Token: 0x040003E6 RID: 998
		private readonly RepeatedField<int> objectIds_;

		// Token: 0x040003E7 RID: 999
		private static AddTagObjectResponse tVyw8qOlRBVxVsIFmay8;
	}
}
