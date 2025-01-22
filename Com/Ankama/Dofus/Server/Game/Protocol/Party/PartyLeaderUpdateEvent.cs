using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002EC RID: 748
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyLeaderUpdateEvent : IMessage<PartyLeaderUpdateEvent>, IMessage, IEquatable<PartyLeaderUpdateEvent>, IDeepCloneable<PartyLeaderUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x001BCFFC File Offset: 0x001BB1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyLeaderUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x001BD00C File Offset: 0x001BB20C
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x001BD01C File Offset: 0x001BB21C
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

		// Token: 0x060022DA RID: 8922 RVA: 0x001BD02C File Offset: 0x001BB22C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaderUpdateEvent()
		{
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x001BD03C File Offset: 0x001BB23C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaderUpdateEvent(PartyLeaderUpdateEvent other)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x001BD04C File Offset: 0x001BB24C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaderUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x001BD05C File Offset: 0x001BB25C
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x001BD06C File Offset: 0x001BB26C
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x001BD07C File Offset: 0x001BB27C
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x001BD08C File Offset: 0x001BB28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PartyLeaderId
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

		// Token: 0x060022E1 RID: 8929 RVA: 0x001BD09C File Offset: 0x001BB29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x001BD0AC File Offset: 0x001BB2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyLeaderUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x001BD0BC File Offset: 0x001BB2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x001BD0CC File Offset: 0x001BB2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x001BD0DC File Offset: 0x001BB2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x001BD0EC File Offset: 0x001BB2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x001BD0FC File Offset: 0x001BB2FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x001BD10C File Offset: 0x001BB30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyLeaderUpdateEvent other)
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x001BD11C File Offset: 0x001BB31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x001BD12C File Offset: 0x001BB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x001BD13C File Offset: 0x001BB33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyLeaderUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PartyLeaderUpdateEvent._parser = new MessageParser<PartyLeaderUpdateEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x001BD220 File Offset: 0x001BB420
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool axdtiVOLjLkssOvWQiFX()
		{
			return true;
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x001BD228 File Offset: 0x001BB428
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyLeaderUpdateEvent fSjGoYOLKQ7BR66HIibR()
		{
			return null;
		}

		// Token: 0x04000C52 RID: 3154
		private static readonly MessageParser<PartyLeaderUpdateEvent> _parser;

		// Token: 0x04000C53 RID: 3155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C54 RID: 3156
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C55 RID: 3157
		private int partyId_;

		// Token: 0x04000C56 RID: 3158
		public const int PartyLeaderIdFieldNumber = 2;

		// Token: 0x04000C57 RID: 3159
		private long partyLeaderId_;

		// Token: 0x04000C58 RID: 3160
		internal static PartyLeaderUpdateEvent WPC3r8OL4g5b9JNKIxiC;
	}
}
