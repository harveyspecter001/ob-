using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008B0 RID: 2224
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientChallengeInitRequest : IMessage<ClientChallengeInitRequest>, IMessage, IEquatable<ClientChallengeInitRequest>, IDeepCloneable<ClientChallengeInitRequest>, IBufferMessage
	{
		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06006C04 RID: 27652 RVA: 0x00232040 File Offset: 0x00230240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientChallengeInitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06006C05 RID: 27653 RVA: 0x00232050 File Offset: 0x00230250
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

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06006C06 RID: 27654 RVA: 0x00232060 File Offset: 0x00230260
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

		// Token: 0x06006C07 RID: 27655 RVA: 0x00232070 File Offset: 0x00230270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeInitRequest()
		{
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x00232080 File Offset: 0x00230280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeInitRequest(ClientChallengeInitRequest other)
		{
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00232090 File Offset: 0x00230290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientChallengeInitRequest Clone()
		{
			return null;
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06006C0A RID: 27658 RVA: 0x002320A0 File Offset: 0x002302A0
		// (set) Token: 0x06006C0B RID: 27659 RVA: 0x002320B0 File Offset: 0x002302B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ChallengeKey
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

		// Token: 0x06006C0C RID: 27660 RVA: 0x002320C0 File Offset: 0x002302C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x002320D0 File Offset: 0x002302D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ClientChallengeInitRequest other)
		{
			return true;
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x002320E0 File Offset: 0x002302E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x002320F0 File Offset: 0x002302F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00232100 File Offset: 0x00230300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x00232110 File Offset: 0x00230310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x00232120 File Offset: 0x00230320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00232130 File Offset: 0x00230330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ClientChallengeInitRequest other)
		{
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00232140 File Offset: 0x00230340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00232150 File Offset: 0x00230350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00232160 File Offset: 0x00230360
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ClientChallengeInitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ClientChallengeInitRequest._parser = new MessageParser<ClientChallengeInitRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00232244 File Offset: 0x00230444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kmgDEeJmPJXadLggidtr()
		{
			return true;
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x0023224C File Offset: 0x0023044C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClientChallengeInitRequest bJmVoSJmSEWPoOfV8Adu()
		{
			return null;
		}

		// Token: 0x040025B3 RID: 9651
		private static readonly MessageParser<ClientChallengeInitRequest> _parser;

		// Token: 0x040025B4 RID: 9652
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025B5 RID: 9653
		public const int ChallengeKeyFieldNumber = 1;

		// Token: 0x040025B6 RID: 9654
		private string challengeKey_;

		// Token: 0x040025B7 RID: 9655
		internal static ClientChallengeInitRequest v5RHB0Jmi9piSCv3Gk3G;
	}
}
