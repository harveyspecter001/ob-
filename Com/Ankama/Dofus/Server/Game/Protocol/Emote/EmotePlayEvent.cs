using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007C1 RID: 1985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmotePlayEvent : IMessage<EmotePlayEvent>, IMessage, IEquatable<EmotePlayEvent>, IDeepCloneable<EmotePlayEvent>, IBufferMessage
	{
		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06006144 RID: 24900 RVA: 0x00220C1C File Offset: 0x0021EE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EmotePlayEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06006145 RID: 24901 RVA: 0x00220C2C File Offset: 0x0021EE2C
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06006146 RID: 24902 RVA: 0x00220C3C File Offset: 0x0021EE3C
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

		// Token: 0x06006147 RID: 24903 RVA: 0x00220C4C File Offset: 0x0021EE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayEvent()
		{
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x00220C5C File Offset: 0x0021EE5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayEvent(EmotePlayEvent other)
		{
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00220C6C File Offset: 0x0021EE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayEvent Clone()
		{
			return null;
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x00220C7C File Offset: 0x0021EE7C
		// (set) Token: 0x0600614B RID: 24907 RVA: 0x00220C8C File Offset: 0x0021EE8C
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x00220C9C File Offset: 0x0021EE9C
		// (set) Token: 0x0600614D RID: 24909 RVA: 0x00220CAC File Offset: 0x0021EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EmoteStartTime
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

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x00220CBC File Offset: 0x0021EEBC
		// (set) Token: 0x0600614F RID: 24911 RVA: 0x00220CCC File Offset: 0x0021EECC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ActorId
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06006150 RID: 24912 RVA: 0x00220CDC File Offset: 0x0021EEDC
		// (set) Token: 0x06006151 RID: 24913 RVA: 0x00220CEC File Offset: 0x0021EEEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AccountId
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

		// Token: 0x06006152 RID: 24914 RVA: 0x00220CFC File Offset: 0x0021EEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00220D0C File Offset: 0x0021EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmotePlayEvent other)
		{
			return true;
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x00220D1C File Offset: 0x0021EF1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00220D2C File Offset: 0x0021EF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x00220D3C File Offset: 0x0021EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x00220D4C File Offset: 0x0021EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x00220D5C File Offset: 0x0021EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x00220D6C File Offset: 0x0021EF6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmotePlayEvent other)
		{
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x00220D7C File Offset: 0x0021EF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00220D8C File Offset: 0x0021EF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x00220D9C File Offset: 0x0021EF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmotePlayEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						break;
					case 3:
						goto IL_73;
					case 4:
						return;
					}
				}
				IL_73:
				EmotePlayEvent._parser = new MessageParser<EmotePlayEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00220E6C File Offset: 0x0021F06C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hjJh9nOFBPvFVcJOUEtv()
		{
			return true;
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x00220E74 File Offset: 0x0021F074
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmotePlayEvent YiqcbOOFeW7mv9lhbA56()
		{
			return null;
		}

		// Token: 0x0400222D RID: 8749
		private static readonly MessageParser<EmotePlayEvent> _parser;

		// Token: 0x0400222E RID: 8750
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400222F RID: 8751
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04002230 RID: 8752
		private int emoteId_;

		// Token: 0x04002231 RID: 8753
		public const int EmoteStartTimeFieldNumber = 2;

		// Token: 0x04002232 RID: 8754
		private long emoteStartTime_;

		// Token: 0x04002233 RID: 8755
		public const int ActorIdFieldNumber = 3;

		// Token: 0x04002234 RID: 8756
		private long actorId_;

		// Token: 0x04002235 RID: 8757
		public const int AccountIdFieldNumber = 4;

		// Token: 0x04002236 RID: 8758
		private int accountId_;

		// Token: 0x04002237 RID: 8759
		internal static EmotePlayEvent vsTZHJOFAk8ZqjJWrvkh;
	}
}
