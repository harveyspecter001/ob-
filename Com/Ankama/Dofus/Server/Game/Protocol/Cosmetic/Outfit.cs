using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CD7 RID: 3287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Outfit : IMessage<Outfit>, IMessage, IEquatable<Outfit>, IDeepCloneable<Outfit>, IBufferMessage
	{
		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x002839D4 File Offset: 0x00281BD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Outfit> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x002839E4 File Offset: 0x00281BE4
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

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06009E27 RID: 40487 RVA: 0x002839F4 File Offset: 0x00281BF4
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

		// Token: 0x06009E28 RID: 40488 RVA: 0x00283A04 File Offset: 0x00281C04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outfit()
		{
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x00283A14 File Offset: 0x00281C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outfit(Outfit other)
		{
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x00283A24 File Offset: 0x00281C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outfit Clone()
		{
			return null;
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06009E2B RID: 40491 RVA: 0x00283A34 File Offset: 0x00281C34
		// (set) Token: 0x06009E2C RID: 40492 RVA: 0x00283A44 File Offset: 0x00281C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uuid
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

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06009E2D RID: 40493 RVA: 0x00283A54 File Offset: 0x00281C54
		// (set) Token: 0x06009E2E RID: 40494 RVA: 0x00283A64 File Offset: 0x00281C64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06009E2F RID: 40495 RVA: 0x00283A74 File Offset: 0x00281C74
		// (set) Token: 0x06009E30 RID: 40496 RVA: 0x00283A84 File Offset: 0x00281C84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PictogramId
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

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06009E31 RID: 40497 RVA: 0x00283A94 File Offset: 0x00281C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Outfit.Types.ObjectsEntry> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x00283AA4 File Offset: 0x00281CA4
		// (set) Token: 0x06009E33 RID: 40499 RVA: 0x00283AB4 File Offset: 0x00281CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Favorite
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

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x00283AC4 File Offset: 0x00281CC4
		// (set) Token: 0x06009E35 RID: 40501 RVA: 0x00283AD4 File Offset: 0x00281CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LastModified
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

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x00283AE4 File Offset: 0x00281CE4
		// (set) Token: 0x06009E37 RID: 40503 RVA: 0x00283AF4 File Offset: 0x00281CF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FaceId
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

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x00283B04 File Offset: 0x00281D04
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x00283B14 File Offset: 0x00281D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColorPalette ColorPalette
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

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x00283B24 File Offset: 0x00281D24
		// (set) Token: 0x06009E3B RID: 40507 RVA: 0x00283B34 File Offset: 0x00281D34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AuraEmoteId
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

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06009E3C RID: 40508 RVA: 0x00283B44 File Offset: 0x00281D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasAuraEmoteId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x00283B54 File Offset: 0x00281D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAuraEmoteId()
		{
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x00283B64 File Offset: 0x00281D64
		// (set) Token: 0x06009E3F RID: 40511 RVA: 0x00283B74 File Offset: 0x00281D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
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

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06009E40 RID: 40512 RVA: 0x00283B84 File Offset: 0x00281D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasOrnamentId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x00283B94 File Offset: 0x00281D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOrnamentId()
		{
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06009E42 RID: 40514 RVA: 0x00283BA4 File Offset: 0x00281DA4
		// (set) Token: 0x06009E43 RID: 40515 RVA: 0x00283BB4 File Offset: 0x00281DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TitleId
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

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06009E44 RID: 40516 RVA: 0x00283BC4 File Offset: 0x00281DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTitleId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x00283BD4 File Offset: 0x00281DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearTitleId()
		{
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06009E46 RID: 40518 RVA: 0x00283BE4 File Offset: 0x00281DE4
		// (set) Token: 0x06009E47 RID: 40519 RVA: 0x00283BF4 File Offset: 0x00281DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06009E48 RID: 40520 RVA: 0x00283C04 File Offset: 0x00281E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x00283C14 File Offset: 0x00281E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Outfit other)
		{
			return true;
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x00283C24 File Offset: 0x00281E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x00283C34 File Offset: 0x00281E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x00283C44 File Offset: 0x00281E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x00283C54 File Offset: 0x00281E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x00283C64 File Offset: 0x00281E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x00283C74 File Offset: 0x00281E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Outfit other)
		{
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x00283C84 File Offset: 0x00281E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x00283C94 File Offset: 0x00281E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x00283CA4 File Offset: 0x00281EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Outfit()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 7;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_13B;
					case 2:
						Outfit.OrnamentIdDefaultValue = 0;
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						Outfit.TitleIdDefaultValue = 0;
						num2 = 3;
						continue;
					case 5:
						Outfit._repeated_objects_codec = FieldCodec.ForMessage<Outfit.Types.ObjectsEntry>(34U, npXtv1etw3pFwxy5e77e.XVInXhlssT(npXtv1etw3pFwxy5e77e.FtPetQ7Z95b));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 8;
						continue;
					case 7:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 6;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 8:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					Outfit.AuraEmoteIdDefaultValue = 0;
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 0;
					}
				}
				IL_13B:
				Outfit._parser = new MessageParser<Outfit>(() => null);
				num = 5;
			}
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x00283E14 File Offset: 0x00282014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xpm0quJjfRGsEdxU7Ofl()
		{
			return true;
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x00283E1C File Offset: 0x0028201C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Outfit by8TPyJjneIRqliJwJDj()
		{
			return null;
		}

		// Token: 0x04003A8E RID: 14990
		private static readonly MessageParser<Outfit> _parser;

		// Token: 0x04003A8F RID: 14991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A90 RID: 14992
		private int _hasBits0;

		// Token: 0x04003A91 RID: 14993
		public const int UuidFieldNumber = 1;

		// Token: 0x04003A92 RID: 14994
		private string uuid_;

		// Token: 0x04003A93 RID: 14995
		public const int NameFieldNumber = 2;

		// Token: 0x04003A94 RID: 14996
		private string name_;

		// Token: 0x04003A95 RID: 14997
		public const int PictogramIdFieldNumber = 3;

		// Token: 0x04003A96 RID: 14998
		private int pictogramId_;

		// Token: 0x04003A97 RID: 14999
		public const int ObjectsFieldNumber = 4;

		// Token: 0x04003A98 RID: 15000
		private static readonly FieldCodec<Outfit.Types.ObjectsEntry> _repeated_objects_codec;

		// Token: 0x04003A99 RID: 15001
		private readonly RepeatedField<Outfit.Types.ObjectsEntry> objects_;

		// Token: 0x04003A9A RID: 15002
		public const int FavoriteFieldNumber = 9;

		// Token: 0x04003A9B RID: 15003
		private bool favorite_;

		// Token: 0x04003A9C RID: 15004
		public const int LastModifiedFieldNumber = 10;

		// Token: 0x04003A9D RID: 15005
		private string lastModified_;

		// Token: 0x04003A9E RID: 15006
		public const int FaceIdFieldNumber = 11;

		// Token: 0x04003A9F RID: 15007
		private int faceId_;

		// Token: 0x04003AA0 RID: 15008
		public const int ColorPaletteFieldNumber = 12;

		// Token: 0x04003AA1 RID: 15009
		private ColorPalette colorPalette_;

		// Token: 0x04003AA2 RID: 15010
		public const int AuraEmoteIdFieldNumber = 5;

		// Token: 0x04003AA3 RID: 15011
		private static readonly int AuraEmoteIdDefaultValue;

		// Token: 0x04003AA4 RID: 15012
		private int auraEmoteId_;

		// Token: 0x04003AA5 RID: 15013
		public const int OrnamentIdFieldNumber = 6;

		// Token: 0x04003AA6 RID: 15014
		private static readonly int OrnamentIdDefaultValue;

		// Token: 0x04003AA7 RID: 15015
		private int ornamentId_;

		// Token: 0x04003AA8 RID: 15016
		public const int TitleIdFieldNumber = 7;

		// Token: 0x04003AA9 RID: 15017
		private static readonly int TitleIdDefaultValue;

		// Token: 0x04003AAA RID: 15018
		private int titleId_;

		// Token: 0x04003AAB RID: 15019
		public const int EntityLookFieldNumber = 8;

		// Token: 0x04003AAC RID: 15020
		private EntityLook entityLook_;

		// Token: 0x04003AAD RID: 15021
		internal static Outfit uAXSqkJ4zR5LyqxwQvgi;

		// Token: 0x02000CD8 RID: 3288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06009E55 RID: 40533 RVA: 0x002EBF8C File Offset: 0x002EA18C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000CD9 RID: 3289
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectsEntry : IMessage<Outfit.Types.ObjectsEntry>, IMessage, IEquatable<Outfit.Types.ObjectsEntry>, IDeepCloneable<Outfit.Types.ObjectsEntry>, IBufferMessage
			{
				// Token: 0x17001D82 RID: 7554
				// (get) Token: 0x06009E56 RID: 40534 RVA: 0x0030E600 File Offset: 0x0030C800
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Outfit.Types.ObjectsEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001D83 RID: 7555
				// (get) Token: 0x06009E57 RID: 40535 RVA: 0x0030E610 File Offset: 0x0030C810
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

				// Token: 0x17001D84 RID: 7556
				// (get) Token: 0x06009E58 RID: 40536 RVA: 0x0030E620 File Offset: 0x0030C820
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

				// Token: 0x06009E59 RID: 40537 RVA: 0x0030E630 File Offset: 0x0030C830
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectsEntry()
				{
				}

				// Token: 0x06009E5A RID: 40538 RVA: 0x0030E640 File Offset: 0x0030C840
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectsEntry(Outfit.Types.ObjectsEntry other)
				{
				}

				// Token: 0x06009E5B RID: 40539 RVA: 0x0030E650 File Offset: 0x0030C850
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Outfit.Types.ObjectsEntry Clone()
				{
					return null;
				}

				// Token: 0x17001D85 RID: 7557
				// (get) Token: 0x06009E5C RID: 40540 RVA: 0x0030E660 File Offset: 0x0030C860
				// (set) Token: 0x06009E5D RID: 40541 RVA: 0x0030E670 File Offset: 0x0030C870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Key
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

				// Token: 0x17001D86 RID: 7558
				// (get) Token: 0x06009E5E RID: 40542 RVA: 0x0030E680 File Offset: 0x0030C880
				// (set) Token: 0x06009E5F RID: 40543 RVA: 0x0030E690 File Offset: 0x0030C890
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Outfit.Types.SkinOutfit Value
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

				// Token: 0x06009E60 RID: 40544 RVA: 0x0030E6A0 File Offset: 0x0030C8A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009E61 RID: 40545 RVA: 0x0030E6B0 File Offset: 0x0030C8B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(Outfit.Types.ObjectsEntry other)
				{
					return true;
				}

				// Token: 0x06009E62 RID: 40546 RVA: 0x0030E6C0 File Offset: 0x0030C8C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009E63 RID: 40547 RVA: 0x0030E6D0 File Offset: 0x0030C8D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009E64 RID: 40548 RVA: 0x0030E6E0 File Offset: 0x0030C8E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009E65 RID: 40549 RVA: 0x0030E6F0 File Offset: 0x0030C8F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009E66 RID: 40550 RVA: 0x0030E700 File Offset: 0x0030C900
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009E67 RID: 40551 RVA: 0x0030E710 File Offset: 0x0030C910
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(Outfit.Types.ObjectsEntry other)
				{
				}

				// Token: 0x06009E68 RID: 40552 RVA: 0x0030E720 File Offset: 0x0030C920
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009E69 RID: 40553 RVA: 0x0030E730 File Offset: 0x0030C930
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009E6A RID: 40554 RVA: 0x0030E740 File Offset: 0x0030C940
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectsEntry()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							Outfit.Types.ObjectsEntry._parser = new MessageParser<Outfit.Types.ObjectsEntry>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
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

				// Token: 0x06009E6B RID: 40555 RVA: 0x0030E80C File Offset: 0x0030CA0C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool uE4rsuGZFW9Vr31yWRLn()
				{
					return true;
				}

				// Token: 0x06009E6C RID: 40556 RVA: 0x0030E814 File Offset: 0x0030CA14
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static Outfit.Types.ObjectsEntry Cqf9I1GZzMhY6EqmHvE1()
				{
					return null;
				}

				// Token: 0x04003AAE RID: 15022
				private static readonly MessageParser<Outfit.Types.ObjectsEntry> _parser;

				// Token: 0x04003AAF RID: 15023
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003AB0 RID: 15024
				public const int KeyFieldNumber = 1;

				// Token: 0x04003AB1 RID: 15025
				private int key_;

				// Token: 0x04003AB2 RID: 15026
				public const int ValueFieldNumber = 2;

				// Token: 0x04003AB3 RID: 15027
				private Outfit.Types.SkinOutfit value_;

				// Token: 0x04003AB4 RID: 15028
				internal static Outfit.Types.ObjectsEntry MfS1jJGZqEktnBrQFYbu;
			}

			// Token: 0x02000CDB RID: 3291
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SkinOutfit : IMessage<Outfit.Types.SkinOutfit>, IMessage, IEquatable<Outfit.Types.SkinOutfit>, IDeepCloneable<Outfit.Types.SkinOutfit>, IBufferMessage
			{
				// Token: 0x17001D87 RID: 7559
				// (get) Token: 0x06009E72 RID: 40562 RVA: 0x0030E81C File Offset: 0x0030CA1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Outfit.Types.SkinOutfit> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001D88 RID: 7560
				// (get) Token: 0x06009E73 RID: 40563 RVA: 0x0030E82C File Offset: 0x0030CA2C
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

				// Token: 0x17001D89 RID: 7561
				// (get) Token: 0x06009E74 RID: 40564 RVA: 0x0030E83C File Offset: 0x0030CA3C
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

				// Token: 0x06009E75 RID: 40565 RVA: 0x0030E84C File Offset: 0x0030CA4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SkinOutfit()
				{
				}

				// Token: 0x06009E76 RID: 40566 RVA: 0x0030E85C File Offset: 0x0030CA5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SkinOutfit(Outfit.Types.SkinOutfit other)
				{
				}

				// Token: 0x06009E77 RID: 40567 RVA: 0x0030E86C File Offset: 0x0030CA6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Outfit.Types.SkinOutfit Clone()
				{
					return null;
				}

				// Token: 0x17001D8A RID: 7562
				// (get) Token: 0x06009E78 RID: 40568 RVA: 0x0030E87C File Offset: 0x0030CA7C
				// (set) Token: 0x06009E79 RID: 40569 RVA: 0x0030E88C File Offset: 0x0030CA8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Gid
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

				// Token: 0x17001D8B RID: 7563
				// (get) Token: 0x06009E7A RID: 40570 RVA: 0x0030E89C File Offset: 0x0030CA9C
				// (set) Token: 0x06009E7B RID: 40571 RVA: 0x0030E8AC File Offset: 0x0030CAAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Skin
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

				// Token: 0x17001D8C RID: 7564
				// (get) Token: 0x06009E7C RID: 40572 RVA: 0x0030E8BC File Offset: 0x0030CABC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasSkin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06009E7D RID: 40573 RVA: 0x0030E8CC File Offset: 0x0030CACC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearSkin()
				{
				}

				// Token: 0x06009E7E RID: 40574 RVA: 0x0030E8DC File Offset: 0x0030CADC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009E7F RID: 40575 RVA: 0x0030E8EC File Offset: 0x0030CAEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(Outfit.Types.SkinOutfit other)
				{
					return true;
				}

				// Token: 0x06009E80 RID: 40576 RVA: 0x0030E8FC File Offset: 0x0030CAFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009E81 RID: 40577 RVA: 0x0030E90C File Offset: 0x0030CB0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009E82 RID: 40578 RVA: 0x0030E91C File Offset: 0x0030CB1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009E83 RID: 40579 RVA: 0x0030E92C File Offset: 0x0030CB2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009E84 RID: 40580 RVA: 0x0030E93C File Offset: 0x0030CB3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009E85 RID: 40581 RVA: 0x0030E94C File Offset: 0x0030CB4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(Outfit.Types.SkinOutfit other)
				{
				}

				// Token: 0x06009E86 RID: 40582 RVA: 0x0030E95C File Offset: 0x0030CB5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009E87 RID: 40583 RVA: 0x0030E96C File Offset: 0x0030CB6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009E88 RID: 40584 RVA: 0x0030E97C File Offset: 0x0030CB7C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SkinOutfit()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							Outfit.Types.SkinOutfit._parser = new MessageParser<Outfit.Types.SkinOutfit>(() => null);
							num2 = 5;
							continue;
						case 5:
							Outfit.Types.SkinOutfit.SkinDefaultValue = 0;
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06009E89 RID: 40585 RVA: 0x0030EA88 File Offset: 0x0030CC88
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool y1yuaIGqnXRZmneQuMhH()
				{
					return true;
				}

				// Token: 0x06009E8A RID: 40586 RVA: 0x0030EA90 File Offset: 0x0030CC90
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static Outfit.Types.SkinOutfit SbVoJBGqm168dB1KVy64()
				{
					return null;
				}

				// Token: 0x04003AB7 RID: 15031
				private static readonly MessageParser<Outfit.Types.SkinOutfit> _parser;

				// Token: 0x04003AB8 RID: 15032
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003AB9 RID: 15033
				private int _hasBits0;

				// Token: 0x04003ABA RID: 15034
				public const int GidFieldNumber = 1;

				// Token: 0x04003ABB RID: 15035
				private int gid_;

				// Token: 0x04003ABC RID: 15036
				public const int SkinFieldNumber = 2;

				// Token: 0x04003ABD RID: 15037
				private static readonly int SkinDefaultValue;

				// Token: 0x04003ABE RID: 15038
				private int skin_;

				// Token: 0x04003ABF RID: 15039
				internal static Outfit.Types.SkinOutfit HUt2nAGqf0r0QPSYoMYZ;
			}
		}
	}
}
