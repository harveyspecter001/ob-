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
	// Token: 0x020003DE RID: 990
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarAddRequest : IMessage<ShortcutBarAddRequest>, IMessage, IEquatable<ShortcutBarAddRequest>, IDeepCloneable<ShortcutBarAddRequest>, IBufferMessage
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x001D1780 File Offset: 0x001CF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarAddRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x001D1790 File Offset: 0x001CF990
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x001D17A0 File Offset: 0x001CF9A0
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

		// Token: 0x06002E89 RID: 11913 RVA: 0x001D17B0 File Offset: 0x001CF9B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarAddRequest()
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x001D17C0 File Offset: 0x001CF9C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarAddRequest(ShortcutBarAddRequest other)
		{
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x001D17D0 File Offset: 0x001CF9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarAddRequest Clone()
		{
			return null;
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x001D17E0 File Offset: 0x001CF9E0
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x001D17F4 File Offset: 0x001CF9F4
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x001D1804 File Offset: 0x001CFA04
		// (set) Token: 0x06002E8F RID: 11919 RVA: 0x001D1814 File Offset: 0x001CFA14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Shortcut Shortcut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x001D1824 File Offset: 0x001CFA24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x001D1834 File Offset: 0x001CFA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarAddRequest other)
		{
			return true;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x001D1844 File Offset: 0x001CFA44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x001D1854 File Offset: 0x001CFA54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x001D1864 File Offset: 0x001CFA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x001D1874 File Offset: 0x001CFA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x001D1884 File Offset: 0x001CFA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x001D1894 File Offset: 0x001CFA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarAddRequest other)
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x001D18A4 File Offset: 0x001CFAA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x001D18B4 File Offset: 0x001CFAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x001D18C4 File Offset: 0x001CFAC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarAddRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ShortcutBarAddRequest._parser = new MessageParser<ShortcutBarAddRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x001D1990 File Offset: 0x001CFB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K2dYdoO09OlhQ5TtG8sn()
		{
			return true;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x001D1998 File Offset: 0x001CFB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarAddRequest Ut3dukO02asUn7dr25iv()
		{
			return null;
		}

		// Token: 0x04001064 RID: 4196
		private static readonly MessageParser<ShortcutBarAddRequest> _parser;

		// Token: 0x04001065 RID: 4197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001066 RID: 4198
		public const int BarTypeFieldNumber = 1;

		// Token: 0x04001067 RID: 4199
		private ShortcutBar barType_;

		// Token: 0x04001068 RID: 4200
		public const int ShortcutFieldNumber = 2;

		// Token: 0x04001069 RID: 4201
		private Shortcut shortcut_;

		// Token: 0x0400106A RID: 4202
		internal static ShortcutBarAddRequest uewJU0O0dpoTUNbSTLfa;
	}
}
