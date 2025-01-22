using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CAF RID: 3247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipOrnamentResponse : IMessage<OutfitEquipOrnamentResponse>, IMessage, IEquatable<OutfitEquipOrnamentResponse>, IDeepCloneable<OutfitEquipOrnamentResponse>, IBufferMessage
	{
		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x00280DC0 File Offset: 0x0027EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipOrnamentResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x00280DD0 File Offset: 0x0027EFD0
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

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x00280DE0 File Offset: 0x0027EFE0
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

		// Token: 0x06009BFB RID: 39931 RVA: 0x00280DF0 File Offset: 0x0027EFF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentResponse()
		{
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x00280E00 File Offset: 0x0027F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentResponse(OutfitEquipOrnamentResponse other)
		{
		}

		// Token: 0x06009BFD RID: 39933 RVA: 0x00280E10 File Offset: 0x0027F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipOrnamentResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x00280E20 File Offset: 0x0027F020
		// (set) Token: 0x06009BFF RID: 39935 RVA: 0x00280E30 File Offset: 0x0027F030
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

		// Token: 0x06009C00 RID: 39936 RVA: 0x00280E40 File Offset: 0x0027F040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x00280E50 File Offset: 0x0027F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipOrnamentResponse other)
		{
			return true;
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x00280E60 File Offset: 0x0027F060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x00280E70 File Offset: 0x0027F070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x00280E80 File Offset: 0x0027F080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x00280E90 File Offset: 0x0027F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x00280EA0 File Offset: 0x0027F0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C07 RID: 39943 RVA: 0x00280EB0 File Offset: 0x0027F0B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipOrnamentResponse other)
		{
		}

		// Token: 0x06009C08 RID: 39944 RVA: 0x00280EC0 File Offset: 0x0027F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x00280ED0 File Offset: 0x0027F0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x00280EE0 File Offset: 0x0027F0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipOrnamentResponse()
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
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_88;
					case 4:
						OutfitEquipOrnamentResponse._parser = new MessageParser<OutfitEquipOrnamentResponse>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_88:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06009C0B RID: 39947 RVA: 0x00280FC8 File Offset: 0x0027F1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nkxqLXJ4mNn2uj02mWkU()
		{
			return true;
		}

		// Token: 0x06009C0C RID: 39948 RVA: 0x00280FD0 File Offset: 0x0027F1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipOrnamentResponse hHh7g4J4ADuTQ9I9BA5v()
		{
			return null;
		}

		// Token: 0x040039DC RID: 14812
		private static readonly MessageParser<OutfitEquipOrnamentResponse> _parser;

		// Token: 0x040039DD RID: 14813
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DE RID: 14814
		public const int SuccessFieldNumber = 1;

		// Token: 0x040039DF RID: 14815
		private bool success_;

		// Token: 0x040039E0 RID: 14816
		internal static OutfitEquipOrnamentResponse GANsveJ4na7LKO41Fn7o;
	}
}
