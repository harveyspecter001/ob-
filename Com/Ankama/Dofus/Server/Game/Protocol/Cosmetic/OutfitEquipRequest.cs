using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CCF RID: 3279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipRequest : IMessage<OutfitEquipRequest>, IMessage, IEquatable<OutfitEquipRequest>, IDeepCloneable<OutfitEquipRequest>, IBufferMessage
	{
		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06009DBA RID: 40378 RVA: 0x00283160 File Offset: 0x00281360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitEquipRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06009DBB RID: 40379 RVA: 0x00283170 File Offset: 0x00281370
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

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06009DBC RID: 40380 RVA: 0x00283180 File Offset: 0x00281380
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

		// Token: 0x06009DBD RID: 40381 RVA: 0x00283190 File Offset: 0x00281390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipRequest()
		{
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x002831A0 File Offset: 0x002813A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipRequest(OutfitEquipRequest other)
		{
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x002831B0 File Offset: 0x002813B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x002831C0 File Offset: 0x002813C0
		// (set) Token: 0x06009DC1 RID: 40385 RVA: 0x002831D0 File Offset: 0x002813D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutfitUuid
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

		// Token: 0x06009DC2 RID: 40386 RVA: 0x002831E0 File Offset: 0x002813E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x002831F0 File Offset: 0x002813F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipRequest other)
		{
			return true;
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x00283200 File Offset: 0x00281400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x00283210 File Offset: 0x00281410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x00283220 File Offset: 0x00281420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x00283230 File Offset: 0x00281430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x00283240 File Offset: 0x00281440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x00283250 File Offset: 0x00281450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipRequest other)
		{
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x00283260 File Offset: 0x00281460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x00283270 File Offset: 0x00281470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x00283280 File Offset: 0x00281480
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					OutfitEquipRequest._parser = new MessageParser<OutfitEquipRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x0028334C File Offset: 0x0028154C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E4u2chJ4Y2ZdJTOZWGDp()
		{
			return true;
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x00283354 File Offset: 0x00281554
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipRequest bkRXOsJ4bwDepXcESKYl()
		{
			return null;
		}

		// Token: 0x04003A6D RID: 14957
		private static readonly MessageParser<OutfitEquipRequest> _parser;

		// Token: 0x04003A6E RID: 14958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A6F RID: 14959
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x04003A70 RID: 14960
		private string outfitUuid_;

		// Token: 0x04003A71 RID: 14961
		private static OutfitEquipRequest BQ2G0EJ4HCymceLR3vjf;
	}
}
