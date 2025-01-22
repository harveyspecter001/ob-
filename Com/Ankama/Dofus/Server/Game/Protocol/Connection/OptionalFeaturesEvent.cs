using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x020008A1 RID: 2209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OptionalFeaturesEvent : IMessage<OptionalFeaturesEvent>, IMessage, IEquatable<OptionalFeaturesEvent>, IDeepCloneable<OptionalFeaturesEvent>, IBufferMessage
	{
		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x00230D94 File Offset: 0x0022EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OptionalFeaturesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x00230DA4 File Offset: 0x0022EFA4
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x00230DB4 File Offset: 0x0022EFB4
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

		// Token: 0x06006B50 RID: 27472 RVA: 0x00230DC4 File Offset: 0x0022EFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OptionalFeaturesEvent()
		{
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00230DD4 File Offset: 0x0022EFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OptionalFeaturesEvent(OptionalFeaturesEvent other)
		{
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00230DE4 File Offset: 0x0022EFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OptionalFeaturesEvent Clone()
		{
			return null;
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x00230DF4 File Offset: 0x0022EFF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Features
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00230E04 File Offset: 0x0022F004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00230E14 File Offset: 0x0022F014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OptionalFeaturesEvent other)
		{
			return true;
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00230E24 File Offset: 0x0022F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x00230E34 File Offset: 0x0022F034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00230E44 File Offset: 0x0022F044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00230E54 File Offset: 0x0022F054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00230E64 File Offset: 0x0022F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00230E74 File Offset: 0x0022F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OptionalFeaturesEvent other)
		{
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x00230E84 File Offset: 0x0022F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00230E94 File Offset: 0x0022F094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00230EA4 File Offset: 0x0022F0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OptionalFeaturesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					OptionalFeaturesEvent._repeated_features_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 3;
					}
					break;
				case 5:
					OptionalFeaturesEvent._parser = new MessageParser<OptionalFeaturesEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00230FD0 File Offset: 0x0022F1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWPJbZJmohZdipHvJckY()
		{
			return true;
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00230FD8 File Offset: 0x0022F1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OptionalFeaturesEvent u5PlLWJm1AtCOH0g6m0T()
		{
			return null;
		}

		// Token: 0x04002581 RID: 9601
		private static readonly MessageParser<OptionalFeaturesEvent> _parser;

		// Token: 0x04002582 RID: 9602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002583 RID: 9603
		public const int FeaturesFieldNumber = 1;

		// Token: 0x04002584 RID: 9604
		private static readonly FieldCodec<int> _repeated_features_codec;

		// Token: 0x04002585 RID: 9605
		private readonly RepeatedField<int> features_;

		// Token: 0x04002586 RID: 9606
		private static OptionalFeaturesEvent p670OHJmvNoJyUVRUwqq;
	}
}
