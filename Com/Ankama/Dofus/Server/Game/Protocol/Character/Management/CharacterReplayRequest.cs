using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000913 RID: 2323
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterReplayRequest : IMessage<CharacterReplayRequest>, IMessage, IEquatable<CharacterReplayRequest>, IDeepCloneable<CharacterReplayRequest>, IBufferMessage
	{
		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x0023B970 File Offset: 0x00239B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterReplayRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x0023B980 File Offset: 0x00239B80
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

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x0023B990 File Offset: 0x00239B90
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

		// Token: 0x060070B3 RID: 28851 RVA: 0x0023B9A0 File Offset: 0x00239BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayRequest()
		{
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0023B9B0 File Offset: 0x00239BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayRequest(CharacterReplayRequest other)
		{
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0023B9C0 File Offset: 0x00239BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayRequest Clone()
		{
			return null;
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x0023B9D0 File Offset: 0x00239BD0
		// (set) Token: 0x060070B7 RID: 28855 RVA: 0x0023B9E0 File Offset: 0x00239BE0
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

		// Token: 0x060070B8 RID: 28856 RVA: 0x0023B9F0 File Offset: 0x00239BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x0023BA00 File Offset: 0x00239C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterReplayRequest other)
		{
			return true;
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x0023BA10 File Offset: 0x00239C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x0023BA20 File Offset: 0x00239C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x0023BA30 File Offset: 0x00239C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x0023BA40 File Offset: 0x00239C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x0023BA50 File Offset: 0x00239C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x0023BA60 File Offset: 0x00239C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterReplayRequest other)
		{
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x0023BA70 File Offset: 0x00239C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x0023BA80 File Offset: 0x00239C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x0023BA90 File Offset: 0x00239C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterReplayRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterReplayRequest._parser = new MessageParser<CharacterReplayRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x0023BB74 File Offset: 0x00239D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ARyg91Jegj0w3Y37o8tt()
		{
			return true;
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x0023BB7C File Offset: 0x00239D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterReplayRequest GFe52AJesJNnIaM3kEGQ()
		{
			return null;
		}

		// Token: 0x04002780 RID: 10112
		private static readonly MessageParser<CharacterReplayRequest> _parser;

		// Token: 0x04002781 RID: 10113
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002782 RID: 10114
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002783 RID: 10115
		private long characterId_;

		// Token: 0x04002784 RID: 10116
		internal static CharacterReplayRequest QH2Yf6JeGgGqQeJU5vu4;
	}
}
