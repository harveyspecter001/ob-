using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000423 RID: 1059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarContentEvent : IMessage<ShortcutBarContentEvent>, IMessage, IEquatable<ShortcutBarContentEvent>, IDeepCloneable<ShortcutBarContentEvent>, IBufferMessage
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x001D5E58 File Offset: 0x001D4058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarContentEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x001D5E68 File Offset: 0x001D4068
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

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x001D5E78 File Offset: 0x001D4078
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

		// Token: 0x0600321F RID: 12831 RVA: 0x001D5E88 File Offset: 0x001D4088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarContentEvent()
		{
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x001D5E98 File Offset: 0x001D4098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarContentEvent(ShortcutBarContentEvent other)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x001D5EA8 File Offset: 0x001D40A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarContentEvent Clone()
		{
			return null;
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x001D5EB8 File Offset: 0x001D40B8
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x001D5ECC File Offset: 0x001D40CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x001D5EDC File Offset: 0x001D40DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Shortcut> Shortcuts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x001D5EEC File Offset: 0x001D40EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x001D5EFC File Offset: 0x001D40FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarContentEvent other)
		{
			return true;
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x001D5F0C File Offset: 0x001D410C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x001D5F1C File Offset: 0x001D411C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x001D5F2C File Offset: 0x001D412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x001D5F3C File Offset: 0x001D413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x001D5F4C File Offset: 0x001D414C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x001D5F5C File Offset: 0x001D415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarContentEvent other)
		{
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x001D5F6C File Offset: 0x001D416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x001D5F7C File Offset: 0x001D417C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x001D5F8C File Offset: 0x001D418C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarContentEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					ShortcutBarContentEvent._parser = new MessageParser<ShortcutBarContentEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				ShortcutBarContentEvent._repeated_shortcuts_codec = FieldCodec.ForMessage<Shortcut>(18U, iW01yrnF9K4S4GUbqCXR.XVInXhlssT(iW01yrnF9K4S4GUbqCXR.S3AnF2miOx2));
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x001D607C File Offset: 0x001D427C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KK3OHoOCbtMg8rgrBv43()
		{
			return true;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x001D6084 File Offset: 0x001D4284
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarContentEvent DcVW4cOCisKOtHUWQUgT()
		{
			return null;
		}

		// Token: 0x04001185 RID: 4485
		private static readonly MessageParser<ShortcutBarContentEvent> _parser;

		// Token: 0x04001186 RID: 4486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001187 RID: 4487
		public const int BarTypeFieldNumber = 1;

		// Token: 0x04001188 RID: 4488
		private ShortcutBar barType_;

		// Token: 0x04001189 RID: 4489
		public const int ShortcutsFieldNumber = 2;

		// Token: 0x0400118A RID: 4490
		private static readonly FieldCodec<Shortcut> _repeated_shortcuts_codec;

		// Token: 0x0400118B RID: 4491
		private readonly RepeatedField<Shortcut> shortcuts_;

		// Token: 0x0400118C RID: 4492
		private static ShortcutBarContentEvent x0kNnKOCYxcEPrk5RlBe;
	}
}
