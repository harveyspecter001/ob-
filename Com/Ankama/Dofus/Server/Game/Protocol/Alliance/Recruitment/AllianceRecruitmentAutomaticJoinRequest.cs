using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000CFE RID: 3326
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentAutomaticJoinRequest : IMessage<AllianceRecruitmentAutomaticJoinRequest>, IMessage, IEquatable<AllianceRecruitmentAutomaticJoinRequest>, IDeepCloneable<AllianceRecruitmentAutomaticJoinRequest>, IBufferMessage
	{
		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06009FFF RID: 40959 RVA: 0x002872E0 File Offset: 0x002854E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRecruitmentAutomaticJoinRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x0600A000 RID: 40960 RVA: 0x002872F0 File Offset: 0x002854F0
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

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x00287300 File Offset: 0x00285500
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

		// Token: 0x0600A002 RID: 40962 RVA: 0x00287310 File Offset: 0x00285510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentAutomaticJoinRequest()
		{
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x00287320 File Offset: 0x00285520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentAutomaticJoinRequest(AllianceRecruitmentAutomaticJoinRequest other)
		{
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x00287330 File Offset: 0x00285530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentAutomaticJoinRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x00287340 File Offset: 0x00285540
		// (set) Token: 0x0600A006 RID: 40966 RVA: 0x00287350 File Offset: 0x00285550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600A007 RID: 40967 RVA: 0x00287360 File Offset: 0x00285560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x00287370 File Offset: 0x00285570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentAutomaticJoinRequest other)
		{
			return true;
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x00287380 File Offset: 0x00285580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x00287390 File Offset: 0x00285590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x002873A0 File Offset: 0x002855A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x002873B0 File Offset: 0x002855B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x002873C0 File Offset: 0x002855C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x002873D0 File Offset: 0x002855D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentAutomaticJoinRequest other)
		{
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x002873E0 File Offset: 0x002855E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x002873F0 File Offset: 0x002855F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x00287400 File Offset: 0x00285600
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentAutomaticJoinRequest()
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
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AllianceRecruitmentAutomaticJoinRequest._parser = new MessageParser<AllianceRecruitmentAutomaticJoinRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x002874CC File Offset: 0x002856CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kXrXh6JjpBTUFps15Y4m()
		{
			return true;
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x002874D4 File Offset: 0x002856D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentAutomaticJoinRequest mZQbakJjHdcJVqWVmZen()
		{
			return null;
		}

		// Token: 0x04003B3E RID: 15166
		private static readonly MessageParser<AllianceRecruitmentAutomaticJoinRequest> _parser;

		// Token: 0x04003B3F RID: 15167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B40 RID: 15168
		public const int AllianceUidFieldNumber = 1;

		// Token: 0x04003B41 RID: 15169
		private string allianceUid_;

		// Token: 0x04003B42 RID: 15170
		private static AllianceRecruitmentAutomaticJoinRequest OtN51BJjTemdMQJ6fexG;
	}
}
