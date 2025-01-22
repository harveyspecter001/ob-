using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000989 RID: 2441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachBudgetEvent : IMessage<BreachBudgetEvent>, IMessage, IEquatable<BreachBudgetEvent>, IDeepCloneable<BreachBudgetEvent>, IBufferMessage
	{
		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x00243D00 File Offset: 0x00241F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachBudgetEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x00243D10 File Offset: 0x00241F10
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

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06007627 RID: 30247 RVA: 0x00243D20 File Offset: 0x00241F20
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

		// Token: 0x06007628 RID: 30248 RVA: 0x00243D30 File Offset: 0x00241F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBudgetEvent()
		{
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00243D40 File Offset: 0x00241F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBudgetEvent(BreachBudgetEvent other)
		{
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00243D50 File Offset: 0x00241F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBudgetEvent Clone()
		{
			return null;
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600762B RID: 30251 RVA: 0x00243D60 File Offset: 0x00241F60
		// (set) Token: 0x0600762C RID: 30252 RVA: 0x00243D70 File Offset: 0x00241F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Budget
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

		// Token: 0x0600762D RID: 30253 RVA: 0x00243D80 File Offset: 0x00241F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00243D90 File Offset: 0x00241F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachBudgetEvent other)
		{
			return true;
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00243DA0 File Offset: 0x00241FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00243DB0 File Offset: 0x00241FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00243DC0 File Offset: 0x00241FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00243DD0 File Offset: 0x00241FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00243DE0 File Offset: 0x00241FE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00243DF0 File Offset: 0x00241FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachBudgetEvent other)
		{
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00243E00 File Offset: 0x00242000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00243E10 File Offset: 0x00242010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00243E20 File Offset: 0x00242020
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachBudgetEvent()
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
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				BreachBudgetEvent._parser = new MessageParser<BreachBudgetEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00243F04 File Offset: 0x00242104
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zaL2dqJR7UunQ6pBnUpX()
		{
			return true;
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00243F0C File Offset: 0x0024210C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachBudgetEvent ItEVvUJRTMYZKOEkTXsn()
		{
			return null;
		}

		// Token: 0x04002920 RID: 10528
		private static readonly MessageParser<BreachBudgetEvent> _parser;

		// Token: 0x04002921 RID: 10529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002922 RID: 10530
		public const int BudgetFieldNumber = 1;

		// Token: 0x04002923 RID: 10531
		private int budget_;

		// Token: 0x04002924 RID: 10532
		private static BreachBudgetEvent nXQyAVJRQ9fIOg9bGC6V;
	}
}
