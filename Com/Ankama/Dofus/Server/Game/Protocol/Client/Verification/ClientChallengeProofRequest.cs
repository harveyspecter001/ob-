using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008B4 RID: 2228
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientChallengeProofRequest : IMessage<ClientChallengeProofRequest>, IMessage, IEquatable<ClientChallengeProofRequest>, IDeepCloneable<ClientChallengeProofRequest>, IBufferMessage
	{
		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06006C3A RID: 27706 RVA: 0x002324B4 File Offset: 0x002306B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ClientChallengeProofRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06006C3B RID: 27707 RVA: 0x002324C4 File Offset: 0x002306C4
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

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06006C3C RID: 27708 RVA: 0x002324D4 File Offset: 0x002306D4
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

		// Token: 0x06006C3D RID: 27709 RVA: 0x002324E4 File Offset: 0x002306E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeProofRequest()
		{
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x002324F4 File Offset: 0x002306F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeProofRequest(ClientChallengeProofRequest other)
		{
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00232504 File Offset: 0x00230704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeProofRequest Clone()
		{
			return null;
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06006C40 RID: 27712 RVA: 0x00232514 File Offset: 0x00230714
		// (set) Token: 0x06006C41 RID: 27713 RVA: 0x00232524 File Offset: 0x00230724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Proof
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

		// Token: 0x06006C42 RID: 27714 RVA: 0x00232534 File Offset: 0x00230734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x00232544 File Offset: 0x00230744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ClientChallengeProofRequest other)
		{
			return true;
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x00232554 File Offset: 0x00230754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x00232564 File Offset: 0x00230764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x00232574 File Offset: 0x00230774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x00232584 File Offset: 0x00230784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x00232594 File Offset: 0x00230794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x002325A4 File Offset: 0x002307A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ClientChallengeProofRequest other)
		{
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x002325B4 File Offset: 0x002307B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x002325C4 File Offset: 0x002307C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x002325D4 File Offset: 0x002307D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ClientChallengeProofRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
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
					ClientChallengeProofRequest._parser = new MessageParser<ClientChallengeProofRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x002326A0 File Offset: 0x002308A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h4CHgyJmqMEvrBVdclSE()
		{
			return true;
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x002326A8 File Offset: 0x002308A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClientChallengeProofRequest OmC9GuJmF0ixD6nWZiln()
		{
			return null;
		}

		// Token: 0x040025C2 RID: 9666
		private static readonly MessageParser<ClientChallengeProofRequest> _parser;

		// Token: 0x040025C3 RID: 9667
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C4 RID: 9668
		public const int ProofFieldNumber = 1;

		// Token: 0x040025C5 RID: 9669
		private string proof_;

		// Token: 0x040025C6 RID: 9670
		internal static ClientChallengeProofRequest B0DCpJJmZDtsQnntjGHK;
	}
}
