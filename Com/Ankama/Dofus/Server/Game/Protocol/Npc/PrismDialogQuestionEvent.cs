using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000345 RID: 837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismDialogQuestionEvent : IMessage<PrismDialogQuestionEvent>, IMessage, IEquatable<PrismDialogQuestionEvent>, IDeepCloneable<PrismDialogQuestionEvent>, IBufferMessage
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x001C39F4 File Offset: 0x001C1BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismDialogQuestionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x001C3A04 File Offset: 0x001C1C04
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x001C3A14 File Offset: 0x001C1C14
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

		// Token: 0x06002741 RID: 10049 RVA: 0x001C3A24 File Offset: 0x001C1C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismDialogQuestionEvent()
		{
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x001C3A34 File Offset: 0x001C1C34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismDialogQuestionEvent(PrismDialogQuestionEvent other)
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x001C3A44 File Offset: 0x001C1C44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismDialogQuestionEvent Clone()
		{
			return null;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x001C3A54 File Offset: 0x001C1C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x001C3A64 File Offset: 0x001C1C64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismDialogQuestionEvent other)
		{
			return true;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x001C3A74 File Offset: 0x001C1C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x001C3A84 File Offset: 0x001C1C84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x001C3A94 File Offset: 0x001C1C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x001C3AA4 File Offset: 0x001C1CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x001C3AB4 File Offset: 0x001C1CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x001C3AC4 File Offset: 0x001C1CC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismDialogQuestionEvent other)
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x001C3AD4 File Offset: 0x001C1CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x001C3AE4 File Offset: 0x001C1CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x001C3AF4 File Offset: 0x001C1CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismDialogQuestionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_35;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					PrismDialogQuestionEvent._parser = new MessageParser<PrismDialogQuestionEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x001C3BDC File Offset: 0x001C1DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MVTJZDOhmdEiWNxv0tf0()
		{
			return true;
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x001C3BE4 File Offset: 0x001C1DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismDialogQuestionEvent vLibL4OhAwvGgnXh1A8v()
		{
			return null;
		}

		// Token: 0x04000E00 RID: 3584
		private static readonly MessageParser<PrismDialogQuestionEvent> _parser;

		// Token: 0x04000E01 RID: 3585
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E02 RID: 3586
		internal static PrismDialogQuestionEvent ExfnPkOhnhI4HMFUkrVY;
	}
}
