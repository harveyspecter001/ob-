using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000E6 RID: 230
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveTagStorageResponse : IMessage<RemoveTagStorageResponse>, IMessage, IEquatable<RemoveTagStorageResponse>, IDeepCloneable<RemoveTagStorageResponse>, IBufferMessage
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00194100 File Offset: 0x00192300
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RemoveTagStorageResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00194110 File Offset: 0x00192310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00194120 File Offset: 0x00192320
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

		// Token: 0x06000A5D RID: 2653 RVA: 0x00194130 File Offset: 0x00192330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageResponse()
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00194140 File Offset: 0x00192340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageResponse(RemoveTagStorageResponse other)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00194150 File Offset: 0x00192350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageResponse Clone()
		{
			return null;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00194160 File Offset: 0x00192360
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00194170 File Offset: 0x00192370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TagStorageUuid
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

		// Token: 0x06000A62 RID: 2658 RVA: 0x00194180 File Offset: 0x00192380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00194190 File Offset: 0x00192390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveTagStorageResponse other)
		{
			return true;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x001941A0 File Offset: 0x001923A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x001941B0 File Offset: 0x001923B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x001941C0 File Offset: 0x001923C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x001941D0 File Offset: 0x001923D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x001941E0 File Offset: 0x001923E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x001941F0 File Offset: 0x001923F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveTagStorageResponse other)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00194200 File Offset: 0x00192400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00194210 File Offset: 0x00192410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00194220 File Offset: 0x00192420
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveTagStorageResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_35;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					RemoveTagStorageResponse._parser = new MessageParser<RemoveTagStorageResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 4;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00194308 File Offset: 0x00192508
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jcPHVaOlmiZrUlwcIdpL()
		{
			return true;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00194310 File Offset: 0x00192510
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveTagStorageResponse UVrgSbOlAHfykKvV1KT4()
		{
			return null;
		}

		// Token: 0x040003D3 RID: 979
		private static readonly MessageParser<RemoveTagStorageResponse> _parser;

		// Token: 0x040003D4 RID: 980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003D5 RID: 981
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x040003D6 RID: 982
		private string tagStorageUuid_;

		// Token: 0x040003D7 RID: 983
		internal static RemoveTagStorageResponse ViG2YYOlnUlEexOtNPhn;
	}
}
