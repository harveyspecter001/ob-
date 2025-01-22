using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration
{
	// Token: 0x02000CEB RID: 3307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlterationsEvent : IMessage<AlterationsEvent>, IMessage, IEquatable<AlterationsEvent>, IDeepCloneable<AlterationsEvent>, IBufferMessage
	{
		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06009F27 RID: 40743 RVA: 0x00285254 File Offset: 0x00283454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AlterationsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06009F28 RID: 40744 RVA: 0x00285264 File Offset: 0x00283464
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

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06009F29 RID: 40745 RVA: 0x00285274 File Offset: 0x00283474
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

		// Token: 0x06009F2A RID: 40746 RVA: 0x00285284 File Offset: 0x00283484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsEvent()
		{
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x00285294 File Offset: 0x00283494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsEvent(AlterationsEvent other)
		{
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x002852A4 File Offset: 0x002834A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06009F2D RID: 40749 RVA: 0x002852B4 File Offset: 0x002834B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Alteration> Alterations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x002852C4 File Offset: 0x002834C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x002852D4 File Offset: 0x002834D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlterationsEvent other)
		{
			return true;
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x002852E4 File Offset: 0x002834E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x002852F4 File Offset: 0x002834F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x00285304 File Offset: 0x00283504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x00285314 File Offset: 0x00283514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x00285324 File Offset: 0x00283524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x00285334 File Offset: 0x00283534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlterationsEvent other)
		{
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x00285344 File Offset: 0x00283544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x00285354 File Offset: 0x00283554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00285364 File Offset: 0x00283564
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlterationsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AlterationsEvent._repeated_alterations_codec = FieldCodec.ForMessage<Alteration>(10U, zwXBOiePGVOfR8A0yUAw.XVInXhlssT(zwXBOiePGVOfR8A0yUAw.h0oePgEHXQS));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AlterationsEvent._parser = new MessageParser<AlterationsEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
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
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x0028546C File Offset: 0x0028366C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wT7Wy4Jjj5Z33YbXG7cN()
		{
			return true;
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x00285474 File Offset: 0x00283674
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlterationsEvent N81geuJjKNBhTELWVAA9()
		{
			return null;
		}

		// Token: 0x04003AF4 RID: 15092
		private static readonly MessageParser<AlterationsEvent> _parser;

		// Token: 0x04003AF5 RID: 15093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF6 RID: 15094
		public const int AlterationsFieldNumber = 1;

		// Token: 0x04003AF7 RID: 15095
		private static readonly FieldCodec<Alteration> _repeated_alterations_codec;

		// Token: 0x04003AF8 RID: 15096
		private readonly RepeatedField<Alteration> alterations_;

		// Token: 0x04003AF9 RID: 15097
		private static AlterationsEvent Ia8Gw9Jj41pvfmE9LGwB;
	}
}
