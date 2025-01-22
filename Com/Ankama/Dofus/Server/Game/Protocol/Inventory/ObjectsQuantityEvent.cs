using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000413 RID: 1043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectsQuantityEvent : IMessage<ObjectsQuantityEvent>, IMessage, IEquatable<ObjectsQuantityEvent>, IDeepCloneable<ObjectsQuantityEvent>, IBufferMessage
	{
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x001D4CE8 File Offset: 0x001D2EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectsQuantityEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x001D4CF8 File Offset: 0x001D2EF8
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

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x001D4D08 File Offset: 0x001D2F08
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

		// Token: 0x06003146 RID: 12614 RVA: 0x001D4D18 File Offset: 0x001D2F18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsQuantityEvent()
		{
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x001D4D28 File Offset: 0x001D2F28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsQuantityEvent(ObjectsQuantityEvent other)
		{
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x001D4D38 File Offset: 0x001D2F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsQuantityEvent Clone()
		{
			return null;
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x001D4D48 File Offset: 0x001D2F48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectUidWithQuantity> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x001D4D58 File Offset: 0x001D2F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x001D4D68 File Offset: 0x001D2F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectsQuantityEvent other)
		{
			return true;
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x001D4D78 File Offset: 0x001D2F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x001D4D88 File Offset: 0x001D2F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x001D4D98 File Offset: 0x001D2F98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x001D4DA8 File Offset: 0x001D2FA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x001D4DB8 File Offset: 0x001D2FB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x001D4DC8 File Offset: 0x001D2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectsQuantityEvent other)
		{
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x001D4DD8 File Offset: 0x001D2FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x001D4DE8 File Offset: 0x001D2FE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x001D4DF8 File Offset: 0x001D2FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectsQuantityEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					ObjectsQuantityEvent._repeated_object_codec = FieldCodec.ForMessage<ObjectUidWithQuantity>(10U, s7w74qnuEYuoJcLSH5jI.XVInXhlssT(s7w74qnuEYuoJcLSH5jI.L5AnuXvQxv7));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				ObjectsQuantityEvent._parser = new MessageParser<ObjectsQuantityEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x001D4F00 File Offset: 0x001D3100
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool magUd7OCUOJLDhdARr49()
		{
			return true;
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x001D4F08 File Offset: 0x001D3108
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectsQuantityEvent Vx77iSOCvfRBIjQxOUFe()
		{
			return null;
		}

		// Token: 0x0400113E RID: 4414
		private static readonly MessageParser<ObjectsQuantityEvent> _parser;

		// Token: 0x0400113F RID: 4415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001140 RID: 4416
		public const int ObjectFieldNumber = 1;

		// Token: 0x04001141 RID: 4417
		private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_object_codec;

		// Token: 0x04001142 RID: 4418
		private readonly RepeatedField<ObjectUidWithQuantity> object_;

		// Token: 0x04001143 RID: 4419
		internal static ObjectsQuantityEvent IwrXEZOCcfKlHLj8aCwH;
	}
}
