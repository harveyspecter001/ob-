using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D02 RID: 3330
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationSubmitRequest : IMessage<AllianceApplicationSubmitRequest>, IMessage, IEquatable<AllianceApplicationSubmitRequest>, IDeepCloneable<AllianceApplicationSubmitRequest>, IBufferMessage
	{
		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x002876D0 File Offset: 0x002858D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationSubmitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600A032 RID: 41010 RVA: 0x002876E0 File Offset: 0x002858E0
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x0600A033 RID: 41011 RVA: 0x002876F0 File Offset: 0x002858F0
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

		// Token: 0x0600A034 RID: 41012 RVA: 0x00287700 File Offset: 0x00285900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationSubmitRequest()
		{
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00287710 File Offset: 0x00285910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationSubmitRequest(AllianceApplicationSubmitRequest other)
		{
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00287720 File Offset: 0x00285920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationSubmitRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x00287730 File Offset: 0x00285930
		// (set) Token: 0x0600A038 RID: 41016 RVA: 0x00287740 File Offset: 0x00285940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceUid
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

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x0600A039 RID: 41017 RVA: 0x00287750 File Offset: 0x00285950
		// (set) Token: 0x0600A03A RID: 41018 RVA: 0x00287760 File Offset: 0x00285960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Text
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

		// Token: 0x0600A03B RID: 41019 RVA: 0x00287770 File Offset: 0x00285970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x00287780 File Offset: 0x00285980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationSubmitRequest other)
		{
			return true;
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x00287790 File Offset: 0x00285990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x002877A0 File Offset: 0x002859A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x002877B0 File Offset: 0x002859B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x002877C0 File Offset: 0x002859C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x002877D0 File Offset: 0x002859D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x002877E0 File Offset: 0x002859E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationSubmitRequest other)
		{
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x002877F0 File Offset: 0x002859F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x00287800 File Offset: 0x00285A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x00287810 File Offset: 0x00285A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationSubmitRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AllianceApplicationSubmitRequest._parser = new MessageParser<AllianceApplicationSubmitRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x002878F4 File Offset: 0x00285AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool holKIfJjS7WCv8USAprj()
		{
			return true;
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x002878FC File Offset: 0x00285AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationSubmitRequest cvNxy1JjMohZVBn6Bi7v()
		{
			return null;
		}

		// Token: 0x04003B4A RID: 15178
		private static readonly MessageParser<AllianceApplicationSubmitRequest> _parser;

		// Token: 0x04003B4B RID: 15179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B4C RID: 15180
		public const int AllianceUidFieldNumber = 1;

		// Token: 0x04003B4D RID: 15181
		private string allianceUid_;

		// Token: 0x04003B4E RID: 15182
		public const int TextFieldNumber = 2;

		// Token: 0x04003B4F RID: 15183
		private string text_;

		// Token: 0x04003B50 RID: 15184
		internal static AllianceApplicationSubmitRequest PdH6lrJjP3tfauS1Ca3t;
	}
}
