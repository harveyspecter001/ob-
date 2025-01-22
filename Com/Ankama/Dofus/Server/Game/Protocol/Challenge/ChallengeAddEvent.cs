using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x02000962 RID: 2402
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeAddEvent : IMessage<ChallengeAddEvent>, IMessage, IEquatable<ChallengeAddEvent>, IDeepCloneable<ChallengeAddEvent>, IBufferMessage
	{
		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600744D RID: 29773 RVA: 0x00240970 File Offset: 0x0023EB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeAddEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x00240980 File Offset: 0x0023EB80
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

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600744F RID: 29775 RVA: 0x00240990 File Offset: 0x0023EB90
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

		// Token: 0x06007450 RID: 29776 RVA: 0x002409A0 File Offset: 0x0023EBA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeAddEvent()
		{
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x002409B0 File Offset: 0x0023EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeAddEvent(ChallengeAddEvent other)
		{
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x002409C0 File Offset: 0x0023EBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeAddEvent Clone()
		{
			return null;
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x002409D0 File Offset: 0x0023EBD0
		// (set) Token: 0x06007454 RID: 29780 RVA: 0x002409E0 File Offset: 0x0023EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge Challenge
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

		// Token: 0x06007455 RID: 29781 RVA: 0x002409F0 File Offset: 0x0023EBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x00240A00 File Offset: 0x0023EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeAddEvent other)
		{
			return true;
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x00240A10 File Offset: 0x0023EC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x00240A20 File Offset: 0x0023EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00240A30 File Offset: 0x0023EC30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x00240A40 File Offset: 0x0023EC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x00240A50 File Offset: 0x0023EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x00240A60 File Offset: 0x0023EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeAddEvent other)
		{
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00240A70 File Offset: 0x0023EC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x00240A80 File Offset: 0x0023EC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x00240A90 File Offset: 0x0023EC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeAddEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ChallengeAddEvent._parser = new MessageParser<ChallengeAddEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00240B74 File Offset: 0x0023ED74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CIhM0lJ3bydqMmb0Z9ci()
		{
			return true;
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x00240B7C File Offset: 0x0023ED7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeAddEvent YXJFK1J3iKcQTTxMEZaU()
		{
			return null;
		}

		// Token: 0x04002898 RID: 10392
		private static readonly MessageParser<ChallengeAddEvent> _parser;

		// Token: 0x04002899 RID: 10393
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400289A RID: 10394
		public const int ChallengeFieldNumber = 1;

		// Token: 0x0400289B RID: 10395
		private Challenge challenge_;

		// Token: 0x0400289C RID: 10396
		private static ChallengeAddEvent bWNEbnJ3YfMfnY2YBJaP;
	}
}
