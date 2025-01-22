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
	// Token: 0x02000B8D RID: 2957
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorInformation : IMessage<TaxCollectorInformation>, IMessage, IEquatable<TaxCollectorInformation>, IDeepCloneable<TaxCollectorInformation>, IBufferMessage
	{
		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x0026AFD4 File Offset: 0x002691D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06008DE2 RID: 36322 RVA: 0x0026AFE4 File Offset: 0x002691E4
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

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x0026AFF4 File Offset: 0x002691F4
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

		// Token: 0x06008DE4 RID: 36324 RVA: 0x0026B004 File Offset: 0x00269204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorInformation()
		{
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x0026B014 File Offset: 0x00269214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorInformation(TaxCollectorInformation other)
		{
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x0026B024 File Offset: 0x00269224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06008DE7 RID: 36327 RVA: 0x0026B034 File Offset: 0x00269234
		// (set) Token: 0x06008DE8 RID: 36328 RVA: 0x0026B044 File Offset: 0x00269244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Uid
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

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x0026B054 File Offset: 0x00269254
		// (set) Token: 0x06008DEA RID: 36330 RVA: 0x0026B064 File Offset: 0x00269264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstNameId
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

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06008DEB RID: 36331 RVA: 0x0026B074 File Offset: 0x00269274
		// (set) Token: 0x06008DEC RID: 36332 RVA: 0x0026B084 File Offset: 0x00269284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastNameId
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

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06008DED RID: 36333 RVA: 0x0026B094 File Offset: 0x00269294
		// (set) Token: 0x06008DEE RID: 36334 RVA: 0x0026B0A4 File Offset: 0x002692A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation Alliance
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

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x0026B0B4 File Offset: 0x002692B4
		// (set) Token: 0x06008DF0 RID: 36336 RVA: 0x0026B0C4 File Offset: 0x002692C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CallerId
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

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06008DF1 RID: 36337 RVA: 0x0026B0D4 File Offset: 0x002692D4
		// (set) Token: 0x06008DF2 RID: 36338 RVA: 0x0026B0E4 File Offset: 0x002692E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string CallerName
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

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06008DF3 RID: 36339 RVA: 0x0026B0F4 File Offset: 0x002692F4
		// (set) Token: 0x06008DF4 RID: 36340 RVA: 0x0026B104 File Offset: 0x00269304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long HiredDate
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

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x0026B114 File Offset: 0x00269314
		// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x0026B124 File Offset: 0x00269324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapCoordinates Coordinates
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

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008DF7 RID: 36343 RVA: 0x0026B134 File Offset: 0x00269334
		// (set) Token: 0x06008DF8 RID: 36344 RVA: 0x0026B144 File Offset: 0x00269344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubAreaId
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

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x0026B154 File Offset: 0x00269354
		// (set) Token: 0x06008DFA RID: 36346 RVA: 0x0026B164 File Offset: 0x00269364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MapId
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008DFB RID: 36347 RVA: 0x0026B174 File Offset: 0x00269374
		// (set) Token: 0x06008DFC RID: 36348 RVA: 0x0026B188 File Offset: 0x00269388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TaxCollectorState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06008DFD RID: 36349 RVA: 0x0026B198 File Offset: 0x00269398
		// (set) Token: 0x06008DFE RID: 36350 RVA: 0x0026B1A8 File Offset: 0x002693A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook EntityLook
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

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0026B1B8 File Offset: 0x002693B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaxCollectorComplementaryInformation> ComplementaryInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06008E00 RID: 36352 RVA: 0x0026B1C8 File Offset: 0x002693C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterCharacteristic> CharacterCharacteristics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x0026B1D8 File Offset: 0x002693D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectItemInventory> Equipments
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06008E02 RID: 36354 RVA: 0x0026B1E8 File Offset: 0x002693E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaxCollectorOrderedSpell> Spells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x0026B1F8 File Offset: 0x002693F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x0026B208 File Offset: 0x00269408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorInformation other)
		{
			return true;
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x0026B218 File Offset: 0x00269418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0026B228 File Offset: 0x00269428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x0026B238 File Offset: 0x00269438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x0026B248 File Offset: 0x00269448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x0026B258 File Offset: 0x00269458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x0026B268 File Offset: 0x00269468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorInformation other)
		{
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x0026B278 File Offset: 0x00269478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x0026B288 File Offset: 0x00269488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x0026B298 File Offset: 0x00269498
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 7;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					TaxCollectorInformation._repeated_equipments_codec = FieldCodec.ForMessage<ObjectItemInventory>(122U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					TaxCollectorInformation._repeated_characterCharacteristics_codec = FieldCodec.ForMessage<CharacterCharacteristic>(114U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					return;
				case 7:
					TaxCollectorInformation._parser = new MessageParser<TaxCollectorInformation>(() => null);
					num2 = 8;
					continue;
				case 8:
					TaxCollectorInformation._repeated_complementaryInformation_codec = FieldCodec.ForMessage<TaxCollectorComplementaryInformation>(106U, jTe3JgBlDptqHGpaUByJ.XVInXhlssT(jTe3JgBlDptqHGpaUByJ.qGZBlt7VCcR));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				}
				TaxCollectorInformation._repeated_spells_codec = FieldCodec.ForMessage<TaxCollectorOrderedSpell>(130U, VNeXjioNI0Bas9sNLR3.XVInXhlssT(VNeXjioNI0Bas9sNLR3.M9pox3YLqv));
				num2 = 6;
			}
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x0026B424 File Offset: 0x00269624
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RLZJChJ9rqRjTAiw3WGg()
		{
			return true;
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x0026B42C File Offset: 0x0026962C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorInformation tbbZi2J9VSPlSx3WPctp()
		{
			return null;
		}

		// Token: 0x04003492 RID: 13458
		private static readonly MessageParser<TaxCollectorInformation> _parser;

		// Token: 0x04003493 RID: 13459
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003494 RID: 13460
		public const int UidFieldNumber = 1;

		// Token: 0x04003495 RID: 13461
		private string uid_;

		// Token: 0x04003496 RID: 13462
		public const int FirstNameIdFieldNumber = 2;

		// Token: 0x04003497 RID: 13463
		private int firstNameId_;

		// Token: 0x04003498 RID: 13464
		public const int LastNameIdFieldNumber = 3;

		// Token: 0x04003499 RID: 13465
		private int lastNameId_;

		// Token: 0x0400349A RID: 13466
		public const int AllianceFieldNumber = 4;

		// Token: 0x0400349B RID: 13467
		private AllianceInformation alliance_;

		// Token: 0x0400349C RID: 13468
		public const int CallerIdFieldNumber = 5;

		// Token: 0x0400349D RID: 13469
		private long callerId_;

		// Token: 0x0400349E RID: 13470
		public const int CallerNameFieldNumber = 6;

		// Token: 0x0400349F RID: 13471
		private string callerName_;

		// Token: 0x040034A0 RID: 13472
		public const int HiredDateFieldNumber = 7;

		// Token: 0x040034A1 RID: 13473
		private long hiredDate_;

		// Token: 0x040034A2 RID: 13474
		public const int CoordinatesFieldNumber = 8;

		// Token: 0x040034A3 RID: 13475
		private MapCoordinates coordinates_;

		// Token: 0x040034A4 RID: 13476
		public const int SubAreaIdFieldNumber = 9;

		// Token: 0x040034A5 RID: 13477
		private int subAreaId_;

		// Token: 0x040034A6 RID: 13478
		public const int MapIdFieldNumber = 10;

		// Token: 0x040034A7 RID: 13479
		private long mapId_;

		// Token: 0x040034A8 RID: 13480
		public const int StateFieldNumber = 11;

		// Token: 0x040034A9 RID: 13481
		private TaxCollectorState state_;

		// Token: 0x040034AA RID: 13482
		public const int EntityLookFieldNumber = 12;

		// Token: 0x040034AB RID: 13483
		private EntityLook entityLook_;

		// Token: 0x040034AC RID: 13484
		public const int ComplementaryInformationFieldNumber = 13;

		// Token: 0x040034AD RID: 13485
		private static readonly FieldCodec<TaxCollectorComplementaryInformation> _repeated_complementaryInformation_codec;

		// Token: 0x040034AE RID: 13486
		private readonly RepeatedField<TaxCollectorComplementaryInformation> complementaryInformation_;

		// Token: 0x040034AF RID: 13487
		public const int CharacterCharacteristicsFieldNumber = 14;

		// Token: 0x040034B0 RID: 13488
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_characterCharacteristics_codec;

		// Token: 0x040034B1 RID: 13489
		private readonly RepeatedField<CharacterCharacteristic> characterCharacteristics_;

		// Token: 0x040034B2 RID: 13490
		public const int EquipmentsFieldNumber = 15;

		// Token: 0x040034B3 RID: 13491
		private static readonly FieldCodec<ObjectItemInventory> _repeated_equipments_codec;

		// Token: 0x040034B4 RID: 13492
		private readonly RepeatedField<ObjectItemInventory> equipments_;

		// Token: 0x040034B5 RID: 13493
		public const int SpellsFieldNumber = 16;

		// Token: 0x040034B6 RID: 13494
		private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

		// Token: 0x040034B7 RID: 13495
		private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

		// Token: 0x040034B8 RID: 13496
		internal static TaxCollectorInformation VV0iocJ9hyu2LhLspyss;
	}
}
