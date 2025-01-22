using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000213 RID: 531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetCreateResponse : IMessage<ForgettableSpellPresetCreateResponse>, IMessage, IEquatable<ForgettableSpellPresetCreateResponse>, IDeepCloneable<ForgettableSpellPresetCreateResponse>, IBufferMessage
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x001AE828 File Offset: 0x001ACA28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForgettableSpellPresetCreateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x001AE838 File Offset: 0x001ACA38
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x001AE848 File Offset: 0x001ACA48
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

		// Token: 0x060018CD RID: 6349 RVA: 0x001AE858 File Offset: 0x001ACA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateResponse()
		{
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x001AE868 File Offset: 0x001ACA68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateResponse(ForgettableSpellPresetCreateResponse other)
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x001AE878 File Offset: 0x001ACA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateResponse Clone()
		{
			return null;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x001AE888 File Offset: 0x001ACA88
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x001AE898 File Offset: 0x001ACA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ForgettableSpellPresetCreateResponse.Types.Success Success
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x001AE8A8 File Offset: 0x001ACAA8
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x001AE8BC File Offset: 0x001ACABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ForgettableSpellPresetCreateResponse.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForgettableSpellPresetCreateResponse.Types.Error)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x001AE8CC File Offset: 0x001ACACC
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

		// Token: 0x060018D5 RID: 6357 RVA: 0x001AE8DC File Offset: 0x001ACADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearError()
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x001AE8EC File Offset: 0x001ACAEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ForgettableSpellPresetCreateResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForgettableSpellPresetCreateResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x001AE900 File Offset: 0x001ACB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x001AE910 File Offset: 0x001ACB10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x001AE920 File Offset: 0x001ACB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetCreateResponse other)
		{
			return true;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x001AE930 File Offset: 0x001ACB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x001AE940 File Offset: 0x001ACB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x001AE950 File Offset: 0x001ACB50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x001AE960 File Offset: 0x001ACB60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x001AE970 File Offset: 0x001ACB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x001AE980 File Offset: 0x001ACB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetCreateResponse other)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x001AE990 File Offset: 0x001ACB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x001AE9A0 File Offset: 0x001ACBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x001AE9B0 File Offset: 0x001ACBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetCreateResponse()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ForgettableSpellPresetCreateResponse._parser = new MessageParser<ForgettableSpellPresetCreateResponse>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x001AEA94 File Offset: 0x001ACC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vlp7LeOaXmwKNOc7Cbj6()
		{
			return true;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x001AEA9C File Offset: 0x001ACC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetCreateResponse ac0st2OaN7jmfY9VKKKK()
		{
			return null;
		}

		// Token: 0x040008D6 RID: 2262
		private static readonly MessageParser<ForgettableSpellPresetCreateResponse> _parser;

		// Token: 0x040008D7 RID: 2263
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008D8 RID: 2264
		public const int SuccessFieldNumber = 1;

		// Token: 0x040008D9 RID: 2265
		public const int ErrorFieldNumber = 2;

		// Token: 0x040008DA RID: 2266
		private object result_;

		// Token: 0x040008DB RID: 2267
		private ForgettableSpellPresetCreateResponse.ResultOneofCase resultCase_;

		// Token: 0x040008DC RID: 2268
		internal static ForgettableSpellPresetCreateResponse RRqSRhOaESQGwglfummD;

		// Token: 0x02000214 RID: 532
		public enum ResultOneofCase
		{
			// Token: 0x040008DE RID: 2270
			None,
			// Token: 0x040008DF RID: 2271
			Success,
			// Token: 0x040008E0 RID: 2272
			Error
		}

		// Token: 0x02000215 RID: 533
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060018E5 RID: 6373 RVA: 0x002B0F90 File Offset: 0x002AF190
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000216 RID: 534
			public enum Error
			{
				// Token: 0x040008E2 RID: 2274
				[OriginalName("FEATURE_DISABLED")]
				FeatureDisabled,
				// Token: 0x040008E3 RID: 2275
				[OriginalName("MAX_QUANTITY")]
				MaxQuantity,
				// Token: 0x040008E4 RID: 2276
				[OriginalName("INVALID_NAME_SIZE")]
				InvalidNameSize,
				// Token: 0x040008E5 RID: 2277
				[OriginalName("PRESET_NOT_FOUND")]
				PresetNotFound,
				// Token: 0x040008E6 RID: 2278
				[OriginalName("UNKNOWN")]
				Unknown
			}

			// Token: 0x02000217 RID: 535
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<ForgettableSpellPresetCreateResponse.Types.Success>, IMessage, IEquatable<ForgettableSpellPresetCreateResponse.Types.Success>, IDeepCloneable<ForgettableSpellPresetCreateResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17000472 RID: 1138
				// (get) Token: 0x060018E6 RID: 6374 RVA: 0x002F9578 File Offset: 0x002F7778
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ForgettableSpellPresetCreateResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000473 RID: 1139
				// (get) Token: 0x060018E7 RID: 6375 RVA: 0x002F9588 File Offset: 0x002F7788
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

				// Token: 0x17000474 RID: 1140
				// (get) Token: 0x060018E8 RID: 6376 RVA: 0x002F9598 File Offset: 0x002F7798
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

				// Token: 0x060018E9 RID: 6377 RVA: 0x002F95A8 File Offset: 0x002F77A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x060018EA RID: 6378 RVA: 0x002F95B8 File Offset: 0x002F77B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(ForgettableSpellPresetCreateResponse.Types.Success other)
				{
				}

				// Token: 0x060018EB RID: 6379 RVA: 0x002F95C8 File Offset: 0x002F77C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellPresetCreateResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17000475 RID: 1141
				// (get) Token: 0x060018EC RID: 6380 RVA: 0x002F95D8 File Offset: 0x002F77D8
				// (set) Token: 0x060018ED RID: 6381 RVA: 0x002F95E8 File Offset: 0x002F77E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ForgettableSpellPresetInfo PresetInfo
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

				// Token: 0x060018EE RID: 6382 RVA: 0x002F95F8 File Offset: 0x002F77F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060018EF RID: 6383 RVA: 0x002F9608 File Offset: 0x002F7808
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ForgettableSpellPresetCreateResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x060018F0 RID: 6384 RVA: 0x002F9618 File Offset: 0x002F7818
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060018F1 RID: 6385 RVA: 0x002F9628 File Offset: 0x002F7828
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060018F2 RID: 6386 RVA: 0x002F9638 File Offset: 0x002F7838
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060018F3 RID: 6387 RVA: 0x002F9648 File Offset: 0x002F7848
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060018F4 RID: 6388 RVA: 0x002F9658 File Offset: 0x002F7858
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060018F5 RID: 6389 RVA: 0x002F9668 File Offset: 0x002F7868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ForgettableSpellPresetCreateResponse.Types.Success other)
				{
				}

				// Token: 0x060018F6 RID: 6390 RVA: 0x002F9678 File Offset: 0x002F7878
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060018F7 RID: 6391 RVA: 0x002F9688 File Offset: 0x002F7888
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060018F8 RID: 6392 RVA: 0x002F9698 File Offset: 0x002F7898
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						ForgettableSpellPresetCreateResponse.Types.Success._parser = new MessageParser<ForgettableSpellPresetCreateResponse.Types.Success>(() => null);
						num2 = 2;
					}
				}

				// Token: 0x060018F9 RID: 6393 RVA: 0x002F977C File Offset: 0x002F797C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool PBf8a1GHA3Hkhf95Ldu5()
				{
					return true;
				}

				// Token: 0x060018FA RID: 6394 RVA: 0x002F9784 File Offset: 0x002F7984
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ForgettableSpellPresetCreateResponse.Types.Success rFDn1AGHBf1R9UdXwQY2()
				{
					return null;
				}

				// Token: 0x040008E7 RID: 2279
				private static readonly MessageParser<ForgettableSpellPresetCreateResponse.Types.Success> _parser;

				// Token: 0x040008E8 RID: 2280
				private UnknownFieldSet _unknownFields;

				// Token: 0x040008E9 RID: 2281
				public const int PresetInfoFieldNumber = 1;

				// Token: 0x040008EA RID: 2282
				private ForgettableSpellPresetInfo presetInfo_;

				// Token: 0x040008EB RID: 2283
				internal static ForgettableSpellPresetCreateResponse.Types.Success UYsfvVGHmIYBfSREJF3N;
			}
		}
	}
}
