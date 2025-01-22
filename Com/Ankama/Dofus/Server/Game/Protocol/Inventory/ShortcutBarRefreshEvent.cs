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
	// Token: 0x02000425 RID: 1061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarRefreshEvent : IMessage<ShortcutBarRefreshEvent>, IMessage, IEquatable<ShortcutBarRefreshEvent>, IDeepCloneable<ShortcutBarRefreshEvent>, IBufferMessage
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x001D608C File Offset: 0x001D428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarRefreshEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x001D609C File Offset: 0x001D429C
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

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x001D60AC File Offset: 0x001D42AC
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

		// Token: 0x0600323A RID: 12858 RVA: 0x001D60BC File Offset: 0x001D42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRefreshEvent()
		{
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x001D60CC File Offset: 0x001D42CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRefreshEvent(ShortcutBarRefreshEvent other)
		{
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x001D60DC File Offset: 0x001D42DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRefreshEvent Clone()
		{
			return null;
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x001D60EC File Offset: 0x001D42EC
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x001D6100 File Offset: 0x001D4300
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

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x001D6110 File Offset: 0x001D4310
		// (set) Token: 0x06003240 RID: 12864 RVA: 0x001D6120 File Offset: 0x001D4320
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

		// Token: 0x06003241 RID: 12865 RVA: 0x001D6130 File Offset: 0x001D4330
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x001D6140 File Offset: 0x001D4340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarRefreshEvent other)
		{
			return true;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x001D6150 File Offset: 0x001D4350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x001D6160 File Offset: 0x001D4360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x001D6170 File Offset: 0x001D4370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x001D6180 File Offset: 0x001D4380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x001D6190 File Offset: 0x001D4390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x001D61A0 File Offset: 0x001D43A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarRefreshEvent other)
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x001D61B0 File Offset: 0x001D43B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x001D61C0 File Offset: 0x001D43C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x001D61D0 File Offset: 0x001D43D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarRefreshEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ShortcutBarRefreshEvent._parser = new MessageParser<ShortcutBarRefreshEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x001D62B4 File Offset: 0x001D44B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K3al3jOCSvNR21H1d23v()
		{
			return true;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x001D62BC File Offset: 0x001D44BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarRefreshEvent DgBIN8OCMBCPYUk6eTvM()
		{
			return null;
		}

		// Token: 0x0400118F RID: 4495
		private static readonly MessageParser<ShortcutBarRefreshEvent> _parser;

		// Token: 0x04001190 RID: 4496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001191 RID: 4497
		public const int BarTypeFieldNumber = 1;

		// Token: 0x04001192 RID: 4498
		private ShortcutBar barType_;

		// Token: 0x04001193 RID: 4499
		public const int ShortcutFieldNumber = 2;

		// Token: 0x04001194 RID: 4500
		private Shortcut shortcut_;

		// Token: 0x04001195 RID: 4501
		private static ShortcutBarRefreshEvent zOiQZHOCPgc9jIG5sy8R;
	}
}
