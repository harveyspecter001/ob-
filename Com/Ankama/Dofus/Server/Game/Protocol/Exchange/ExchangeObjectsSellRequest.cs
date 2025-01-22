using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006FA RID: 1786
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectsSellRequest : IMessage<ExchangeObjectsSellRequest>, IMessage, IEquatable<ExchangeObjectsSellRequest>, IDeepCloneable<ExchangeObjectsSellRequest>, IBufferMessage
	{
		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x00214FF4 File Offset: 0x002131F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectsSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x00215004 File Offset: 0x00213204
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

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x00215014 File Offset: 0x00213214
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

		// Token: 0x06005773 RID: 22387 RVA: 0x00215024 File Offset: 0x00213224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsSellRequest()
		{
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x00215034 File Offset: 0x00213234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsSellRequest(ExchangeObjectsSellRequest other)
		{
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00215044 File Offset: 0x00213244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsSellRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x00215054 File Offset: 0x00213254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExchangeObjectsSellRequest.Types.ExchangeObject> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00215064 File Offset: 0x00213264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00215074 File Offset: 0x00213274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectsSellRequest other)
		{
			return true;
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00215084 File Offset: 0x00213284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00215094 File Offset: 0x00213294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x002150A4 File Offset: 0x002132A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x002150B4 File Offset: 0x002132B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x002150C4 File Offset: 0x002132C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x002150D4 File Offset: 0x002132D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectsSellRequest other)
		{
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x002150E4 File Offset: 0x002132E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x002150F4 File Offset: 0x002132F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00215104 File Offset: 0x00213304
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectsSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_D0;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						ExchangeObjectsSellRequest._parser = new MessageParser<ExchangeObjectsSellRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					}
					ExchangeObjectsSellRequest._repeated_objects_codec = FieldCodec.ForMessage<ExchangeObjectsSellRequest.Types.ExchangeObject>(10U, RtMc2LAsBrcV9Gxel6PA.XVInXhlssT(RtMc2LAsBrcV9Gxel6PA.b3HAseapSDG));
					num2 = 3;
				}
				IL_D0:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 5;
			}
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x002151F8 File Offset: 0x002133F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fxlFbeOuAuYY3wZ9qaFm()
		{
			return true;
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00215200 File Offset: 0x00213400
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectsSellRequest lGVak7OuBjMXpFL4kFyf()
		{
			return null;
		}

		// Token: 0x04001E9A RID: 7834
		private static readonly MessageParser<ExchangeObjectsSellRequest> _parser;

		// Token: 0x04001E9B RID: 7835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E9C RID: 7836
		public const int ObjectsFieldNumber = 1;

		// Token: 0x04001E9D RID: 7837
		private static readonly FieldCodec<ExchangeObjectsSellRequest.Types.ExchangeObject> _repeated_objects_codec;

		// Token: 0x04001E9E RID: 7838
		private readonly RepeatedField<ExchangeObjectsSellRequest.Types.ExchangeObject> objects_;

		// Token: 0x04001E9F RID: 7839
		private static ExchangeObjectsSellRequest Mv0bmAOumwqpYWDdYP9f;

		// Token: 0x020006FB RID: 1787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06005784 RID: 22404 RVA: 0x002CE088 File Offset: 0x002CC288
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020006FC RID: 1788
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ExchangeObject : IMessage<ExchangeObjectsSellRequest.Types.ExchangeObject>, IMessage, IEquatable<ExchangeObjectsSellRequest.Types.ExchangeObject>, IDeepCloneable<ExchangeObjectsSellRequest.Types.ExchangeObject>, IBufferMessage
			{
				// Token: 0x17000FDA RID: 4058
				// (get) Token: 0x06005785 RID: 22405 RVA: 0x00304178 File Offset: 0x00302378
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ExchangeObjectsSellRequest.Types.ExchangeObject> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000FDB RID: 4059
				// (get) Token: 0x06005786 RID: 22406 RVA: 0x00304188 File Offset: 0x00302388
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

				// Token: 0x17000FDC RID: 4060
				// (get) Token: 0x06005787 RID: 22407 RVA: 0x00304198 File Offset: 0x00302398
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

				// Token: 0x06005788 RID: 22408 RVA: 0x003041A8 File Offset: 0x003023A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeObject()
				{
				}

				// Token: 0x06005789 RID: 22409 RVA: 0x003041B8 File Offset: 0x003023B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeObject(ExchangeObjectsSellRequest.Types.ExchangeObject other)
				{
				}

				// Token: 0x0600578A RID: 22410 RVA: 0x003041C8 File Offset: 0x003023C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeObjectsSellRequest.Types.ExchangeObject Clone()
				{
					return null;
				}

				// Token: 0x17000FDD RID: 4061
				// (get) Token: 0x0600578B RID: 22411 RVA: 0x003041D8 File Offset: 0x003023D8
				// (set) Token: 0x0600578C RID: 22412 RVA: 0x003041E8 File Offset: 0x003023E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ObjectUid
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

				// Token: 0x17000FDE RID: 4062
				// (get) Token: 0x0600578D RID: 22413 RVA: 0x003041F8 File Offset: 0x003023F8
				// (set) Token: 0x0600578E RID: 22414 RVA: 0x00304208 File Offset: 0x00302408
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Quantity
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

				// Token: 0x0600578F RID: 22415 RVA: 0x00304218 File Offset: 0x00302418
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06005790 RID: 22416 RVA: 0x00304228 File Offset: 0x00302428
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ExchangeObjectsSellRequest.Types.ExchangeObject other)
				{
					return true;
				}

				// Token: 0x06005791 RID: 22417 RVA: 0x00304238 File Offset: 0x00302438
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06005792 RID: 22418 RVA: 0x00304248 File Offset: 0x00302448
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06005793 RID: 22419 RVA: 0x00304258 File Offset: 0x00302458
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06005794 RID: 22420 RVA: 0x00304268 File Offset: 0x00302468
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06005795 RID: 22421 RVA: 0x00304278 File Offset: 0x00302478
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06005796 RID: 22422 RVA: 0x00304288 File Offset: 0x00302488
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ExchangeObjectsSellRequest.Types.ExchangeObject other)
				{
				}

				// Token: 0x06005797 RID: 22423 RVA: 0x00304298 File Offset: 0x00302498
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06005798 RID: 22424 RVA: 0x003042A8 File Offset: 0x003024A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06005799 RID: 22425 RVA: 0x003042B8 File Offset: 0x003024B8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeObject()
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
							num2 = 4;
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
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
							ExchangeObjectsSellRequest.Types.ExchangeObject._parser = new MessageParser<ExchangeObjectsSellRequest.Types.ExchangeObject>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x0600579A RID: 22426 RVA: 0x00304384 File Offset: 0x00302584
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool OkNRAEGP7FgLZKtabeHg()
				{
					return true;
				}

				// Token: 0x0600579B RID: 22427 RVA: 0x0030438C File Offset: 0x0030258C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ExchangeObjectsSellRequest.Types.ExchangeObject YXO34WGPTmC61NBTx4NE()
				{
					return null;
				}

				// Token: 0x04001EA0 RID: 7840
				private static readonly MessageParser<ExchangeObjectsSellRequest.Types.ExchangeObject> _parser;

				// Token: 0x04001EA1 RID: 7841
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001EA2 RID: 7842
				public const int ObjectUidFieldNumber = 1;

				// Token: 0x04001EA3 RID: 7843
				private int objectUid_;

				// Token: 0x04001EA4 RID: 7844
				public const int QuantityFieldNumber = 2;

				// Token: 0x04001EA5 RID: 7845
				private int quantity_;

				// Token: 0x04001EA6 RID: 7846
				internal static ExchangeObjectsSellRequest.Types.ExchangeObject RCC8GaGPQZ5tK4a6ygOH;
			}
		}
	}
}
