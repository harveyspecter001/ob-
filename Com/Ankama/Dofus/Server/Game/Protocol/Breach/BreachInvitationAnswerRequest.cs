using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000973 RID: 2419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachInvitationAnswerRequest : IMessage<BreachInvitationAnswerRequest>, IMessage, IEquatable<BreachInvitationAnswerRequest>, IDeepCloneable<BreachInvitationAnswerRequest>, IBufferMessage
	{
		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x002427F0 File Offset: 0x002409F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachInvitationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x00242800 File Offset: 0x00240A00
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x00242810 File Offset: 0x00240A10
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

		// Token: 0x0600751F RID: 29983 RVA: 0x00242820 File Offset: 0x00240A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationAnswerRequest()
		{
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x00242830 File Offset: 0x00240A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationAnswerRequest(BreachInvitationAnswerRequest other)
		{
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x00242840 File Offset: 0x00240A40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06007522 RID: 29986 RVA: 0x00242850 File Offset: 0x00240A50
		// (set) Token: 0x06007523 RID: 29987 RVA: 0x00242860 File Offset: 0x00240A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06007524 RID: 29988 RVA: 0x00242870 File Offset: 0x00240A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x00242880 File Offset: 0x00240A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachInvitationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00242890 File Offset: 0x00240A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x002428A0 File Offset: 0x00240AA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x002428B0 File Offset: 0x00240AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x002428C0 File Offset: 0x00240AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x002428D0 File Offset: 0x00240AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x002428E0 File Offset: 0x00240AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachInvitationAnswerRequest other)
		{
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x002428F0 File Offset: 0x00240AF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x00242900 File Offset: 0x00240B00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x00242910 File Offset: 0x00240B10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachInvitationAnswerRequest()
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
					case 1:
						goto IL_77;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						BreachInvitationAnswerRequest._parser = new MessageParser<BreachInvitationAnswerRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_5F;
					}
					return;
				}
				IL_5F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				IL_77:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x002429E4 File Offset: 0x00240BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RRs8piJRE9F5BXLaMq5i()
		{
			return true;
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x002429EC File Offset: 0x00240BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachInvitationAnswerRequest jCtxWxJRXtCYQJq8jpVj()
		{
			return null;
		}

		// Token: 0x040028CF RID: 10447
		private static readonly MessageParser<BreachInvitationAnswerRequest> _parser;

		// Token: 0x040028D0 RID: 10448
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D1 RID: 10449
		public const int AcceptedFieldNumber = 1;

		// Token: 0x040028D2 RID: 10450
		private bool accepted_;

		// Token: 0x040028D3 RID: 10451
		private static BreachInvitationAnswerRequest LdbjI8JR2VIwWErpUu3c;
	}
}
