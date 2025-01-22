using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000CF RID: 207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorEquipmentUpdateEvent : IMessage<TaxCollectorEquipmentUpdateEvent>, IMessage, IEquatable<TaxCollectorEquipmentUpdateEvent>, IDeepCloneable<TaxCollectorEquipmentUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00192018 File Offset: 0x00190218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorEquipmentUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00192028 File Offset: 0x00190228
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

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00192038 File Offset: 0x00190238
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

		// Token: 0x0600094E RID: 2382 RVA: 0x00192048 File Offset: 0x00190248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorEquipmentUpdateEvent()
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00192058 File Offset: 0x00190258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorEquipmentUpdateEvent(TaxCollectorEquipmentUpdateEvent other)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00192068 File Offset: 0x00190268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorEquipmentUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00192078 File Offset: 0x00190278
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00192088 File Offset: 0x00190288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TaxCollectorUid
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00192098 File Offset: 0x00190298
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x001920A8 File Offset: 0x001902A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectItemInventory Object
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x001920B8 File Offset: 0x001902B8
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x001920C8 File Offset: 0x001902C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Added
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x001920D8 File Offset: 0x001902D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterCharacteristic> Characteristics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x001920E8 File Offset: 0x001902E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x001920F8 File Offset: 0x001902F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorEquipmentUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00192108 File Offset: 0x00190308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00192118 File Offset: 0x00190318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00192128 File Offset: 0x00190328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00192138 File Offset: 0x00190338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00192148 File Offset: 0x00190348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00192158 File Offset: 0x00190358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorEquipmentUpdateEvent other)
		{
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00192168 File Offset: 0x00190368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00192178 File Offset: 0x00190378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00192188 File Offset: 0x00190388
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorEquipmentUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					TaxCollectorEquipmentUpdateEvent._parser = new MessageParser<TaxCollectorEquipmentUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TaxCollectorEquipmentUpdateEvent._repeated_characteristics_codec = FieldCodec.ForMessage<CharacterCharacteristic>(34U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
				num2 = 3;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00192278 File Offset: 0x00190478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LN41uGOkaxqC0A3uZvd1()
		{
			return true;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00192280 File Offset: 0x00190480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorEquipmentUpdateEvent Wt3cYaOk5rMBcyAN0H5l()
		{
			return null;
		}

		// Token: 0x04000373 RID: 883
		private static readonly MessageParser<TaxCollectorEquipmentUpdateEvent> _parser;

		// Token: 0x04000374 RID: 884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000375 RID: 885
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x04000376 RID: 886
		private string taxCollectorUid_;

		// Token: 0x04000377 RID: 887
		public const int ObjectFieldNumber = 2;

		// Token: 0x04000378 RID: 888
		private ObjectItemInventory object_;

		// Token: 0x04000379 RID: 889
		public const int AddedFieldNumber = 3;

		// Token: 0x0400037A RID: 890
		private bool added_;

		// Token: 0x0400037B RID: 891
		public const int CharacteristicsFieldNumber = 4;

		// Token: 0x0400037C RID: 892
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

		// Token: 0x0400037D RID: 893
		private readonly RepeatedField<CharacterCharacteristic> characteristics_;

		// Token: 0x0400037E RID: 894
		internal static TaxCollectorEquipmentUpdateEvent vL3AluOk1pBXQpwa04it;
	}
}
