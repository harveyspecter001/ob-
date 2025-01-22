using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200073D RID: 1853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseGenericItemRemovedEvent : IMessage<ExchangeBidHouseGenericItemRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseGenericItemRemovedEvent>, IDeepCloneable<ExchangeBidHouseGenericItemRemovedEvent>, IBufferMessage
	{
		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06005AEC RID: 23276 RVA: 0x00219444 File Offset: 0x00217644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseGenericItemRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x00219454 File Offset: 0x00217654
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

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005AEE RID: 23278 RVA: 0x00219464 File Offset: 0x00217664
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

		// Token: 0x06005AEF RID: 23279 RVA: 0x00219474 File Offset: 0x00217674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemRemovedEvent()
		{
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x00219484 File Offset: 0x00217684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemRemovedEvent(ExchangeBidHouseGenericItemRemovedEvent other)
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00219494 File Offset: 0x00217694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x002194A4 File Offset: 0x002176A4
		// (set) Token: 0x06005AF3 RID: 23283 RVA: 0x002194B4 File Offset: 0x002176B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06005AF4 RID: 23284 RVA: 0x002194C4 File Offset: 0x002176C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x002194D4 File Offset: 0x002176D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseGenericItemRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x002194E4 File Offset: 0x002176E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x002194F4 File Offset: 0x002176F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00219504 File Offset: 0x00217704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x00219514 File Offset: 0x00217714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00219524 File Offset: 0x00217724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00219534 File Offset: 0x00217734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseGenericItemRemovedEvent other)
		{
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00219544 File Offset: 0x00217744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00219554 File Offset: 0x00217754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00219564 File Offset: 0x00217764
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseGenericItemRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ExchangeBidHouseGenericItemRemovedEvent._parser = new MessageParser<ExchangeBidHouseGenericItemRemovedEvent>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_C1;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 1;
					}
				}
				IL_C1:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x0021964C File Offset: 0x0021784C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XTkRk6O86H1Nk5HioJVj()
		{
			return true;
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00219654 File Offset: 0x00217854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseGenericItemRemovedEvent XnNhUfO8LGsuexTibDHU()
		{
			return null;
		}

		// Token: 0x04001FD4 RID: 8148
		private static readonly MessageParser<ExchangeBidHouseGenericItemRemovedEvent> _parser;

		// Token: 0x04001FD5 RID: 8149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FD6 RID: 8150
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001FD7 RID: 8151
		private int objectGid_;

		// Token: 0x04001FD8 RID: 8152
		internal static ExchangeBidHouseGenericItemRemovedEvent tj0nWvO8y8pFd82MZD54;
	}
}
