using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x020008A7 RID: 2215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AuthenticationTicketRefusedEvent : IMessage<AuthenticationTicketRefusedEvent>, IMessage, IEquatable<AuthenticationTicketRefusedEvent>, IDeepCloneable<AuthenticationTicketRefusedEvent>, IBufferMessage
	{
		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x00231448 File Offset: 0x0022F648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthenticationTicketRefusedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x00231458 File Offset: 0x0022F658
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

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x00231468 File Offset: 0x0022F668
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

		// Token: 0x06006BA1 RID: 27553 RVA: 0x00231478 File Offset: 0x0022F678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketRefusedEvent()
		{
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x00231488 File Offset: 0x0022F688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketRefusedEvent(AuthenticationTicketRefusedEvent other)
		{
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x00231498 File Offset: 0x0022F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketRefusedEvent Clone()
		{
			return null;
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x002314A8 File Offset: 0x0022F6A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x002314B8 File Offset: 0x0022F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AuthenticationTicketRefusedEvent other)
		{
			return true;
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x002314C8 File Offset: 0x0022F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x002314D8 File Offset: 0x0022F6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x002314E8 File Offset: 0x0022F6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x002314F8 File Offset: 0x0022F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00231508 File Offset: 0x0022F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00231518 File Offset: 0x0022F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AuthenticationTicketRefusedEvent other)
		{
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00231528 File Offset: 0x0022F728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00231538 File Offset: 0x0022F738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00231548 File Offset: 0x0022F748
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AuthenticationTicketRefusedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				AuthenticationTicketRefusedEvent._parser = new MessageParser<AuthenticationTicketRefusedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00231614 File Offset: 0x0022F814
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FPyGKUJmrkhhLDLX4DUM()
		{
			return true;
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x0023161C File Offset: 0x0022F81C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationTicketRefusedEvent DmCCCcJmVj1RlwyLI78O()
		{
			return null;
		}

		// Token: 0x0400259B RID: 9627
		private static readonly MessageParser<AuthenticationTicketRefusedEvent> _parser;

		// Token: 0x0400259C RID: 9628
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400259D RID: 9629
		private static AuthenticationTicketRefusedEvent IcxDOEJmhH3fXdFIokj8;
	}
}
