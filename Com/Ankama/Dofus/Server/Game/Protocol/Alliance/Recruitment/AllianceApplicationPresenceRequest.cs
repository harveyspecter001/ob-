using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D10 RID: 3344
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationPresenceRequest : IMessage<AllianceApplicationPresenceRequest>, IMessage, IEquatable<AllianceApplicationPresenceRequest>, IDeepCloneable<AllianceApplicationPresenceRequest>, IBufferMessage
	{
		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x0028859C File Offset: 0x0028679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationPresenceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x0600A0EC RID: 41196 RVA: 0x002885AC File Offset: 0x002867AC
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

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x002885BC File Offset: 0x002867BC
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

		// Token: 0x0600A0EE RID: 41198 RVA: 0x002885CC File Offset: 0x002867CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceRequest()
		{
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x002885DC File Offset: 0x002867DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceRequest(AllianceApplicationPresenceRequest other)
		{
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x002885EC File Offset: 0x002867EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x002885FC File Offset: 0x002867FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x0028860C File Offset: 0x0028680C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationPresenceRequest other)
		{
			return true;
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x0028861C File Offset: 0x0028681C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x0028862C File Offset: 0x0028682C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x0028863C File Offset: 0x0028683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x0028864C File Offset: 0x0028684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x0028865C File Offset: 0x0028685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x0028866C File Offset: 0x0028686C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationPresenceRequest other)
		{
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x0028867C File Offset: 0x0028687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x0028868C File Offset: 0x0028688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x0028869C File Offset: 0x0028689C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationPresenceRequest()
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
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AllianceApplicationPresenceRequest._parser = new MessageParser<AllianceApplicationPresenceRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x00288780 File Offset: 0x00286980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DMcQA6JKdeljVMY3vBNY()
		{
			return true;
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x00288788 File Offset: 0x00286988
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationPresenceRequest BrXNm6JK9DCIbU4B1Shs()
		{
			return null;
		}

		// Token: 0x04003B7F RID: 15231
		private static readonly MessageParser<AllianceApplicationPresenceRequest> _parser;

		// Token: 0x04003B80 RID: 15232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B81 RID: 15233
		private static AllianceApplicationPresenceRequest YA9MSyJKshbwWKaD9LwE;
	}
}
