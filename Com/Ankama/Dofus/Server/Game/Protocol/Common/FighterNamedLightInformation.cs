using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A9C RID: 2716
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterNamedLightInformation : IMessage<FighterNamedLightInformation>, IMessage, IEquatable<FighterNamedLightInformation>, IDeepCloneable<FighterNamedLightInformation>, IBufferMessage
	{
		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x060081B5 RID: 33205 RVA: 0x00261810 File Offset: 0x0025FA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FighterNamedLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x060081B6 RID: 33206 RVA: 0x00261820 File Offset: 0x0025FA20
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

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x00261830 File Offset: 0x0025FA30
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

		// Token: 0x060081B8 RID: 33208 RVA: 0x00261840 File Offset: 0x0025FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterNamedLightInformation()
		{
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x00261850 File Offset: 0x0025FA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterNamedLightInformation(FighterNamedLightInformation other)
		{
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00261860 File Offset: 0x0025FA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterNamedLightInformation Clone()
		{
			return null;
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x060081BB RID: 33211 RVA: 0x00261870 File Offset: 0x0025FA70
		// (set) Token: 0x060081BC RID: 33212 RVA: 0x00261880 File Offset: 0x0025FA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x060081BD RID: 33213 RVA: 0x00261890 File Offset: 0x0025FA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x002618A0 File Offset: 0x0025FAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterNamedLightInformation other)
		{
			return true;
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x002618B0 File Offset: 0x0025FAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x002618C0 File Offset: 0x0025FAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x002618D0 File Offset: 0x0025FAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x002618E0 File Offset: 0x0025FAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x002618F0 File Offset: 0x0025FAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x00261900 File Offset: 0x0025FB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterNamedLightInformation other)
		{
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x00261910 File Offset: 0x0025FB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x00261920 File Offset: 0x0025FB20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x00261930 File Offset: 0x0025FB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterNamedLightInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
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
					FighterNamedLightInformation._parser = new MessageParser<FighterNamedLightInformation>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00261A14 File Offset: 0x0025FC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YGF3bnJgTCl4eIsrZvx9()
		{
			return true;
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x00261A1C File Offset: 0x0025FC1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterNamedLightInformation eJaV7GJgpwTwxkWUneHQ()
		{
			return null;
		}

		// Token: 0x04002F2F RID: 12079
		private static readonly MessageParser<FighterNamedLightInformation> _parser;

		// Token: 0x04002F30 RID: 12080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F31 RID: 12081
		public const int NameFieldNumber = 1;

		// Token: 0x04002F32 RID: 12082
		private string name_;

		// Token: 0x04002F33 RID: 12083
		internal static FighterNamedLightInformation bF549PJg7u5reXexXGA0;
	}
}
