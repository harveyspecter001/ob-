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
	// Token: 0x02000995 RID: 2453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachInvitationCloseEvent : IMessage<BreachInvitationCloseEvent>, IMessage, IEquatable<BreachInvitationCloseEvent>, IDeepCloneable<BreachInvitationCloseEvent>, IBufferMessage
	{
		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060076C3 RID: 30403 RVA: 0x002449C0 File Offset: 0x00242BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachInvitationCloseEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x002449D0 File Offset: 0x00242BD0
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

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060076C5 RID: 30405 RVA: 0x002449E0 File Offset: 0x00242BE0
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

		// Token: 0x060076C6 RID: 30406 RVA: 0x002449F0 File Offset: 0x00242BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationCloseEvent()
		{
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00244A00 File Offset: 0x00242C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationCloseEvent(BreachInvitationCloseEvent other)
		{
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00244A10 File Offset: 0x00242C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachInvitationCloseEvent Clone()
		{
			return null;
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x00244A20 File Offset: 0x00242C20
		// (set) Token: 0x060076CA RID: 30410 RVA: 0x00244A30 File Offset: 0x00242C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060076CB RID: 30411 RVA: 0x00244A40 File Offset: 0x00242C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00244A50 File Offset: 0x00242C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachInvitationCloseEvent other)
		{
			return true;
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00244A60 File Offset: 0x00242C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00244A70 File Offset: 0x00242C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00244A80 File Offset: 0x00242C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00244A90 File Offset: 0x00242C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x00244AA0 File Offset: 0x00242CA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00244AB0 File Offset: 0x00242CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachInvitationCloseEvent other)
		{
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00244AC0 File Offset: 0x00242CC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00244AD0 File Offset: 0x00242CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00244AE0 File Offset: 0x00242CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachInvitationCloseEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BreachInvitationCloseEvent._parser = new MessageParser<BreachInvitationCloseEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00244BAC File Offset: 0x00242DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f9BwsdJOmDssclHvxh5i()
		{
			return true;
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00244BB4 File Offset: 0x00242DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachInvitationCloseEvent qqY8C0JOAKxSVPpLLkoh()
		{
			return null;
		}

		// Token: 0x04002950 RID: 10576
		private static readonly MessageParser<BreachInvitationCloseEvent> _parser;

		// Token: 0x04002951 RID: 10577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002952 RID: 10578
		public const int HostFieldNumber = 1;

		// Token: 0x04002953 RID: 10579
		private Character host_;

		// Token: 0x04002954 RID: 10580
		private static BreachInvitationCloseEvent PsN83fJOnRRfvnlQRtMe;
	}
}
