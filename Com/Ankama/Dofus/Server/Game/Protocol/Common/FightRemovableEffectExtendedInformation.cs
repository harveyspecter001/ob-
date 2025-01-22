using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000ABC RID: 2748
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightRemovableEffectExtendedInformation : IMessage<FightRemovableEffectExtendedInformation>, IMessage, IEquatable<FightRemovableEffectExtendedInformation>, IDeepCloneable<FightRemovableEffectExtendedInformation>, IBufferMessage
	{
		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x0600836A RID: 33642 RVA: 0x00263600 File Offset: 0x00261800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightRemovableEffectExtendedInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600836B RID: 33643 RVA: 0x00263610 File Offset: 0x00261810
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

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600836C RID: 33644 RVA: 0x00263620 File Offset: 0x00261820
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

		// Token: 0x0600836D RID: 33645 RVA: 0x00263630 File Offset: 0x00261830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffectExtendedInformation()
		{
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x00263640 File Offset: 0x00261840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffectExtendedInformation(FightRemovableEffectExtendedInformation other)
		{
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x00263650 File Offset: 0x00261850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffectExtendedInformation Clone()
		{
			return null;
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06008370 RID: 33648 RVA: 0x00263660 File Offset: 0x00261860
		// (set) Token: 0x06008371 RID: 33649 RVA: 0x00263670 File Offset: 0x00261870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
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

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06008372 RID: 33650 RVA: 0x00263680 File Offset: 0x00261880
		// (set) Token: 0x06008373 RID: 33651 RVA: 0x00263690 File Offset: 0x00261890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SourceId
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

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06008374 RID: 33652 RVA: 0x002636A0 File Offset: 0x002618A0
		// (set) Token: 0x06008375 RID: 33653 RVA: 0x002636B0 File Offset: 0x002618B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRemovableEffect Effect
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

		// Token: 0x06008376 RID: 33654 RVA: 0x002636C0 File Offset: 0x002618C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x002636D0 File Offset: 0x002618D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightRemovableEffectExtendedInformation other)
		{
			return true;
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x002636E0 File Offset: 0x002618E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x002636F0 File Offset: 0x002618F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x00263700 File Offset: 0x00261900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x00263710 File Offset: 0x00261910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x00263720 File Offset: 0x00261920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x00263730 File Offset: 0x00261930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightRemovableEffectExtendedInformation other)
		{
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x00263740 File Offset: 0x00261940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x00263750 File Offset: 0x00261950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x00263760 File Offset: 0x00261960
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightRemovableEffectExtendedInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					FightRemovableEffectExtendedInformation._parser = new MessageParser<FightRemovableEffectExtendedInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x00263844 File Offset: 0x00261A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w9cT2kJsjpD1ovwnqVUi()
		{
			return true;
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0026384C File Offset: 0x00261A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightRemovableEffectExtendedInformation h7xBOrJsKINYNbGQ50Xt()
		{
			return null;
		}

		// Token: 0x04002FEA RID: 12266
		private static readonly MessageParser<FightRemovableEffectExtendedInformation> _parser;

		// Token: 0x04002FEB RID: 12267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FEC RID: 12268
		public const int ActionIdFieldNumber = 1;

		// Token: 0x04002FED RID: 12269
		private int actionId_;

		// Token: 0x04002FEE RID: 12270
		public const int SourceIdFieldNumber = 2;

		// Token: 0x04002FEF RID: 12271
		private long sourceId_;

		// Token: 0x04002FF0 RID: 12272
		public const int EffectFieldNumber = 3;

		// Token: 0x04002FF1 RID: 12273
		private FightRemovableEffect effect_;

		// Token: 0x04002FF2 RID: 12274
		internal static FightRemovableEffectExtendedInformation MxFCUwJs40SMCHWJeIEo;
	}
}
