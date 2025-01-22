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
	// Token: 0x02000429 RID: 1065
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarReplacedEvent : IMessage<ShortcutBarReplacedEvent>, IMessage, IEquatable<ShortcutBarReplacedEvent>, IDeepCloneable<ShortcutBarReplacedEvent>, IBufferMessage
	{
		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x001D64FC File Offset: 0x001D46FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarReplacedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x001D650C File Offset: 0x001D470C
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x001D651C File Offset: 0x001D471C
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

		// Token: 0x06003272 RID: 12914 RVA: 0x001D652C File Offset: 0x001D472C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarReplacedEvent()
		{
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x001D653C File Offset: 0x001D473C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarReplacedEvent(ShortcutBarReplacedEvent other)
		{
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x001D654C File Offset: 0x001D474C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarReplacedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x001D655C File Offset: 0x001D475C
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x001D6570 File Offset: 0x001D4770
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x001D6580 File Offset: 0x001D4780
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x001D6590 File Offset: 0x001D4790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06003279 RID: 12921 RVA: 0x001D65A0 File Offset: 0x001D47A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x001D65B0 File Offset: 0x001D47B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarReplacedEvent other)
		{
			return true;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x001D65C0 File Offset: 0x001D47C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x001D65D0 File Offset: 0x001D47D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x001D65E0 File Offset: 0x001D47E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x001D65F0 File Offset: 0x001D47F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x001D6600 File Offset: 0x001D4800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x001D6610 File Offset: 0x001D4810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarReplacedEvent other)
		{
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x001D6620 File Offset: 0x001D4820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x001D6630 File Offset: 0x001D4830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x001D6640 File Offset: 0x001D4840
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarReplacedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					ShortcutBarReplacedEvent._parser = new MessageParser<ShortcutBarReplacedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x001D6724 File Offset: 0x001D4924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KghOSWOCFD0BmdJEhdZt()
		{
			return true;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x001D672C File Offset: 0x001D492C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarReplacedEvent LBE2CFOCztnX0iYQbu8c()
		{
			return null;
		}

		// Token: 0x040011A1 RID: 4513
		private static readonly MessageParser<ShortcutBarReplacedEvent> _parser;

		// Token: 0x040011A2 RID: 4514
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011A3 RID: 4515
		public const int BarTypeFieldNumber = 1;

		// Token: 0x040011A4 RID: 4516
		private ShortcutBar barType_;

		// Token: 0x040011A5 RID: 4517
		public const int ShortcutFieldNumber = 2;

		// Token: 0x040011A6 RID: 4518
		private Shortcut shortcut_;

		// Token: 0x040011A7 RID: 4519
		internal static ShortcutBarReplacedEvent rEYZFyOCqmKOPkqwCa2E;
	}
}
