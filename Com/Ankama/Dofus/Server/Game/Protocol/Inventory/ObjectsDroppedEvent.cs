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
	// Token: 0x020003FD RID: 1021
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectsDroppedEvent : IMessage<ObjectsDroppedEvent>, IMessage, IEquatable<ObjectsDroppedEvent>, IDeepCloneable<ObjectsDroppedEvent>, IBufferMessage
	{
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x001D3580 File Offset: 0x001D1780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectsDroppedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x001D3590 File Offset: 0x001D1790
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x001D35A0 File Offset: 0x001D17A0
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

		// Token: 0x06003026 RID: 12326 RVA: 0x001D35B0 File Offset: 0x001D17B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDroppedEvent()
		{
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x001D35C0 File Offset: 0x001D17C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDroppedEvent(ObjectsDroppedEvent other)
		{
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x001D35D0 File Offset: 0x001D17D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDroppedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x001D35E0 File Offset: 0x001D17E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectInRolePlay> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x001D35F0 File Offset: 0x001D17F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x001D3600 File Offset: 0x001D1800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectsDroppedEvent other)
		{
			return true;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x001D3610 File Offset: 0x001D1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x001D3620 File Offset: 0x001D1820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x001D3630 File Offset: 0x001D1830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x001D3640 File Offset: 0x001D1840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x001D3650 File Offset: 0x001D1850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x001D3660 File Offset: 0x001D1860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectsDroppedEvent other)
		{
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x001D3670 File Offset: 0x001D1870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x001D3680 File Offset: 0x001D1880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x001D3690 File Offset: 0x001D1890
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectsDroppedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					ObjectsDroppedEvent._parser = new MessageParser<ObjectsDroppedEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					ObjectsDroppedEvent._repeated_object_codec = FieldCodec.ForMessage<ObjectInRolePlay>(10U, CF3fbNn5Y1qo69YIf7GE.XVInXhlssT(CF3fbNn5Y1qo69YIf7GE.Krsn5b9wcjd));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x001D37AC File Offset: 0x001D19AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QJVed7O0uUegFSiDIBGH()
		{
			return true;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x001D37B4 File Offset: 0x001D19B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectsDroppedEvent WFNi4bO08S0Okk66CA2I()
		{
			return null;
		}

		// Token: 0x040010E7 RID: 4327
		private static readonly MessageParser<ObjectsDroppedEvent> _parser;

		// Token: 0x040010E8 RID: 4328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010E9 RID: 4329
		public const int ObjectFieldNumber = 1;

		// Token: 0x040010EA RID: 4330
		private static readonly FieldCodec<ObjectInRolePlay> _repeated_object_codec;

		// Token: 0x040010EB RID: 4331
		private readonly RepeatedField<ObjectInRolePlay> object_;

		// Token: 0x040010EC RID: 4332
		internal static ObjectsDroppedEvent h3nE7fO0M5flRpkw9Bsa;
	}
}
