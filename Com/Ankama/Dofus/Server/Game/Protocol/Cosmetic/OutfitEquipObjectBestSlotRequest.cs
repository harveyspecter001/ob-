using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CB5 RID: 3253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipObjectBestSlotRequest : IMessage<OutfitEquipObjectBestSlotRequest>, IMessage, IEquatable<OutfitEquipObjectBestSlotRequest>, IDeepCloneable<OutfitEquipObjectBestSlotRequest>, IBufferMessage
	{
		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06009C4E RID: 40014 RVA: 0x002814C8 File Offset: 0x0027F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipObjectBestSlotRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06009C4F RID: 40015 RVA: 0x002814D8 File Offset: 0x0027F6D8
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

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06009C50 RID: 40016 RVA: 0x002814E8 File Offset: 0x0027F6E8
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

		// Token: 0x06009C51 RID: 40017 RVA: 0x002814F8 File Offset: 0x0027F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotRequest()
		{
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x00281508 File Offset: 0x0027F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotRequest(OutfitEquipObjectBestSlotRequest other)
		{
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x00281518 File Offset: 0x0027F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectBestSlotRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06009C54 RID: 40020 RVA: 0x00281528 File Offset: 0x0027F728
		// (set) Token: 0x06009C55 RID: 40021 RVA: 0x00281538 File Offset: 0x0027F738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Gid
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

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06009C56 RID: 40022 RVA: 0x00281548 File Offset: 0x0027F748
		// (set) Token: 0x06009C57 RID: 40023 RVA: 0x00281558 File Offset: 0x0027F758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkinId
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

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x00281568 File Offset: 0x0027F768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkinId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x00281578 File Offset: 0x0027F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSkinId()
		{
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x00281588 File Offset: 0x0027F788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x00281598 File Offset: 0x0027F798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipObjectBestSlotRequest other)
		{
			return true;
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x002815A8 File Offset: 0x0027F7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x002815B8 File Offset: 0x0027F7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x002815C8 File Offset: 0x0027F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x002815D8 File Offset: 0x0027F7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x002815E8 File Offset: 0x0027F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x002815F8 File Offset: 0x0027F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipObjectBestSlotRequest other)
		{
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x00281608 File Offset: 0x0027F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x00281618 File Offset: 0x0027F818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x00281628 File Offset: 0x0027F828
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipObjectBestSlotRequest()
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
					num2 = 5;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OutfitEquipObjectBestSlotRequest.SkinIdDefaultValue = 0;
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				OutfitEquipObjectBestSlotRequest._parser = new MessageParser<OutfitEquipObjectBestSlotRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x00281734 File Offset: 0x0027F934
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hMuvJoJ4g0IOJOAd2ARn()
		{
			return true;
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x0028173C File Offset: 0x0027F93C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipObjectBestSlotRequest P0lGnMJ4srZnqF3AgiRe()
		{
			return null;
		}

		// Token: 0x040039F8 RID: 14840
		private static readonly MessageParser<OutfitEquipObjectBestSlotRequest> _parser;

		// Token: 0x040039F9 RID: 14841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039FA RID: 14842
		private int _hasBits0;

		// Token: 0x040039FB RID: 14843
		public const int GidFieldNumber = 1;

		// Token: 0x040039FC RID: 14844
		private int gid_;

		// Token: 0x040039FD RID: 14845
		public const int SkinIdFieldNumber = 2;

		// Token: 0x040039FE RID: 14846
		private static readonly int SkinIdDefaultValue;

		// Token: 0x040039FF RID: 14847
		private int skinId_;

		// Token: 0x04003A00 RID: 14848
		private static OutfitEquipObjectBestSlotRequest VA8Zp2J4GOiSDFAuR9K6;
	}
}
