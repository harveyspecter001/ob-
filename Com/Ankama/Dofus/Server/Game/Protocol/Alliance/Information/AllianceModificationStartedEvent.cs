using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D59 RID: 3417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceModificationStartedEvent : IMessage<AllianceModificationStartedEvent>, IMessage, IEquatable<AllianceModificationStartedEvent>, IDeepCloneable<AllianceModificationStartedEvent>, IBufferMessage
	{
		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x0028F804 File Offset: 0x0028DA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceModificationStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x0028F814 File Offset: 0x0028DA14
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

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x0028F824 File Offset: 0x0028DA24
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

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x0028F834 File Offset: 0x0028DA34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationStartedEvent()
		{
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x0028F844 File Offset: 0x0028DA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationStartedEvent(AllianceModificationStartedEvent other)
		{
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x0028F854 File Offset: 0x0028DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceModificationStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x0028F864 File Offset: 0x0028DA64
		// (set) Token: 0x0600A4A8 RID: 42152 RVA: 0x0028F874 File Offset: 0x0028DA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChangeName
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

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x0028F884 File Offset: 0x0028DA84
		// (set) Token: 0x0600A4AA RID: 42154 RVA: 0x0028F894 File Offset: 0x0028DA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChangeTag
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

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x0028F8A4 File Offset: 0x0028DAA4
		// (set) Token: 0x0600A4AC RID: 42156 RVA: 0x0028F8B4 File Offset: 0x0028DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChangeEmblem
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

		// Token: 0x0600A4AD RID: 42157 RVA: 0x0028F8C4 File Offset: 0x0028DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x0028F8D4 File Offset: 0x0028DAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceModificationStartedEvent other)
		{
			return true;
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x0028F8E4 File Offset: 0x0028DAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x0028F8F4 File Offset: 0x0028DAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x0028F904 File Offset: 0x0028DB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x0028F914 File Offset: 0x0028DB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x0028F924 File Offset: 0x0028DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x0028F934 File Offset: 0x0028DB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceModificationStartedEvent other)
		{
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x0028F944 File Offset: 0x0028DB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x0028F954 File Offset: 0x0028DB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x0028F964 File Offset: 0x0028DB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceModificationStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_88;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 4;
					}
				}
				IL_88:
				AllianceModificationStartedEvent._parser = new MessageParser<AllianceModificationStartedEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x0028FA4C File Offset: 0x0028DC4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QU4BfMJkA68ktnSjD1qF()
		{
			return true;
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x0028FA54 File Offset: 0x0028DC54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceModificationStartedEvent EEl3GbJkBERURZfvkn27()
		{
			return null;
		}

		// Token: 0x04003C9E RID: 15518
		private static readonly MessageParser<AllianceModificationStartedEvent> _parser;

		// Token: 0x04003C9F RID: 15519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA0 RID: 15520
		public const int CanChangeNameFieldNumber = 1;

		// Token: 0x04003CA1 RID: 15521
		private bool canChangeName_;

		// Token: 0x04003CA2 RID: 15522
		public const int CanChangeTagFieldNumber = 2;

		// Token: 0x04003CA3 RID: 15523
		private bool canChangeTag_;

		// Token: 0x04003CA4 RID: 15524
		public const int CanChangeEmblemFieldNumber = 3;

		// Token: 0x04003CA5 RID: 15525
		private bool canChangeEmblem_;

		// Token: 0x04003CA6 RID: 15526
		internal static AllianceModificationStartedEvent dOCciuJkmArVs6fxnUdo;
	}
}
