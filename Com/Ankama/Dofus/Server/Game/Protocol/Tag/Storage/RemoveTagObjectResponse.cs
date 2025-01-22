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
	// Token: 0x020000EE RID: 238
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveTagObjectResponse : IMessage<RemoveTagObjectResponse>, IMessage, IEquatable<RemoveTagObjectResponse>, IDeepCloneable<RemoveTagObjectResponse>, IBufferMessage
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0019499C File Offset: 0x00192B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveTagObjectResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x001949AC File Offset: 0x00192BAC
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x001949BC File Offset: 0x00192BBC
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

		// Token: 0x06000AC2 RID: 2754 RVA: 0x001949CC File Offset: 0x00192BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectResponse()
		{
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x001949DC File Offset: 0x00192BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectResponse(RemoveTagObjectResponse other)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x001949EC File Offset: 0x00192BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectResponse Clone()
		{
			return null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x001949FC File Offset: 0x00192BFC
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

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00194A0C File Offset: 0x00192C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00194A1C File Offset: 0x00192C1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveTagObjectResponse other)
		{
			return true;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00194A2C File Offset: 0x00192C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00194A3C File Offset: 0x00192C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00194A4C File Offset: 0x00192C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00194A5C File Offset: 0x00192C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00194A6C File Offset: 0x00192C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00194A7C File Offset: 0x00192C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveTagObjectResponse other)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00194A8C File Offset: 0x00192C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00194A9C File Offset: 0x00192C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00194AAC File Offset: 0x00192CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveTagObjectResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					RemoveTagObjectResponse._repeated_objectIds_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				RemoveTagObjectResponse._parser = new MessageParser<RemoveTagObjectResponse>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00194BD8 File Offset: 0x00192DD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NgY5sbOl92YFn44XKbkj()
		{
			return true;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00194BE0 File Offset: 0x00192DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveTagObjectResponse rQG9xPOl2beYZNk24wlx()
		{
			return null;
		}

		// Token: 0x040003F2 RID: 1010
		private static readonly MessageParser<RemoveTagObjectResponse> _parser;

		// Token: 0x040003F3 RID: 1011
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003F4 RID: 1012
		public const int ObjectIdsFieldNumber = 1;

		// Token: 0x040003F5 RID: 1013
		private static readonly FieldCodec<int> _repeated_objectIds_codec;

		// Token: 0x040003F6 RID: 1014
		private readonly RepeatedField<int> objectIds_;

		// Token: 0x040003F7 RID: 1015
		internal static RemoveTagObjectResponse Vw3NvvOldHPiI82il1xT;
	}
}
