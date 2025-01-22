using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CA5 RID: 3237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipAuraResponse : IMessage<OutfitEquipAuraResponse>, IMessage, IEquatable<OutfitEquipAuraResponse>, IDeepCloneable<OutfitEquipAuraResponse>, IBufferMessage
	{
		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06009B70 RID: 39792 RVA: 0x002802D8 File Offset: 0x0027E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipAuraResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06009B71 RID: 39793 RVA: 0x002802E8 File Offset: 0x0027E4E8
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

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06009B72 RID: 39794 RVA: 0x002802F8 File Offset: 0x0027E4F8
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

		// Token: 0x06009B73 RID: 39795 RVA: 0x00280308 File Offset: 0x0027E508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraResponse()
		{
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x00280318 File Offset: 0x0027E518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraResponse(OutfitEquipAuraResponse other)
		{
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x00280328 File Offset: 0x0027E528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraResponse Clone()
		{
			return null;
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06009B76 RID: 39798 RVA: 0x00280338 File Offset: 0x0027E538
		// (set) Token: 0x06009B77 RID: 39799 RVA: 0x00280348 File Offset: 0x0027E548
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

		// Token: 0x06009B78 RID: 39800 RVA: 0x00280358 File Offset: 0x0027E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x00280368 File Offset: 0x0027E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipAuraResponse other)
		{
			return true;
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x00280378 File Offset: 0x0027E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x00280388 File Offset: 0x0027E588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x00280398 File Offset: 0x0027E598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x002803A8 File Offset: 0x0027E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x002803B8 File Offset: 0x0027E5B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x002803C8 File Offset: 0x0027E5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipAuraResponse other)
		{
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x002803D8 File Offset: 0x0027E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x002803E8 File Offset: 0x0027E5E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x002803F8 File Offset: 0x0027E5F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipAuraResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					OutfitEquipAuraResponse._parser = new MessageParser<OutfitEquipAuraResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x002804DC File Offset: 0x0027E6DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RDQoNMJxHnwmxrEoh3q3()
		{
			return true;
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x002804E4 File Offset: 0x0027E6E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipAuraResponse MYwsJgJxYujON5JE01qu()
		{
			return null;
		}

		// Token: 0x040039B3 RID: 14771
		private static readonly MessageParser<OutfitEquipAuraResponse> _parser;

		// Token: 0x040039B4 RID: 14772
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039B5 RID: 14773
		public const int SuccessFieldNumber = 1;

		// Token: 0x040039B6 RID: 14774
		private bool success_;

		// Token: 0x040039B7 RID: 14775
		internal static OutfitEquipAuraResponse KH1ZNKJxpeg2n3w32Kuo;
	}
}
