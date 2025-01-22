using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E43 RID: 3651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendListResponse : IMessage<FriendListResponse>, IMessage, IEquatable<FriendListResponse>, IDeepCloneable<FriendListResponse>, IBufferMessage
	{
		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x002A1284 File Offset: 0x0029F484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendListResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600AF4D RID: 44877 RVA: 0x002A1294 File Offset: 0x0029F494
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

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002A12A4 File Offset: 0x0029F4A4
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

		// Token: 0x0600AF4F RID: 44879 RVA: 0x002A12B4 File Offset: 0x0029F4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListResponse()
		{
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x002A12C4 File Offset: 0x0029F4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListResponse(FriendListResponse other)
		{
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x002A12D4 File Offset: 0x0029F4D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListResponse Clone()
		{
			return null;
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x002A12E4 File Offset: 0x0029F4E4
		// (set) Token: 0x0600AF53 RID: 44883 RVA: 0x002A12F4 File Offset: 0x0029F4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendListResponse.Types.FriendList Friends
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

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x002A1304 File Offset: 0x0029F504
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x002A1318 File Offset: 0x0029F518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendListResponse.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FriendListResponse.Types.Error)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x002A1328 File Offset: 0x0029F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasError
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x002A1338 File Offset: 0x0029F538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearError()
		{
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x002A1348 File Offset: 0x0029F548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendListResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FriendListResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x002A135C File Offset: 0x0029F55C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x002A136C File Offset: 0x0029F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x002A137C File Offset: 0x0029F57C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendListResponse other)
		{
			return true;
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x002A138C File Offset: 0x0029F58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x002A139C File Offset: 0x0029F59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x002A13AC File Offset: 0x0029F5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AF5F RID: 44895 RVA: 0x002A13BC File Offset: 0x0029F5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x002A13CC File Offset: 0x0029F5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x002A13DC File Offset: 0x0029F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendListResponse other)
		{
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x002A13EC File Offset: 0x0029F5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x002A13FC File Offset: 0x0029F5FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x002A140C File Offset: 0x0029F60C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendListResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					FriendListResponse._parser = new MessageParser<FriendListResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x002A14F0 File Offset: 0x0029F6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BomPpMJvvqCukZqNlJJc()
		{
			return true;
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x002A14F8 File Offset: 0x0029F6F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendListResponse LUfMHWJvoXthnkkinE3D()
		{
			return null;
		}

		// Token: 0x0400409B RID: 16539
		private static readonly MessageParser<FriendListResponse> _parser;

		// Token: 0x0400409C RID: 16540
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400409D RID: 16541
		public const int FriendsFieldNumber = 1;

		// Token: 0x0400409E RID: 16542
		public const int ErrorFieldNumber = 2;

		// Token: 0x0400409F RID: 16543
		private object result_;

		// Token: 0x040040A0 RID: 16544
		private FriendListResponse.ResultOneofCase resultCase_;

		// Token: 0x040040A1 RID: 16545
		private static FriendListResponse qN2LMBJvUNUeH9Z9OOk8;

		// Token: 0x02000E44 RID: 3652
		public enum ResultOneofCase
		{
			// Token: 0x040040A3 RID: 16547
			None,
			// Token: 0x040040A4 RID: 16548
			Friends,
			// Token: 0x040040A5 RID: 16549
			Error
		}

		// Token: 0x02000E45 RID: 3653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AF67 RID: 44903 RVA: 0x002F495C File Offset: 0x002F2B5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E46 RID: 3654
			public enum Error
			{
				// Token: 0x040040A7 RID: 16551
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x040040A8 RID: 16552
				[OriginalName("FLOODING")]
				Flooding
			}

			// Token: 0x02000E47 RID: 3655
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FriendList : IMessage<FriendListResponse.Types.FriendList>, IMessage, IEquatable<FriendListResponse.Types.FriendList>, IDeepCloneable<FriendListResponse.Types.FriendList>, IBufferMessage
			{
				// Token: 0x17002089 RID: 8329
				// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x0030FF24 File Offset: 0x0030E124
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FriendListResponse.Types.FriendList> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700208A RID: 8330
				// (get) Token: 0x0600AF69 RID: 44905 RVA: 0x0030FF34 File Offset: 0x0030E134
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

				// Token: 0x1700208B RID: 8331
				// (get) Token: 0x0600AF6A RID: 44906 RVA: 0x0030FF44 File Offset: 0x0030E144
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

				// Token: 0x0600AF6B RID: 44907 RVA: 0x0030FF54 File Offset: 0x0030E154
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendList()
				{
				}

				// Token: 0x0600AF6C RID: 44908 RVA: 0x0030FF64 File Offset: 0x0030E164
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendList(FriendListResponse.Types.FriendList other)
				{
				}

				// Token: 0x0600AF6D RID: 44909 RVA: 0x0030FF74 File Offset: 0x0030E174
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendListResponse.Types.FriendList Clone()
				{
					return null;
				}

				// Token: 0x1700208C RID: 8332
				// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x0030FF84 File Offset: 0x0030E184
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<FriendListResponse.Types.FriendList.Types.Friend> Friends
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x0600AF6F RID: 44911 RVA: 0x0030FF94 File Offset: 0x0030E194
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AF70 RID: 44912 RVA: 0x0030FFA4 File Offset: 0x0030E1A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FriendListResponse.Types.FriendList other)
				{
					return true;
				}

				// Token: 0x0600AF71 RID: 44913 RVA: 0x0030FFB4 File Offset: 0x0030E1B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AF72 RID: 44914 RVA: 0x0030FFC4 File Offset: 0x0030E1C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AF73 RID: 44915 RVA: 0x0030FFD4 File Offset: 0x0030E1D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AF74 RID: 44916 RVA: 0x0030FFE4 File Offset: 0x0030E1E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AF75 RID: 44917 RVA: 0x0030FFF4 File Offset: 0x0030E1F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AF76 RID: 44918 RVA: 0x00310004 File Offset: 0x0030E204
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FriendListResponse.Types.FriendList other)
				{
				}

				// Token: 0x0600AF77 RID: 44919 RVA: 0x00310014 File Offset: 0x0030E214
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AF78 RID: 44920 RVA: 0x00310024 File Offset: 0x0030E224
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AF79 RID: 44921 RVA: 0x00310034 File Offset: 0x0030E234
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FriendList()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							FriendListResponse.Types.FriendList._repeated_friends_codec = FieldCodec.ForMessage<FriendListResponse.Types.FriendList.Types.Friend>(10U, SlbevP3Nkc7NaHn9KcUd.XVInXhlssT(SlbevP3Nkc7NaHn9KcUd.IjK3NlDCx40));
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							FriendListResponse.Types.FriendList._parser = new MessageParser<FriendListResponse.Types.FriendList>(() => null);
							num2 = 2;
							continue;
						case 4:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 5:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x0600AF7A RID: 44922 RVA: 0x00310150 File Offset: 0x0030E350
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool LuQiKmGFmS3KZtwcqC2l()
				{
					return true;
				}

				// Token: 0x0600AF7B RID: 44923 RVA: 0x00310158 File Offset: 0x0030E358
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FriendListResponse.Types.FriendList wl5CbtGFAFw7ITZbrhYg()
				{
					return null;
				}

				// Token: 0x040040A9 RID: 16553
				private static readonly MessageParser<FriendListResponse.Types.FriendList> _parser;

				// Token: 0x040040AA RID: 16554
				private UnknownFieldSet _unknownFields;

				// Token: 0x040040AB RID: 16555
				public const int FriendsFieldNumber = 1;

				// Token: 0x040040AC RID: 16556
				private static readonly FieldCodec<FriendListResponse.Types.FriendList.Types.Friend> _repeated_friends_codec;

				// Token: 0x040040AD RID: 16557
				private readonly RepeatedField<FriendListResponse.Types.FriendList.Types.Friend> friends_;

				// Token: 0x040040AE RID: 16558
				internal static FriendListResponse.Types.FriendList KlMmrsGFnrxHAltDkWJN;

				// Token: 0x02000E48 RID: 3656
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600AF7C RID: 44924 RVA: 0x0031ADC0 File Offset: 0x00318FC0
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000E49 RID: 3657
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Friend : IMessage<FriendListResponse.Types.FriendList.Types.Friend>, IMessage, IEquatable<FriendListResponse.Types.FriendList.Types.Friend>, IDeepCloneable<FriendListResponse.Types.FriendList.Types.Friend>, IBufferMessage
					{
						// Token: 0x1700208D RID: 8333
						// (get) Token: 0x0600AF7D RID: 44925 RVA: 0x00320704 File Offset: 0x0031E904
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<FriendListResponse.Types.FriendList.Types.Friend> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700208E RID: 8334
						// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x00320714 File Offset: 0x0031E914
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

						// Token: 0x1700208F RID: 8335
						// (get) Token: 0x0600AF7F RID: 44927 RVA: 0x00320724 File Offset: 0x0031E924
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

						// Token: 0x0600AF80 RID: 44928 RVA: 0x00320734 File Offset: 0x0031E934
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Friend()
						{
						}

						// Token: 0x0600AF81 RID: 44929 RVA: 0x00320744 File Offset: 0x0031E944
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Friend(FriendListResponse.Types.FriendList.Types.Friend other)
						{
						}

						// Token: 0x0600AF82 RID: 44930 RVA: 0x00320754 File Offset: 0x0031E954
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FriendListResponse.Types.FriendList.Types.Friend Clone()
						{
							return null;
						}

						// Token: 0x17002090 RID: 8336
						// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x00320764 File Offset: 0x0031E964
						// (set) Token: 0x0600AF84 RID: 44932 RVA: 0x00320774 File Offset: 0x0031E974
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public string AccountName
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

						// Token: 0x17002091 RID: 8337
						// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x00320784 File Offset: 0x0031E984
						// (set) Token: 0x0600AF86 RID: 44934 RVA: 0x00320794 File Offset: 0x0031E994
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public string AccountTag
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

						// Token: 0x17002092 RID: 8338
						// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x003207A4 File Offset: 0x0031E9A4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<int> Servers
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x0600AF88 RID: 44936 RVA: 0x003207B4 File Offset: 0x0031E9B4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600AF89 RID: 44937 RVA: 0x003207C4 File Offset: 0x0031E9C4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(FriendListResponse.Types.FriendList.Types.Friend other)
						{
							return true;
						}

						// Token: 0x0600AF8A RID: 44938 RVA: 0x003207D4 File Offset: 0x0031E9D4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600AF8B RID: 44939 RVA: 0x003207E4 File Offset: 0x0031E9E4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600AF8C RID: 44940 RVA: 0x003207F4 File Offset: 0x0031E9F4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600AF8D RID: 44941 RVA: 0x00320804 File Offset: 0x0031EA04
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600AF8E RID: 44942 RVA: 0x00320814 File Offset: 0x0031EA14
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600AF8F RID: 44943 RVA: 0x00320824 File Offset: 0x0031EA24
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(FriendListResponse.Types.FriendList.Types.Friend other)
						{
						}

						// Token: 0x0600AF90 RID: 44944 RVA: 0x00320834 File Offset: 0x0031EA34
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600AF91 RID: 44945 RVA: 0x00320844 File Offset: 0x0031EA44
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600AF92 RID: 44946 RVA: 0x00320854 File Offset: 0x0031EA54
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Friend()
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
									num2 = 3;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
									{
										num2 = 5;
										continue;
									}
									continue;
								case 2:
									return;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
									{
										num2 = 3;
										continue;
									}
									continue;
								case 5:
									FriendListResponse.Types.FriendList.Types.Friend._parser = new MessageParser<FriendListResponse.Types.FriendList.Types.Friend>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								FriendListResponse.Types.FriendList.Types.Friend._repeated_servers_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 2;
							}
						}

						// Token: 0x0600AF93 RID: 44947 RVA: 0x0032096C File Offset: 0x0031EB6C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool dNZBbUgGufQUN1fmZp7v()
						{
							return true;
						}

						// Token: 0x0600AF94 RID: 44948 RVA: 0x00320974 File Offset: 0x0031EB74
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static FriendListResponse.Types.FriendList.Types.Friend uL6E6KgG8tX8mMaDy49Z()
						{
							return null;
						}

						// Token: 0x040040AF RID: 16559
						private static readonly MessageParser<FriendListResponse.Types.FriendList.Types.Friend> _parser;

						// Token: 0x040040B0 RID: 16560
						private UnknownFieldSet _unknownFields;

						// Token: 0x040040B1 RID: 16561
						public const int AccountNameFieldNumber = 1;

						// Token: 0x040040B2 RID: 16562
						private string accountName_;

						// Token: 0x040040B3 RID: 16563
						public const int AccountTagFieldNumber = 2;

						// Token: 0x040040B4 RID: 16564
						private string accountTag_;

						// Token: 0x040040B5 RID: 16565
						public const int ServersFieldNumber = 3;

						// Token: 0x040040B6 RID: 16566
						private static readonly FieldCodec<int> _repeated_servers_codec;

						// Token: 0x040040B7 RID: 16567
						private readonly RepeatedField<int> servers_;

						// Token: 0x040040B8 RID: 16568
						internal static FriendListResponse.Types.FriendList.Types.Friend h3bJ1ZgGMwryYJHqMnXB;
					}
				}
			}
		}
	}
}
