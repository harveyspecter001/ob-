using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008F5 RID: 2293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LifePointsRegenBeginEvent : IMessage<LifePointsRegenBeginEvent>, IMessage, IEquatable<LifePointsRegenBeginEvent>, IDeepCloneable<LifePointsRegenBeginEvent>, IBufferMessage
	{
		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x00238C10 File Offset: 0x00236E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifePointsRegenBeginEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06006F81 RID: 28545 RVA: 0x00238C20 File Offset: 0x00236E20
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

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x00238C30 File Offset: 0x00236E30
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

		// Token: 0x06006F83 RID: 28547 RVA: 0x00238C40 File Offset: 0x00236E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LifePointsRegenBeginEvent()
		{
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x00238C50 File Offset: 0x00236E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LifePointsRegenBeginEvent(LifePointsRegenBeginEvent other)
		{
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x00238C60 File Offset: 0x00236E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LifePointsRegenBeginEvent Clone()
		{
			return null;
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x00238C70 File Offset: 0x00236E70
		// (set) Token: 0x06006F87 RID: 28551 RVA: 0x00238C80 File Offset: 0x00236E80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RegenRate
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

		// Token: 0x06006F88 RID: 28552 RVA: 0x00238C90 File Offset: 0x00236E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00238CA0 File Offset: 0x00236EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LifePointsRegenBeginEvent other)
		{
			return true;
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00238CB0 File Offset: 0x00236EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00238CC0 File Offset: 0x00236EC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00238CD0 File Offset: 0x00236ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00238CE0 File Offset: 0x00236EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x00238CF0 File Offset: 0x00236EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00238D00 File Offset: 0x00236F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LifePointsRegenBeginEvent other)
		{
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00238D10 File Offset: 0x00236F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00238D20 File Offset: 0x00236F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x00238D30 File Offset: 0x00236F30
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LifePointsRegenBeginEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					LifePointsRegenBeginEvent._parser = new MessageParser<LifePointsRegenBeginEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00238DFC File Offset: 0x00236FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m9Xv8FJB6m4fcVgWso5y()
		{
			return true;
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00238E04 File Offset: 0x00237004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LifePointsRegenBeginEvent PWJxW7JBLIlFg2HmeuW4()
		{
			return null;
		}

		// Token: 0x04002709 RID: 9993
		private static readonly MessageParser<LifePointsRegenBeginEvent> _parser;

		// Token: 0x0400270A RID: 9994
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400270B RID: 9995
		public const int RegenRateFieldNumber = 1;

		// Token: 0x0400270C RID: 9996
		private int regenRate_;

		// Token: 0x0400270D RID: 9997
		private static LifePointsRegenBeginEvent G8ZJcNJBysfO3ikLvc03;
	}
}
