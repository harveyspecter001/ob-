using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000919 RID: 2329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterSelectionWithRemodelRequest : IMessage<CharacterSelectionWithRemodelRequest>, IMessage, IEquatable<CharacterSelectionWithRemodelRequest>, IDeepCloneable<CharacterSelectionWithRemodelRequest>, IBufferMessage
	{
		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x0023BFA0 File Offset: 0x0023A1A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterSelectionWithRemodelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06007101 RID: 28929 RVA: 0x0023BFB0 File Offset: 0x0023A1B0
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

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06007102 RID: 28930 RVA: 0x0023BFC0 File Offset: 0x0023A1C0
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

		// Token: 0x06007103 RID: 28931 RVA: 0x0023BFD0 File Offset: 0x0023A1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionWithRemodelRequest()
		{
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x0023BFE0 File Offset: 0x0023A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionWithRemodelRequest(CharacterSelectionWithRemodelRequest other)
		{
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x0023BFF0 File Offset: 0x0023A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionWithRemodelRequest Clone()
		{
			return null;
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x0023C000 File Offset: 0x0023A200
		// (set) Token: 0x06007107 RID: 28935 RVA: 0x0023C010 File Offset: 0x0023A210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x0023C020 File Offset: 0x0023A220
		// (set) Token: 0x06007109 RID: 28937 RVA: 0x0023C030 File Offset: 0x0023A230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character RemodelingInformation
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

		// Token: 0x0600710A RID: 28938 RVA: 0x0023C040 File Offset: 0x0023A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0023C050 File Offset: 0x0023A250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterSelectionWithRemodelRequest other)
		{
			return true;
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x0023C060 File Offset: 0x0023A260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x0023C070 File Offset: 0x0023A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x0023C080 File Offset: 0x0023A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x0023C090 File Offset: 0x0023A290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x0023C0A0 File Offset: 0x0023A2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x0023C0B0 File Offset: 0x0023A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterSelectionWithRemodelRequest other)
		{
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x0023C0C0 File Offset: 0x0023A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x0023C0D0 File Offset: 0x0023A2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x0023C0E0 File Offset: 0x0023A2E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterSelectionWithRemodelRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					CharacterSelectionWithRemodelRequest._parser = new MessageParser<CharacterSelectionWithRemodelRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x0023C1C4 File Offset: 0x0023A3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lPM3AbJe4qixAgJgmcQd()
		{
			return true;
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x0023C1CC File Offset: 0x0023A3CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterSelectionWithRemodelRequest JtMNMYJejdyerJPIWXbM()
		{
			return null;
		}

		// Token: 0x04002797 RID: 10135
		private static readonly MessageParser<CharacterSelectionWithRemodelRequest> _parser;

		// Token: 0x04002798 RID: 10136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002799 RID: 10137
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400279A RID: 10138
		private long characterId_;

		// Token: 0x0400279B RID: 10139
		public const int RemodelingInformationFieldNumber = 2;

		// Token: 0x0400279C RID: 10140
		private Character remodelingInformation_;

		// Token: 0x0400279D RID: 10141
		internal static CharacterSelectionWithRemodelRequest BWdUSTJexGTbEne7VGMj;
	}
}
