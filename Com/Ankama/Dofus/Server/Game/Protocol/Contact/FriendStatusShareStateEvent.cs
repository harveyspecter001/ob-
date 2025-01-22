using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200085A RID: 2138
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendStatusShareStateEvent : IMessage<FriendStatusShareStateEvent>, IMessage, IEquatable<FriendStatusShareStateEvent>, IDeepCloneable<FriendStatusShareStateEvent>, IBufferMessage
	{
		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x0022DAE0 File Offset: 0x0022BCE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendStatusShareStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060067FB RID: 26619 RVA: 0x0022DAF0 File Offset: 0x0022BCF0
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

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060067FC RID: 26620 RVA: 0x0022DB00 File Offset: 0x0022BD00
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

		// Token: 0x060067FD RID: 26621 RVA: 0x0022DB10 File Offset: 0x0022BD10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendStatusShareStateEvent()
		{
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x0022DB20 File Offset: 0x0022BD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendStatusShareStateEvent(FriendStatusShareStateEvent other)
		{
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x0022DB30 File Offset: 0x0022BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendStatusShareStateEvent Clone()
		{
			return null;
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x0022DB40 File Offset: 0x0022BD40
		// (set) Token: 0x06006801 RID: 26625 RVA: 0x0022DB50 File Offset: 0x0022BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Share
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

		// Token: 0x06006802 RID: 26626 RVA: 0x0022DB60 File Offset: 0x0022BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x0022DB70 File Offset: 0x0022BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendStatusShareStateEvent other)
		{
			return true;
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x0022DB80 File Offset: 0x0022BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x0022DB90 File Offset: 0x0022BD90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x0022DBA0 File Offset: 0x0022BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x0022DBB0 File Offset: 0x0022BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x0022DBC0 File Offset: 0x0022BDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x0022DBD0 File Offset: 0x0022BDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendStatusShareStateEvent other)
		{
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x0022DBE0 File Offset: 0x0022BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x0022DBF0 File Offset: 0x0022BDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x0022DC00 File Offset: 0x0022BE00
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendStatusShareStateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					FriendStatusShareStateEvent._parser = new MessageParser<FriendStatusShareStateEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x0022DCE4 File Offset: 0x0022BEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KMUxckJnvNZ7yhb355Hu()
		{
			return true;
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x0022DCEC File Offset: 0x0022BEEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendStatusShareStateEvent ndlyJJJnoUkeKRHTqD9u()
		{
			return null;
		}

		// Token: 0x04002462 RID: 9314
		private static readonly MessageParser<FriendStatusShareStateEvent> _parser;

		// Token: 0x04002463 RID: 9315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002464 RID: 9316
		public const int ShareFieldNumber = 1;

		// Token: 0x04002465 RID: 9317
		private bool share_;

		// Token: 0x04002466 RID: 9318
		internal static FriendStatusShareStateEvent cB6VHJJnU5kSNuBKku84;
	}
}
