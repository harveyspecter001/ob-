using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004F6 RID: 1270
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInvitationAnswerRequest : IMessage<GuildInvitationAnswerRequest>, IMessage, IEquatable<GuildInvitationAnswerRequest>, IDeepCloneable<GuildInvitationAnswerRequest>, IBufferMessage
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x001E906C File Offset: 0x001E726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInvitationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x001E907C File Offset: 0x001E727C
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

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x001E908C File Offset: 0x001E728C
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

		// Token: 0x06003CB9 RID: 15545 RVA: 0x001E909C File Offset: 0x001E729C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationAnswerRequest()
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x001E90AC File Offset: 0x001E72AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationAnswerRequest(GuildInvitationAnswerRequest other)
		{
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x001E90BC File Offset: 0x001E72BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x001E90CC File Offset: 0x001E72CC
		// (set) Token: 0x06003CBD RID: 15549 RVA: 0x001E90DC File Offset: 0x001E72DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accepted
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

		// Token: 0x06003CBE RID: 15550 RVA: 0x001E90EC File Offset: 0x001E72EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x001E90FC File Offset: 0x001E72FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInvitationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001E910C File Offset: 0x001E730C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x001E911C File Offset: 0x001E731C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x001E912C File Offset: 0x001E732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x001E913C File Offset: 0x001E733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x001E914C File Offset: 0x001E734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x001E915C File Offset: 0x001E735C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInvitationAnswerRequest other)
		{
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x001E916C File Offset: 0x001E736C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x001E917C File Offset: 0x001E737C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x001E918C File Offset: 0x001E738C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInvitationAnswerRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildInvitationAnswerRequest._parser = new MessageParser<GuildInvitationAnswerRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x001E9270 File Offset: 0x001E7470
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QSYjCQO7YmJu9wEe60Iu()
		{
			return true;
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x001E9278 File Offset: 0x001E7478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInvitationAnswerRequest b2N6yFO7bYn3SHEyKTVr()
		{
			return null;
		}

		// Token: 0x0400151B RID: 5403
		private static readonly MessageParser<GuildInvitationAnswerRequest> _parser;

		// Token: 0x0400151C RID: 5404
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400151D RID: 5405
		public const int AcceptedFieldNumber = 1;

		// Token: 0x0400151E RID: 5406
		private bool accepted_;

		// Token: 0x0400151F RID: 5407
		private static GuildInvitationAnswerRequest UlmTh2O7HKE7HeDUpTZP;
	}
}
