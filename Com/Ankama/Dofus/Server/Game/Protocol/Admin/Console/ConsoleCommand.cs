using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console
{
	// Token: 0x02000DAE RID: 3502
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ConsoleCommand : IMessage<ConsoleCommand>, IMessage, IEquatable<ConsoleCommand>, IDeepCloneable<ConsoleCommand>, IBufferMessage
	{
		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x00295E68 File Offset: 0x00294068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConsoleCommand> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x00295E78 File Offset: 0x00294078
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

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x00295E88 File Offset: 0x00294088
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

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x00295E98 File Offset: 0x00294098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleCommand()
		{
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00295EA8 File Offset: 0x002940A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleCommand(ConsoleCommand other)
		{
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x00295EB8 File Offset: 0x002940B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleCommand Clone()
		{
			return null;
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600A8C9 RID: 43209 RVA: 0x00295EC8 File Offset: 0x002940C8
		// (set) Token: 0x0600A8CA RID: 43210 RVA: 0x00295ED8 File Offset: 0x002940D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
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

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x00295EE8 File Offset: 0x002940E8
		// (set) Token: 0x0600A8CC RID: 43212 RVA: 0x00295EF8 File Offset: 0x002940F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Quiet
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

		// Token: 0x0600A8CD RID: 43213 RVA: 0x00295F08 File Offset: 0x00294108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x00295F18 File Offset: 0x00294118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ConsoleCommand other)
		{
			return true;
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x00295F28 File Offset: 0x00294128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x00295F38 File Offset: 0x00294138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x00295F48 File Offset: 0x00294148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x00295F58 File Offset: 0x00294158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x00295F68 File Offset: 0x00294168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x00295F78 File Offset: 0x00294178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ConsoleCommand other)
		{
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x00295F88 File Offset: 0x00294188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x00295F98 File Offset: 0x00294198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x00295FA8 File Offset: 0x002941A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConsoleCommand()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					ConsoleCommand._parser = new MessageParser<ConsoleCommand>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x002960A0 File Offset: 0x002942A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DqMVaRJliECUZ4P2BHJG()
		{
			return true;
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x002960A8 File Offset: 0x002942A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConsoleCommand FcMqOVJlPsL1ItxobR2l()
		{
			return null;
		}

		// Token: 0x04003E0D RID: 15885
		private static readonly MessageParser<ConsoleCommand> _parser;

		// Token: 0x04003E0E RID: 15886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E0F RID: 15887
		public const int ContentFieldNumber = 1;

		// Token: 0x04003E10 RID: 15888
		private string content_;

		// Token: 0x04003E11 RID: 15889
		public const int QuietFieldNumber = 2;

		// Token: 0x04003E12 RID: 15890
		private bool quiet_;

		// Token: 0x04003E13 RID: 15891
		internal static ConsoleCommand alMcQPJlb3YrcxttiO9k;
	}
}
