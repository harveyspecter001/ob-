using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x0200011A RID: 282
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ApplySpellModifierEvent : IMessage<ApplySpellModifierEvent>, IMessage, IEquatable<ApplySpellModifierEvent>, IDeepCloneable<ApplySpellModifierEvent>, IBufferMessage
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00198880 File Offset: 0x00196A80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ApplySpellModifierEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00198890 File Offset: 0x00196A90
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x001988A0 File Offset: 0x00196AA0
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

		// Token: 0x06000CD0 RID: 3280 RVA: 0x001988B0 File Offset: 0x00196AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplySpellModifierEvent()
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x001988C0 File Offset: 0x00196AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplySpellModifierEvent(ApplySpellModifierEvent other)
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x001988D0 File Offset: 0x00196AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplySpellModifierEvent Clone()
		{
			return null;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x001988E0 File Offset: 0x00196AE0
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x001988F0 File Offset: 0x00196AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActorId
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00198900 File Offset: 0x00196B00
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00198910 File Offset: 0x00196B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellModifier Modifier
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

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00198920 File Offset: 0x00196B20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00198930 File Offset: 0x00196B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ApplySpellModifierEvent other)
		{
			return true;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00198940 File Offset: 0x00196B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00198950 File Offset: 0x00196B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00198960 File Offset: 0x00196B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00198970 File Offset: 0x00196B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00198980 File Offset: 0x00196B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00198990 File Offset: 0x00196B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ApplySpellModifierEvent other)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x001989A0 File Offset: 0x00196BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x001989B0 File Offset: 0x00196BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x001989C0 File Offset: 0x00196BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ApplySpellModifierEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ApplySpellModifierEvent._parser = new MessageParser<ApplySpellModifierEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00198AA4 File Offset: 0x00196CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hNPovkOcj2OL1UyA7xxm()
		{
			return true;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00198AAC File Offset: 0x00196CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ApplySpellModifierEvent xLnVAEOcKeEHCrURfJ12()
		{
			return null;
		}

		// Token: 0x040004A5 RID: 1189
		private static readonly MessageParser<ApplySpellModifierEvent> _parser;

		// Token: 0x040004A6 RID: 1190
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004A7 RID: 1191
		public const int ActorIdFieldNumber = 1;

		// Token: 0x040004A8 RID: 1192
		private long actorId_;

		// Token: 0x040004A9 RID: 1193
		public const int ModifierFieldNumber = 2;

		// Token: 0x040004AA RID: 1194
		private SpellModifier modifier_;

		// Token: 0x040004AB RID: 1195
		internal static ApplySpellModifierEvent pTOhHVOc4fKucBToZ9Ht;
	}
}
