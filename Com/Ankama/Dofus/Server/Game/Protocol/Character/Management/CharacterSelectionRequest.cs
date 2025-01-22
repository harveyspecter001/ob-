using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000917 RID: 2327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterSelectionRequest : IMessage<CharacterSelectionRequest>, IMessage, IEquatable<CharacterSelectionRequest>, IDeepCloneable<CharacterSelectionRequest>, IBufferMessage
	{
		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x0023BDA4 File Offset: 0x00239FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterSelectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060070E7 RID: 28903 RVA: 0x0023BDB4 File Offset: 0x00239FB4
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x0023BDC4 File Offset: 0x00239FC4
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

		// Token: 0x060070E9 RID: 28905 RVA: 0x0023BDD4 File Offset: 0x00239FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionRequest()
		{
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x0023BDE4 File Offset: 0x00239FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionRequest(CharacterSelectionRequest other)
		{
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x0023BDF4 File Offset: 0x00239FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x0023BE04 File Offset: 0x0023A004
		// (set) Token: 0x060070ED RID: 28909 RVA: 0x0023BE14 File Offset: 0x0023A014
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

		// Token: 0x060070EE RID: 28910 RVA: 0x0023BE24 File Offset: 0x0023A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x0023BE34 File Offset: 0x0023A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterSelectionRequest other)
		{
			return true;
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0023BE44 File Offset: 0x0023A044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x0023BE54 File Offset: 0x0023A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x0023BE64 File Offset: 0x0023A064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0023BE74 File Offset: 0x0023A074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0023BE84 File Offset: 0x0023A084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x0023BE94 File Offset: 0x0023A094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterSelectionRequest other)
		{
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x0023BEA4 File Offset: 0x0023A0A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x0023BEB4 File Offset: 0x0023A0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x0023BEC4 File Offset: 0x0023A0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterSelectionRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					CharacterSelectionRequest._parser = new MessageParser<CharacterSelectionRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0023BF90 File Offset: 0x0023A190
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qnH8eMJeX5S8LikJ4Rcy()
		{
			return true;
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x0023BF98 File Offset: 0x0023A198
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterSelectionRequest GqnlP8JeNYEVang9YIuZ()
		{
			return null;
		}

		// Token: 0x04002790 RID: 10128
		private static readonly MessageParser<CharacterSelectionRequest> _parser;

		// Token: 0x04002791 RID: 10129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002792 RID: 10130
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002793 RID: 10131
		private long characterId_;

		// Token: 0x04002794 RID: 10132
		private static CharacterSelectionRequest ReOyEoJeEewkxlcjb58b;
	}
}
