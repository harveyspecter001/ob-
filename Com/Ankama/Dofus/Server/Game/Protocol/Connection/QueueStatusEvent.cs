using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x020008A5 RID: 2213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QueueStatusEvent : IMessage<QueueStatusEvent>, IMessage, IEquatable<QueueStatusEvent>, IDeepCloneable<QueueStatusEvent>, IBufferMessage
	{
		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x00231214 File Offset: 0x0022F414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QueueStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x00231224 File Offset: 0x0022F424
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x00231234 File Offset: 0x0022F434
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

		// Token: 0x06006B85 RID: 27525 RVA: 0x00231244 File Offset: 0x0022F444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueStatusEvent()
		{
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00231254 File Offset: 0x0022F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueStatusEvent(QueueStatusEvent other)
		{
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00231264 File Offset: 0x0022F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x00231274 File Offset: 0x0022F474
		// (set) Token: 0x06006B89 RID: 27529 RVA: 0x00231284 File Offset: 0x0022F484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
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

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06006B8A RID: 27530 RVA: 0x00231294 File Offset: 0x0022F494
		// (set) Token: 0x06006B8B RID: 27531 RVA: 0x002312A4 File Offset: 0x0022F4A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Total
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

		// Token: 0x06006B8C RID: 27532 RVA: 0x002312B4 File Offset: 0x0022F4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x002312C4 File Offset: 0x0022F4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QueueStatusEvent other)
		{
			return true;
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x002312D4 File Offset: 0x0022F4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x002312E4 File Offset: 0x0022F4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x002312F4 File Offset: 0x0022F4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00231304 File Offset: 0x0022F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00231314 File Offset: 0x0022F514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00231324 File Offset: 0x0022F524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QueueStatusEvent other)
		{
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00231334 File Offset: 0x0022F534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00231344 File Offset: 0x0022F544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00231354 File Offset: 0x0022F554
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QueueStatusEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					QueueStatusEvent._parser = new MessageParser<QueueStatusEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
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
			}
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00231438 File Offset: 0x0022F638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wKDY8PJmLTrRRZpZHhGw()
		{
			return true;
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00231440 File Offset: 0x0022F640
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QueueStatusEvent Jw7SdWJmWua0bjXmdyIQ()
		{
			return null;
		}

		// Token: 0x04002592 RID: 9618
		private static readonly MessageParser<QueueStatusEvent> _parser;

		// Token: 0x04002593 RID: 9619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002594 RID: 9620
		public const int PositionFieldNumber = 1;

		// Token: 0x04002595 RID: 9621
		private int position_;

		// Token: 0x04002596 RID: 9622
		public const int TotalFieldNumber = 2;

		// Token: 0x04002597 RID: 9623
		private int total_;

		// Token: 0x04002598 RID: 9624
		private static QueueStatusEvent FVUj5aJm6HvKiDZPyRJv;
	}
}
