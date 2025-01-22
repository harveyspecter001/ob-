using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200075F RID: 1887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftResultEvent : IMessage<ExchangeCraftResultEvent>, IMessage, IEquatable<ExchangeCraftResultEvent>, IDeepCloneable<ExchangeCraftResultEvent>, IBufferMessage
	{
		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x0021B844 File Offset: 0x00219A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeCraftResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06005CA9 RID: 23721 RVA: 0x0021B854 File Offset: 0x00219A54
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

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x0021B864 File Offset: 0x00219A64
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

		// Token: 0x06005CAB RID: 23723 RVA: 0x0021B874 File Offset: 0x00219A74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftResultEvent()
		{
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x0021B884 File Offset: 0x00219A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftResultEvent(ExchangeCraftResultEvent other)
		{
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x0021B894 File Offset: 0x00219A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x0021B8A4 File Offset: 0x00219AA4
		// (set) Token: 0x06005CAF RID: 23727 RVA: 0x0021B8B8 File Offset: 0x00219AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ExchangeCraftResultEvent.Types.CraftResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeCraftResultEvent.Types.CraftResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x0021B8C8 File Offset: 0x00219AC8
		// (set) Token: 0x06005CB1 RID: 23729 RVA: 0x0021B8D8 File Offset: 0x00219AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x0021B8E8 File Offset: 0x00219AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasObjectGid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x0021B8F8 File Offset: 0x00219AF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearObjectGid()
		{
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x0021B908 File Offset: 0x00219B08
		// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x0021B918 File Offset: 0x00219B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription Object
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x0021B928 File Offset: 0x00219B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeCraftResultEvent.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeCraftResultEvent.ComplementOneofCase)null;
			}
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x0021B93C File Offset: 0x00219B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x0021B94C File Offset: 0x00219B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x0021B95C File Offset: 0x00219B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftResultEvent other)
		{
			return true;
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x0021B96C File Offset: 0x00219B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x0021B97C File Offset: 0x00219B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x0021B98C File Offset: 0x00219B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x0021B99C File Offset: 0x00219B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x0021B9AC File Offset: 0x00219BAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x0021B9BC File Offset: 0x00219BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftResultEvent other)
		{
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x0021B9CC File Offset: 0x00219BCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x0021B9DC File Offset: 0x00219BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x0021B9EC File Offset: 0x00219BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ExchangeCraftResultEvent._parser = new MessageParser<ExchangeCraftResultEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_35;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
					}
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x0021BAD4 File Offset: 0x00219CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gFxygsOZ4hjFROS9lhxS()
		{
			return true;
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x0021BADC File Offset: 0x00219CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftResultEvent IfKOUxOZjaGjkrydDCrD()
		{
			return null;
		}

		// Token: 0x0400207D RID: 8317
		private static readonly MessageParser<ExchangeCraftResultEvent> _parser;

		// Token: 0x0400207E RID: 8318
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400207F RID: 8319
		public const int ResultFieldNumber = 1;

		// Token: 0x04002080 RID: 8320
		private ExchangeCraftResultEvent.Types.CraftResult result_;

		// Token: 0x04002081 RID: 8321
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x04002082 RID: 8322
		public const int ObjectFieldNumber = 3;

		// Token: 0x04002083 RID: 8323
		private object complement_;

		// Token: 0x04002084 RID: 8324
		private ExchangeCraftResultEvent.ComplementOneofCase complementCase_;

		// Token: 0x04002085 RID: 8325
		internal static ExchangeCraftResultEvent mWwJUaOZx7NEeZC0BnNa;

		// Token: 0x02000760 RID: 1888
		public enum ComplementOneofCase
		{
			// Token: 0x04002087 RID: 8327
			None,
			// Token: 0x04002088 RID: 8328
			ObjectGid = 2,
			// Token: 0x04002089 RID: 8329
			Object
		}

		// Token: 0x02000761 RID: 1889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06005CC5 RID: 23749 RVA: 0x002D0EC4 File Offset: 0x002CF0C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000762 RID: 1890
			public enum CraftResult
			{
				// Token: 0x0400208B RID: 8331
				[OriginalName("IMPOSSIBLE")]
				Impossible,
				// Token: 0x0400208C RID: 8332
				[OriginalName("FAILED")]
				Failed,
				// Token: 0x0400208D RID: 8333
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x0400208E RID: 8334
				[OriginalName("NEUTRAL")]
				Neutral,
				// Token: 0x0400208F RID: 8335
				[OriginalName("FORBIDDEN")]
				Forbidden
			}

			// Token: 0x02000763 RID: 1891
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ExchangeCraftResultWithObjectDescription : IMessage<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription>, IMessage, IEquatable<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription>, IDeepCloneable<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription>, IBufferMessage
			{
				// Token: 0x170010D0 RID: 4304
				// (get) Token: 0x06005CC6 RID: 23750 RVA: 0x00304394 File Offset: 0x00302594
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170010D1 RID: 4305
				// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x003043A4 File Offset: 0x003025A4
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

				// Token: 0x170010D2 RID: 4306
				// (get) Token: 0x06005CC8 RID: 23752 RVA: 0x003043B4 File Offset: 0x003025B4
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

				// Token: 0x06005CC9 RID: 23753 RVA: 0x003043C4 File Offset: 0x003025C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeCraftResultWithObjectDescription()
				{
				}

				// Token: 0x06005CCA RID: 23754 RVA: 0x003043D4 File Offset: 0x003025D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeCraftResultWithObjectDescription(ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription other)
				{
				}

				// Token: 0x06005CCB RID: 23755 RVA: 0x003043E4 File Offset: 0x003025E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription Clone()
				{
					return null;
				}

				// Token: 0x170010D3 RID: 4307
				// (get) Token: 0x06005CCC RID: 23756 RVA: 0x003043F4 File Offset: 0x003025F4
				// (set) Token: 0x06005CCD RID: 23757 RVA: 0x00304404 File Offset: 0x00302604
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ObjectItem Object
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

				// Token: 0x170010D4 RID: 4308
				// (get) Token: 0x06005CCE RID: 23758 RVA: 0x00304414 File Offset: 0x00302614
				// (set) Token: 0x06005CCF RID: 23759 RVA: 0x00304424 File Offset: 0x00302624
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float FmPower
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170010D5 RID: 4309
				// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x00304434 File Offset: 0x00302634
				// (set) Token: 0x06005CD1 RID: 23761 RVA: 0x00304448 File Offset: 0x00302648
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.Types.MagicPoolStatus MagicPoolStatus
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.Types.MagicPoolStatus)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170010D6 RID: 4310
				// (get) Token: 0x06005CD2 RID: 23762 RVA: 0x00304458 File Offset: 0x00302658
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasMagicPoolStatus
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06005CD3 RID: 23763 RVA: 0x00304468 File Offset: 0x00302668
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearMagicPoolStatus()
				{
				}

				// Token: 0x06005CD4 RID: 23764 RVA: 0x00304478 File Offset: 0x00302678
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06005CD5 RID: 23765 RVA: 0x00304488 File Offset: 0x00302688
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription other)
				{
					return true;
				}

				// Token: 0x06005CD6 RID: 23766 RVA: 0x00304498 File Offset: 0x00302698
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06005CD7 RID: 23767 RVA: 0x003044A8 File Offset: 0x003026A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06005CD8 RID: 23768 RVA: 0x003044B8 File Offset: 0x003026B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06005CD9 RID: 23769 RVA: 0x003044C8 File Offset: 0x003026C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06005CDA RID: 23770 RVA: 0x003044D8 File Offset: 0x003026D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06005CDB RID: 23771 RVA: 0x003044E8 File Offset: 0x003026E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription other)
				{
				}

				// Token: 0x06005CDC RID: 23772 RVA: 0x003044F8 File Offset: 0x003026F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06005CDD RID: 23773 RVA: 0x00304508 File Offset: 0x00302708
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06005CDE RID: 23774 RVA: 0x00304518 File Offset: 0x00302718
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeCraftResultWithObjectDescription()
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
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
								{
									num2 = 4;
								}
								break;
							case 1:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								return;
							case 3:
								ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription._parser = new MessageParser<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription>(() => null);
								num2 = 5;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
								{
									num2 = 4;
								}
								break;
							case 4:
								goto IL_9B;
							case 5:
								ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.MagicPoolStatusDefaultValue = ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.Types.MagicPoolStatus.NoChange;
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
								{
									num2 = 1;
								}
								break;
							}
						}
						IL_9B:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 3;
					}
				}

				// Token: 0x06005CDF RID: 23775 RVA: 0x00304628 File Offset: 0x00302828
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TDLS33GPZ7VFXxwkidYr()
				{
					return true;
				}

				// Token: 0x06005CE0 RID: 23776 RVA: 0x00304630 File Offset: 0x00302830
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription gJAp2hGPqZbZek5moqq9()
				{
					return null;
				}

				// Token: 0x04002090 RID: 8336
				private static readonly MessageParser<ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription> _parser;

				// Token: 0x04002091 RID: 8337
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002092 RID: 8338
				private int _hasBits0;

				// Token: 0x04002093 RID: 8339
				public const int ObjectFieldNumber = 1;

				// Token: 0x04002094 RID: 8340
				private ObjectItem object_;

				// Token: 0x04002095 RID: 8341
				public const int FmPowerFieldNumber = 3;

				// Token: 0x04002096 RID: 8342
				private float fmPower_;

				// Token: 0x04002097 RID: 8343
				public const int MagicPoolStatusFieldNumber = 2;

				// Token: 0x04002098 RID: 8344
				private static readonly ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.Types.MagicPoolStatus MagicPoolStatusDefaultValue;

				// Token: 0x04002099 RID: 8345
				private ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription.Types.MagicPoolStatus magicPoolStatus_;

				// Token: 0x0400209A RID: 8346
				private static ExchangeCraftResultEvent.Types.ExchangeCraftResultWithObjectDescription GHyrSBGP8hORMiKTWcO5;

				// Token: 0x02000764 RID: 1892
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x06005CE1 RID: 23777 RVA: 0x003160B0 File Offset: 0x003142B0
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000765 RID: 1893
					public enum MagicPoolStatus
					{
						// Token: 0x0400209C RID: 8348
						[OriginalName("NO_CHANGE")]
						NoChange,
						// Token: 0x0400209D RID: 8349
						[OriginalName("INCREASE")]
						Increase,
						// Token: 0x0400209E RID: 8350
						[OriginalName("LOSS")]
						Loss
					}
				}
			}
		}
	}
}
