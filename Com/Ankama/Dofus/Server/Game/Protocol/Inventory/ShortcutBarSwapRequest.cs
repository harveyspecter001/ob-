using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003E2 RID: 994
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarSwapRequest : IMessage<ShortcutBarSwapRequest>, IMessage, IEquatable<ShortcutBarSwapRequest>, IDeepCloneable<ShortcutBarSwapRequest>, IBufferMessage
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x001D1BC0 File Offset: 0x001CFDC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ShortcutBarSwapRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x001D1BD0 File Offset: 0x001CFDD0
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x001D1BE0 File Offset: 0x001CFDE0
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

		// Token: 0x06002EC1 RID: 11969 RVA: 0x001D1BF0 File Offset: 0x001CFDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarSwapRequest()
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x001D1C00 File Offset: 0x001CFE00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarSwapRequest(ShortcutBarSwapRequest other)
		{
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x001D1C10 File Offset: 0x001CFE10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarSwapRequest Clone()
		{
			return null;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x001D1C20 File Offset: 0x001CFE20
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x001D1C34 File Offset: 0x001CFE34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutBar BarType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ShortcutBar)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x001D1C44 File Offset: 0x001CFE44
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x001D1C54 File Offset: 0x001CFE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstSlotId
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

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x001D1C64 File Offset: 0x001CFE64
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x001D1C74 File Offset: 0x001CFE74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SecondSlotId
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

		// Token: 0x06002ECA RID: 11978 RVA: 0x001D1C84 File Offset: 0x001CFE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x001D1C94 File Offset: 0x001CFE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarSwapRequest other)
		{
			return true;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x001D1CA4 File Offset: 0x001CFEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x001D1CB4 File Offset: 0x001CFEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x001D1CC4 File Offset: 0x001CFEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x001D1CD4 File Offset: 0x001CFED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x001D1CE4 File Offset: 0x001CFEE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x001D1CF4 File Offset: 0x001CFEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarSwapRequest other)
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x001D1D04 File Offset: 0x001CFF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x001D1D14 File Offset: 0x001CFF14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x001D1D24 File Offset: 0x001CFF24
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarSwapRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				ShortcutBarSwapRequest._parser = new MessageParser<ShortcutBarSwapRequest>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x001D1DF0 File Offset: 0x001CFFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NVwXY7O04otIEfIv66ul()
		{
			return true;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x001D1DF8 File Offset: 0x001CFFF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarSwapRequest Qmhc3tO0jWMpXMMM3rcY()
		{
			return null;
		}

		// Token: 0x04001076 RID: 4214
		private static readonly MessageParser<ShortcutBarSwapRequest> _parser;

		// Token: 0x04001077 RID: 4215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001078 RID: 4216
		public const int BarTypeFieldNumber = 1;

		// Token: 0x04001079 RID: 4217
		private ShortcutBar barType_;

		// Token: 0x0400107A RID: 4218
		public const int FirstSlotIdFieldNumber = 2;

		// Token: 0x0400107B RID: 4219
		private int firstSlotId_;

		// Token: 0x0400107C RID: 4220
		public const int SecondSlotIdFieldNumber = 3;

		// Token: 0x0400107D RID: 4221
		private int secondSlotId_;

		// Token: 0x0400107E RID: 4222
		private static ShortcutBarSwapRequest wChKBDO0xsMXbi8q8oYW;
	}
}
