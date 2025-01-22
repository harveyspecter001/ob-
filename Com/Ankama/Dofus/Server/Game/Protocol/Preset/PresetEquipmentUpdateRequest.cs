using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000248 RID: 584
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetEquipmentUpdateRequest : IMessage<PresetEquipmentUpdateRequest>, IMessage, IEquatable<PresetEquipmentUpdateRequest>, IDeepCloneable<PresetEquipmentUpdateRequest>, IBufferMessage
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x001B11F0 File Offset: 0x001AF3F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetEquipmentUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x001B1200 File Offset: 0x001AF400
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x001B1210 File Offset: 0x001AF410
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

		// Token: 0x06001B37 RID: 6967 RVA: 0x001B1220 File Offset: 0x001AF420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateRequest()
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x001B1230 File Offset: 0x001AF430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateRequest(PresetEquipmentUpdateRequest other)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x001B1240 File Offset: 0x001AF440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x001B1250 File Offset: 0x001AF450
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x001B1260 File Offset: 0x001AF460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string CharacterPresetUuid
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x001B1270 File Offset: 0x001AF470
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x001B1280 File Offset: 0x001AF480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetEquipmentUpdateRequest.Types.SetItem SetItem
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x001B1290 File Offset: 0x001AF490
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x001B12A0 File Offset: 0x001AF4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetEquipmentUpdateRequest.Types.RemoveItem RemoveItem
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x001B12B0 File Offset: 0x001AF4B0
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x001B12C0 File Offset: 0x001AF4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetEquipmentUpdateRequest.Types.SetRide SetRide
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x001B12D0 File Offset: 0x001AF4D0
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x001B12E0 File Offset: 0x001AF4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetEquipmentUpdateRequest.Types.RemoveRide RemoveRide
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x001B12F0 File Offset: 0x001AF4F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetEquipmentUpdateRequest.ActionOneofCase ActionCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetEquipmentUpdateRequest.ActionOneofCase)null;
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x001B1304 File Offset: 0x001AF504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAction()
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x001B1314 File Offset: 0x001AF514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x001B1324 File Offset: 0x001AF524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetEquipmentUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x001B1334 File Offset: 0x001AF534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x001B1344 File Offset: 0x001AF544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x001B1354 File Offset: 0x001AF554
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x001B1364 File Offset: 0x001AF564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x001B1374 File Offset: 0x001AF574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x001B1384 File Offset: 0x001AF584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetEquipmentUpdateRequest other)
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x001B1394 File Offset: 0x001AF594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x001B13A4 File Offset: 0x001AF5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x001B13B4 File Offset: 0x001AF5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetEquipmentUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PresetEquipmentUpdateRequest._parser = new MessageParser<PresetEquipmentUpdateRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x001B1498 File Offset: 0x001AF698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YiKXeUO5s5BwxRIQShLI()
		{
			return true;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x001B14A0 File Offset: 0x001AF6A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetEquipmentUpdateRequest pTRgRUO5dCZiBwpCUpcd()
		{
			return null;
		}

		// Token: 0x040009B0 RID: 2480
		private static readonly MessageParser<PresetEquipmentUpdateRequest> _parser;

		// Token: 0x040009B1 RID: 2481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009B2 RID: 2482
		public const int CharacterPresetUuidFieldNumber = 1;

		// Token: 0x040009B3 RID: 2483
		private string characterPresetUuid_;

		// Token: 0x040009B4 RID: 2484
		public const int SetItemFieldNumber = 2;

		// Token: 0x040009B5 RID: 2485
		public const int RemoveItemFieldNumber = 3;

		// Token: 0x040009B6 RID: 2486
		public const int SetRideFieldNumber = 4;

		// Token: 0x040009B7 RID: 2487
		public const int RemoveRideFieldNumber = 5;

		// Token: 0x040009B8 RID: 2488
		private object action_;

		// Token: 0x040009B9 RID: 2489
		private PresetEquipmentUpdateRequest.ActionOneofCase actionCase_;

		// Token: 0x040009BA RID: 2490
		private static PresetEquipmentUpdateRequest T47Y8ZO5grF1Bq62lxDp;

		// Token: 0x02000249 RID: 585
		public enum ActionOneofCase
		{
			// Token: 0x040009BC RID: 2492
			None,
			// Token: 0x040009BD RID: 2493
			SetItem = 2,
			// Token: 0x040009BE RID: 2494
			RemoveItem,
			// Token: 0x040009BF RID: 2495
			SetRide,
			// Token: 0x040009C0 RID: 2496
			RemoveRide
		}

		// Token: 0x0200024A RID: 586
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001B53 RID: 6995 RVA: 0x002B2220 File Offset: 0x002B0420
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200024B RID: 587
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SetItem : IMessage<PresetEquipmentUpdateRequest.Types.SetItem>, IMessage, IEquatable<PresetEquipmentUpdateRequest.Types.SetItem>, IDeepCloneable<PresetEquipmentUpdateRequest.Types.SetItem>, IBufferMessage
			{
				// Token: 0x170004E2 RID: 1250
				// (get) Token: 0x06001B54 RID: 6996 RVA: 0x002F9C20 File Offset: 0x002F7E20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PresetEquipmentUpdateRequest.Types.SetItem> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004E3 RID: 1251
				// (get) Token: 0x06001B55 RID: 6997 RVA: 0x002F9C30 File Offset: 0x002F7E30
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

				// Token: 0x170004E4 RID: 1252
				// (get) Token: 0x06001B56 RID: 6998 RVA: 0x002F9C40 File Offset: 0x002F7E40
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

				// Token: 0x06001B57 RID: 6999 RVA: 0x002F9C50 File Offset: 0x002F7E50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SetItem()
				{
				}

				// Token: 0x06001B58 RID: 7000 RVA: 0x002F9C60 File Offset: 0x002F7E60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SetItem(PresetEquipmentUpdateRequest.Types.SetItem other)
				{
				}

				// Token: 0x06001B59 RID: 7001 RVA: 0x002F9C70 File Offset: 0x002F7E70
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetEquipmentUpdateRequest.Types.SetItem Clone()
				{
					return null;
				}

				// Token: 0x170004E5 RID: 1253
				// (get) Token: 0x06001B5A RID: 7002 RVA: 0x002F9C80 File Offset: 0x002F7E80
				// (set) Token: 0x06001B5B RID: 7003 RVA: 0x002F9C90 File Offset: 0x002F7E90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Position
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

				// Token: 0x170004E6 RID: 1254
				// (get) Token: 0x06001B5C RID: 7004 RVA: 0x002F9CA0 File Offset: 0x002F7EA0
				// (set) Token: 0x06001B5D RID: 7005 RVA: 0x002F9CB0 File Offset: 0x002F7EB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ItemUid
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

				// Token: 0x06001B5E RID: 7006 RVA: 0x002F9CC0 File Offset: 0x002F7EC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001B5F RID: 7007 RVA: 0x002F9CD0 File Offset: 0x002F7ED0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetEquipmentUpdateRequest.Types.SetItem other)
				{
					return true;
				}

				// Token: 0x06001B60 RID: 7008 RVA: 0x002F9CE0 File Offset: 0x002F7EE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001B61 RID: 7009 RVA: 0x002F9CF0 File Offset: 0x002F7EF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001B62 RID: 7010 RVA: 0x002F9D00 File Offset: 0x002F7F00
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001B63 RID: 7011 RVA: 0x002F9D10 File Offset: 0x002F7F10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001B64 RID: 7012 RVA: 0x002F9D20 File Offset: 0x002F7F20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001B65 RID: 7013 RVA: 0x002F9D30 File Offset: 0x002F7F30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetEquipmentUpdateRequest.Types.SetItem other)
				{
				}

				// Token: 0x06001B66 RID: 7014 RVA: 0x002F9D40 File Offset: 0x002F7F40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001B67 RID: 7015 RVA: 0x002F9D50 File Offset: 0x002F7F50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001B68 RID: 7016 RVA: 0x002F9D60 File Offset: 0x002F7F60
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SetItem()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							PresetEquipmentUpdateRequest.Types.SetItem._parser = new MessageParser<PresetEquipmentUpdateRequest.Types.SetItem>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
					}
				}

				// Token: 0x06001B69 RID: 7017 RVA: 0x002F9E2C File Offset: 0x002F802C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool AfRY3xGHNEMblJbNvYBF()
				{
					return true;
				}

				// Token: 0x06001B6A RID: 7018 RVA: 0x002F9E34 File Offset: 0x002F8034
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetEquipmentUpdateRequest.Types.SetItem XS7VXUGHxvCkLf82fFmY()
				{
					return null;
				}

				// Token: 0x040009C1 RID: 2497
				private static readonly MessageParser<PresetEquipmentUpdateRequest.Types.SetItem> _parser;

				// Token: 0x040009C2 RID: 2498
				private UnknownFieldSet _unknownFields;

				// Token: 0x040009C3 RID: 2499
				public const int PositionFieldNumber = 1;

				// Token: 0x040009C4 RID: 2500
				private int position_;

				// Token: 0x040009C5 RID: 2501
				public const int ItemUidFieldNumber = 2;

				// Token: 0x040009C6 RID: 2502
				private int itemUid_;

				// Token: 0x040009C7 RID: 2503
				private static PresetEquipmentUpdateRequest.Types.SetItem DUhlhXGHXnlIVky9KpP2;
			}

			// Token: 0x0200024D RID: 589
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class RemoveItem : IMessage<PresetEquipmentUpdateRequest.Types.RemoveItem>, IMessage, IEquatable<PresetEquipmentUpdateRequest.Types.RemoveItem>, IDeepCloneable<PresetEquipmentUpdateRequest.Types.RemoveItem>, IBufferMessage
			{
				// Token: 0x170004E7 RID: 1255
				// (get) Token: 0x06001B70 RID: 7024 RVA: 0x002F9E3C File Offset: 0x002F803C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PresetEquipmentUpdateRequest.Types.RemoveItem> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004E8 RID: 1256
				// (get) Token: 0x06001B71 RID: 7025 RVA: 0x002F9E4C File Offset: 0x002F804C
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

				// Token: 0x170004E9 RID: 1257
				// (get) Token: 0x06001B72 RID: 7026 RVA: 0x002F9E5C File Offset: 0x002F805C
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

				// Token: 0x06001B73 RID: 7027 RVA: 0x002F9E6C File Offset: 0x002F806C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemoveItem()
				{
				}

				// Token: 0x06001B74 RID: 7028 RVA: 0x002F9E7C File Offset: 0x002F807C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemoveItem(PresetEquipmentUpdateRequest.Types.RemoveItem other)
				{
				}

				// Token: 0x06001B75 RID: 7029 RVA: 0x002F9E8C File Offset: 0x002F808C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetEquipmentUpdateRequest.Types.RemoveItem Clone()
				{
					return null;
				}

				// Token: 0x170004EA RID: 1258
				// (get) Token: 0x06001B76 RID: 7030 RVA: 0x002F9E9C File Offset: 0x002F809C
				// (set) Token: 0x06001B77 RID: 7031 RVA: 0x002F9EAC File Offset: 0x002F80AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Position
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

				// Token: 0x06001B78 RID: 7032 RVA: 0x002F9EBC File Offset: 0x002F80BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001B79 RID: 7033 RVA: 0x002F9ECC File Offset: 0x002F80CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetEquipmentUpdateRequest.Types.RemoveItem other)
				{
					return true;
				}

				// Token: 0x06001B7A RID: 7034 RVA: 0x002F9EDC File Offset: 0x002F80DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001B7B RID: 7035 RVA: 0x002F9EEC File Offset: 0x002F80EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001B7C RID: 7036 RVA: 0x002F9EFC File Offset: 0x002F80FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001B7D RID: 7037 RVA: 0x002F9F0C File Offset: 0x002F810C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001B7E RID: 7038 RVA: 0x002F9F1C File Offset: 0x002F811C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001B7F RID: 7039 RVA: 0x002F9F2C File Offset: 0x002F812C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetEquipmentUpdateRequest.Types.RemoveItem other)
				{
				}

				// Token: 0x06001B80 RID: 7040 RVA: 0x002F9F3C File Offset: 0x002F813C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001B81 RID: 7041 RVA: 0x002F9F4C File Offset: 0x002F814C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001B82 RID: 7042 RVA: 0x002F9F5C File Offset: 0x002F815C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static RemoveItem()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 2;
							}
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
							{
								num2 = 4;
							}
							break;
						case 3:
							return;
						case 4:
							PresetEquipmentUpdateRequest.Types.RemoveItem._parser = new MessageParser<PresetEquipmentUpdateRequest.Types.RemoveItem>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
							{
								num2 = 3;
							}
							break;
						}
					}
				}

				// Token: 0x06001B83 RID: 7043 RVA: 0x002FA054 File Offset: 0x002F8254
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ou82FOGHjYaBpbspldB3()
				{
					return true;
				}

				// Token: 0x06001B84 RID: 7044 RVA: 0x002FA05C File Offset: 0x002F825C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetEquipmentUpdateRequest.Types.RemoveItem Q3Qw5dGHKPCPtDTEjfIl()
				{
					return null;
				}

				// Token: 0x040009CA RID: 2506
				private static readonly MessageParser<PresetEquipmentUpdateRequest.Types.RemoveItem> _parser;

				// Token: 0x040009CB RID: 2507
				private UnknownFieldSet _unknownFields;

				// Token: 0x040009CC RID: 2508
				public const int PositionFieldNumber = 1;

				// Token: 0x040009CD RID: 2509
				private int position_;

				// Token: 0x040009CE RID: 2510
				internal static PresetEquipmentUpdateRequest.Types.RemoveItem oqLxgYGH444wn9jrxMhe;
			}

			// Token: 0x0200024F RID: 591
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SetRide : IMessage<PresetEquipmentUpdateRequest.Types.SetRide>, IMessage, IEquatable<PresetEquipmentUpdateRequest.Types.SetRide>, IDeepCloneable<PresetEquipmentUpdateRequest.Types.SetRide>, IBufferMessage
			{
				// Token: 0x170004EB RID: 1259
				// (get) Token: 0x06001B8A RID: 7050 RVA: 0x002FA064 File Offset: 0x002F8264
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PresetEquipmentUpdateRequest.Types.SetRide> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004EC RID: 1260
				// (get) Token: 0x06001B8B RID: 7051 RVA: 0x002FA074 File Offset: 0x002F8274
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

				// Token: 0x170004ED RID: 1261
				// (get) Token: 0x06001B8C RID: 7052 RVA: 0x002FA084 File Offset: 0x002F8284
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

				// Token: 0x06001B8D RID: 7053 RVA: 0x002FA094 File Offset: 0x002F8294
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SetRide()
				{
				}

				// Token: 0x06001B8E RID: 7054 RVA: 0x002FA0A4 File Offset: 0x002F82A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SetRide(PresetEquipmentUpdateRequest.Types.SetRide other)
				{
				}

				// Token: 0x06001B8F RID: 7055 RVA: 0x002FA0B4 File Offset: 0x002F82B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetEquipmentUpdateRequest.Types.SetRide Clone()
				{
					return null;
				}

				// Token: 0x06001B90 RID: 7056 RVA: 0x002FA0C4 File Offset: 0x002F82C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001B91 RID: 7057 RVA: 0x002FA0D4 File Offset: 0x002F82D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetEquipmentUpdateRequest.Types.SetRide other)
				{
					return true;
				}

				// Token: 0x06001B92 RID: 7058 RVA: 0x002FA0E4 File Offset: 0x002F82E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001B93 RID: 7059 RVA: 0x002FA0F4 File Offset: 0x002F82F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001B94 RID: 7060 RVA: 0x002FA104 File Offset: 0x002F8304
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001B95 RID: 7061 RVA: 0x002FA114 File Offset: 0x002F8314
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001B96 RID: 7062 RVA: 0x002FA124 File Offset: 0x002F8324
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001B97 RID: 7063 RVA: 0x002FA134 File Offset: 0x002F8334
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetEquipmentUpdateRequest.Types.SetRide other)
				{
				}

				// Token: 0x06001B98 RID: 7064 RVA: 0x002FA144 File Offset: 0x002F8344
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001B99 RID: 7065 RVA: 0x002FA154 File Offset: 0x002F8354
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001B9A RID: 7066 RVA: 0x002FA164 File Offset: 0x002F8364
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SetRide()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							PresetEquipmentUpdateRequest.Types.SetRide._parser = new MessageParser<PresetEquipmentUpdateRequest.Types.SetRide>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
					}
				}

				// Token: 0x06001B9B RID: 7067 RVA: 0x002FA230 File Offset: 0x002F8430
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool oZitnfGHkppsyiVtKBgO()
				{
					return true;
				}

				// Token: 0x06001B9C RID: 7068 RVA: 0x002FA238 File Offset: 0x002F8438
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetEquipmentUpdateRequest.Types.SetRide x3LnSqGHlNLDrk4KZuNr()
				{
					return null;
				}

				// Token: 0x040009D1 RID: 2513
				private static readonly MessageParser<PresetEquipmentUpdateRequest.Types.SetRide> _parser;

				// Token: 0x040009D2 RID: 2514
				private UnknownFieldSet _unknownFields;

				// Token: 0x040009D3 RID: 2515
				internal static PresetEquipmentUpdateRequest.Types.SetRide g63Qv2GHIfhKcAqbwvFy;
			}

			// Token: 0x02000251 RID: 593
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class RemoveRide : IMessage<PresetEquipmentUpdateRequest.Types.RemoveRide>, IMessage, IEquatable<PresetEquipmentUpdateRequest.Types.RemoveRide>, IDeepCloneable<PresetEquipmentUpdateRequest.Types.RemoveRide>, IBufferMessage
			{
				// Token: 0x170004EE RID: 1262
				// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x002FA240 File Offset: 0x002F8440
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetEquipmentUpdateRequest.Types.RemoveRide> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004EF RID: 1263
				// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x002FA250 File Offset: 0x002F8450
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

				// Token: 0x170004F0 RID: 1264
				// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x002FA260 File Offset: 0x002F8460
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

				// Token: 0x06001BA5 RID: 7077 RVA: 0x002FA270 File Offset: 0x002F8470
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemoveRide()
				{
				}

				// Token: 0x06001BA6 RID: 7078 RVA: 0x002FA280 File Offset: 0x002F8480
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemoveRide(PresetEquipmentUpdateRequest.Types.RemoveRide other)
				{
				}

				// Token: 0x06001BA7 RID: 7079 RVA: 0x002FA290 File Offset: 0x002F8490
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetEquipmentUpdateRequest.Types.RemoveRide Clone()
				{
					return null;
				}

				// Token: 0x06001BA8 RID: 7080 RVA: 0x002FA2A0 File Offset: 0x002F84A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001BA9 RID: 7081 RVA: 0x002FA2B0 File Offset: 0x002F84B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetEquipmentUpdateRequest.Types.RemoveRide other)
				{
					return true;
				}

				// Token: 0x06001BAA RID: 7082 RVA: 0x002FA2C0 File Offset: 0x002F84C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001BAB RID: 7083 RVA: 0x002FA2D0 File Offset: 0x002F84D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001BAC RID: 7084 RVA: 0x002FA2E0 File Offset: 0x002F84E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001BAD RID: 7085 RVA: 0x002FA2F0 File Offset: 0x002F84F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001BAE RID: 7086 RVA: 0x002FA300 File Offset: 0x002F8500
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001BAF RID: 7087 RVA: 0x002FA310 File Offset: 0x002F8510
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetEquipmentUpdateRequest.Types.RemoveRide other)
				{
				}

				// Token: 0x06001BB0 RID: 7088 RVA: 0x002FA320 File Offset: 0x002F8520
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001BB1 RID: 7089 RVA: 0x002FA330 File Offset: 0x002F8530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001BB2 RID: 7090 RVA: 0x002FA340 File Offset: 0x002F8540
				[MethodImpl(MethodImplOptions.NoInlining)]
				static RemoveRide()
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
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
							{
								num2 = 3;
							}
							break;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 4:
							PresetEquipmentUpdateRequest.Types.RemoveRide._parser = new MessageParser<PresetEquipmentUpdateRequest.Types.RemoveRide>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x06001BB3 RID: 7091 RVA: 0x002FA424 File Offset: 0x002F8624
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool oC9jBVGHUhepBOv8ERpa()
				{
					return true;
				}

				// Token: 0x06001BB4 RID: 7092 RVA: 0x002FA42C File Offset: 0x002F862C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetEquipmentUpdateRequest.Types.RemoveRide ayAxQ7GHvR4lkW2iNU7T()
				{
					return null;
				}

				// Token: 0x040009D6 RID: 2518
				private static readonly MessageParser<PresetEquipmentUpdateRequest.Types.RemoveRide> _parser;

				// Token: 0x040009D7 RID: 2519
				private UnknownFieldSet _unknownFields;

				// Token: 0x040009D8 RID: 2520
				internal static PresetEquipmentUpdateRequest.Types.RemoveRide RGwJLcGHcesl9aoBt7cc;
			}
		}
	}
}
