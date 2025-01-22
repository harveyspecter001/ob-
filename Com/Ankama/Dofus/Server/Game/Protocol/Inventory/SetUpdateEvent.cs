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
	// Token: 0x0200043B RID: 1083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetUpdateEvent : IMessage<SetUpdateEvent>, IMessage, IEquatable<SetUpdateEvent>, IDeepCloneable<SetUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06003364 RID: 13156 RVA: 0x001D78E0 File Offset: 0x001D5AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SetUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x001D78F0 File Offset: 0x001D5AF0
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x001D7900 File Offset: 0x001D5B00
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

		// Token: 0x06003367 RID: 13159 RVA: 0x001D7910 File Offset: 0x001D5B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetUpdateEvent()
		{
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x001D7920 File Offset: 0x001D5B20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetUpdateEvent(SetUpdateEvent other)
		{
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x001D7930 File Offset: 0x001D5B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x001D7940 File Offset: 0x001D5B40
		// (set) Token: 0x0600336B RID: 13163 RVA: 0x001D7950 File Offset: 0x001D5B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x001D7960 File Offset: 0x001D5B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x001D7970 File Offset: 0x001D5B70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x001D7980 File Offset: 0x001D5B80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x001D7990 File Offset: 0x001D5B90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SetUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x001D79A0 File Offset: 0x001D5BA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x001D79B0 File Offset: 0x001D5BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x001D79C0 File Offset: 0x001D5BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x001D79D0 File Offset: 0x001D5BD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x001D79E0 File Offset: 0x001D5BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x001D79F0 File Offset: 0x001D5BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SetUpdateEvent other)
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x001D7A00 File Offset: 0x001D5C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x001D7A10 File Offset: 0x001D5C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x001D7A20 File Offset: 0x001D5C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SetUpdateEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 3:
						goto IL_87;
					case 4:
						SetUpdateEvent._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(26U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
						num2 = 6;
						continue;
					case 5:
						SetUpdateEvent._parser = new MessageParser<SetUpdateEvent>(() => null);
						num2 = 3;
						continue;
					case 6:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 2;
					}
				}
				IL_87:
				SetUpdateEvent._repeated_objectsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num = 4;
			}
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x001D7B48 File Offset: 0x001D5D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ILorXoODllRFgcaGm5UV()
		{
			return true;
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x001D7B50 File Offset: 0x001D5D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SetUpdateEvent rEDMTGODcDv8IM4eBcvy()
		{
			return null;
		}

		// Token: 0x040011F5 RID: 4597
		private static readonly MessageParser<SetUpdateEvent> _parser;

		// Token: 0x040011F6 RID: 4598
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011F7 RID: 4599
		public const int SetIdFieldNumber = 1;

		// Token: 0x040011F8 RID: 4600
		private int setId_;

		// Token: 0x040011F9 RID: 4601
		public const int ObjectsUidFieldNumber = 2;

		// Token: 0x040011FA RID: 4602
		private static readonly FieldCodec<int> _repeated_objectsUid_codec;

		// Token: 0x040011FB RID: 4603
		private readonly RepeatedField<int> objectsUid_;

		// Token: 0x040011FC RID: 4604
		public const int EffectsFieldNumber = 3;

		// Token: 0x040011FD RID: 4605
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x040011FE RID: 4606
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x040011FF RID: 4607
		private static SetUpdateEvent NmRObdODkQJM6pj4FhVB;
	}
}
