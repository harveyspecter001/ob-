using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B39 RID: 2873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutOutfit : IMessage<ShortcutOutfit>, IMessage, IEquatable<ShortcutOutfit>, IDeepCloneable<ShortcutOutfit>, IBufferMessage
	{
		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x00267290 File Offset: 0x00265490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutOutfit> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x002672A0 File Offset: 0x002654A0
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

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06008978 RID: 35192 RVA: 0x002672B0 File Offset: 0x002654B0
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

		// Token: 0x06008979 RID: 35193 RVA: 0x002672C0 File Offset: 0x002654C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutOutfit()
		{
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x002672D0 File Offset: 0x002654D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutOutfit(ShortcutOutfit other)
		{
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x002672E0 File Offset: 0x002654E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutOutfit Clone()
		{
			return null;
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600897C RID: 35196 RVA: 0x002672F0 File Offset: 0x002654F0
		// (set) Token: 0x0600897D RID: 35197 RVA: 0x00267300 File Offset: 0x00265500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutfitUuid
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

		// Token: 0x0600897E RID: 35198 RVA: 0x00267310 File Offset: 0x00265510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x00267320 File Offset: 0x00265520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutOutfit other)
		{
			return true;
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x00267330 File Offset: 0x00265530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00267340 File Offset: 0x00265540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00267350 File Offset: 0x00265550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x00267360 File Offset: 0x00265560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x00267370 File Offset: 0x00265570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x00267380 File Offset: 0x00265580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutOutfit other)
		{
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x00267390 File Offset: 0x00265590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x002673A0 File Offset: 0x002655A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x002673B0 File Offset: 0x002655B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutOutfit()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ShortcutOutfit._parser = new MessageParser<ShortcutOutfit>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x002674A8 File Offset: 0x002656A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mG5L7MJdv3EXAg8kTqW4()
		{
			return true;
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x002674B0 File Offset: 0x002656B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutOutfit VXerc7Jdo9NthtG1g4XN()
		{
			return null;
		}

		// Token: 0x040032A4 RID: 12964
		private static readonly MessageParser<ShortcutOutfit> _parser;

		// Token: 0x040032A5 RID: 12965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032A6 RID: 12966
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x040032A7 RID: 12967
		private string outfitUuid_;

		// Token: 0x040032A8 RID: 12968
		internal static ShortcutOutfit Gp8YFeJdUUQAM6nHcG0a;
	}
}
