using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000133 RID: 307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AdditionalSmileyEvent : IMessage<AdditionalSmileyEvent>, IMessage, IEquatable<AdditionalSmileyEvent>, IDeepCloneable<AdditionalSmileyEvent>, IBufferMessage
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0019B2F0 File Offset: 0x001994F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdditionalSmileyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0019B300 File Offset: 0x00199500
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0019B310 File Offset: 0x00199510
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

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0019B320 File Offset: 0x00199520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AdditionalSmileyEvent()
		{
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0019B330 File Offset: 0x00199530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AdditionalSmileyEvent(AdditionalSmileyEvent other)
		{
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0019B340 File Offset: 0x00199540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AdditionalSmileyEvent Clone()
		{
			return null;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0019B350 File Offset: 0x00199550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PackId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0019B360 File Offset: 0x00199560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0019B370 File Offset: 0x00199570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AdditionalSmileyEvent other)
		{
			return true;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0019B380 File Offset: 0x00199580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0019B390 File Offset: 0x00199590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0019B3A0 File Offset: 0x001995A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0019B3B0 File Offset: 0x001995B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0019B3C0 File Offset: 0x001995C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0019B3D0 File Offset: 0x001995D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AdditionalSmileyEvent other)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0019B3E0 File Offset: 0x001995E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0019B3F0 File Offset: 0x001995F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0019B400 File Offset: 0x00199600
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AdditionalSmileyEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AdditionalSmileyEvent._repeated_packId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					AdditionalSmileyEvent._parser = new MessageParser<AdditionalSmileyEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0019B4EC File Offset: 0x001996EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RADWLuOcSDHpwalapi39()
		{
			return true;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0019B4F4 File Offset: 0x001996F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AdditionalSmileyEvent xrTTQaOcMQFQeZltHTUJ()
		{
			return null;
		}

		// Token: 0x0400051B RID: 1307
		private static readonly MessageParser<AdditionalSmileyEvent> _parser;

		// Token: 0x0400051C RID: 1308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400051D RID: 1309
		public const int PackIdFieldNumber = 1;

		// Token: 0x0400051E RID: 1310
		private static readonly FieldCodec<int> _repeated_packId_codec;

		// Token: 0x0400051F RID: 1311
		private readonly RepeatedField<int> packId_;

		// Token: 0x04000520 RID: 1312
		private static AdditionalSmileyEvent wmdvHyOcPimMTsRN0Uin;
	}
}
