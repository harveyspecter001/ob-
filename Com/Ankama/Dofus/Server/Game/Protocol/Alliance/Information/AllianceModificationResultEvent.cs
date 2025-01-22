using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D5D RID: 3421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceModificationResultEvent : IMessage<AllianceModificationResultEvent>, IMessage, IEquatable<AllianceModificationResultEvent>, IDeepCloneable<AllianceModificationResultEvent>, IBufferMessage
	{
		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600A4D9 RID: 42201 RVA: 0x0028FC88 File Offset: 0x0028DE88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceModificationResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600A4DA RID: 42202 RVA: 0x0028FC98 File Offset: 0x0028DE98
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

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x0600A4DB RID: 42203 RVA: 0x0028FCA8 File Offset: 0x0028DEA8
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

		// Token: 0x0600A4DC RID: 42204 RVA: 0x0028FCB8 File Offset: 0x0028DEB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationResultEvent()
		{
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x0028FCC8 File Offset: 0x0028DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationResultEvent(AllianceModificationResultEvent other)
		{
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x0028FCD8 File Offset: 0x0028DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x0028FCE8 File Offset: 0x0028DEE8
		// (set) Token: 0x0600A4E0 RID: 42208 RVA: 0x0028FCFC File Offset: 0x0028DEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialGroupOperationResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupOperationResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x0028FD0C File Offset: 0x0028DF0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x0028FD1C File Offset: 0x0028DF1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceModificationResultEvent other)
		{
			return true;
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x0028FD2C File Offset: 0x0028DF2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x0028FD3C File Offset: 0x0028DF3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x0028FD4C File Offset: 0x0028DF4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x0028FD5C File Offset: 0x0028DF5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x0028FD6C File Offset: 0x0028DF6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x0028FD7C File Offset: 0x0028DF7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceModificationResultEvent other)
		{
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x0028FD8C File Offset: 0x0028DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x0028FD9C File Offset: 0x0028DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x0028FDAC File Offset: 0x0028DFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceModificationResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
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
				AllianceModificationResultEvent._parser = new MessageParser<AllianceModificationResultEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x0028FE78 File Offset: 0x0028E078
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hbatUAJkJYOtWe8Bt5Vc()
		{
			return true;
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x0028FE80 File Offset: 0x0028E080
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceModificationResultEvent phMP3kJkGoJu2Dw4jeY2()
		{
			return null;
		}

		// Token: 0x04003CB0 RID: 15536
		private static readonly MessageParser<AllianceModificationResultEvent> _parser;

		// Token: 0x04003CB1 RID: 15537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CB2 RID: 15538
		public const int ResultFieldNumber = 1;

		// Token: 0x04003CB3 RID: 15539
		private SocialGroupOperationResult result_;

		// Token: 0x04003CB4 RID: 15540
		internal static AllianceModificationResultEvent UuTDYDJkO0FEc3JJyIg2;
	}
}
