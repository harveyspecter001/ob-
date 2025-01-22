using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A52 RID: 2642
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyUpdateCommonsInformation : IMessage<PartyUpdateCommonsInformation>, IMessage, IEquatable<PartyUpdateCommonsInformation>, IDeepCloneable<PartyUpdateCommonsInformation>, IBufferMessage
	{
		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x0025D50C File Offset: 0x0025B70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyUpdateCommonsInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06007DEB RID: 32235 RVA: 0x0025D51C File Offset: 0x0025B71C
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

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06007DEC RID: 32236 RVA: 0x0025D52C File Offset: 0x0025B72C
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

		// Token: 0x06007DED RID: 32237 RVA: 0x0025D53C File Offset: 0x0025B73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyUpdateCommonsInformation()
		{
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x0025D54C File Offset: 0x0025B74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyUpdateCommonsInformation(PartyUpdateCommonsInformation other)
		{
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x0025D55C File Offset: 0x0025B75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyUpdateCommonsInformation Clone()
		{
			return null;
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x0025D56C File Offset: 0x0025B76C
		// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x0025D57C File Offset: 0x0025B77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifePoint
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

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x0025D58C File Offset: 0x0025B78C
		// (set) Token: 0x06007DF3 RID: 32243 RVA: 0x0025D59C File Offset: 0x0025B79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLifePoints
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

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x0025D5AC File Offset: 0x0025B7AC
		// (set) Token: 0x06007DF5 RID: 32245 RVA: 0x0025D5BC File Offset: 0x0025B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Prospecting
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

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x0025D5CC File Offset: 0x0025B7CC
		// (set) Token: 0x06007DF7 RID: 32247 RVA: 0x0025D5DC File Offset: 0x0025B7DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RegenRate
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

		// Token: 0x06007DF8 RID: 32248 RVA: 0x0025D5EC File Offset: 0x0025B7EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x0025D5FC File Offset: 0x0025B7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyUpdateCommonsInformation other)
		{
			return true;
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x0025D60C File Offset: 0x0025B80C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x0025D61C File Offset: 0x0025B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x0025D62C File Offset: 0x0025B82C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x0025D63C File Offset: 0x0025B83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x0025D64C File Offset: 0x0025B84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x0025D65C File Offset: 0x0025B85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyUpdateCommonsInformation other)
		{
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x0025D66C File Offset: 0x0025B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x0025D67C File Offset: 0x0025B87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x0025D68C File Offset: 0x0025B88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyUpdateCommonsInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PartyUpdateCommonsInformation._parser = new MessageParser<PartyUpdateCommonsInformation>(() => null);
					num2 = 2;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x0025D770 File Offset: 0x0025B970
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UXE23IJGa6uKnwFjeqQs()
		{
			return true;
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x0025D778 File Offset: 0x0025B978
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyUpdateCommonsInformation VCecpCJG5lWkX7LedKKk()
		{
			return null;
		}

		// Token: 0x04002D77 RID: 11639
		private static readonly MessageParser<PartyUpdateCommonsInformation> _parser;

		// Token: 0x04002D78 RID: 11640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D79 RID: 11641
		public const int LifePointFieldNumber = 1;

		// Token: 0x04002D7A RID: 11642
		private int lifePoint_;

		// Token: 0x04002D7B RID: 11643
		public const int MaxLifePointsFieldNumber = 2;

		// Token: 0x04002D7C RID: 11644
		private int maxLifePoints_;

		// Token: 0x04002D7D RID: 11645
		public const int ProspectingFieldNumber = 3;

		// Token: 0x04002D7E RID: 11646
		private int prospecting_;

		// Token: 0x04002D7F RID: 11647
		public const int RegenRateFieldNumber = 4;

		// Token: 0x04002D80 RID: 11648
		private int regenRate_;

		// Token: 0x04002D81 RID: 11649
		internal static PartyUpdateCommonsInformation bei0gOJG1t9B29twNLoR;
	}
}
