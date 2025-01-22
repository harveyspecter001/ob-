using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D87 RID: 3463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightLeaveRequest : IMessage<AllianceFightLeaveRequest>, IMessage, IEquatable<AllianceFightLeaveRequest>, IDeepCloneable<AllianceFightLeaveRequest>, IBufferMessage
	{
		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x00293B30 File Offset: 0x00291D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightLeaveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x0600A6EE RID: 42734 RVA: 0x00293B40 File Offset: 0x00291D40
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

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x00293B50 File Offset: 0x00291D50
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

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x00293B60 File Offset: 0x00291D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightLeaveRequest()
		{
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x00293B70 File Offset: 0x00291D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightLeaveRequest(AllianceFightLeaveRequest other)
		{
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x00293B80 File Offset: 0x00291D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightLeaveRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x00293B90 File Offset: 0x00291D90
		// (set) Token: 0x0600A6F4 RID: 42740 RVA: 0x00293BA0 File Offset: 0x00291DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialFightInformation FightInformation
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

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x00293BB0 File Offset: 0x00291DB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x00293BC0 File Offset: 0x00291DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightLeaveRequest other)
		{
			return true;
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x00293BD0 File Offset: 0x00291DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x00293BE0 File Offset: 0x00291DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x00293BF0 File Offset: 0x00291DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x00293C00 File Offset: 0x00291E00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x00293C10 File Offset: 0x00291E10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A6FC RID: 42748 RVA: 0x00293C20 File Offset: 0x00291E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightLeaveRequest other)
		{
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x00293C30 File Offset: 0x00291E30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x00293C40 File Offset: 0x00291E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x00293C50 File Offset: 0x00291E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightLeaveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						AllianceFightLeaveRequest._parser = new MessageParser<AllianceFightLeaveRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x00293D38 File Offset: 0x00291F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RVMuc0JlRx4WXMpQSqDj()
		{
			return true;
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x00293D40 File Offset: 0x00291F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightLeaveRequest nwmNOfJlOnajcppvvYlA()
		{
			return null;
		}

		// Token: 0x04003D71 RID: 15729
		private static readonly MessageParser<AllianceFightLeaveRequest> _parser;

		// Token: 0x04003D72 RID: 15730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D73 RID: 15731
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D74 RID: 15732
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D75 RID: 15733
		private static AllianceFightLeaveRequest WKofAtJl3pweCVO0GaOR;
	}
}
