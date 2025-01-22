using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000832 RID: 2098
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendSetWarnOnLevelGainRequest : IMessage<FriendSetWarnOnLevelGainRequest>, IMessage, IEquatable<FriendSetWarnOnLevelGainRequest>, IDeepCloneable<FriendSetWarnOnLevelGainRequest>, IBufferMessage
	{
		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060065F0 RID: 26096 RVA: 0x0022B168 File Offset: 0x00229368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendSetWarnOnLevelGainRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x0022B178 File Offset: 0x00229378
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

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060065F2 RID: 26098 RVA: 0x0022B188 File Offset: 0x00229388
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

		// Token: 0x060065F3 RID: 26099 RVA: 0x0022B198 File Offset: 0x00229398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnLevelGainRequest()
		{
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0022B1A8 File Offset: 0x002293A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnLevelGainRequest(FriendSetWarnOnLevelGainRequest other)
		{
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0022B1B8 File Offset: 0x002293B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendSetWarnOnLevelGainRequest Clone()
		{
			return null;
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x0022B1C8 File Offset: 0x002293C8
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x0022B1D8 File Offset: 0x002293D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x0022B1E8 File Offset: 0x002293E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x0022B1F8 File Offset: 0x002293F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendSetWarnOnLevelGainRequest other)
		{
			return true;
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x0022B208 File Offset: 0x00229408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x0022B218 File Offset: 0x00229418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x0022B228 File Offset: 0x00229428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x0022B238 File Offset: 0x00229438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x0022B248 File Offset: 0x00229448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x0022B258 File Offset: 0x00229458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendSetWarnOnLevelGainRequest other)
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x0022B268 File Offset: 0x00229468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0022B278 File Offset: 0x00229478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x0022B288 File Offset: 0x00229488
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendSetWarnOnLevelGainRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					FriendSetWarnOnLevelGainRequest._parser = new MessageParser<FriendSetWarnOnLevelGainRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0022B354 File Offset: 0x00229554
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YiCqndJf1pP2OL0KM2Iw()
		{
			return true;
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x0022B35C File Offset: 0x0022955C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendSetWarnOnLevelGainRequest jxdO4EJfaGGi1CHGXlOT()
		{
			return null;
		}

		// Token: 0x040023D4 RID: 9172
		private static readonly MessageParser<FriendSetWarnOnLevelGainRequest> _parser;

		// Token: 0x040023D5 RID: 9173
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D6 RID: 9174
		public const int EnableFieldNumber = 1;

		// Token: 0x040023D7 RID: 9175
		private bool enable_;

		// Token: 0x040023D8 RID: 9176
		internal static FriendSetWarnOnLevelGainRequest RA2lsCJfomCGgsmcW2In;
	}
}
