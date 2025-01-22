using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D08 RID: 3336
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationListenRequest : IMessage<AllianceApplicationListenRequest>, IMessage, IEquatable<AllianceApplicationListenRequest>, IDeepCloneable<AllianceApplicationListenRequest>, IBufferMessage
	{
		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x00287D2C File Offset: 0x00285F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationListenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600A082 RID: 41090 RVA: 0x00287D3C File Offset: 0x00285F3C
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x00287D4C File Offset: 0x00285F4C
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

		// Token: 0x0600A084 RID: 41092 RVA: 0x00287D5C File Offset: 0x00285F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListenRequest()
		{
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x00287D6C File Offset: 0x00285F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListenRequest(AllianceApplicationListenRequest other)
		{
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x00287D7C File Offset: 0x00285F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListenRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x00287D8C File Offset: 0x00285F8C
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x00287D9C File Offset: 0x00285F9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool State
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

		// Token: 0x0600A089 RID: 41097 RVA: 0x00287DAC File Offset: 0x00285FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x00287DBC File Offset: 0x00285FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationListenRequest other)
		{
			return true;
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x00287DCC File Offset: 0x00285FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x00287DDC File Offset: 0x00285FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x00287DEC File Offset: 0x00285FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00287DFC File Offset: 0x00285FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00287E0C File Offset: 0x0028600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x00287E1C File Offset: 0x0028601C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationListenRequest other)
		{
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x00287E2C File Offset: 0x0028602C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x00287E3C File Offset: 0x0028603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x00287E4C File Offset: 0x0028604C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationListenRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AllianceApplicationListenRequest._parser = new MessageParser<AllianceApplicationListenRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x00287F18 File Offset: 0x00286118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bd1RQ6JKnQIMVjQlfjpp()
		{
			return true;
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x00287F20 File Offset: 0x00286120
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationListenRequest HCBshaJKmOmqGoZU0NX7()
		{
			return null;
		}

		// Token: 0x04003B61 RID: 15201
		private static readonly MessageParser<AllianceApplicationListenRequest> _parser;

		// Token: 0x04003B62 RID: 15202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B63 RID: 15203
		public const int StateFieldNumber = 1;

		// Token: 0x04003B64 RID: 15204
		private bool state_;

		// Token: 0x04003B65 RID: 15205
		private static AllianceApplicationListenRequest UGkxK5JKfUqd5NZkwJ3F;
	}
}
