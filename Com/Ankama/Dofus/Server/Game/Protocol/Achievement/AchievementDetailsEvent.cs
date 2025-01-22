using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DC5 RID: 3525
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementDetailsEvent : IMessage<AchievementDetailsEvent>, IMessage, IEquatable<AchievementDetailsEvent>, IDeepCloneable<AchievementDetailsEvent>, IBufferMessage
	{
		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x002981E4 File Offset: 0x002963E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementDetailsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x002981F4 File Offset: 0x002963F4
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

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x00298204 File Offset: 0x00296404
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

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x00298214 File Offset: 0x00296414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsEvent()
		{
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x00298224 File Offset: 0x00296424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsEvent(AchievementDetailsEvent other)
		{
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x00298234 File Offset: 0x00296434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x00298244 File Offset: 0x00296444
		// (set) Token: 0x0600A9D7 RID: 43479 RVA: 0x00298254 File Offset: 0x00296454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Achievement Achievement
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

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x00298264 File Offset: 0x00296464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x00298274 File Offset: 0x00296474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementDetailsEvent other)
		{
			return true;
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x00298284 File Offset: 0x00296484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x00298294 File Offset: 0x00296494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x002982A4 File Offset: 0x002964A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x002982B4 File Offset: 0x002964B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x002982C4 File Offset: 0x002964C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002982D4 File Offset: 0x002964D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementDetailsEvent other)
		{
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002982E4 File Offset: 0x002964E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002982F4 File Offset: 0x002964F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x00298304 File Offset: 0x00296504
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementDetailsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						goto IL_88;
					case 4:
						return;
					}
				}
				IL_88:
				AchievementDetailsEvent._parser = new MessageParser<AchievementDetailsEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x002983EC File Offset: 0x002965EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UJ3ZYsJcIqEynrOnypa6()
		{
			return true;
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x002983F4 File Offset: 0x002965F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementDetailsEvent PoDrNGJckXjNA3v5f1Sf()
		{
			return null;
		}

		// Token: 0x04003E61 RID: 15969
		private static readonly MessageParser<AchievementDetailsEvent> _parser;

		// Token: 0x04003E62 RID: 15970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E63 RID: 15971
		public const int AchievementFieldNumber = 1;

		// Token: 0x04003E64 RID: 15972
		private Achievement achievement_;

		// Token: 0x04003E65 RID: 15973
		internal static AchievementDetailsEvent SCU7MyJcKLpfFfJCOyiN;
	}
}
