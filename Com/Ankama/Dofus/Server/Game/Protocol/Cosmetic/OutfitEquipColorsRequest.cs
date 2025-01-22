using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CBD RID: 3261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipColorsRequest : IMessage<OutfitEquipColorsRequest>, IMessage, IEquatable<OutfitEquipColorsRequest>, IDeepCloneable<OutfitEquipColorsRequest>, IBufferMessage
	{
		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x00281DAC File Offset: 0x0027FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipColorsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06009CBF RID: 40127 RVA: 0x00281DBC File Offset: 0x0027FFBC
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

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x00281DCC File Offset: 0x0027FFCC
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

		// Token: 0x06009CC1 RID: 40129 RVA: 0x00281DDC File Offset: 0x0027FFDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsRequest()
		{
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00281DEC File Offset: 0x0027FFEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsRequest(OutfitEquipColorsRequest other)
		{
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x00281DFC File Offset: 0x0027FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipColorsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x00281E0C File Offset: 0x0028000C
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x00281E1C File Offset: 0x0028001C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColorPalette ColorPalette
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

		// Token: 0x06009CC6 RID: 40134 RVA: 0x00281E2C File Offset: 0x0028002C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x00281E3C File Offset: 0x0028003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipColorsRequest other)
		{
			return true;
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x00281E4C File Offset: 0x0028004C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x00281E5C File Offset: 0x0028005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x00281E6C File Offset: 0x0028006C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x00281E7C File Offset: 0x0028007C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x00281E8C File Offset: 0x0028008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x00281E9C File Offset: 0x0028009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipColorsRequest other)
		{
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x00281EAC File Offset: 0x002800AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x00281EBC File Offset: 0x002800BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x00281ECC File Offset: 0x002800CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipColorsRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					OutfitEquipColorsRequest._parser = new MessageParser<OutfitEquipColorsRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x00281FC4 File Offset: 0x002801C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oWF8SbJ4ICircAIIRGyY()
		{
			return true;
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x00281FCC File Offset: 0x002801CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipColorsRequest kdgmSdJ4kSFBIkgvA8sK()
		{
			return null;
		}

		// Token: 0x04003A1C RID: 14876
		private static readonly MessageParser<OutfitEquipColorsRequest> _parser;

		// Token: 0x04003A1D RID: 14877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A1E RID: 14878
		public const int ColorPaletteFieldNumber = 1;

		// Token: 0x04003A1F RID: 14879
		private ColorPalette colorPalette_;

		// Token: 0x04003A20 RID: 14880
		private static OutfitEquipColorsRequest VtasTyJ4KdoilBUPIeZL;
	}
}
