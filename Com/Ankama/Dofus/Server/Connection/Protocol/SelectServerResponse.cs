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
	// Token: 0x02000E20 RID: 3616
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectServerResponse : IMessage<SelectServerResponse>, IMessage, IEquatable<SelectServerResponse>, IDeepCloneable<SelectServerResponse>, IBufferMessage
	{
		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x0029F9E4 File Offset: 0x0029DBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SelectServerResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x0029F9F4 File Offset: 0x0029DBF4
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

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x0029FA04 File Offset: 0x0029DC04
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

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x0029FA14 File Offset: 0x0029DC14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerResponse()
		{
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x0029FA24 File Offset: 0x0029DC24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerResponse(SelectServerResponse other)
		{
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x0029FA34 File Offset: 0x0029DC34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerResponse Clone()
		{
			return null;
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600ADF7 RID: 44535 RVA: 0x0029FA44 File Offset: 0x0029DC44
		// (set) Token: 0x0600ADF8 RID: 44536 RVA: 0x0029FA54 File Offset: 0x0029DC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectServerResponse.Types.Success Success
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

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x0029FA64 File Offset: 0x0029DC64
		// (set) Token: 0x0600ADFA RID: 44538 RVA: 0x0029FA78 File Offset: 0x0029DC78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SelectServerResponse.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SelectServerResponse.Types.Error)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x0029FA88 File Offset: 0x0029DC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasError
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x0029FA98 File Offset: 0x0029DC98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearError()
		{
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x0029FAA8 File Offset: 0x0029DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectServerResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SelectServerResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x0029FABC File Offset: 0x0029DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x0029FACC File Offset: 0x0029DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x0029FADC File Offset: 0x0029DCDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SelectServerResponse other)
		{
			return true;
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x0029FAEC File Offset: 0x0029DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x0029FAFC File Offset: 0x0029DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x0029FB0C File Offset: 0x0029DD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x0029FB1C File Offset: 0x0029DD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x0029FB2C File Offset: 0x0029DD2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x0029FB3C File Offset: 0x0029DD3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SelectServerResponse other)
		{
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x0029FB4C File Offset: 0x0029DD4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x0029FB5C File Offset: 0x0029DD5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x0029FB6C File Offset: 0x0029DD6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SelectServerResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					SelectServerResponse._parser = new MessageParser<SelectServerResponse>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x0029FC64 File Offset: 0x0029DE64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yco6GGJU8u8ro5R1F58G()
		{
			return true;
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x0029FC6C File Offset: 0x0029DE6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SelectServerResponse qhn2x8JUZev7Uo3pkKKS()
		{
			return null;
		}

		// Token: 0x04003FFC RID: 16380
		private static readonly MessageParser<SelectServerResponse> _parser;

		// Token: 0x04003FFD RID: 16381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FFE RID: 16382
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003FFF RID: 16383
		public const int ErrorFieldNumber = 2;

		// Token: 0x04004000 RID: 16384
		private object result_;

		// Token: 0x04004001 RID: 16385
		private SelectServerResponse.ResultOneofCase resultCase_;

		// Token: 0x04004002 RID: 16386
		internal static SelectServerResponse vkdFptJUugayP653OWYi;

		// Token: 0x02000E21 RID: 3617
		public enum ResultOneofCase
		{
			// Token: 0x04004004 RID: 16388
			None,
			// Token: 0x04004005 RID: 16389
			Success,
			// Token: 0x04004006 RID: 16390
			Error
		}

		// Token: 0x02000E22 RID: 3618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600AE0C RID: 44556 RVA: 0x002F3ED8 File Offset: 0x002F20D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E23 RID: 3619
			public enum Error
			{
				// Token: 0x04004008 RID: 16392
				[OriginalName("REFUSED")]
				Refused,
				// Token: 0x04004009 RID: 16393
				[OriginalName("SUBSCRIBER_ONLY")]
				SubscriberOnly,
				// Token: 0x0400400A RID: 16394
				[OriginalName("SINGLE_ACCOUNT_VERIFIED_ONLY")]
				SingleAccountVerifiedOnly,
				// Token: 0x0400400B RID: 16395
				[OriginalName("MAINTENANCE")]
				Maintenance
			}

			// Token: 0x02000E24 RID: 3620
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<SelectServerResponse.Types.Success>, IMessage, IEquatable<SelectServerResponse.Types.Success>, IDeepCloneable<SelectServerResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17002048 RID: 8264
				// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x0030FCAC File Offset: 0x0030DEAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<SelectServerResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17002049 RID: 8265
				// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x0030FCBC File Offset: 0x0030DEBC
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

				// Token: 0x1700204A RID: 8266
				// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x0030FCCC File Offset: 0x0030DECC
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

				// Token: 0x0600AE10 RID: 44560 RVA: 0x0030FCDC File Offset: 0x0030DEDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600AE11 RID: 44561 RVA: 0x0030FCEC File Offset: 0x0030DEEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(SelectServerResponse.Types.Success other)
				{
				}

				// Token: 0x0600AE12 RID: 44562 RVA: 0x0030FCFC File Offset: 0x0030DEFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SelectServerResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x1700204B RID: 8267
				// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x0030FD0C File Offset: 0x0030DF0C
				// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x0030FD1C File Offset: 0x0030DF1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string Token
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

				// Token: 0x1700204C RID: 8268
				// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x0030FD2C File Offset: 0x0030DF2C
				// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x0030FD3C File Offset: 0x0030DF3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string Host
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

				// Token: 0x1700204D RID: 8269
				// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x0030FD4C File Offset: 0x0030DF4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<int> Ports
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x0600AE18 RID: 44568 RVA: 0x0030FD5C File Offset: 0x0030DF5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AE19 RID: 44569 RVA: 0x0030FD6C File Offset: 0x0030DF6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(SelectServerResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x0600AE1A RID: 44570 RVA: 0x0030FD7C File Offset: 0x0030DF7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AE1B RID: 44571 RVA: 0x0030FD8C File Offset: 0x0030DF8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AE1C RID: 44572 RVA: 0x0030FD9C File Offset: 0x0030DF9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AE1D RID: 44573 RVA: 0x0030FDAC File Offset: 0x0030DFAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AE1E RID: 44574 RVA: 0x0030FDBC File Offset: 0x0030DFBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AE1F RID: 44575 RVA: 0x0030FDCC File Offset: 0x0030DFCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(SelectServerResponse.Types.Success other)
				{
				}

				// Token: 0x0600AE20 RID: 44576 RVA: 0x0030FDDC File Offset: 0x0030DFDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AE21 RID: 44577 RVA: 0x0030FDEC File Offset: 0x0030DFEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AE22 RID: 44578 RVA: 0x0030FDFC File Offset: 0x0030DFFC
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
						default:
							return;
						case 1:
							SelectServerResponse.Types.Success._parser = new MessageParser<SelectServerResponse.Types.Success>(() => null);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
							{
								num2 = 5;
							}
							break;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						case 5:
							SelectServerResponse.Types.Success._repeated_ports_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x0600AE23 RID: 44579 RVA: 0x0030FF14 File Offset: 0x0030E114
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TkmHLMGq7H8Mqeu8HeQV()
				{
					return true;
				}

				// Token: 0x0600AE24 RID: 44580 RVA: 0x0030FF1C File Offset: 0x0030E11C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static SelectServerResponse.Types.Success mL8MyYGqTKKvDe2DRwpd()
				{
					return null;
				}

				// Token: 0x0400400C RID: 16396
				private static readonly MessageParser<SelectServerResponse.Types.Success> _parser;

				// Token: 0x0400400D RID: 16397
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400400E RID: 16398
				public const int TokenFieldNumber = 1;

				// Token: 0x0400400F RID: 16399
				private string token_;

				// Token: 0x04004010 RID: 16400
				public const int HostFieldNumber = 2;

				// Token: 0x04004011 RID: 16401
				private string host_;

				// Token: 0x04004012 RID: 16402
				public const int PortsFieldNumber = 3;

				// Token: 0x04004013 RID: 16403
				private static readonly FieldCodec<int> _repeated_ports_codec;

				// Token: 0x04004014 RID: 16404
				private readonly RepeatedField<int> ports_;

				// Token: 0x04004015 RID: 16405
				internal static SelectServerResponse.Types.Success lFxmYJGqQxkq5YDeG4WT;
			}
		}
	}
}
