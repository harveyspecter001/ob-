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
	// Token: 0x02000427 RID: 1063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarRemovedEvent : IMessage<ShortcutBarRemovedEvent>, IMessage, IEquatable<ShortcutBarRemovedEvent>, IDeepCloneable<ShortcutBarRemovedEvent>, IBufferMessage
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x001D62C4 File Offset: 0x001D44C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x001D62D4 File Offset: 0x001D44D4
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x001D62E4 File Offset: 0x001D44E4
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

		// Token: 0x06003256 RID: 12886 RVA: 0x001D62F4 File Offset: 0x001D44F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemovedEvent()
		{
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x001D6304 File Offset: 0x001D4504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemovedEvent(ShortcutBarRemovedEvent other)
		{
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x001D6314 File Offset: 0x001D4514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x001D6324 File Offset: 0x001D4524
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x001D6338 File Offset: 0x001D4538
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x001D6348 File Offset: 0x001D4548
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x001D6358 File Offset: 0x001D4558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SlotId
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

		// Token: 0x0600325D RID: 12893 RVA: 0x001D6368 File Offset: 0x001D4568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x001D6378 File Offset: 0x001D4578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarRemovedEvent other)
		{
			return true;
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x001D6388 File Offset: 0x001D4588
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x001D6398 File Offset: 0x001D4598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x001D63A8 File Offset: 0x001D45A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x001D63B8 File Offset: 0x001D45B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x001D63C8 File Offset: 0x001D45C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x001D63D8 File Offset: 0x001D45D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarRemovedEvent other)
		{
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x001D63E8 File Offset: 0x001D45E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x001D63F8 File Offset: 0x001D45F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x001D6408 File Offset: 0x001D4608
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarRemovedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
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
					continue;
				case 4:
					ShortcutBarRemovedEvent._parser = new MessageParser<ShortcutBarRemovedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x001D64EC File Offset: 0x001D46EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QHjRviOC8wtmw3BtqeN6()
		{
			return true;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x001D64F4 File Offset: 0x001D46F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarRemovedEvent nnC6GGOCZQCiJI5fcBnl()
		{
			return null;
		}

		// Token: 0x04001198 RID: 4504
		private static readonly MessageParser<ShortcutBarRemovedEvent> _parser;

		// Token: 0x04001199 RID: 4505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400119A RID: 4506
		public const int BarTypeFieldNumber = 1;

		// Token: 0x0400119B RID: 4507
		private ShortcutBar barType_;

		// Token: 0x0400119C RID: 4508
		public const int SlotIdFieldNumber = 2;

		// Token: 0x0400119D RID: 4509
		private int slotId_;

		// Token: 0x0400119E RID: 4510
		internal static ShortcutBarRemovedEvent mTtuRLOCudIS9C81GPwh;
	}
}
