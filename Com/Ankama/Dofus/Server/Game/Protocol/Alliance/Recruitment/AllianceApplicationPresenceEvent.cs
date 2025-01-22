using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D20 RID: 3360
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationPresenceEvent : IMessage<AllianceApplicationPresenceEvent>, IMessage, IEquatable<AllianceApplicationPresenceEvent>, IDeepCloneable<AllianceApplicationPresenceEvent>, IBufferMessage
	{
		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600A1C6 RID: 41414 RVA: 0x002896E8 File Offset: 0x002878E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationPresenceEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x0600A1C7 RID: 41415 RVA: 0x002896F8 File Offset: 0x002878F8
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

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x0600A1C8 RID: 41416 RVA: 0x00289708 File Offset: 0x00287908
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

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00289718 File Offset: 0x00287918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceEvent()
		{
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x00289728 File Offset: 0x00287928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceEvent(AllianceApplicationPresenceEvent other)
		{
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x00289738 File Offset: 0x00287938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationPresenceEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x0600A1CC RID: 41420 RVA: 0x00289748 File Offset: 0x00287948
		// (set) Token: 0x0600A1CD RID: 41421 RVA: 0x00289758 File Offset: 0x00287958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Presence
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

		// Token: 0x0600A1CE RID: 41422 RVA: 0x00289768 File Offset: 0x00287968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x00289778 File Offset: 0x00287978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationPresenceEvent other)
		{
			return true;
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00289788 File Offset: 0x00287988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00289798 File Offset: 0x00287998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x002897A8 File Offset: 0x002879A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x002897B8 File Offset: 0x002879B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x002897C8 File Offset: 0x002879C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x002897D8 File Offset: 0x002879D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationPresenceEvent other)
		{
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x002897E8 File Offset: 0x002879E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x002897F8 File Offset: 0x002879F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00289808 File Offset: 0x00287A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationPresenceEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AllianceApplicationPresenceEvent._parser = new MessageParser<AllianceApplicationPresenceEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x002898D4 File Offset: 0x00287AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yevJUQJKhotRZMpD65FP()
		{
			return true;
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x002898DC File Offset: 0x00287ADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationPresenceEvent cMaoDyJKrvosS3eiPeCL()
		{
			return null;
		}

		// Token: 0x04003BC4 RID: 15300
		private static readonly MessageParser<AllianceApplicationPresenceEvent> _parser;

		// Token: 0x04003BC5 RID: 15301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC6 RID: 15302
		public const int PresenceFieldNumber = 1;

		// Token: 0x04003BC7 RID: 15303
		private bool presence_;

		// Token: 0x04003BC8 RID: 15304
		private static AllianceApplicationPresenceEvent XepNOPJKW6HKOlEVwXvc;
	}
}
