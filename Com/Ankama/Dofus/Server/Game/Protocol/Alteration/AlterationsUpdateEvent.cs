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
	// Token: 0x02000CF1 RID: 3313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlterationsUpdateEvent : IMessage<AlterationsUpdateEvent>, IMessage, IEquatable<AlterationsUpdateEvent>, IDeepCloneable<AlterationsUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06009F74 RID: 40820 RVA: 0x002858B8 File Offset: 0x00283AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AlterationsUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x002858C8 File Offset: 0x00283AC8
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

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x002858D8 File Offset: 0x00283AD8
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

		// Token: 0x06009F77 RID: 40823 RVA: 0x002858E8 File Offset: 0x00283AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsUpdateEvent()
		{
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x002858F8 File Offset: 0x00283AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsUpdateEvent(AlterationsUpdateEvent other)
		{
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x00285908 File Offset: 0x00283B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationsUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009F7A RID: 40826 RVA: 0x00285918 File Offset: 0x00283B18
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

		// Token: 0x06009F7B RID: 40827 RVA: 0x00285928 File Offset: 0x00283B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x00285938 File Offset: 0x00283B38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlterationsUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x00285948 File Offset: 0x00283B48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x00285958 File Offset: 0x00283B58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x00285968 File Offset: 0x00283B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x00285978 File Offset: 0x00283B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x00285988 File Offset: 0x00283B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x00285998 File Offset: 0x00283B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlterationsUpdateEvent other)
		{
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x002859A8 File Offset: 0x00283BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x002859B8 File Offset: 0x00283BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x002859C8 File Offset: 0x00283BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlterationsUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					AlterationsUpdateEvent._parser = new MessageParser<AlterationsUpdateEvent>(() => null);
					num2 = 5;
					break;
				case 5:
					AlterationsUpdateEvent._repeated_alterations_codec = FieldCodec.ForMessage<Alteration>(10U, zwXBOiePGVOfR8A0yUAw.XVInXhlssT(zwXBOiePGVOfR8A0yUAw.h0oePgEHXQS));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x00285AB8 File Offset: 0x00283CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CZQk00Jj1evYELRI3c0G()
		{
			return true;
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x00285AC0 File Offset: 0x00283CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlterationsUpdateEvent McTDHVJjaNitqlNHjUXm()
		{
			return null;
		}

		// Token: 0x04003B0A RID: 15114
		private static readonly MessageParser<AlterationsUpdateEvent> _parser;

		// Token: 0x04003B0B RID: 15115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B0C RID: 15116
		public const int AlterationsFieldNumber = 1;

		// Token: 0x04003B0D RID: 15117
		private static readonly FieldCodec<Alteration> _repeated_alterations_codec;

		// Token: 0x04003B0E RID: 15118
		private readonly RepeatedField<Alteration> alterations_;

		// Token: 0x04003B0F RID: 15119
		internal static AlterationsUpdateEvent YdXXh4JjoBfmRwtVDZtg;
	}
}
