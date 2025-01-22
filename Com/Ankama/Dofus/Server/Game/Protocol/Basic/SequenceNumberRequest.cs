using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BC2 RID: 3010
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SequenceNumberRequest : IMessage<SequenceNumberRequest>, IMessage, IEquatable<SequenceNumberRequest>, IDeepCloneable<SequenceNumberRequest>, IBufferMessage
	{
		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x0026EE74 File Offset: 0x0026D074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SequenceNumberRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060090D5 RID: 37077 RVA: 0x0026EE84 File Offset: 0x0026D084
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

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x0026EE94 File Offset: 0x0026D094
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

		// Token: 0x060090D7 RID: 37079 RVA: 0x0026EEA4 File Offset: 0x0026D0A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberRequest()
		{
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x0026EEB4 File Offset: 0x0026D0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberRequest(SequenceNumberRequest other)
		{
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x0026EEC4 File Offset: 0x0026D0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x0026EED4 File Offset: 0x0026D0D4
		// (set) Token: 0x060090DB RID: 37083 RVA: 0x0026EEE4 File Offset: 0x0026D0E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Number
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

		// Token: 0x060090DC RID: 37084 RVA: 0x0026EEF4 File Offset: 0x0026D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x0026EF04 File Offset: 0x0026D104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SequenceNumberRequest other)
		{
			return true;
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x0026EF14 File Offset: 0x0026D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x0026EF24 File Offset: 0x0026D124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x0026EF34 File Offset: 0x0026D134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0026EF44 File Offset: 0x0026D144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x0026EF54 File Offset: 0x0026D154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060090E3 RID: 37091 RVA: 0x0026EF64 File Offset: 0x0026D164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SequenceNumberRequest other)
		{
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x0026EF74 File Offset: 0x0026D174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0026EF84 File Offset: 0x0026D184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x0026EF94 File Offset: 0x0026D194
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SequenceNumberRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					SequenceNumberRequest._parser = new MessageParser<SequenceNumberRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0026F08C File Offset: 0x0026D28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ev9vsJJ2ys3ZhYaAU2u8()
		{
			return true;
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x0026F094 File Offset: 0x0026D294
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SequenceNumberRequest gqNbSjJ26CKpqS5TmFXb()
		{
			return null;
		}

		// Token: 0x040035E4 RID: 13796
		private static readonly MessageParser<SequenceNumberRequest> _parser;

		// Token: 0x040035E5 RID: 13797
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E6 RID: 13798
		public const int NumberFieldNumber = 1;

		// Token: 0x040035E7 RID: 13799
		private int number_;

		// Token: 0x040035E8 RID: 13800
		private static SequenceNumberRequest tcluchJ25KKW8uiLJFV4;
	}
}
