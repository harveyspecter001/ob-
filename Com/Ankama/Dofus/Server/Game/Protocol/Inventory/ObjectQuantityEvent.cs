using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000411 RID: 1041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectQuantityEvent : IMessage<ObjectQuantityEvent>, IMessage, IEquatable<ObjectQuantityEvent>, IDeepCloneable<ObjectQuantityEvent>, IBufferMessage
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x001D4AC8 File Offset: 0x001D2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectQuantityEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x001D4AD8 File Offset: 0x001D2CD8
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

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x001D4AE8 File Offset: 0x001D2CE8
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

		// Token: 0x0600312A RID: 12586 RVA: 0x001D4AF8 File Offset: 0x001D2CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectQuantityEvent()
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x001D4B08 File Offset: 0x001D2D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectQuantityEvent(ObjectQuantityEvent other)
		{
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x001D4B18 File Offset: 0x001D2D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectQuantityEvent Clone()
		{
			return null;
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x001D4B28 File Offset: 0x001D2D28
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x001D4B38 File Offset: 0x001D2D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectUidWithQuantity Object
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

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x001D4B48 File Offset: 0x001D2D48
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x001D4B5C File Offset: 0x001D2D5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectOrigin Origin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectOrigin)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x001D4B6C File Offset: 0x001D2D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x001D4B7C File Offset: 0x001D2D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectQuantityEvent other)
		{
			return true;
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x001D4B8C File Offset: 0x001D2D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x001D4B9C File Offset: 0x001D2D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x001D4BAC File Offset: 0x001D2DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x001D4BBC File Offset: 0x001D2DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x001D4BCC File Offset: 0x001D2DCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x001D4BDC File Offset: 0x001D2DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectQuantityEvent other)
		{
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x001D4BEC File Offset: 0x001D2DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x001D4BFC File Offset: 0x001D2DFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x001D4C0C File Offset: 0x001D2E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectQuantityEvent()
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
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					ObjectQuantityEvent._parser = new MessageParser<ObjectQuantityEvent>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x001D4CD8 File Offset: 0x001D2ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AEDxKBOCkMP0weBpScTC()
		{
			return true;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x001D4CE0 File Offset: 0x001D2EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectQuantityEvent zmlWtNOClqYMoU1fS4jf()
		{
			return null;
		}

		// Token: 0x04001135 RID: 4405
		private static readonly MessageParser<ObjectQuantityEvent> _parser;

		// Token: 0x04001136 RID: 4406
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001137 RID: 4407
		public const int ObjectFieldNumber = 1;

		// Token: 0x04001138 RID: 4408
		private ObjectUidWithQuantity object_;

		// Token: 0x04001139 RID: 4409
		public const int OriginFieldNumber = 2;

		// Token: 0x0400113A RID: 4410
		private ObjectOrigin origin_;

		// Token: 0x0400113B RID: 4411
		internal static ObjectQuantityEvent g5HSapOCICFrar92tnTM;
	}
}
