using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000465 RID: 1125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseAccountEvent : IMessage<HouseAccountEvent>, IMessage, IEquatable<HouseAccountEvent>, IDeepCloneable<HouseAccountEvent>, IBufferMessage
	{
		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x001DC42C File Offset: 0x001DA62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseAccountEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x001DC43C File Offset: 0x001DA63C
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x001DC44C File Offset: 0x001DA64C
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

		// Token: 0x060035A5 RID: 13733 RVA: 0x001DC45C File Offset: 0x001DA65C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseAccountEvent()
		{
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x001DC46C File Offset: 0x001DA66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseAccountEvent(HouseAccountEvent other)
		{
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x001DC47C File Offset: 0x001DA67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseAccountEvent Clone()
		{
			return null;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x001DC48C File Offset: 0x001DA68C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<House> Houses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x001DC49C File Offset: 0x001DA69C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x001DC4AC File Offset: 0x001DA6AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseAccountEvent other)
		{
			return true;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x001DC4BC File Offset: 0x001DA6BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x001DC4CC File Offset: 0x001DA6CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x001DC4DC File Offset: 0x001DA6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x001DC4EC File Offset: 0x001DA6EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x001DC4FC File Offset: 0x001DA6FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x001DC50C File Offset: 0x001DA70C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseAccountEvent other)
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x001DC51C File Offset: 0x001DA71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x001DC52C File Offset: 0x001DA72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x001DC53C File Offset: 0x001DA73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseAccountEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_AF;
					case 3:
						HouseAccountEvent._parser = new MessageParser<HouseAccountEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
				}
				IL_AF:
				HouseAccountEvent._repeated_houses_codec = FieldCodec.ForMessage<House>(10U, Qlb7XImRf9HtV6bHB6q0.XVInXhlssT(Qlb7XImRf9HtV6bHB6q0.eFnmRnonDuN));
				num = 4;
			}
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x001DC630 File Offset: 0x001DA830
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S4jdpUOtosJeCLZSM3Au()
		{
			return true;
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x001DC638 File Offset: 0x001DA838
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseAccountEvent Uo5Yh2Ot1jC7ZtL492Hc()
		{
			return null;
		}

		// Token: 0x040012BB RID: 4795
		private static readonly MessageParser<HouseAccountEvent> _parser;

		// Token: 0x040012BC RID: 4796
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012BD RID: 4797
		public const int HousesFieldNumber = 1;

		// Token: 0x040012BE RID: 4798
		private static readonly FieldCodec<House> _repeated_houses_codec;

		// Token: 0x040012BF RID: 4799
		private readonly RepeatedField<House> houses_;

		// Token: 0x040012C0 RID: 4800
		private static HouseAccountEvent mnGXdtOtvT8hTThMikEk;
	}
}
