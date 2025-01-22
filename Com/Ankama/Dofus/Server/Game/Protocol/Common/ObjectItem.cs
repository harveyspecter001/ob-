using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B56 RID: 2902
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectItem : IMessage<ObjectItem>, IMessage, IEquatable<ObjectItem>, IDeepCloneable<ObjectItem>, IBufferMessage
	{
		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06008AF6 RID: 35574 RVA: 0x00268CB4 File Offset: 0x00266EB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x00268CC4 File Offset: 0x00266EC4
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x00268CD4 File Offset: 0x00266ED4
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

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00268CE4 File Offset: 0x00266EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItem()
		{
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x00268CF4 File Offset: 0x00266EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItem(ObjectItem other)
		{
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x00268D04 File Offset: 0x00266F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItem Clone()
		{
			return null;
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06008AFC RID: 35580 RVA: 0x00268D14 File Offset: 0x00266F14
		// (set) Token: 0x06008AFD RID: 35581 RVA: 0x00268D24 File Offset: 0x00266F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Uid
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

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x00268D34 File Offset: 0x00266F34
		// (set) Token: 0x06008AFF RID: 35583 RVA: 0x00268D44 File Offset: 0x00266F44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
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

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x00268D54 File Offset: 0x00266F54
		// (set) Token: 0x06008B01 RID: 35585 RVA: 0x00268D64 File Offset: 0x00266F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Gid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x00268D74 File Offset: 0x00266F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00268D84 File Offset: 0x00266F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00268D94 File Offset: 0x00266F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectItem other)
		{
			return true;
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x00268DA4 File Offset: 0x00266FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00268DB4 File Offset: 0x00266FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00268DC4 File Offset: 0x00266FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x00268DD4 File Offset: 0x00266FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x00268DE4 File Offset: 0x00266FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00268DF4 File Offset: 0x00266FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectItem other)
		{
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x00268E04 File Offset: 0x00267004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00268E14 File Offset: 0x00267014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x00268E24 File Offset: 0x00267024
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectItem()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 2:
					ObjectItem._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(34U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					ObjectItem._parser = new MessageParser<ObjectItem>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x00268F2C File Offset: 0x0026712C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PsyeYsJdz5V0AhZSPrmT()
		{
			return true;
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x00268F34 File Offset: 0x00267134
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectItem vq5Nj7J9f1HD4MG9OCQp()
		{
			return null;
		}

		// Token: 0x04003337 RID: 13111
		private static readonly MessageParser<ObjectItem> _parser;

		// Token: 0x04003338 RID: 13112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003339 RID: 13113
		public const int UidFieldNumber = 1;

		// Token: 0x0400333A RID: 13114
		private int uid_;

		// Token: 0x0400333B RID: 13115
		public const int QuantityFieldNumber = 2;

		// Token: 0x0400333C RID: 13116
		private int quantity_;

		// Token: 0x0400333D RID: 13117
		public const int GidFieldNumber = 3;

		// Token: 0x0400333E RID: 13118
		private long gid_;

		// Token: 0x0400333F RID: 13119
		public const int EffectsFieldNumber = 4;

		// Token: 0x04003340 RID: 13120
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04003341 RID: 13121
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04003342 RID: 13122
		private static ObjectItem ydX0viJdFj7oUcJ43mkZ;
	}
}
