using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001F7 RID: 503
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellInfo : IMessage<ForgettableSpellInfo>, IMessage, IEquatable<ForgettableSpellInfo>, IDeepCloneable<ForgettableSpellInfo>, IBufferMessage
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x001ADA4C File Offset: 0x001ABC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellInfo> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x001ADA5C File Offset: 0x001ABC5C
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x001ADA6C File Offset: 0x001ABC6C
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

		// Token: 0x06001799 RID: 6041 RVA: 0x001ADA7C File Offset: 0x001ABC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellInfo()
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x001ADA8C File Offset: 0x001ABC8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellInfo(ForgettableSpellInfo other)
		{
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x001ADA9C File Offset: 0x001ABC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellInfo Clone()
		{
			return null;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x001ADAAC File Offset: 0x001ABCAC
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x001ADABC File Offset: 0x001ABCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellPositions SpellPositions
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x001ADACC File Offset: 0x001ABCCC
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x001ADADC File Offset: 0x001ABCDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsMissing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x001ADAEC File Offset: 0x001ABCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x001ADAFC File Offset: 0x001ABCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellInfo other)
		{
			return true;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x001ADB0C File Offset: 0x001ABD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x001ADB1C File Offset: 0x001ABD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x001ADB2C File Offset: 0x001ABD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x001ADB3C File Offset: 0x001ABD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x001ADB4C File Offset: 0x001ABD4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x001ADB5C File Offset: 0x001ABD5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellInfo other)
		{
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x001ADB6C File Offset: 0x001ABD6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x001ADB7C File Offset: 0x001ABD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x001ADB8C File Offset: 0x001ABD8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellInfo()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ForgettableSpellInfo._parser = new MessageParser<ForgettableSpellInfo>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x001ADC84 File Offset: 0x001ABE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool La2pF8O1z2VykRN8JRWg()
		{
			return true;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x001ADC8C File Offset: 0x001ABE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellInfo uY26EuOafa3ptnwwQX0o()
		{
			return null;
		}

		// Token: 0x0400086D RID: 2157
		private static readonly MessageParser<ForgettableSpellInfo> _parser;

		// Token: 0x0400086E RID: 2158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400086F RID: 2159
		public const int SpellPositionsFieldNumber = 1;

		// Token: 0x04000870 RID: 2160
		private SpellPositions spellPositions_;

		// Token: 0x04000871 RID: 2161
		public const int IsMissingFieldNumber = 2;

		// Token: 0x04000872 RID: 2162
		private bool isMissing_;

		// Token: 0x04000873 RID: 2163
		private static ForgettableSpellInfo WLSDA0O1F73OOv5iGHpB;
	}
}
