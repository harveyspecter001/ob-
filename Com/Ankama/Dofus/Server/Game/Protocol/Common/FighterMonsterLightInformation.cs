using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A96 RID: 2710
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterMonsterLightInformation : IMessage<FighterMonsterLightInformation>, IMessage, IEquatable<FighterMonsterLightInformation>, IDeepCloneable<FighterMonsterLightInformation>, IBufferMessage
	{
		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x00261194 File Offset: 0x0025F394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FighterMonsterLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x002611A4 File Offset: 0x0025F3A4
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

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06008165 RID: 33125 RVA: 0x002611B4 File Offset: 0x0025F3B4
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

		// Token: 0x06008166 RID: 33126 RVA: 0x002611C4 File Offset: 0x0025F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterMonsterLightInformation()
		{
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x002611D4 File Offset: 0x0025F3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterMonsterLightInformation(FighterMonsterLightInformation other)
		{
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x002611E4 File Offset: 0x0025F3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterMonsterLightInformation Clone()
		{
			return null;
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06008169 RID: 33129 RVA: 0x002611F4 File Offset: 0x0025F3F4
		// (set) Token: 0x0600816A RID: 33130 RVA: 0x00261204 File Offset: 0x0025F404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterGid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00261214 File Offset: 0x0025F414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00261224 File Offset: 0x0025F424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterMonsterLightInformation other)
		{
			return true;
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00261234 File Offset: 0x0025F434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00261244 File Offset: 0x0025F444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x00261254 File Offset: 0x0025F454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00261264 File Offset: 0x0025F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x00261274 File Offset: 0x0025F474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x00261284 File Offset: 0x0025F484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterMonsterLightInformation other)
		{
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x00261294 File Offset: 0x0025F494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x002612A4 File Offset: 0x0025F4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x002612B4 File Offset: 0x0025F4B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterMonsterLightInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				FighterMonsterLightInformation._parser = new MessageParser<FighterMonsterLightInformation>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00261398 File Offset: 0x0025F598
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool chgJDeJgrg2K2F0vlWKe()
		{
			return true;
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x002613A0 File Offset: 0x0025F5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterMonsterLightInformation iSqhtiJgVJ1ufZpe5vXd()
		{
			return null;
		}

		// Token: 0x04002F16 RID: 12054
		private static readonly MessageParser<FighterMonsterLightInformation> _parser;

		// Token: 0x04002F17 RID: 12055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F18 RID: 12056
		public const int MonsterGidFieldNumber = 1;

		// Token: 0x04002F19 RID: 12057
		private int monsterGid_;

		// Token: 0x04002F1A RID: 12058
		private static FighterMonsterLightInformation vYV2LqJghcfwVvWBCIYo;
	}
}
