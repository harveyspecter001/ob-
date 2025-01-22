using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000234 RID: 564
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetUseResponse : IMessage<PresetUseResponse>, IMessage, IEquatable<PresetUseResponse>, IDeepCloneable<PresetUseResponse>, IBufferMessage
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x001B068C File Offset: 0x001AE88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetUseResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x001B069C File Offset: 0x001AE89C
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x001B06AC File Offset: 0x001AE8AC
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

		// Token: 0x06001A6C RID: 6764 RVA: 0x001B06BC File Offset: 0x001AE8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseResponse()
		{
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x001B06CC File Offset: 0x001AE8CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseResponse(PresetUseResponse other)
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x001B06DC File Offset: 0x001AE8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseResponse Clone()
		{
			return null;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x001B06EC File Offset: 0x001AE8EC
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x001B0700 File Offset: 0x001AE900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetUseResponse.Types.ResultEnum ResultEnum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetUseResponse.Types.ResultEnum)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x001B0710 File Offset: 0x001AE910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasResultEnum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x001B0720 File Offset: 0x001AE920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResultEnum()
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x001B0730 File Offset: 0x001AE930
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x001B0740 File Offset: 0x001AE940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetUseResponse.Types.MissingEquipments MissingEquipments
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x001B0750 File Offset: 0x001AE950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetUseResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetUseResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x001B0764 File Offset: 0x001AE964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x001B0774 File Offset: 0x001AE974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x001B0784 File Offset: 0x001AE984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetUseResponse other)
		{
			return true;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x001B0794 File Offset: 0x001AE994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x001B07A4 File Offset: 0x001AE9A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x001B07B4 File Offset: 0x001AE9B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x001B07C4 File Offset: 0x001AE9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x001B07D4 File Offset: 0x001AE9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x001B07E4 File Offset: 0x001AE9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetUseResponse other)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x001B07F4 File Offset: 0x001AE9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x001B0804 File Offset: 0x001AEA04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x001B0814 File Offset: 0x001AEA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetUseResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PresetUseResponse._parser = new MessageParser<PresetUseResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x001B08F8 File Offset: 0x001AEAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gHEuS4OaqTb0AV8fWMS7()
		{
			return true;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x001B0900 File Offset: 0x001AEB00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetUseResponse ylBCr1OaFVBdE2uPSFY4()
		{
			return null;
		}

		// Token: 0x0400095D RID: 2397
		private static readonly MessageParser<PresetUseResponse> _parser;

		// Token: 0x0400095E RID: 2398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400095F RID: 2399
		public const int ResultEnumFieldNumber = 1;

		// Token: 0x04000960 RID: 2400
		public const int MissingEquipmentsFieldNumber = 2;

		// Token: 0x04000961 RID: 2401
		private object result_;

		// Token: 0x04000962 RID: 2402
		private PresetUseResponse.ResultOneofCase resultCase_;

		// Token: 0x04000963 RID: 2403
		internal static PresetUseResponse wrMvfdOaZ8rZHiga7B2D;

		// Token: 0x02000235 RID: 565
		public enum ResultOneofCase
		{
			// Token: 0x04000965 RID: 2405
			None,
			// Token: 0x04000966 RID: 2406
			ResultEnum,
			// Token: 0x04000967 RID: 2407
			MissingEquipments
		}

		// Token: 0x02000236 RID: 566
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001A84 RID: 6788 RVA: 0x002B1D0C File Offset: 0x002AFF0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000237 RID: 567
			public enum ResultEnum
			{
				// Token: 0x04000969 RID: 2409
				[OriginalName("OK")]
				Ok,
				// Token: 0x0400096A RID: 2410
				[OriginalName("ERROR_COOLDOWN")]
				ErrorCooldown,
				// Token: 0x0400096B RID: 2411
				[OriginalName("ERROR_BAD_PRESET_UUID")]
				ErrorBadPresetUuid,
				// Token: 0x0400096C RID: 2412
				[OriginalName("ERROR_INVALID_STATE")]
				ErrorInvalidState,
				// Token: 0x0400096D RID: 2413
				[OriginalName("ERROR_UNKNOWN")]
				ErrorUnknown,
				// Token: 0x0400096E RID: 2414
				[OriginalName("ERROR_INVALID_DATA")]
				ErrorInvalidData,
				// Token: 0x0400096F RID: 2415
				[OriginalName("MISSING_SPELLS")]
				MissingSpells
			}

			// Token: 0x02000238 RID: 568
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MissingEquipments : IMessage<PresetUseResponse.Types.MissingEquipments>, IMessage, IEquatable<PresetUseResponse.Types.MissingEquipments>, IDeepCloneable<PresetUseResponse.Types.MissingEquipments>, IBufferMessage
			{
				// Token: 0x170004BA RID: 1210
				// (get) Token: 0x06001A85 RID: 6789 RVA: 0x002F978C File Offset: 0x002F798C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetUseResponse.Types.MissingEquipments> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004BB RID: 1211
				// (get) Token: 0x06001A86 RID: 6790 RVA: 0x002F979C File Offset: 0x002F799C
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

				// Token: 0x170004BC RID: 1212
				// (get) Token: 0x06001A87 RID: 6791 RVA: 0x002F97AC File Offset: 0x002F79AC
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

				// Token: 0x06001A88 RID: 6792 RVA: 0x002F97BC File Offset: 0x002F79BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MissingEquipments()
				{
				}

				// Token: 0x06001A89 RID: 6793 RVA: 0x002F97CC File Offset: 0x002F79CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MissingEquipments(PresetUseResponse.Types.MissingEquipments other)
				{
				}

				// Token: 0x06001A8A RID: 6794 RVA: 0x002F97DC File Offset: 0x002F79DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetUseResponse.Types.MissingEquipments Clone()
				{
					return null;
				}

				// Token: 0x170004BD RID: 1213
				// (get) Token: 0x06001A8B RID: 6795 RVA: 0x002F97EC File Offset: 0x002F79EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<int> MissingItemGids
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004BE RID: 1214
				// (get) Token: 0x06001A8C RID: 6796 RVA: 0x002F97FC File Offset: 0x002F79FC
				// (set) Token: 0x06001A8D RID: 6797 RVA: 0x002F980C File Offset: 0x002F7A0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MissingRideModelId
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

				// Token: 0x170004BF RID: 1215
				// (get) Token: 0x06001A8E RID: 6798 RVA: 0x002F981C File Offset: 0x002F7A1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasMissingRideModelId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06001A8F RID: 6799 RVA: 0x002F982C File Offset: 0x002F7A2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearMissingRideModelId()
				{
				}

				// Token: 0x06001A90 RID: 6800 RVA: 0x002F983C File Offset: 0x002F7A3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001A91 RID: 6801 RVA: 0x002F984C File Offset: 0x002F7A4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetUseResponse.Types.MissingEquipments other)
				{
					return true;
				}

				// Token: 0x06001A92 RID: 6802 RVA: 0x002F985C File Offset: 0x002F7A5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001A93 RID: 6803 RVA: 0x002F986C File Offset: 0x002F7A6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001A94 RID: 6804 RVA: 0x002F987C File Offset: 0x002F7A7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001A95 RID: 6805 RVA: 0x002F988C File Offset: 0x002F7A8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001A96 RID: 6806 RVA: 0x002F989C File Offset: 0x002F7A9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001A97 RID: 6807 RVA: 0x002F98AC File Offset: 0x002F7AAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetUseResponse.Types.MissingEquipments other)
				{
				}

				// Token: 0x06001A98 RID: 6808 RVA: 0x002F98BC File Offset: 0x002F7ABC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001A99 RID: 6809 RVA: 0x002F98CC File Offset: 0x002F7ACC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001A9A RID: 6810 RVA: 0x002F98DC File Offset: 0x002F7ADC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MissingEquipments()
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
							default:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 6;
								break;
							case 1:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								PresetUseResponse.Types.MissingEquipments._parser = new MessageParser<PresetUseResponse.Types.MissingEquipments>(() => null);
								num2 = 3;
								break;
							case 3:
								PresetUseResponse.Types.MissingEquipments._repeated_missingItemGids_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
								{
									num2 = 5;
								}
								break;
							case 4:
								return;
							case 5:
								goto IL_F8;
							case 6:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
								{
									num2 = 0;
								}
								break;
							}
						}
						IL_F8:
						PresetUseResponse.Types.MissingEquipments.MissingRideModelIdDefaultValue = 0;
						num = 4;
					}
				}

				// Token: 0x06001A9B RID: 6811 RVA: 0x002F99F4 File Offset: 0x002F7BF4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool sT1ln5GHJ0h8qNIaVFk6()
				{
					return true;
				}

				// Token: 0x06001A9C RID: 6812 RVA: 0x002F99FC File Offset: 0x002F7BFC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetUseResponse.Types.MissingEquipments UX7vPTGHGTjkRpiraDfx()
				{
					return null;
				}

				// Token: 0x04000970 RID: 2416
				private static readonly MessageParser<PresetUseResponse.Types.MissingEquipments> _parser;

				// Token: 0x04000971 RID: 2417
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000972 RID: 2418
				private int _hasBits0;

				// Token: 0x04000973 RID: 2419
				public const int MissingItemGidsFieldNumber = 1;

				// Token: 0x04000974 RID: 2420
				private static readonly FieldCodec<int> _repeated_missingItemGids_codec;

				// Token: 0x04000975 RID: 2421
				private readonly RepeatedField<int> missingItemGids_;

				// Token: 0x04000976 RID: 2422
				public const int MissingRideModelIdFieldNumber = 2;

				// Token: 0x04000977 RID: 2423
				private static readonly int MissingRideModelIdDefaultValue;

				// Token: 0x04000978 RID: 2424
				private int missingRideModelId_;

				// Token: 0x04000979 RID: 2425
				private static PresetUseResponse.Types.MissingEquipments COAAhLGHOtrcqgEuacdK;
			}
		}
	}
}
