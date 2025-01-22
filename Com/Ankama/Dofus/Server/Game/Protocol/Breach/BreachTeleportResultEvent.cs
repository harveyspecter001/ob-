using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000979 RID: 2425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachTeleportResultEvent : IMessage<BreachTeleportResultEvent>, IMessage, IEquatable<BreachTeleportResultEvent>, IDeepCloneable<BreachTeleportResultEvent>, IBufferMessage
	{
		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x00242E1C File Offset: 0x0024101C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachTeleportResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600756B RID: 30059 RVA: 0x00242E2C File Offset: 0x0024102C
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x00242E3C File Offset: 0x0024103C
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

		// Token: 0x0600756D RID: 30061 RVA: 0x00242E4C File Offset: 0x0024104C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportResultEvent()
		{
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x00242E5C File Offset: 0x0024105C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportResultEvent(BreachTeleportResultEvent other)
		{
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00242E6C File Offset: 0x0024106C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachTeleportResultEvent Clone()
		{
			return null;
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x00242E7C File Offset: 0x0024107C
		// (set) Token: 0x06007571 RID: 30065 RVA: 0x00242E8C File Offset: 0x0024108C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Teleported
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

		// Token: 0x06007572 RID: 30066 RVA: 0x00242E9C File Offset: 0x0024109C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00242EAC File Offset: 0x002410AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachTeleportResultEvent other)
		{
			return true;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00242EBC File Offset: 0x002410BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00242ECC File Offset: 0x002410CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00242EDC File Offset: 0x002410DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00242EEC File Offset: 0x002410EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00242EFC File Offset: 0x002410FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00242F0C File Offset: 0x0024110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachTeleportResultEvent other)
		{
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00242F1C File Offset: 0x0024111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00242F2C File Offset: 0x0024112C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00242F3C File Offset: 0x0024113C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachTeleportResultEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					BreachTeleportResultEvent._parser = new MessageParser<BreachTeleportResultEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00243020 File Offset: 0x00241220
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jjwt29JRlxFbWTtHcx2q()
		{
			return true;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x00243028 File Offset: 0x00241228
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachTeleportResultEvent r01OCjJRcjmru7qrP1nL()
		{
			return null;
		}

		// Token: 0x040028E4 RID: 10468
		private static readonly MessageParser<BreachTeleportResultEvent> _parser;

		// Token: 0x040028E5 RID: 10469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E6 RID: 10470
		public const int TeleportedFieldNumber = 1;

		// Token: 0x040028E7 RID: 10471
		private bool teleported_;

		// Token: 0x040028E8 RID: 10472
		internal static BreachTeleportResultEvent HErg5MJRkN6whbJibaAJ;
	}
}
