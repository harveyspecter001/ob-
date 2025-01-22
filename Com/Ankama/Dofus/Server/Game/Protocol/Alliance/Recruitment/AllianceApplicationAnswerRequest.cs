using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D0E RID: 3342
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationAnswerRequest : IMessage<AllianceApplicationAnswerRequest>, IMessage, IEquatable<AllianceApplicationAnswerRequest>, IDeepCloneable<AllianceApplicationAnswerRequest>, IBufferMessage
	{
		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x00288364 File Offset: 0x00286564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x00288374 File Offset: 0x00286574
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

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x00288384 File Offset: 0x00286584
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

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00288394 File Offset: 0x00286594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationAnswerRequest()
		{
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x002883A4 File Offset: 0x002865A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationAnswerRequest(AllianceApplicationAnswerRequest other)
		{
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x002883B4 File Offset: 0x002865B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600A0D5 RID: 41173 RVA: 0x002883C4 File Offset: 0x002865C4
		// (set) Token: 0x0600A0D6 RID: 41174 RVA: 0x002883D4 File Offset: 0x002865D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600A0D7 RID: 41175 RVA: 0x002883E4 File Offset: 0x002865E4
		// (set) Token: 0x0600A0D8 RID: 41176 RVA: 0x002883F4 File Offset: 0x002865F4
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

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x00288404 File Offset: 0x00286604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00288414 File Offset: 0x00286614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00288424 File Offset: 0x00286624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00288434 File Offset: 0x00286634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00288444 File Offset: 0x00286644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00288454 File Offset: 0x00286654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x00288464 File Offset: 0x00286664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00288474 File Offset: 0x00286674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationAnswerRequest other)
		{
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00288484 File Offset: 0x00286684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00288494 File Offset: 0x00286694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x002884A4 File Offset: 0x002866A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationAnswerRequest()
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
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						AllianceApplicationAnswerRequest._parser = new MessageParser<AllianceApplicationAnswerRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_35;
					}
					return;
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x0028858C File Offset: 0x0028678C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EhnuwYJKGMHxq85j72uk()
		{
			return true;
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00288594 File Offset: 0x00286794
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationAnswerRequest AaFaQ4JKgOurGmGpQdGt()
		{
			return null;
		}

		// Token: 0x04003B76 RID: 15222
		private static readonly MessageParser<AllianceApplicationAnswerRequest> _parser;

		// Token: 0x04003B77 RID: 15223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B78 RID: 15224
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04003B79 RID: 15225
		private long playerId_;

		// Token: 0x04003B7A RID: 15226
		public const int AcceptedFieldNumber = 2;

		// Token: 0x04003B7B RID: 15227
		private bool accepted_;

		// Token: 0x04003B7C RID: 15228
		internal static AllianceApplicationAnswerRequest EbbaWQJKJnApkWNh3d8V;
	}
}
