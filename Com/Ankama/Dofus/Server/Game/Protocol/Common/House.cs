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
	// Token: 0x02000B20 RID: 2848
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class House : IMessage<House>, IMessage, IEquatable<House>, IDeepCloneable<House>, IBufferMessage
	{
		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x002661E8 File Offset: 0x002643E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<House> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600882B RID: 34859 RVA: 0x002661F8 File Offset: 0x002643F8
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

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x00266208 File Offset: 0x00264408
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

		// Token: 0x0600882D RID: 34861 RVA: 0x00266218 File Offset: 0x00264418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public House()
		{
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x00266228 File Offset: 0x00264428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public House(House other)
		{
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x00266238 File Offset: 0x00264438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public House Clone()
		{
			return null;
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x00266248 File Offset: 0x00264448
		// (set) Token: 0x06008831 RID: 34865 RVA: 0x00266258 File Offset: 0x00264458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HouseId
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

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x00266268 File Offset: 0x00264468
		// (set) Token: 0x06008833 RID: 34867 RVA: 0x00266278 File Offset: 0x00264478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ModelId
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

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x00266288 File Offset: 0x00264488
		// (set) Token: 0x06008835 RID: 34869 RVA: 0x00266298 File Offset: 0x00264498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public House.Types.HouseAccount HouseAccount
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x002662A8 File Offset: 0x002644A8
		// (set) Token: 0x06008837 RID: 34871 RVA: 0x002662B8 File Offset: 0x002644B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public House.Types.HouseOnMap HouseOnMap
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

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x002662C8 File Offset: 0x002644C8
		// (set) Token: 0x06008839 RID: 34873 RVA: 0x002662D8 File Offset: 0x002644D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public House.Types.HouseInside HouseInside
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600883A RID: 34874 RVA: 0x002662E8 File Offset: 0x002644E8
		// (set) Token: 0x0600883B RID: 34875 RVA: 0x002662F8 File Offset: 0x002644F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public House.Types.HouseGuild HouseGuild
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

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x0600883C RID: 34876 RVA: 0x00266308 File Offset: 0x00264508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public House.InformationOneofCase InformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (House.InformationOneofCase)null;
			}
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x0026631C File Offset: 0x0026451C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearInformation()
		{
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x0026632C File Offset: 0x0026452C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0026633C File Offset: 0x0026453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(House other)
		{
			return true;
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0026634C File Offset: 0x0026454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0026635C File Offset: 0x0026455C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0026636C File Offset: 0x0026456C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x0026637C File Offset: 0x0026457C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x0026638C File Offset: 0x0026458C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x0026639C File Offset: 0x0026459C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(House other)
		{
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x002663AC File Offset: 0x002645AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x002663BC File Offset: 0x002645BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x002663CC File Offset: 0x002645CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static House()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					House._parser = new MessageParser<House>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x00266498 File Offset: 0x00264698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DJyynuJdRbk9ppTuHttm()
		{
			return true;
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x002664A0 File Offset: 0x002646A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static House Eb10X0JdOnXKPm3w6dF4()
		{
			return null;
		}

		// Token: 0x04003220 RID: 12832
		private static readonly MessageParser<House> _parser;

		// Token: 0x04003221 RID: 12833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003222 RID: 12834
		public const int HouseIdFieldNumber = 1;

		// Token: 0x04003223 RID: 12835
		private int houseId_;

		// Token: 0x04003224 RID: 12836
		public const int ModelIdFieldNumber = 2;

		// Token: 0x04003225 RID: 12837
		private int modelId_;

		// Token: 0x04003226 RID: 12838
		public const int HouseAccountFieldNumber = 3;

		// Token: 0x04003227 RID: 12839
		public const int HouseOnMapFieldNumber = 4;

		// Token: 0x04003228 RID: 12840
		public const int HouseInsideFieldNumber = 5;

		// Token: 0x04003229 RID: 12841
		public const int HouseGuildFieldNumber = 6;

		// Token: 0x0400322A RID: 12842
		private object information_;

		// Token: 0x0400322B RID: 12843
		private House.InformationOneofCase informationCase_;

		// Token: 0x0400322C RID: 12844
		private static House KPtSvBJd35VtXy4WB8bM;

		// Token: 0x02000B21 RID: 2849
		public enum InformationOneofCase
		{
			// Token: 0x0400322E RID: 12846
			None,
			// Token: 0x0400322F RID: 12847
			HouseAccount = 3,
			// Token: 0x04003230 RID: 12848
			HouseOnMap,
			// Token: 0x04003231 RID: 12849
			HouseInside,
			// Token: 0x04003232 RID: 12850
			HouseGuild
		}

		// Token: 0x02000B22 RID: 2850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600884B RID: 34891 RVA: 0x002E2C7C File Offset: 0x002E0E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B23 RID: 2851
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HouseAccount : IMessage<House.Types.HouseAccount>, IMessage, IEquatable<House.Types.HouseAccount>, IDeepCloneable<House.Types.HouseAccount>, IBufferMessage
			{
				// Token: 0x17001930 RID: 6448
				// (get) Token: 0x0600884C RID: 34892 RVA: 0x0030A7F8 File Offset: 0x003089F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<House.Types.HouseAccount> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001931 RID: 6449
				// (get) Token: 0x0600884D RID: 34893 RVA: 0x0030A808 File Offset: 0x00308A08
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

				// Token: 0x17001932 RID: 6450
				// (get) Token: 0x0600884E RID: 34894 RVA: 0x0030A818 File Offset: 0x00308A18
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

				// Token: 0x0600884F RID: 34895 RVA: 0x0030A828 File Offset: 0x00308A28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseAccount()
				{
				}

				// Token: 0x06008850 RID: 34896 RVA: 0x0030A838 File Offset: 0x00308A38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseAccount(House.Types.HouseAccount other)
				{
				}

				// Token: 0x06008851 RID: 34897 RVA: 0x0030A848 File Offset: 0x00308A48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public House.Types.HouseAccount Clone()
				{
					return null;
				}

				// Token: 0x17001933 RID: 6451
				// (get) Token: 0x06008852 RID: 34898 RVA: 0x0030A858 File Offset: 0x00308A58
				// (set) Token: 0x06008853 RID: 34899 RVA: 0x0030A868 File Offset: 0x00308A68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public HouseInstance HouseInformation
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

				// Token: 0x17001934 RID: 6452
				// (get) Token: 0x06008854 RID: 34900 RVA: 0x0030A878 File Offset: 0x00308A78
				// (set) Token: 0x06008855 RID: 34901 RVA: 0x0030A888 File Offset: 0x00308A88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public MapExtendedCoordinates Coordinates
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

				// Token: 0x06008856 RID: 34902 RVA: 0x0030A898 File Offset: 0x00308A98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008857 RID: 34903 RVA: 0x0030A8A8 File Offset: 0x00308AA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(House.Types.HouseAccount other)
				{
					return true;
				}

				// Token: 0x06008858 RID: 34904 RVA: 0x0030A8B8 File Offset: 0x00308AB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008859 RID: 34905 RVA: 0x0030A8C8 File Offset: 0x00308AC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600885A RID: 34906 RVA: 0x0030A8D8 File Offset: 0x00308AD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600885B RID: 34907 RVA: 0x0030A8E8 File Offset: 0x00308AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600885C RID: 34908 RVA: 0x0030A8F8 File Offset: 0x00308AF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600885D RID: 34909 RVA: 0x0030A908 File Offset: 0x00308B08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(House.Types.HouseAccount other)
				{
				}

				// Token: 0x0600885E RID: 34910 RVA: 0x0030A918 File Offset: 0x00308B18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600885F RID: 34911 RVA: 0x0030A928 File Offset: 0x00308B28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008860 RID: 34912 RVA: 0x0030A938 File Offset: 0x00308B38
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HouseAccount()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							House.Types.HouseAccount._parser = new MessageParser<House.Types.HouseAccount>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06008861 RID: 34913 RVA: 0x0030AA30 File Offset: 0x00308C30
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool zYg5QbG84sxZgjocZlkS()
				{
					return true;
				}

				// Token: 0x06008862 RID: 34914 RVA: 0x0030AA38 File Offset: 0x00308C38
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static House.Types.HouseAccount s7hO9aG8jPlOVfLs5n4L()
				{
					return null;
				}

				// Token: 0x04003233 RID: 12851
				private static readonly MessageParser<House.Types.HouseAccount> _parser;

				// Token: 0x04003234 RID: 12852
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003235 RID: 12853
				public const int HouseInformationFieldNumber = 1;

				// Token: 0x04003236 RID: 12854
				private HouseInstance houseInformation_;

				// Token: 0x04003237 RID: 12855
				public const int CoordinatesFieldNumber = 2;

				// Token: 0x04003238 RID: 12856
				private MapExtendedCoordinates coordinates_;

				// Token: 0x04003239 RID: 12857
				private static House.Types.HouseAccount M5HdAQG8xcw5Hk252DRF;
			}

			// Token: 0x02000B25 RID: 2853
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HouseOnMap : IMessage<House.Types.HouseOnMap>, IMessage, IEquatable<House.Types.HouseOnMap>, IDeepCloneable<House.Types.HouseOnMap>, IBufferMessage
			{
				// Token: 0x17001935 RID: 6453
				// (get) Token: 0x06008868 RID: 34920 RVA: 0x0030AA40 File Offset: 0x00308C40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<House.Types.HouseOnMap> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001936 RID: 6454
				// (get) Token: 0x06008869 RID: 34921 RVA: 0x0030AA50 File Offset: 0x00308C50
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

				// Token: 0x17001937 RID: 6455
				// (get) Token: 0x0600886A RID: 34922 RVA: 0x0030AA60 File Offset: 0x00308C60
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

				// Token: 0x0600886B RID: 34923 RVA: 0x0030AA70 File Offset: 0x00308C70
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseOnMap()
				{
				}

				// Token: 0x0600886C RID: 34924 RVA: 0x0030AA80 File Offset: 0x00308C80
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseOnMap(House.Types.HouseOnMap other)
				{
				}

				// Token: 0x0600886D RID: 34925 RVA: 0x0030AA90 File Offset: 0x00308C90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public House.Types.HouseOnMap Clone()
				{
					return null;
				}

				// Token: 0x17001938 RID: 6456
				// (get) Token: 0x0600886E RID: 34926 RVA: 0x0030AAA0 File Offset: 0x00308CA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> DoorsOnMap
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001939 RID: 6457
				// (get) Token: 0x0600886F RID: 34927 RVA: 0x0030AAB0 File Offset: 0x00308CB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<HouseInstance> HousesInformation
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06008870 RID: 34928 RVA: 0x0030AAC0 File Offset: 0x00308CC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008871 RID: 34929 RVA: 0x0030AAD0 File Offset: 0x00308CD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(House.Types.HouseOnMap other)
				{
					return true;
				}

				// Token: 0x06008872 RID: 34930 RVA: 0x0030AAE0 File Offset: 0x00308CE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008873 RID: 34931 RVA: 0x0030AAF0 File Offset: 0x00308CF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008874 RID: 34932 RVA: 0x0030AB00 File Offset: 0x00308D00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008875 RID: 34933 RVA: 0x0030AB10 File Offset: 0x00308D10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008876 RID: 34934 RVA: 0x0030AB20 File Offset: 0x00308D20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008877 RID: 34935 RVA: 0x0030AB30 File Offset: 0x00308D30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(House.Types.HouseOnMap other)
				{
				}

				// Token: 0x06008878 RID: 34936 RVA: 0x0030AB40 File Offset: 0x00308D40
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008879 RID: 34937 RVA: 0x0030AB50 File Offset: 0x00308D50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600887A RID: 34938 RVA: 0x0030AB60 File Offset: 0x00308D60
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HouseOnMap()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								House.Types.HouseOnMap._repeated_housesInformation_codec = FieldCodec.ForMessage<HouseInstance>(18U, vpRgVFBk1iwXoBGkUUvE.XVInXhlssT(vpRgVFBk1iwXoBGkUUvE.PkjBkaRssr6));
								num2 = 3;
								continue;
							case 3:
								return;
							case 4:
								House.Types.HouseOnMap._repeated_doorsOnMap_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
								{
									num2 = 2;
									continue;
								}
								continue;
							case 5:
								House.Types.HouseOnMap._parser = new MessageParser<House.Types.HouseOnMap>(() => null);
								num2 = 4;
								continue;
							case 6:
								goto IL_3D;
							}
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
							{
								num2 = 6;
							}
						}
						IL_3D:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 5;
					}
				}

				// Token: 0x0600887B RID: 34939 RVA: 0x0030AC88 File Offset: 0x00308E88
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool MnfHk7G8I8NXffCaSsKD()
				{
					return true;
				}

				// Token: 0x0600887C RID: 34940 RVA: 0x0030AC90 File Offset: 0x00308E90
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static House.Types.HouseOnMap TSuTu2G8ksXv1Pv2j1Y0()
				{
					return null;
				}

				// Token: 0x0400323C RID: 12860
				private static readonly MessageParser<House.Types.HouseOnMap> _parser;

				// Token: 0x0400323D RID: 12861
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400323E RID: 12862
				public const int DoorsOnMapFieldNumber = 1;

				// Token: 0x0400323F RID: 12863
				private static readonly FieldCodec<int> _repeated_doorsOnMap_codec;

				// Token: 0x04003240 RID: 12864
				private readonly RepeatedField<int> doorsOnMap_;

				// Token: 0x04003241 RID: 12865
				public const int HousesInformationFieldNumber = 2;

				// Token: 0x04003242 RID: 12866
				private static readonly FieldCodec<HouseInstance> _repeated_housesInformation_codec;

				// Token: 0x04003243 RID: 12867
				private readonly RepeatedField<HouseInstance> housesInformation_;

				// Token: 0x04003244 RID: 12868
				private static House.Types.HouseOnMap bbIgWIG8KLlqcLjllwXQ;
			}

			// Token: 0x02000B27 RID: 2855
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HouseInside : IMessage<House.Types.HouseInside>, IMessage, IEquatable<House.Types.HouseInside>, IDeepCloneable<House.Types.HouseInside>, IBufferMessage
			{
				// Token: 0x1700193A RID: 6458
				// (get) Token: 0x06008882 RID: 34946 RVA: 0x0030AC98 File Offset: 0x00308E98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<House.Types.HouseInside> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700193B RID: 6459
				// (get) Token: 0x06008883 RID: 34947 RVA: 0x0030ACA8 File Offset: 0x00308EA8
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

				// Token: 0x1700193C RID: 6460
				// (get) Token: 0x06008884 RID: 34948 RVA: 0x0030ACB8 File Offset: 0x00308EB8
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

				// Token: 0x06008885 RID: 34949 RVA: 0x0030ACC8 File Offset: 0x00308EC8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseInside()
				{
				}

				// Token: 0x06008886 RID: 34950 RVA: 0x0030ACD8 File Offset: 0x00308ED8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseInside(House.Types.HouseInside other)
				{
				}

				// Token: 0x06008887 RID: 34951 RVA: 0x0030ACE8 File Offset: 0x00308EE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public House.Types.HouseInside Clone()
				{
					return null;
				}

				// Token: 0x1700193D RID: 6461
				// (get) Token: 0x06008888 RID: 34952 RVA: 0x0030ACF8 File Offset: 0x00308EF8
				// (set) Token: 0x06008889 RID: 34953 RVA: 0x0030AD08 File Offset: 0x00308F08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HouseInstance HouseInformation
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

				// Token: 0x1700193E RID: 6462
				// (get) Token: 0x0600888A RID: 34954 RVA: 0x0030AD18 File Offset: 0x00308F18
				// (set) Token: 0x0600888B RID: 34955 RVA: 0x0030AD28 File Offset: 0x00308F28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x0600888C RID: 34956 RVA: 0x0030AD38 File Offset: 0x00308F38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600888D RID: 34957 RVA: 0x0030AD48 File Offset: 0x00308F48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(House.Types.HouseInside other)
				{
					return true;
				}

				// Token: 0x0600888E RID: 34958 RVA: 0x0030AD58 File Offset: 0x00308F58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600888F RID: 34959 RVA: 0x0030AD68 File Offset: 0x00308F68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008890 RID: 34960 RVA: 0x0030AD78 File Offset: 0x00308F78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008891 RID: 34961 RVA: 0x0030AD88 File Offset: 0x00308F88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008892 RID: 34962 RVA: 0x0030AD98 File Offset: 0x00308F98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008893 RID: 34963 RVA: 0x0030ADA8 File Offset: 0x00308FA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(House.Types.HouseInside other)
				{
				}

				// Token: 0x06008894 RID: 34964 RVA: 0x0030ADB8 File Offset: 0x00308FB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008895 RID: 34965 RVA: 0x0030ADC8 File Offset: 0x00308FC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008896 RID: 34966 RVA: 0x0030ADD8 File Offset: 0x00308FD8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HouseInside()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							House.Types.HouseInside._parser = new MessageParser<House.Types.HouseInside>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06008897 RID: 34967 RVA: 0x0030AEBC File Offset: 0x003090BC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool bg1ycyG8cbmgCFOc9G7Q()
				{
					return true;
				}

				// Token: 0x06008898 RID: 34968 RVA: 0x0030AEC4 File Offset: 0x003090C4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static House.Types.HouseInside Qt3k4HG8UR1XoBEOmBag()
				{
					return null;
				}

				// Token: 0x04003247 RID: 12871
				private static readonly MessageParser<House.Types.HouseInside> _parser;

				// Token: 0x04003248 RID: 12872
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003249 RID: 12873
				public const int HouseInformationFieldNumber = 1;

				// Token: 0x0400324A RID: 12874
				private HouseInstance houseInformation_;

				// Token: 0x0400324B RID: 12875
				public const int CoordinatesFieldNumber = 2;

				// Token: 0x0400324C RID: 12876
				private MapCoordinates coordinates_;

				// Token: 0x0400324D RID: 12877
				private static House.Types.HouseInside Tlu3m6G8lxZlRtj2hNTV;
			}

			// Token: 0x02000B29 RID: 2857
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HouseGuild : IMessage<House.Types.HouseGuild>, IMessage, IEquatable<House.Types.HouseGuild>, IDeepCloneable<House.Types.HouseGuild>, IBufferMessage
			{
				// Token: 0x1700193F RID: 6463
				// (get) Token: 0x0600889E RID: 34974 RVA: 0x0030AECC File Offset: 0x003090CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<House.Types.HouseGuild> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001940 RID: 6464
				// (get) Token: 0x0600889F RID: 34975 RVA: 0x0030AEDC File Offset: 0x003090DC
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

				// Token: 0x17001941 RID: 6465
				// (get) Token: 0x060088A0 RID: 34976 RVA: 0x0030AEEC File Offset: 0x003090EC
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

				// Token: 0x060088A1 RID: 34977 RVA: 0x0030AEFC File Offset: 0x003090FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseGuild()
				{
				}

				// Token: 0x060088A2 RID: 34978 RVA: 0x0030AF0C File Offset: 0x0030910C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseGuild(House.Types.HouseGuild other)
				{
				}

				// Token: 0x060088A3 RID: 34979 RVA: 0x0030AF1C File Offset: 0x0030911C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public House.Types.HouseGuild Clone()
				{
					return null;
				}

				// Token: 0x17001942 RID: 6466
				// (get) Token: 0x060088A4 RID: 34980 RVA: 0x0030AF2C File Offset: 0x0030912C
				// (set) Token: 0x060088A5 RID: 34981 RVA: 0x0030AF3C File Offset: 0x0030913C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public HouseInstance HouseInformation
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

				// Token: 0x17001943 RID: 6467
				// (get) Token: 0x060088A6 RID: 34982 RVA: 0x0030AF4C File Offset: 0x0030914C
				// (set) Token: 0x060088A7 RID: 34983 RVA: 0x0030AF5C File Offset: 0x0030915C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public MapExtendedCoordinates Coordinates
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

				// Token: 0x17001944 RID: 6468
				// (get) Token: 0x060088A8 RID: 34984 RVA: 0x0030AF6C File Offset: 0x0030916C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> SkillsId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001945 RID: 6469
				// (get) Token: 0x060088A9 RID: 34985 RVA: 0x0030AF7C File Offset: 0x0030917C
				// (set) Token: 0x060088AA RID: 34986 RVA: 0x0030AF8C File Offset: 0x0030918C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long GuildShareParams
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

				// Token: 0x060088AB RID: 34987 RVA: 0x0030AF9C File Offset: 0x0030919C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060088AC RID: 34988 RVA: 0x0030AFAC File Offset: 0x003091AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(House.Types.HouseGuild other)
				{
					return true;
				}

				// Token: 0x060088AD RID: 34989 RVA: 0x0030AFBC File Offset: 0x003091BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060088AE RID: 34990 RVA: 0x0030AFCC File Offset: 0x003091CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060088AF RID: 34991 RVA: 0x0030AFDC File Offset: 0x003091DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060088B0 RID: 34992 RVA: 0x0030AFEC File Offset: 0x003091EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060088B1 RID: 34993 RVA: 0x0030AFFC File Offset: 0x003091FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060088B2 RID: 34994 RVA: 0x0030B00C File Offset: 0x0030920C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(House.Types.HouseGuild other)
				{
				}

				// Token: 0x060088B3 RID: 34995 RVA: 0x0030B01C File Offset: 0x0030921C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060088B4 RID: 34996 RVA: 0x0030B02C File Offset: 0x0030922C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060088B5 RID: 34997 RVA: 0x0030B03C File Offset: 0x0030923C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HouseGuild()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
							{
								num2 = 4;
							}
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							House.Types.HouseGuild._parser = new MessageParser<House.Types.HouseGuild>(() => null);
							num2 = 3;
							break;
						case 3:
							House.Types.HouseGuild._repeated_skillsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
							num2 = 5;
							break;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
							{
								num2 = 2;
							}
							break;
						case 5:
							return;
						}
					}
				}

				// Token: 0x060088B6 RID: 34998 RVA: 0x0030B13C File Offset: 0x0030933C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool LKxExyG8o2eJUOXCv6ey()
				{
					return true;
				}

				// Token: 0x060088B7 RID: 34999 RVA: 0x0030B144 File Offset: 0x00309344
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static House.Types.HouseGuild DwtH4AG81SxPKaTav3II()
				{
					return null;
				}

				// Token: 0x04003250 RID: 12880
				private static readonly MessageParser<House.Types.HouseGuild> _parser;

				// Token: 0x04003251 RID: 12881
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003252 RID: 12882
				public const int HouseInformationFieldNumber = 1;

				// Token: 0x04003253 RID: 12883
				private HouseInstance houseInformation_;

				// Token: 0x04003254 RID: 12884
				public const int CoordinatesFieldNumber = 2;

				// Token: 0x04003255 RID: 12885
				private MapExtendedCoordinates coordinates_;

				// Token: 0x04003256 RID: 12886
				public const int SkillsIdFieldNumber = 3;

				// Token: 0x04003257 RID: 12887
				private static readonly FieldCodec<int> _repeated_skillsId_codec;

				// Token: 0x04003258 RID: 12888
				private readonly RepeatedField<int> skillsId_;

				// Token: 0x04003259 RID: 12889
				public const int GuildShareParamsFieldNumber = 4;

				// Token: 0x0400325A RID: 12890
				private long guildShareParams_;

				// Token: 0x0400325B RID: 12891
				internal static House.Types.HouseGuild rBOW3vG8vE1Z1gRVAUiN;
			}
		}
	}
}
