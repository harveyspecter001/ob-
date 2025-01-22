using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002F2 RID: 754
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyKickedByEvent : IMessage<PartyKickedByEvent>, IMessage, IEquatable<PartyKickedByEvent>, IDeepCloneable<PartyKickedByEvent>, IBufferMessage
	{
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x001BD6A4 File Offset: 0x001BB8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyKickedByEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x001BD6B4 File Offset: 0x001BB8B4
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x001BD6C4 File Offset: 0x001BB8C4
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

		// Token: 0x06002330 RID: 9008 RVA: 0x001BD6D4 File Offset: 0x001BB8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickedByEvent()
		{
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x001BD6E4 File Offset: 0x001BB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickedByEvent(PartyKickedByEvent other)
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x001BD6F4 File Offset: 0x001BB8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickedByEvent Clone()
		{
			return null;
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x001BD704 File Offset: 0x001BB904
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x001BD714 File Offset: 0x001BB914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x001BD724 File Offset: 0x001BB924
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x001BD734 File Offset: 0x001BB934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KickerId
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

		// Token: 0x06002337 RID: 9015 RVA: 0x001BD744 File Offset: 0x001BB944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x001BD754 File Offset: 0x001BB954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyKickedByEvent other)
		{
			return true;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x001BD764 File Offset: 0x001BB964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x001BD774 File Offset: 0x001BB974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x001BD784 File Offset: 0x001BB984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x001BD794 File Offset: 0x001BB994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x001BD7A4 File Offset: 0x001BB9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x001BD7B4 File Offset: 0x001BB9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyKickedByEvent other)
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x001BD7C4 File Offset: 0x001BB9C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x001BD7D4 File Offset: 0x001BB9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x001BD7E4 File Offset: 0x001BB9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyKickedByEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PartyKickedByEvent._parser = new MessageParser<PartyKickedByEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
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
				break;
			}
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x001BD8B0 File Offset: 0x001BBAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JtNbvyOL1CMPk4mi7Fqt()
		{
			return true;
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x001BD8B8 File Offset: 0x001BBAB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyKickedByEvent FuSgpKOLaUBy3Ylbh1dm()
		{
			return null;
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly MessageParser<PartyKickedByEvent> _parser;

		// Token: 0x04000C70 RID: 3184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C71 RID: 3185
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C72 RID: 3186
		private int partyId_;

		// Token: 0x04000C73 RID: 3187
		public const int KickerIdFieldNumber = 2;

		// Token: 0x04000C74 RID: 3188
		private long kickerId_;

		// Token: 0x04000C75 RID: 3189
		internal static PartyKickedByEvent viXWFHOLoYyYIgcWSOHp;
	}
}
