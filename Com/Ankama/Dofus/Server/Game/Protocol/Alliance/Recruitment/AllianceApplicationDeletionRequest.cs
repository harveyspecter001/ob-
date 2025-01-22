using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D06 RID: 3334
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationDeletionRequest : IMessage<AllianceApplicationDeletionRequest>, IMessage, IEquatable<AllianceApplicationDeletionRequest>, IDeepCloneable<AllianceApplicationDeletionRequest>, IBufferMessage
	{
		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x00287B38 File Offset: 0x00285D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationDeletionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600A06A RID: 41066 RVA: 0x00287B48 File Offset: 0x00285D48
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

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600A06B RID: 41067 RVA: 0x00287B58 File Offset: 0x00285D58
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

		// Token: 0x0600A06C RID: 41068 RVA: 0x00287B68 File Offset: 0x00285D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletionRequest()
		{
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x00287B78 File Offset: 0x00285D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletionRequest(AllianceApplicationDeletionRequest other)
		{
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x00287B88 File Offset: 0x00285D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletionRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x00287B98 File Offset: 0x00285D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x00287BA8 File Offset: 0x00285DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationDeletionRequest other)
		{
			return true;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x00287BB8 File Offset: 0x00285DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x00287BC8 File Offset: 0x00285DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x00287BD8 File Offset: 0x00285DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x00287BE8 File Offset: 0x00285DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x00287BF8 File Offset: 0x00285DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x00287C08 File Offset: 0x00285E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationDeletionRequest other)
		{
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x00287C18 File Offset: 0x00285E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x00287C28 File Offset: 0x00285E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x00287C38 File Offset: 0x00285E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationDeletionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					AllianceApplicationDeletionRequest._parser = new MessageParser<AllianceApplicationDeletionRequest>(() => null);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x00287D1C File Offset: 0x00285F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mBKEXqJjFwspdneVGMp9()
		{
			return true;
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x00287D24 File Offset: 0x00285F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationDeletionRequest pp5OgSJjzls7ZVK92XPo()
		{
			return null;
		}

		// Token: 0x04003B5C RID: 15196
		private static readonly MessageParser<AllianceApplicationDeletionRequest> _parser;

		// Token: 0x04003B5D RID: 15197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B5E RID: 15198
		private static AllianceApplicationDeletionRequest atad9xJjqajkDhRNPD4f;
	}
}
