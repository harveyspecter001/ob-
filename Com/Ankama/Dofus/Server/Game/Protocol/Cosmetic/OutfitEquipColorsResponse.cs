using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CBF RID: 3263
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipColorsResponse : IMessage<OutfitEquipColorsResponse>, IMessage, IEquatable<OutfitEquipColorsResponse>, IDeepCloneable<OutfitEquipColorsResponse>, IBufferMessage
	{
		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x00281FD4 File Offset: 0x002801D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitEquipColorsResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06009CD9 RID: 40153 RVA: 0x00281FE4 File Offset: 0x002801E4
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

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06009CDA RID: 40154 RVA: 0x00281FF4 File Offset: 0x002801F4
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

		// Token: 0x06009CDB RID: 40155 RVA: 0x00282004 File Offset: 0x00280204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsResponse()
		{
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x00282014 File Offset: 0x00280214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsResponse(OutfitEquipColorsResponse other)
		{
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x00282024 File Offset: 0x00280224
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06009CDE RID: 40158 RVA: 0x00282034 File Offset: 0x00280234
		// (set) Token: 0x06009CDF RID: 40159 RVA: 0x00282044 File Offset: 0x00280244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00282054 File Offset: 0x00280254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x00282064 File Offset: 0x00280264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipColorsResponse other)
		{
			return true;
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x00282074 File Offset: 0x00280274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x00282084 File Offset: 0x00280284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x00282094 File Offset: 0x00280294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x002820A4 File Offset: 0x002802A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x002820B4 File Offset: 0x002802B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x002820C4 File Offset: 0x002802C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipColorsResponse other)
		{
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x002820D4 File Offset: 0x002802D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x002820E4 File Offset: 0x002802E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x002820F4 File Offset: 0x002802F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipColorsResponse()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				OutfitEquipColorsResponse._parser = new MessageParser<OutfitEquipColorsResponse>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x002821D8 File Offset: 0x002803D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e8eSeHJ4cB4CLmpEUlJm()
		{
			return true;
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x002821E0 File Offset: 0x002803E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipColorsResponse VfZiroJ4UBHIFkgjsygs()
		{
			return null;
		}

		// Token: 0x04003A23 RID: 14883
		private static readonly MessageParser<OutfitEquipColorsResponse> _parser;

		// Token: 0x04003A24 RID: 14884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A25 RID: 14885
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A26 RID: 14886
		private bool success_;

		// Token: 0x04003A27 RID: 14887
		private static OutfitEquipColorsResponse mWoWoHJ4lftjv7a7LXZm;
	}
}
