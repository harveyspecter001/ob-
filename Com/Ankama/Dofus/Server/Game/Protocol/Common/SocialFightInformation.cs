using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A87 RID: 2695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialFightInformation : IMessage<SocialFightInformation>, IMessage, IEquatable<SocialFightInformation>, IDeepCloneable<SocialFightInformation>, IBufferMessage
	{
		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x00260484 File Offset: 0x0025E684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialFightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x00260494 File Offset: 0x0025E694
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

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x060080BD RID: 32957 RVA: 0x002604A4 File Offset: 0x0025E6A4
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

		// Token: 0x060080BE RID: 32958 RVA: 0x002604B4 File Offset: 0x0025E6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFightInformation()
		{
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x002604C4 File Offset: 0x0025E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFightInformation(SocialFightInformation other)
		{
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x002604D4 File Offset: 0x0025E6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFightInformation Clone()
		{
			return null;
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x060080C1 RID: 32961 RVA: 0x002604E4 File Offset: 0x0025E6E4
		// (set) Token: 0x060080C2 RID: 32962 RVA: 0x002604F4 File Offset: 0x0025E6F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060080C3 RID: 32963 RVA: 0x00260504 File Offset: 0x0025E704
		// (set) Token: 0x060080C4 RID: 32964 RVA: 0x00260518 File Offset: 0x0025E718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialFightInformation.Types.Type FightType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialFightInformation.Types.Type)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060080C5 RID: 32965 RVA: 0x00260528 File Offset: 0x0025E728
		// (set) Token: 0x060080C6 RID: 32966 RVA: 0x00260538 File Offset: 0x0025E738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x060080C7 RID: 32967 RVA: 0x00260548 File Offset: 0x0025E748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x00260558 File Offset: 0x0025E758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SocialFightInformation other)
		{
			return true;
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x00260568 File Offset: 0x0025E768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x00260578 File Offset: 0x0025E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x00260588 File Offset: 0x0025E788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x00260598 File Offset: 0x0025E798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x002605A8 File Offset: 0x0025E7A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x002605B8 File Offset: 0x0025E7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SocialFightInformation other)
		{
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x002605C8 File Offset: 0x0025E7C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x002605D8 File Offset: 0x0025E7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x002605E8 File Offset: 0x0025E7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SocialFightInformation()
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
					SocialFightInformation._parser = new MessageParser<SocialFightInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x002606CC File Offset: 0x0025E8CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool APwxVrJgILVhiGLUXMSm()
		{
			return true;
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x002606D4 File Offset: 0x0025E8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SocialFightInformation yR7MKYJgkTvZJBLdUHVd()
		{
			return null;
		}

		// Token: 0x04002EC2 RID: 11970
		private static readonly MessageParser<SocialFightInformation> _parser;

		// Token: 0x04002EC3 RID: 11971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EC4 RID: 11972
		public const int FightIdFieldNumber = 1;

		// Token: 0x04002EC5 RID: 11973
		private int fightId_;

		// Token: 0x04002EC6 RID: 11974
		public const int FightTypeFieldNumber = 2;

		// Token: 0x04002EC7 RID: 11975
		private SocialFightInformation.Types.Type fightType_;

		// Token: 0x04002EC8 RID: 11976
		public const int MapIdFieldNumber = 3;

		// Token: 0x04002EC9 RID: 11977
		private long mapId_;

		// Token: 0x04002ECA RID: 11978
		private static SocialFightInformation U1WS2bJgK5PhEU0CyRXp;

		// Token: 0x02000A88 RID: 2696
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060080D4 RID: 32980 RVA: 0x002E08C0 File Offset: 0x002DEAC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A89 RID: 2697
			public enum Type
			{
				// Token: 0x04002ECC RID: 11980
				[OriginalName("TAX_COLLECTOR")]
				TaxCollector,
				// Token: 0x04002ECD RID: 11981
				[OriginalName("PRISM")]
				Prism
			}
		}
	}
}
