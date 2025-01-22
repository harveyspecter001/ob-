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
	// Token: 0x02000241 RID: 577
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetStatUpdateRequest : IMessage<PresetStatUpdateRequest>, IMessage, IEquatable<PresetStatUpdateRequest>, IDeepCloneable<PresetStatUpdateRequest>, IBufferMessage
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x001B0D74 File Offset: 0x001AEF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetStatUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x001B0D84 File Offset: 0x001AEF84
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x001B0D94 File Offset: 0x001AEF94
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

		// Token: 0x06001AE3 RID: 6883 RVA: 0x001B0DA4 File Offset: 0x001AEFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateRequest()
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x001B0DB4 File Offset: 0x001AEFB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateRequest(PresetStatUpdateRequest other)
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x001B0DC4 File Offset: 0x001AEFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetStatUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x001B0DD4 File Offset: 0x001AEFD4
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x001B0DE4 File Offset: 0x001AEFE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PresetUuid
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x001B0DF4 File Offset: 0x001AEFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PresetStatUpdateRequest.Types.StatByIdEntry> StatById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x001B0E04 File Offset: 0x001AF004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x001B0E14 File Offset: 0x001AF014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetStatUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x001B0E24 File Offset: 0x001AF024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x001B0E34 File Offset: 0x001AF034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x001B0E44 File Offset: 0x001AF044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x001B0E54 File Offset: 0x001AF054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x001B0E64 File Offset: 0x001AF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x001B0E74 File Offset: 0x001AF074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetStatUpdateRequest other)
		{
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x001B0E84 File Offset: 0x001AF084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x001B0E94 File Offset: 0x001AF094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x001B0EA4 File Offset: 0x001AF0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetStatUpdateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PresetStatUpdateRequest._repeated_statById_codec = FieldCodec.ForMessage<PresetStatUpdateRequest.Types.StatByIdEntry>(18U, muqicwZ7mT7rT2526GJ.XVInXhlssT(muqicwZ7mT7rT2526GJ.xu1ZTG9ZI5));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 2;
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
					PresetStatUpdateRequest._parser = new MessageParser<PresetStatUpdateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x001B0FAC File Offset: 0x001AF1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pyHLVmO53DNfSvTVrn0E()
		{
			return true;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x001B0FB4 File Offset: 0x001AF1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetStatUpdateRequest lpDRa8O5RaTa0U57x8aA()
		{
			return null;
		}

		// Token: 0x04000994 RID: 2452
		private static readonly MessageParser<PresetStatUpdateRequest> _parser;

		// Token: 0x04000995 RID: 2453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000996 RID: 2454
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000997 RID: 2455
		private string presetUuid_;

		// Token: 0x04000998 RID: 2456
		public const int StatByIdFieldNumber = 2;

		// Token: 0x04000999 RID: 2457
		private static readonly FieldCodec<PresetStatUpdateRequest.Types.StatByIdEntry> _repeated_statById_codec;

		// Token: 0x0400099A RID: 2458
		private readonly RepeatedField<PresetStatUpdateRequest.Types.StatByIdEntry> statById_;

		// Token: 0x0400099B RID: 2459
		private static PresetStatUpdateRequest f4hkLbO5e0SqEYYCWtma;

		// Token: 0x02000242 RID: 578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001AF6 RID: 6902 RVA: 0x002B2028 File Offset: 0x002B0228
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000243 RID: 579
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class StatByIdEntry : IMessage<PresetStatUpdateRequest.Types.StatByIdEntry>, IMessage, IEquatable<PresetStatUpdateRequest.Types.StatByIdEntry>, IDeepCloneable<PresetStatUpdateRequest.Types.StatByIdEntry>, IBufferMessage
			{
				// Token: 0x170004CF RID: 1231
				// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x002F9A04 File Offset: 0x002F7C04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetStatUpdateRequest.Types.StatByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004D0 RID: 1232
				// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x002F9A14 File Offset: 0x002F7C14
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

				// Token: 0x170004D1 RID: 1233
				// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x002F9A24 File Offset: 0x002F7C24
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

				// Token: 0x06001AFA RID: 6906 RVA: 0x002F9A34 File Offset: 0x002F7C34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public StatByIdEntry()
				{
				}

				// Token: 0x06001AFB RID: 6907 RVA: 0x002F9A44 File Offset: 0x002F7C44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public StatByIdEntry(PresetStatUpdateRequest.Types.StatByIdEntry other)
				{
				}

				// Token: 0x06001AFC RID: 6908 RVA: 0x002F9A54 File Offset: 0x002F7C54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetStatUpdateRequest.Types.StatByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x170004D2 RID: 1234
				// (get) Token: 0x06001AFD RID: 6909 RVA: 0x002F9A64 File Offset: 0x002F7C64
				// (set) Token: 0x06001AFE RID: 6910 RVA: 0x002F9A74 File Offset: 0x002F7C74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x170004D3 RID: 1235
				// (get) Token: 0x06001AFF RID: 6911 RVA: 0x002F9A84 File Offset: 0x002F7C84
				// (set) Token: 0x06001B00 RID: 6912 RVA: 0x002F9A94 File Offset: 0x002F7C94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Value
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

				// Token: 0x06001B01 RID: 6913 RVA: 0x002F9AA4 File Offset: 0x002F7CA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001B02 RID: 6914 RVA: 0x002F9AB4 File Offset: 0x002F7CB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetStatUpdateRequest.Types.StatByIdEntry other)
				{
					return true;
				}

				// Token: 0x06001B03 RID: 6915 RVA: 0x002F9AC4 File Offset: 0x002F7CC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001B04 RID: 6916 RVA: 0x002F9AD4 File Offset: 0x002F7CD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001B05 RID: 6917 RVA: 0x002F9AE4 File Offset: 0x002F7CE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001B06 RID: 6918 RVA: 0x002F9AF4 File Offset: 0x002F7CF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001B07 RID: 6919 RVA: 0x002F9B04 File Offset: 0x002F7D04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001B08 RID: 6920 RVA: 0x002F9B14 File Offset: 0x002F7D14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetStatUpdateRequest.Types.StatByIdEntry other)
				{
				}

				// Token: 0x06001B09 RID: 6921 RVA: 0x002F9B24 File Offset: 0x002F7D24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001B0A RID: 6922 RVA: 0x002F9B34 File Offset: 0x002F7D34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001B0B RID: 6923 RVA: 0x002F9B44 File Offset: 0x002F7D44
				[MethodImpl(MethodImplOptions.NoInlining)]
				static StatByIdEntry()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						PresetStatUpdateRequest.Types.StatByIdEntry._parser = new MessageParser<PresetStatUpdateRequest.Types.StatByIdEntry>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06001B0C RID: 6924 RVA: 0x002F9C10 File Offset: 0x002F7E10
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool KQ8rGcGH2sV6S7uYBFS8()
				{
					return true;
				}

				// Token: 0x06001B0D RID: 6925 RVA: 0x002F9C18 File Offset: 0x002F7E18
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetStatUpdateRequest.Types.StatByIdEntry PmDaU8GHEqpxJXAcs8Fk()
				{
					return null;
				}

				// Token: 0x0400099C RID: 2460
				private static readonly MessageParser<PresetStatUpdateRequest.Types.StatByIdEntry> _parser;

				// Token: 0x0400099D RID: 2461
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400099E RID: 2462
				public const int KeyFieldNumber = 1;

				// Token: 0x0400099F RID: 2463
				private int key_;

				// Token: 0x040009A0 RID: 2464
				public const int ValueFieldNumber = 2;

				// Token: 0x040009A1 RID: 2465
				private int value_;

				// Token: 0x040009A2 RID: 2466
				private static PresetStatUpdateRequest.Types.StatByIdEntry cbfplDGH962SVvWCXLeq;
			}
		}
	}
}
