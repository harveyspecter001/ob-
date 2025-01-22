using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000CFC RID: 3324
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentInformationEvent : IMessage<AllianceRecruitmentInformationEvent>, IMessage, IEquatable<AllianceRecruitmentInformationEvent>, IDeepCloneable<AllianceRecruitmentInformationEvent>, IBufferMessage
	{
		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x002870CC File Offset: 0x002852CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRecruitmentInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x002870DC File Offset: 0x002852DC
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

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06009FE7 RID: 40935 RVA: 0x002870EC File Offset: 0x002852EC
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

		// Token: 0x06009FE8 RID: 40936 RVA: 0x002870FC File Offset: 0x002852FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationEvent()
		{
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x0028710C File Offset: 0x0028530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationEvent(AllianceRecruitmentInformationEvent other)
		{
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x0028711C File Offset: 0x0028531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06009FEB RID: 40939 RVA: 0x0028712C File Offset: 0x0028532C
		// (set) Token: 0x06009FEC RID: 40940 RVA: 0x0028713C File Offset: 0x0028533C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceRecruitmentInformation Information
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

		// Token: 0x06009FED RID: 40941 RVA: 0x0028714C File Offset: 0x0028534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x0028715C File Offset: 0x0028535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentInformationEvent other)
		{
			return true;
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x0028716C File Offset: 0x0028536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x0028717C File Offset: 0x0028537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x0028718C File Offset: 0x0028538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x0028719C File Offset: 0x0028539C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x002871AC File Offset: 0x002853AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x002871BC File Offset: 0x002853BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentInformationEvent other)
		{
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x002871CC File Offset: 0x002853CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x002871DC File Offset: 0x002853DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x002871EC File Offset: 0x002853EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AllianceRecruitmentInformationEvent._parser = new MessageParser<AllianceRecruitmentInformationEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x002872D0 File Offset: 0x002854D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I3eQf9JjQTCyIpWlxyjN()
		{
			return true;
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x002872D8 File Offset: 0x002854D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentInformationEvent Jk98KOJj7O8XydhMB59b()
		{
			return null;
		}

		// Token: 0x04003B37 RID: 15159
		private static readonly MessageParser<AllianceRecruitmentInformationEvent> _parser;

		// Token: 0x04003B38 RID: 15160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B39 RID: 15161
		public const int InformationFieldNumber = 1;

		// Token: 0x04003B3A RID: 15162
		private AllianceRecruitmentInformation information_;

		// Token: 0x04003B3B RID: 15163
		private static AllianceRecruitmentInformationEvent GKKgGPJjwbfr4fNipwnX;
	}
}
