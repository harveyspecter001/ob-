using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AD7 RID: 2775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSpellCoolDown : IMessage<FightSpellCoolDown>, IMessage, IEquatable<FightSpellCoolDown>, IDeepCloneable<FightSpellCoolDown>, IBufferMessage
	{
		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x002648A0 File Offset: 0x00262AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightSpellCoolDown> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060084A4 RID: 33956 RVA: 0x002648B0 File Offset: 0x00262AB0
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x002648C0 File Offset: 0x00262AC0
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

		// Token: 0x060084A6 RID: 33958 RVA: 0x002648D0 File Offset: 0x00262AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpellCoolDown()
		{
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x002648E0 File Offset: 0x00262AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpellCoolDown(FightSpellCoolDown other)
		{
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x002648F0 File Offset: 0x00262AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpellCoolDown Clone()
		{
			return null;
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060084A9 RID: 33961 RVA: 0x00264900 File Offset: 0x00262B00
		// (set) Token: 0x060084AA RID: 33962 RVA: 0x00264910 File Offset: 0x00262B10
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

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x00264920 File Offset: 0x00262B20
		// (set) Token: 0x060084AC RID: 33964 RVA: 0x00264930 File Offset: 0x00262B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CoolDown
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

		// Token: 0x060084AD RID: 33965 RVA: 0x00264940 File Offset: 0x00262B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x00264950 File Offset: 0x00262B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSpellCoolDown other)
		{
			return true;
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x00264960 File Offset: 0x00262B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x00264970 File Offset: 0x00262B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x00264980 File Offset: 0x00262B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x00264990 File Offset: 0x00262B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x002649A0 File Offset: 0x00262BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x002649B0 File Offset: 0x00262BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSpellCoolDown other)
		{
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x002649C0 File Offset: 0x00262BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x002649D0 File Offset: 0x00262BD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x002649E0 File Offset: 0x00262BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSpellCoolDown()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 4:
					FightSpellCoolDown._parser = new MessageParser<FightSpellCoolDown>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x00264AD8 File Offset: 0x00262CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l5PX1FJsD0PtWTLyTU8b()
		{
			return true;
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x00264AE0 File Offset: 0x00262CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSpellCoolDown wILlUeJstHgaumquV077()
		{
			return null;
		}

		// Token: 0x04003083 RID: 12419
		private static readonly MessageParser<FightSpellCoolDown> _parser;

		// Token: 0x04003084 RID: 12420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003085 RID: 12421
		public const int SpellIdFieldNumber = 1;

		// Token: 0x04003086 RID: 12422
		private int spellId_;

		// Token: 0x04003087 RID: 12423
		public const int CoolDownFieldNumber = 2;

		// Token: 0x04003088 RID: 12424
		private int coolDown_;

		// Token: 0x04003089 RID: 12425
		internal static FightSpellCoolDown hfLtx8JsCAuqmJq9C6bX;
	}
}
