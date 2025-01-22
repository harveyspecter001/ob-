using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200074D RID: 1869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeErrorEvent : IMessage<ExchangeErrorEvent>, IMessage, IEquatable<ExchangeErrorEvent>, IDeepCloneable<ExchangeErrorEvent>, IBufferMessage
	{
		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x0021A69C File Offset: 0x0021889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06005BCD RID: 23501 RVA: 0x0021A6AC File Offset: 0x002188AC
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

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x0021A6BC File Offset: 0x002188BC
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

		// Token: 0x06005BCF RID: 23503 RVA: 0x0021A6CC File Offset: 0x002188CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeErrorEvent()
		{
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x0021A6DC File Offset: 0x002188DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeErrorEvent(ExchangeErrorEvent other)
		{
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x0021A6EC File Offset: 0x002188EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x0021A6FC File Offset: 0x002188FC
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x0021A710 File Offset: 0x00218910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeErrorEvent.Types.ExchangeError ErrorType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeErrorEvent.Types.ExchangeError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x0021A720 File Offset: 0x00218920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x0021A730 File Offset: 0x00218930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeErrorEvent other)
		{
			return true;
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x0021A740 File Offset: 0x00218940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x0021A750 File Offset: 0x00218950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x0021A760 File Offset: 0x00218960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x0021A770 File Offset: 0x00218970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x0021A780 File Offset: 0x00218980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x0021A790 File Offset: 0x00218990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeErrorEvent other)
		{
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x0021A7A0 File Offset: 0x002189A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x0021A7B0 File Offset: 0x002189B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x0021A7C0 File Offset: 0x002189C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
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
					ExchangeErrorEvent._parser = new MessageParser<ExchangeErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x0021A8A4 File Offset: 0x00218AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RognFEO8ZC2hwScquqEJ()
		{
			return true;
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x0021A8AC File Offset: 0x00218AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeErrorEvent CeRFpvO8qi6NG63HX7GN()
		{
			return null;
		}

		// Token: 0x04002028 RID: 8232
		private static readonly MessageParser<ExchangeErrorEvent> _parser;

		// Token: 0x04002029 RID: 8233
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400202A RID: 8234
		public const int ErrorTypeFieldNumber = 1;

		// Token: 0x0400202B RID: 8235
		private ExchangeErrorEvent.Types.ExchangeError errorType_;

		// Token: 0x0400202C RID: 8236
		internal static ExchangeErrorEvent pbqOk6O88lBenSgUGwAN;

		// Token: 0x0200074E RID: 1870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06005BE1 RID: 23521 RVA: 0x002D0714 File Offset: 0x002CE914
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200074F RID: 1871
			public enum ExchangeError
			{
				// Token: 0x0400202E RID: 8238
				[OriginalName("REQUEST_IMPOSSIBLE")]
				RequestImpossible,
				// Token: 0x0400202F RID: 8239
				[OriginalName("REQUEST_CHARACTER_OCCUPIED")]
				RequestCharacterOccupied,
				// Token: 0x04002030 RID: 8240
				[OriginalName("REQUEST_CHARACTER_JOB_NOT_EQUIPPED")]
				RequestCharacterJobNotEquipped,
				// Token: 0x04002031 RID: 8241
				[OriginalName("REQUEST_CHARACTER_TOOL_TOO_FAR")]
				RequestCharacterToolTooFar,
				// Token: 0x04002032 RID: 8242
				[OriginalName("REQUEST_CHARACTER_OVERLOADED")]
				RequestCharacterOverloaded,
				// Token: 0x04002033 RID: 8243
				[OriginalName("REQUEST_CHARACTER_NOT_SUBSCRIBER")]
				RequestCharacterNotSubscriber,
				// Token: 0x04002034 RID: 8244
				[OriginalName("REQUEST_CHARACTER_GUEST")]
				RequestCharacterGuest,
				// Token: 0x04002035 RID: 8245
				[OriginalName("MOUNT_PADDOCK_ERROR")]
				MountPaddockError,
				// Token: 0x04002036 RID: 8246
				[OriginalName("BID_SEARCH_ERROR")]
				BidSearchError,
				// Token: 0x04002037 RID: 8247
				[OriginalName("SELL_ERROR")]
				SellError,
				// Token: 0x04002038 RID: 8248
				[OriginalName("BUY_ERROR")]
				BuyError
			}
		}
	}
}
