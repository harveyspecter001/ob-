using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D46 RID: 3398
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceLeftEvent : IMessage<AllianceLeftEvent>, IMessage, IEquatable<AllianceLeftEvent>, IDeepCloneable<AllianceLeftEvent>, IBufferMessage
	{
		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x0028CD38 File Offset: 0x0028AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceLeftEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x0600A3B2 RID: 41906 RVA: 0x0028CD48 File Offset: 0x0028AF48
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

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x0028CD58 File Offset: 0x0028AF58
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

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x0028CD68 File Offset: 0x0028AF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceLeftEvent()
		{
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x0028CD78 File Offset: 0x0028AF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceLeftEvent(AllianceLeftEvent other)
		{
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x0028CD88 File Offset: 0x0028AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceLeftEvent Clone()
		{
			return null;
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x0028CD98 File Offset: 0x0028AF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x0028CDA8 File Offset: 0x0028AFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceLeftEvent other)
		{
			return true;
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x0028CDB8 File Offset: 0x0028AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x0028CDC8 File Offset: 0x0028AFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A3BB RID: 41915 RVA: 0x0028CDD8 File Offset: 0x0028AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x0028CDE8 File Offset: 0x0028AFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x0028CDF8 File Offset: 0x0028AFF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x0028CE08 File Offset: 0x0028B008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceLeftEvent other)
		{
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x0028CE18 File Offset: 0x0028B018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x0028CE28 File Offset: 0x0028B028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x0028CE38 File Offset: 0x0028B038
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceLeftEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AllianceLeftEvent._parser = new MessageParser<AllianceLeftEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x0028CF30 File Offset: 0x0028B130
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TYrNdcJIL9B9MXktXBpS()
		{
			return true;
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x0028CF38 File Offset: 0x0028B138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceLeftEvent TQmluDJIWG8atkqlM79a()
		{
			return null;
		}

		// Token: 0x04003C5B RID: 15451
		private static readonly MessageParser<AllianceLeftEvent> _parser;

		// Token: 0x04003C5C RID: 15452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C5D RID: 15453
		internal static AllianceLeftEvent N7ZTmKJI6f5K6cWjnqxc;
	}
}
