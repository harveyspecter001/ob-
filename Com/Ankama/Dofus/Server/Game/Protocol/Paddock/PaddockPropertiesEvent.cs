using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x0200031B RID: 795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockPropertiesEvent : IMessage<PaddockPropertiesEvent>, IMessage, IEquatable<PaddockPropertiesEvent>, IDeepCloneable<PaddockPropertiesEvent>, IBufferMessage
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x001C1034 File Offset: 0x001BF234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddockPropertiesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x001C1044 File Offset: 0x001BF244
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

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x001C1054 File Offset: 0x001BF254
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

		// Token: 0x06002567 RID: 9575 RVA: 0x001C1064 File Offset: 0x001BF264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockPropertiesEvent()
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x001C1074 File Offset: 0x001BF274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockPropertiesEvent(PaddockPropertiesEvent other)
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x001C1084 File Offset: 0x001BF284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockPropertiesEvent Clone()
		{
			return null;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x001C1094 File Offset: 0x001BF294
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x001C10A4 File Offset: 0x001BF2A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PaddockInformation Properties
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

		// Token: 0x0600256C RID: 9580 RVA: 0x001C10B4 File Offset: 0x001BF2B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x001C10C4 File Offset: 0x001BF2C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockPropertiesEvent other)
		{
			return true;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x001C10D4 File Offset: 0x001BF2D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x001C10E4 File Offset: 0x001BF2E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x001C10F4 File Offset: 0x001BF2F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x001C1104 File Offset: 0x001BF304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x001C1114 File Offset: 0x001BF314
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x001C1124 File Offset: 0x001BF324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockPropertiesEvent other)
		{
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x001C1134 File Offset: 0x001BF334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x001C1144 File Offset: 0x001BF344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x001C1154 File Offset: 0x001BF354
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockPropertiesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						PaddockPropertiesEvent._parser = new MessageParser<PaddockPropertiesEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x001C123C File Offset: 0x001BF43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aFv9HHOWvpo5OOQLUH9Q()
		{
			return true;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x001C1244 File Offset: 0x001BF444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockPropertiesEvent zFfv0ROWoQCn5EPp4ZMh()
		{
			return null;
		}

		// Token: 0x04000D44 RID: 3396
		private static readonly MessageParser<PaddockPropertiesEvent> _parser;

		// Token: 0x04000D45 RID: 3397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D46 RID: 3398
		public const int PropertiesFieldNumber = 1;

		// Token: 0x04000D47 RID: 3399
		private PaddockInformation properties_;

		// Token: 0x04000D48 RID: 3400
		private static PaddockPropertiesEvent Xbgp1yOWUTOkduOxXLYC;
	}
}
