using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CBB RID: 3259
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipFaceResponse : IMessage<OutfitEquipFaceResponse>, IMessage, IEquatable<OutfitEquipFaceResponse>, IDeepCloneable<OutfitEquipFaceResponse>, IBufferMessage
	{
		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x00281BAC File Offset: 0x0027FDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipFaceResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x00281BBC File Offset: 0x0027FDBC
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

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06009CA6 RID: 40102 RVA: 0x00281BCC File Offset: 0x0027FDCC
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

		// Token: 0x06009CA7 RID: 40103 RVA: 0x00281BDC File Offset: 0x0027FDDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceResponse()
		{
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x00281BEC File Offset: 0x0027FDEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceResponse(OutfitEquipFaceResponse other)
		{
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x00281BFC File Offset: 0x0027FDFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x00281C0C File Offset: 0x0027FE0C
		// (set) Token: 0x06009CAB RID: 40107 RVA: 0x00281C1C File Offset: 0x0027FE1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x00281C2C File Offset: 0x0027FE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x00281C3C File Offset: 0x0027FE3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipFaceResponse other)
		{
			return true;
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x00281C4C File Offset: 0x0027FE4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x00281C5C File Offset: 0x0027FE5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00281C6C File Offset: 0x0027FE6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x00281C7C File Offset: 0x0027FE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x00281C8C File Offset: 0x0027FE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x00281C9C File Offset: 0x0027FE9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipFaceResponse other)
		{
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x00281CAC File Offset: 0x0027FEAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x00281CBC File Offset: 0x0027FEBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x00281CCC File Offset: 0x0027FECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipFaceResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 2:
						OutfitEquipFaceResponse._parser = new MessageParser<OutfitEquipFaceResponse>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_35;
					}
					return;
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x00281D9C File Offset: 0x0027FF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V0p2f0J440NcxscAxG0X()
		{
			return true;
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x00281DA4 File Offset: 0x0027FFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipFaceResponse wQbY9PJ4j3E3YSdXoyxm()
		{
			return null;
		}

		// Token: 0x04003A15 RID: 14869
		private static readonly MessageParser<OutfitEquipFaceResponse> _parser;

		// Token: 0x04003A16 RID: 14870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A17 RID: 14871
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A18 RID: 14872
		private bool success_;

		// Token: 0x04003A19 RID: 14873
		private static OutfitEquipFaceResponse prRD1CJ4x8SfNMSx6FUg;
	}
}
