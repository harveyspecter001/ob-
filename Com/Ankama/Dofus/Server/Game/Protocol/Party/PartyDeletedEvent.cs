using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002F6 RID: 758
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyDeletedEvent : IMessage<PartyDeletedEvent>, IMessage, IEquatable<PartyDeletedEvent>, IDeepCloneable<PartyDeletedEvent>, IBufferMessage
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x001BDAF4 File Offset: 0x001BBCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyDeletedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x001BDB04 File Offset: 0x001BBD04
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x001BDB14 File Offset: 0x001BBD14
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

		// Token: 0x06002368 RID: 9064 RVA: 0x001BDB24 File Offset: 0x001BBD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyDeletedEvent()
		{
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x001BDB34 File Offset: 0x001BBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyDeletedEvent(PartyDeletedEvent other)
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x001BDB44 File Offset: 0x001BBD44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyDeletedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x001BDB54 File Offset: 0x001BBD54
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x001BDB64 File Offset: 0x001BBD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600236D RID: 9069 RVA: 0x001BDB74 File Offset: 0x001BBD74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x001BDB84 File Offset: 0x001BBD84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyDeletedEvent other)
		{
			return true;
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x001BDB94 File Offset: 0x001BBD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x001BDBA4 File Offset: 0x001BBDA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x001BDBB4 File Offset: 0x001BBDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x001BDBC4 File Offset: 0x001BBDC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x001BDBD4 File Offset: 0x001BBDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x001BDBE4 File Offset: 0x001BBDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyDeletedEvent other)
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x001BDBF4 File Offset: 0x001BBDF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x001BDC04 File Offset: 0x001BBE04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x001BDC14 File Offset: 0x001BBE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyDeletedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PartyDeletedEvent._parser = new MessageParser<PartyDeletedEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x001BDCF8 File Offset: 0x001BBEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NsQKS7OLWGbvLmATC6As()
		{
			return true;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x001BDD00 File Offset: 0x001BBF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyDeletedEvent N8xULDOLhaEGyT3wLEqi()
		{
			return null;
		}

		// Token: 0x04000C81 RID: 3201
		private static readonly MessageParser<PartyDeletedEvent> _parser;

		// Token: 0x04000C82 RID: 3202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C83 RID: 3203
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C84 RID: 3204
		private int partyId_;

		// Token: 0x04000C85 RID: 3205
		internal static PartyDeletedEvent qGOddlOLL2HBFd5nf5ua;
	}
}
