using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002F0 RID: 752
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyLeaveEvent : IMessage<PartyLeaveEvent>, IMessage, IEquatable<PartyLeaveEvent>, IDeepCloneable<PartyLeaveEvent>, IBufferMessage
	{
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x001BD4A4 File Offset: 0x001BB6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyLeaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x001BD4B4 File Offset: 0x001BB6B4
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x001BD4C4 File Offset: 0x001BB6C4
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

		// Token: 0x06002316 RID: 8982 RVA: 0x001BD4D4 File Offset: 0x001BB6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveEvent()
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x001BD4E4 File Offset: 0x001BB6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveEvent(PartyLeaveEvent other)
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x001BD4F4 File Offset: 0x001BB6F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x001BD504 File Offset: 0x001BB704
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x001BD514 File Offset: 0x001BB714
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

		// Token: 0x0600231B RID: 8987 RVA: 0x001BD524 File Offset: 0x001BB724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x001BD534 File Offset: 0x001BB734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyLeaveEvent other)
		{
			return true;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x001BD544 File Offset: 0x001BB744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x001BD554 File Offset: 0x001BB754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x001BD564 File Offset: 0x001BB764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x001BD574 File Offset: 0x001BB774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x001BD584 File Offset: 0x001BB784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x001BD594 File Offset: 0x001BB794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyLeaveEvent other)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x001BD5A4 File Offset: 0x001BB7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x001BD5B4 File Offset: 0x001BB7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x001BD5C4 File Offset: 0x001BB7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyLeaveEvent()
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
						return;
					case 2:
						PartyLeaveEvent._parser = new MessageParser<PartyLeaveEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					break;
				}
				IL_AB:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
				continue;
				goto IL_AB;
			}
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x001BD694 File Offset: 0x001BB894
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UFCZaFOLU3ussCRiI45n()
		{
			return true;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x001BD69C File Offset: 0x001BB89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyLeaveEvent vZqGK9OLvgQFXwsWbkB8()
		{
			return null;
		}

		// Token: 0x04000C68 RID: 3176
		private static readonly MessageParser<PartyLeaveEvent> _parser;

		// Token: 0x04000C69 RID: 3177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C6A RID: 3178
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C6B RID: 3179
		private int partyId_;

		// Token: 0x04000C6C RID: 3180
		private static PartyLeaveEvent e7Yf3sOLcWIWZaDPePUu;
	}
}
