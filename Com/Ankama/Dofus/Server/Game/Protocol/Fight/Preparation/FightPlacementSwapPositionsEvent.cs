using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006B1 RID: 1713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsEvent : IMessage<FightPlacementSwapPositionsEvent>, IMessage, IEquatable<FightPlacementSwapPositionsEvent>, IDeepCloneable<FightPlacementSwapPositionsEvent>, IBufferMessage
	{
		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x0020A03C File Offset: 0x0020823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightPlacementSwapPositionsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x0020A04C File Offset: 0x0020824C
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

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060053B0 RID: 21424 RVA: 0x0020A05C File Offset: 0x0020825C
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

		// Token: 0x060053B1 RID: 21425 RVA: 0x0020A06C File Offset: 0x0020826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsEvent()
		{
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0020A07C File Offset: 0x0020827C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsEvent(FightPlacementSwapPositionsEvent other)
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0020A08C File Offset: 0x0020828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x0020A09C File Offset: 0x0020829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityDisposition> Dispositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0020A0AC File Offset: 0x002082AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0020A0BC File Offset: 0x002082BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsEvent other)
		{
			return true;
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x0020A0CC File Offset: 0x002082CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0020A0DC File Offset: 0x002082DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0020A0EC File Offset: 0x002082EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0020A0FC File Offset: 0x002082FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0020A10C File Offset: 0x0020830C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0020A11C File Offset: 0x0020831C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsEvent other)
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0020A12C File Offset: 0x0020832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0020A13C File Offset: 0x0020833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0020A14C File Offset: 0x0020834C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsEvent()
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
						goto IL_C5;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						return;
					}
					FightPlacementSwapPositionsEvent._parser = new MessageParser<FightPlacementSwapPositionsEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 1;
					}
				}
				IL_C5:
				FightPlacementSwapPositionsEvent._repeated_dispositions_codec = FieldCodec.ForMessage<EntityDisposition>(10U, hcMLg7AJcIQsCglnEFOC.XVInXhlssT(hcMLg7AJcIQsCglnEFOC.uKtAJUF3ccs));
				num = 5;
			}
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0020A26C File Offset: 0x0020846C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IOrCmJOSEmTTXBMstbiQ()
		{
			return true;
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x0020A274 File Offset: 0x00208474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsEvent x7RR9UOSXpeXYySjMQEU()
		{
			return null;
		}

		// Token: 0x04001D7E RID: 7550
		private static readonly MessageParser<FightPlacementSwapPositionsEvent> _parser;

		// Token: 0x04001D7F RID: 7551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D80 RID: 7552
		public const int DispositionsFieldNumber = 1;

		// Token: 0x04001D81 RID: 7553
		private static readonly FieldCodec<EntityDisposition> _repeated_dispositions_codec;

		// Token: 0x04001D82 RID: 7554
		private readonly RepeatedField<EntityDisposition> dispositions_;

		// Token: 0x04001D83 RID: 7555
		private static FightPlacementSwapPositionsEvent s4MeRcOS2ryFvV74vVP3;
	}
}
