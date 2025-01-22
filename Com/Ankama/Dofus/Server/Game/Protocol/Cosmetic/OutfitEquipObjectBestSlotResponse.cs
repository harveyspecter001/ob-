using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CB7 RID: 3255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipObjectBestSlotResponse : IMessage<OutfitEquipObjectBestSlotResponse>, IMessage, IEquatable<OutfitEquipObjectBestSlotResponse>, IDeepCloneable<OutfitEquipObjectBestSlotResponse>, IBufferMessage
	{
		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x00281744 File Offset: 0x0027F944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitEquipObjectBestSlotResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06009C6D RID: 40045 RVA: 0x00281754 File Offset: 0x0027F954
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

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06009C6E RID: 40046 RVA: 0x00281764 File Offset: 0x0027F964
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

		// Token: 0x06009C6F RID: 40047 RVA: 0x00281774 File Offset: 0x0027F974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotResponse()
		{
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x00281784 File Offset: 0x0027F984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotResponse(OutfitEquipObjectBestSlotResponse other)
		{
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x00281794 File Offset: 0x0027F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06009C72 RID: 40050 RVA: 0x002817A4 File Offset: 0x0027F9A4
		// (set) Token: 0x06009C73 RID: 40051 RVA: 0x002817B4 File Offset: 0x0027F9B4
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

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06009C74 RID: 40052 RVA: 0x002817C4 File Offset: 0x0027F9C4
		// (set) Token: 0x06009C75 RID: 40053 RVA: 0x002817D8 File Offset: 0x0027F9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectSlot Slot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectSlot)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06009C76 RID: 40054 RVA: 0x002817E8 File Offset: 0x0027F9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasSlot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x002817F8 File Offset: 0x0027F9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSlot()
		{
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x00281808 File Offset: 0x0027FA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x00281818 File Offset: 0x0027FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipObjectBestSlotResponse other)
		{
			return true;
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x00281828 File Offset: 0x0027FA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x00281838 File Offset: 0x0027FA38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x00281848 File Offset: 0x0027FA48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x00281858 File Offset: 0x0027FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x00281868 File Offset: 0x0027FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x00281878 File Offset: 0x0027FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipObjectBestSlotResponse other)
		{
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x00281888 File Offset: 0x0027FA88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x00281898 File Offset: 0x0027FA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x002818A8 File Offset: 0x0027FAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipObjectBestSlotResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OutfitEquipObjectBestSlotResponse.SlotDefaultValue = ObjectSlot.Amulet;
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					OutfitEquipObjectBestSlotResponse._parser = new MessageParser<OutfitEquipObjectBestSlotResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x00281988 File Offset: 0x0027FB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SS0mJhJ49jDiqpocYc6r()
		{
			return true;
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x00281990 File Offset: 0x0027FB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipObjectBestSlotResponse fMr8FOJ42imeJILP51Li()
		{
			return null;
		}

		// Token: 0x04003A03 RID: 14851
		private static readonly MessageParser<OutfitEquipObjectBestSlotResponse> _parser;

		// Token: 0x04003A04 RID: 14852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A05 RID: 14853
		private int _hasBits0;

		// Token: 0x04003A06 RID: 14854
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A07 RID: 14855
		private bool success_;

		// Token: 0x04003A08 RID: 14856
		public const int SlotFieldNumber = 2;

		// Token: 0x04003A09 RID: 14857
		private static readonly ObjectSlot SlotDefaultValue;

		// Token: 0x04003A0A RID: 14858
		private ObjectSlot slot_;

		// Token: 0x04003A0B RID: 14859
		internal static OutfitEquipObjectBestSlotResponse c4RY9dJ4dFJl1XDC7otJ;
	}
}
