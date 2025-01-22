using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x0200012C RID: 300
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellItem : IMessage<SpellItem>, IMessage, IEquatable<SpellItem>, IDeepCloneable<SpellItem>, IBufferMessage
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00199858 File Offset: 0x00197A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00199868 File Offset: 0x00197A68
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00199878 File Offset: 0x00197A78
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

		// Token: 0x06000D96 RID: 3478 RVA: 0x00199888 File Offset: 0x00197A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem()
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00199898 File Offset: 0x00197A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem(SpellItem other)
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x001998A8 File Offset: 0x00197AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem Clone()
		{
			return null;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x001998B8 File Offset: 0x00197AB8
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x001998C8 File Offset: 0x00197AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellId
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x001998D8 File Offset: 0x00197AD8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x001998E8 File Offset: 0x00197AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellLevel
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x001998F8 File Offset: 0x00197AF8
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00199908 File Offset: 0x00197B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Available
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00199918 File Offset: 0x00197B18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00199928 File Offset: 0x00197B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAvailable()
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00199938 File Offset: 0x00197B38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00199948 File Offset: 0x00197B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellItem other)
		{
			return true;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00199958 File Offset: 0x00197B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00199968 File Offset: 0x00197B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00199978 File Offset: 0x00197B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00199988 File Offset: 0x00197B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00199998 File Offset: 0x00197B98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x001999A8 File Offset: 0x00197BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellItem other)
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x001999B8 File Offset: 0x00197BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x001999C8 File Offset: 0x00197BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x001999D8 File Offset: 0x00197BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellItem()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SpellItem._parser = new MessageParser<SpellItem>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				SpellItem.AvailableDefaultValue = false;
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00199AD0 File Offset: 0x00197CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xyP2nyOcDPQKTVvmYqMW()
		{
			return true;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00199AD8 File Offset: 0x00197CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellItem hc7LnEOctJgcPidxdIDc()
		{
			return null;
		}

		// Token: 0x040004F5 RID: 1269
		private static readonly MessageParser<SpellItem> _parser;

		// Token: 0x040004F6 RID: 1270
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004F7 RID: 1271
		private int _hasBits0;

		// Token: 0x040004F8 RID: 1272
		public const int SpellIdFieldNumber = 1;

		// Token: 0x040004F9 RID: 1273
		private int spellId_;

		// Token: 0x040004FA RID: 1274
		public const int SpellLevelFieldNumber = 2;

		// Token: 0x040004FB RID: 1275
		private int spellLevel_;

		// Token: 0x040004FC RID: 1276
		public const int AvailableFieldNumber = 3;

		// Token: 0x040004FD RID: 1277
		private static readonly bool AvailableDefaultValue;

		// Token: 0x040004FE RID: 1278
		private bool available_;

		// Token: 0x040004FF RID: 1279
		internal static SpellItem xjAcJdOcCgTYFwGi0Uhi;
	}
}
