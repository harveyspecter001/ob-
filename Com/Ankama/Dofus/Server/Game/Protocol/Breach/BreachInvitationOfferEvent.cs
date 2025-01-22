using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000993 RID: 2451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachInvitationOfferEvent : IMessage<BreachInvitationOfferEvent>, IMessage, IEquatable<BreachInvitationOfferEvent>, IDeepCloneable<BreachInvitationOfferEvent>, IBufferMessage
	{
		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060076A7 RID: 30375 RVA: 0x00244788 File Offset: 0x00242988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachInvitationOfferEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x00244798 File Offset: 0x00242998
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

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060076A9 RID: 30377 RVA: 0x002447A8 File Offset: 0x002429A8
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

		// Token: 0x060076AA RID: 30378 RVA: 0x002447B8 File Offset: 0x002429B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationOfferEvent()
		{
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x002447C8 File Offset: 0x002429C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationOfferEvent(BreachInvitationOfferEvent other)
		{
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x002447D8 File Offset: 0x002429D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationOfferEvent Clone()
		{
			return null;
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060076AD RID: 30381 RVA: 0x002447E8 File Offset: 0x002429E8
		// (set) Token: 0x060076AE RID: 30382 RVA: 0x002447F8 File Offset: 0x002429F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character Host
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

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060076AF RID: 30383 RVA: 0x00244808 File Offset: 0x00242A08
		// (set) Token: 0x060076B0 RID: 30384 RVA: 0x00244818 File Offset: 0x00242A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TimeLeftBeforeCancel
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

		// Token: 0x060076B1 RID: 30385 RVA: 0x00244828 File Offset: 0x00242A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00244838 File Offset: 0x00242A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachInvitationOfferEvent other)
		{
			return true;
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00244848 File Offset: 0x00242A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00244858 File Offset: 0x00242A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00244868 File Offset: 0x00242A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00244878 File Offset: 0x00242A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00244888 File Offset: 0x00242A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00244898 File Offset: 0x00242A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachInvitationOfferEvent other)
		{
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x002448A8 File Offset: 0x00242AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x002448B8 File Offset: 0x00242AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x002448C8 File Offset: 0x00242AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachInvitationOfferEvent()
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
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5F;
					case 3:
						return;
					case 4:
						BreachInvitationOfferEvent._parser = new MessageParser<BreachInvitationOfferEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 2;
					}
				}
				IL_5F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x002449B0 File Offset: 0x00242BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oQEfQbJRzbtUydhMi0Jn()
		{
			return true;
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x002449B8 File Offset: 0x00242BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachInvitationOfferEvent fO8xj9JOfqney55aEyy7()
		{
			return null;
		}

		// Token: 0x04002947 RID: 10567
		private static readonly MessageParser<BreachInvitationOfferEvent> _parser;

		// Token: 0x04002948 RID: 10568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002949 RID: 10569
		public const int HostFieldNumber = 1;

		// Token: 0x0400294A RID: 10570
		private Character host_;

		// Token: 0x0400294B RID: 10571
		public const int TimeLeftBeforeCancelFieldNumber = 2;

		// Token: 0x0400294C RID: 10572
		private int timeLeftBeforeCancel_;

		// Token: 0x0400294D RID: 10573
		internal static BreachInvitationOfferEvent y1tYXoJRFwbQfDAPfYU7;
	}
}
