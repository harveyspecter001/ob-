using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200090B RID: 2315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrepareCharacterDeletionRequest : IMessage<PrepareCharacterDeletionRequest>, IMessage, IEquatable<PrepareCharacterDeletionRequest>, IDeepCloneable<PrepareCharacterDeletionRequest>, IBufferMessage
	{
		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x0023B150 File Offset: 0x00239350
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrepareCharacterDeletionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x0023B160 File Offset: 0x00239360
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

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x0023B170 File Offset: 0x00239370
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

		// Token: 0x0600704B RID: 28747 RVA: 0x0023B180 File Offset: 0x00239380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrepareCharacterDeletionRequest()
		{
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x0023B190 File Offset: 0x00239390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrepareCharacterDeletionRequest(PrepareCharacterDeletionRequest other)
		{
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x0023B1A0 File Offset: 0x002393A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrepareCharacterDeletionRequest Clone()
		{
			return null;
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x0023B1B0 File Offset: 0x002393B0
		// (set) Token: 0x0600704F RID: 28751 RVA: 0x0023B1C0 File Offset: 0x002393C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharacterId
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

		// Token: 0x06007050 RID: 28752 RVA: 0x0023B1D0 File Offset: 0x002393D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x0023B1E0 File Offset: 0x002393E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrepareCharacterDeletionRequest other)
		{
			return true;
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x0023B1F0 File Offset: 0x002393F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x0023B200 File Offset: 0x00239400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x0023B210 File Offset: 0x00239410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x0023B220 File Offset: 0x00239420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x0023B230 File Offset: 0x00239430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x0023B240 File Offset: 0x00239440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrepareCharacterDeletionRequest other)
		{
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x0023B250 File Offset: 0x00239450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x0023B260 File Offset: 0x00239460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x0023B270 File Offset: 0x00239470
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrepareCharacterDeletionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					PrepareCharacterDeletionRequest._parser = new MessageParser<PrepareCharacterDeletionRequest>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x0023B33C File Offset: 0x0023953C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ExI0gXJBzHAn8AIZhN1x()
		{
			return true;
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x0023B344 File Offset: 0x00239544
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrepareCharacterDeletionRequest K8ApQcJefM3J2Jrcdgdy()
		{
			return null;
		}

		// Token: 0x04002764 RID: 10084
		private static readonly MessageParser<PrepareCharacterDeletionRequest> _parser;

		// Token: 0x04002765 RID: 10085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002766 RID: 10086
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002767 RID: 10087
		private long characterId_;

		// Token: 0x04002768 RID: 10088
		internal static PrepareCharacterDeletionRequest sIUlbBJBFrDyX7qmPbMA;
	}
}
