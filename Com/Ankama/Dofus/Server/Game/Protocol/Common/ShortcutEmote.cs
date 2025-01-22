using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B35 RID: 2869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutEmote : IMessage<ShortcutEmote>, IMessage, IEquatable<ShortcutEmote>, IDeepCloneable<ShortcutEmote>, IBufferMessage
	{
		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x00266E04 File Offset: 0x00265004
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ShortcutEmote> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x00266E14 File Offset: 0x00265014
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

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x00266E24 File Offset: 0x00265024
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

		// Token: 0x0600893F RID: 35135 RVA: 0x00266E34 File Offset: 0x00265034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutEmote()
		{
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00266E44 File Offset: 0x00265044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutEmote(ShortcutEmote other)
		{
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x00266E54 File Offset: 0x00265054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutEmote Clone()
		{
			return null;
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06008942 RID: 35138 RVA: 0x00266E64 File Offset: 0x00265064
		// (set) Token: 0x06008943 RID: 35139 RVA: 0x00266E74 File Offset: 0x00265074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EmoteId
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

		// Token: 0x06008944 RID: 35140 RVA: 0x00266E84 File Offset: 0x00265084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x00266E94 File Offset: 0x00265094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutEmote other)
		{
			return true;
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x00266EA4 File Offset: 0x002650A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x00266EB4 File Offset: 0x002650B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x00266EC4 File Offset: 0x002650C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x00266ED4 File Offset: 0x002650D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x00266EE4 File Offset: 0x002650E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x00266EF4 File Offset: 0x002650F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutEmote other)
		{
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x00266F04 File Offset: 0x00265104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x00266F14 File Offset: 0x00265114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x00266F24 File Offset: 0x00265124
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutEmote()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ShortcutEmote._parser = new MessageParser<ShortcutEmote>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x00267008 File Offset: 0x00265208
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DIygjHJdKgyiJj9TvmST()
		{
			return true;
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x00267010 File Offset: 0x00265210
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutEmote V63Am8JdIXZfsOuVUUET()
		{
			return null;
		}

		// Token: 0x04003290 RID: 12944
		private static readonly MessageParser<ShortcutEmote> _parser;

		// Token: 0x04003291 RID: 12945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003292 RID: 12946
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04003293 RID: 12947
		private int emoteId_;

		// Token: 0x04003294 RID: 12948
		private static ShortcutEmote OdmuJ1JdjfmYaWWOtRhy;
	}
}
