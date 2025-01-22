using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D57 RID: 3415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceCreationStartedEvent : IMessage<AllianceCreationStartedEvent>, IMessage, IEquatable<AllianceCreationStartedEvent>, IDeepCloneable<AllianceCreationStartedEvent>, IBufferMessage
	{
		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x0028F610 File Offset: 0x0028D810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceCreationStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x0028F620 File Offset: 0x0028D820
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

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x0028F630 File Offset: 0x0028D830
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

		// Token: 0x0600A48C RID: 42124 RVA: 0x0028F640 File Offset: 0x0028D840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationStartedEvent()
		{
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x0028F650 File Offset: 0x0028D850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationStartedEvent(AllianceCreationStartedEvent other)
		{
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x0028F660 File Offset: 0x0028D860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x0028F670 File Offset: 0x0028D870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x0028F680 File Offset: 0x0028D880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceCreationStartedEvent other)
		{
			return true;
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x0028F690 File Offset: 0x0028D890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x0028F6A0 File Offset: 0x0028D8A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x0028F6B0 File Offset: 0x0028D8B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x0028F6C0 File Offset: 0x0028D8C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x0028F6D0 File Offset: 0x0028D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x0028F6E0 File Offset: 0x0028D8E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceCreationStartedEvent other)
		{
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x0028F6F0 File Offset: 0x0028D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x0028F700 File Offset: 0x0028D900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x0028F710 File Offset: 0x0028D910
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceCreationStartedEvent()
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
					AllianceCreationStartedEvent._parser = new MessageParser<AllianceCreationStartedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x0028F7F4 File Offset: 0x0028D9F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y6sWLZJkfW2jLOropWnM()
		{
			return true;
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x0028F7FC File Offset: 0x0028D9FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceCreationStartedEvent PSYDnhJknDmcLtiIMSCF()
		{
			return null;
		}

		// Token: 0x04003C99 RID: 15513
		private static readonly MessageParser<AllianceCreationStartedEvent> _parser;

		// Token: 0x04003C9A RID: 15514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C9B RID: 15515
		private static AllianceCreationStartedEvent p0Vq84JIzxyNTXrFkiPt;
	}
}
