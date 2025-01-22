using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D5F RID: 3423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInsiderInformationRequest : IMessage<AllianceInsiderInformationRequest>, IMessage, IEquatable<AllianceInsiderInformationRequest>, IDeepCloneable<AllianceInsiderInformationRequest>, IBufferMessage
	{
		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0600A4F3 RID: 42227 RVA: 0x0028FE88 File Offset: 0x0028E088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceInsiderInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600A4F4 RID: 42228 RVA: 0x0028FE98 File Offset: 0x0028E098
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

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x0028FEA8 File Offset: 0x0028E0A8
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

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x0028FEB8 File Offset: 0x0028E0B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationRequest()
		{
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x0028FEC8 File Offset: 0x0028E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationRequest(AllianceInsiderInformationRequest other)
		{
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x0028FED8 File Offset: 0x0028E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x0028FEE8 File Offset: 0x0028E0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x0028FEF8 File Offset: 0x0028E0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInsiderInformationRequest other)
		{
			return true;
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x0028FF08 File Offset: 0x0028E108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x0028FF18 File Offset: 0x0028E118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x0028FF28 File Offset: 0x0028E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x0028FF38 File Offset: 0x0028E138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x0028FF48 File Offset: 0x0028E148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x0028FF58 File Offset: 0x0028E158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInsiderInformationRequest other)
		{
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x0028FF68 File Offset: 0x0028E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x0028FF78 File Offset: 0x0028E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x0028FF88 File Offset: 0x0028E188
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInsiderInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceInsiderInformationRequest._parser = new MessageParser<AllianceInsiderInformationRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x0029006C File Offset: 0x0028E26C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n4DViMJksUK3CvxmfBgN()
		{
			return true;
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x00290074 File Offset: 0x0028E274
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInsiderInformationRequest rlATxFJkdjeTn8kv1jAn()
		{
			return null;
		}

		// Token: 0x04003CB7 RID: 15543
		private static readonly MessageParser<AllianceInsiderInformationRequest> _parser;

		// Token: 0x04003CB8 RID: 15544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CB9 RID: 15545
		internal static AllianceInsiderInformationRequest OlBqMsJkg04XoCaJaiH7;
	}
}
