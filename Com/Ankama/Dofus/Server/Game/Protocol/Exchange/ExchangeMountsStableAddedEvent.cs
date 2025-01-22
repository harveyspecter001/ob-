using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200078B RID: 1931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountsStableAddedEvent : IMessage<ExchangeMountsStableAddedEvent>, IMessage, IEquatable<ExchangeMountsStableAddedEvent>, IDeepCloneable<ExchangeMountsStableAddedEvent>, IBufferMessage
	{
		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x0021D8BC File Offset: 0x0021BABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMountsStableAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x0021D8CC File Offset: 0x0021BACC
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x0021D8DC File Offset: 0x0021BADC
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

		// Token: 0x06005EB6 RID: 24246 RVA: 0x0021D8EC File Offset: 0x0021BAEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableAddedEvent()
		{
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x0021D8FC File Offset: 0x0021BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableAddedEvent(ExchangeMountsStableAddedEvent other)
		{
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x0021D90C File Offset: 0x0021BB0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x0021D91C File Offset: 0x0021BB1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<MountData> Mounts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06005EBA RID: 24250 RVA: 0x0021D92C File Offset: 0x0021BB2C
		// (set) Token: 0x06005EBB RID: 24251 RVA: 0x0021D93C File Offset: 0x0021BB3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool NewBorn
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

		// Token: 0x06005EBC RID: 24252 RVA: 0x0021D94C File Offset: 0x0021BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x0021D95C File Offset: 0x0021BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountsStableAddedEvent other)
		{
			return true;
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x0021D96C File Offset: 0x0021BB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0021D97C File Offset: 0x0021BB7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0021D98C File Offset: 0x0021BB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x0021D99C File Offset: 0x0021BB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x0021D9AC File Offset: 0x0021BBAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x0021D9BC File Offset: 0x0021BBBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountsStableAddedEvent other)
		{
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x0021D9CC File Offset: 0x0021BBCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x0021D9DC File Offset: 0x0021BBDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x0021D9EC File Offset: 0x0021BBEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountsStableAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeMountsStableAddedEvent._parser = new MessageParser<ExchangeMountsStableAddedEvent>(() => null);
					num2 = 3;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					ExchangeMountsStableAddedEvent._repeated_mounts_codec = FieldCodec.ForMessage<MountData>(10U, uZWv2vA6viUJSmHpxF4k.XVInXhlssT(uZWv2vA6viUJSmHpxF4k.zN6A6oXMqvt));
					num2 = 2;
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x0021DADC File Offset: 0x0021BCDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CE8iunOqfeXhI5Pu4Cvu()
		{
			return true;
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x0021DAE4 File Offset: 0x0021BCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountsStableAddedEvent zfvdOpOqnQiSRkS2qXJ0()
		{
			return null;
		}

		// Token: 0x0400214F RID: 8527
		private static readonly MessageParser<ExchangeMountsStableAddedEvent> _parser;

		// Token: 0x04002150 RID: 8528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002151 RID: 8529
		public const int MountsFieldNumber = 1;

		// Token: 0x04002152 RID: 8530
		private static readonly FieldCodec<MountData> _repeated_mounts_codec;

		// Token: 0x04002153 RID: 8531
		private readonly RepeatedField<MountData> mounts_;

		// Token: 0x04002154 RID: 8532
		public const int NewBornFieldNumber = 2;

		// Token: 0x04002155 RID: 8533
		private bool newBorn_;

		// Token: 0x04002156 RID: 8534
		internal static ExchangeMountsStableAddedEvent eAkOO6OZzq1qH9a0wgdh;
	}
}
