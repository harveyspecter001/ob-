using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008B2 RID: 2226
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerChallengeEvent : IMessage<ServerChallengeEvent>, IMessage, IEquatable<ServerChallengeEvent>, IDeepCloneable<ServerChallengeEvent>, IBufferMessage
	{
		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x00232254 File Offset: 0x00230454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ServerChallengeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x00232264 File Offset: 0x00230464
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

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06006C20 RID: 27680 RVA: 0x00232274 File Offset: 0x00230474
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

		// Token: 0x06006C21 RID: 27681 RVA: 0x00232284 File Offset: 0x00230484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerChallengeEvent()
		{
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x00232294 File Offset: 0x00230494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerChallengeEvent(ServerChallengeEvent other)
		{
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x002322A4 File Offset: 0x002304A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerChallengeEvent Clone()
		{
			return null;
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x002322B4 File Offset: 0x002304B4
		// (set) Token: 0x06006C25 RID: 27685 RVA: 0x002322C4 File Offset: 0x002304C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Value
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

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06006C26 RID: 27686 RVA: 0x002322D4 File Offset: 0x002304D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x002322E4 File Offset: 0x002304E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearValue()
		{
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x002322F4 File Offset: 0x002304F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x00232304 File Offset: 0x00230504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerChallengeEvent other)
		{
			return true;
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00232314 File Offset: 0x00230514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x00232324 File Offset: 0x00230524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x00232334 File Offset: 0x00230534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x00232344 File Offset: 0x00230544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x00232354 File Offset: 0x00230554
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x00232364 File Offset: 0x00230564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerChallengeEvent other)
		{
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x00232374 File Offset: 0x00230574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x00232384 File Offset: 0x00230584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x00232394 File Offset: 0x00230594
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerChallengeEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ServerChallengeEvent.ValueDefaultValue = "";
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					ServerChallengeEvent._parser = new MessageParser<ServerChallengeEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x002324A4 File Offset: 0x002306A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qsLtNAJmue6aVKYTd5g5()
		{
			return true;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x002324AC File Offset: 0x002306AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerChallengeEvent yKhSY0Jm8WrB0fJqNYre()
		{
			return null;
		}

		// Token: 0x040025BA RID: 9658
		private static readonly MessageParser<ServerChallengeEvent> _parser;

		// Token: 0x040025BB RID: 9659
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025BC RID: 9660
		public const int ValueFieldNumber = 1;

		// Token: 0x040025BD RID: 9661
		private static readonly string ValueDefaultValue;

		// Token: 0x040025BE RID: 9662
		private string value_;

		// Token: 0x040025BF RID: 9663
		internal static ServerChallengeEvent zt42vWJmMyVoKa4K2scE;
	}
}
