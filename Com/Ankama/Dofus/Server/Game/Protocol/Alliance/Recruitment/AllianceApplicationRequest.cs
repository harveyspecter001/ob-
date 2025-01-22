using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D0A RID: 3338
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationRequest : IMessage<AllianceApplicationRequest>, IMessage, IEquatable<AllianceApplicationRequest>, IDeepCloneable<AllianceApplicationRequest>, IBufferMessage
	{
		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600A09B RID: 41115 RVA: 0x00287F28 File Offset: 0x00286128
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x00287F38 File Offset: 0x00286138
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

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x00287F48 File Offset: 0x00286148
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

		// Token: 0x0600A09E RID: 41118 RVA: 0x00287F58 File Offset: 0x00286158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationRequest()
		{
		}

		// Token: 0x0600A09F RID: 41119 RVA: 0x00287F68 File Offset: 0x00286168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationRequest(AllianceApplicationRequest other)
		{
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x00287F78 File Offset: 0x00286178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x00287F88 File Offset: 0x00286188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x00287F98 File Offset: 0x00286198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationRequest other)
		{
			return true;
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x00287FA8 File Offset: 0x002861A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x00287FB8 File Offset: 0x002861B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x00287FC8 File Offset: 0x002861C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00287FD8 File Offset: 0x002861D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00287FE8 File Offset: 0x002861E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x00287FF8 File Offset: 0x002861F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationRequest other)
		{
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x00288008 File Offset: 0x00286208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00288018 File Offset: 0x00286218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00288028 File Offset: 0x00286228
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
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
				AllianceApplicationRequest._parser = new MessageParser<AllianceApplicationRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x0028810C File Offset: 0x0028630C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kN6nUKJKB136n1udnoLJ()
		{
			return true;
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x00288114 File Offset: 0x00286314
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationRequest soJoNTJKe2TSyFyVktPX()
		{
			return null;
		}

		// Token: 0x04003B68 RID: 15208
		private static readonly MessageParser<AllianceApplicationRequest> _parser;

		// Token: 0x04003B69 RID: 15209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B6A RID: 15210
		internal static AllianceApplicationRequest cXDvWuJKAW2YjLtZEU5g;
	}
}
