using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D44 RID: 3396
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMemberLeavingEvent : IMessage<AllianceMemberLeavingEvent>, IMessage, IEquatable<AllianceMemberLeavingEvent>, IDeepCloneable<AllianceMemberLeavingEvent>, IBufferMessage
	{
		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x0028CB18 File Offset: 0x0028AD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceMemberLeavingEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600A396 RID: 41878 RVA: 0x0028CB28 File Offset: 0x0028AD28
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

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600A397 RID: 41879 RVA: 0x0028CB38 File Offset: 0x0028AD38
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

		// Token: 0x0600A398 RID: 41880 RVA: 0x0028CB48 File Offset: 0x0028AD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberLeavingEvent()
		{
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x0028CB58 File Offset: 0x0028AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberLeavingEvent(AllianceMemberLeavingEvent other)
		{
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x0028CB68 File Offset: 0x0028AD68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberLeavingEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600A39B RID: 41883 RVA: 0x0028CB78 File Offset: 0x0028AD78
		// (set) Token: 0x0600A39C RID: 41884 RVA: 0x0028CB88 File Offset: 0x0028AD88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Kicked
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

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600A39D RID: 41885 RVA: 0x0028CB98 File Offset: 0x0028AD98
		// (set) Token: 0x0600A39E RID: 41886 RVA: 0x0028CBA8 File Offset: 0x0028ADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MemberId
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

		// Token: 0x0600A39F RID: 41887 RVA: 0x0028CBB8 File Offset: 0x0028ADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x0028CBC8 File Offset: 0x0028ADC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMemberLeavingEvent other)
		{
			return true;
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x0028CBD8 File Offset: 0x0028ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x0028CBE8 File Offset: 0x0028ADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x0028CBF8 File Offset: 0x0028ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x0028CC08 File Offset: 0x0028AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x0028CC18 File Offset: 0x0028AE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x0028CC28 File Offset: 0x0028AE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMemberLeavingEvent other)
		{
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x0028CC38 File Offset: 0x0028AE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x0028CC48 File Offset: 0x0028AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x0028CC58 File Offset: 0x0028AE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMemberLeavingEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 2:
						AllianceMemberLeavingEvent._parser = new MessageParser<AllianceMemberLeavingEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_49;
					}
					return;
				}
				IL_49:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x0028CD28 File Offset: 0x0028AF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cn6uLCJI5K3UilQmDlrB()
		{
			return true;
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x0028CD30 File Offset: 0x0028AF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMemberLeavingEvent Auu9b7JIy8YwRI4TZUL4()
		{
			return null;
		}

		// Token: 0x04003C52 RID: 15442
		private static readonly MessageParser<AllianceMemberLeavingEvent> _parser;

		// Token: 0x04003C53 RID: 15443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C54 RID: 15444
		public const int KickedFieldNumber = 1;

		// Token: 0x04003C55 RID: 15445
		private bool kicked_;

		// Token: 0x04003C56 RID: 15446
		public const int MemberIdFieldNumber = 2;

		// Token: 0x04003C57 RID: 15447
		private long memberId_;

		// Token: 0x04003C58 RID: 15448
		internal static AllianceMemberLeavingEvent e0WNWTJIangkYxtdh5qx;
	}
}
