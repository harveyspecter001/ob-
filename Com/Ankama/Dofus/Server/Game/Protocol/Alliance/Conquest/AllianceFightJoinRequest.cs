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
	// Token: 0x02000D83 RID: 3459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightJoinRequest : IMessage<AllianceFightJoinRequest>, IMessage, IEquatable<AllianceFightJoinRequest>, IDeepCloneable<AllianceFightJoinRequest>, IBufferMessage
	{
		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600A6B7 RID: 42679 RVA: 0x00293710 File Offset: 0x00291910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFightJoinRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x00293720 File Offset: 0x00291920
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

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600A6B9 RID: 42681 RVA: 0x00293730 File Offset: 0x00291930
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

		// Token: 0x0600A6BA RID: 42682 RVA: 0x00293740 File Offset: 0x00291940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightJoinRequest()
		{
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x00293750 File Offset: 0x00291950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightJoinRequest(AllianceFightJoinRequest other)
		{
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x00293760 File Offset: 0x00291960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightJoinRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600A6BD RID: 42685 RVA: 0x00293770 File Offset: 0x00291970
		// (set) Token: 0x0600A6BE RID: 42686 RVA: 0x00293780 File Offset: 0x00291980
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

		// Token: 0x0600A6BF RID: 42687 RVA: 0x00293790 File Offset: 0x00291990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x002937A0 File Offset: 0x002919A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightJoinRequest other)
		{
			return true;
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x002937B0 File Offset: 0x002919B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x002937C0 File Offset: 0x002919C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x002937D0 File Offset: 0x002919D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x002937E0 File Offset: 0x002919E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x002937F0 File Offset: 0x002919F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A6C6 RID: 42694 RVA: 0x00293800 File Offset: 0x00291A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightJoinRequest other)
		{
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x00293810 File Offset: 0x00291A10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x00293820 File Offset: 0x00291A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x00293830 File Offset: 0x00291A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightJoinRequest()
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
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						AllianceFightJoinRequest._parser = new MessageParser<AllianceFightJoinRequest>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 2;
						}
						break;
					case 4:
						goto IL_AB;
					}
				}
				IL_AB:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x00293900 File Offset: 0x00291B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OBhN0NJlnHNrVPP0ElB7()
		{
			return true;
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x00293908 File Offset: 0x00291B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightJoinRequest spGwk7JlmmkdQNYBVueD()
		{
			return null;
		}

		// Token: 0x04003D61 RID: 15713
		private static readonly MessageParser<AllianceFightJoinRequest> _parser;

		// Token: 0x04003D62 RID: 15714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D63 RID: 15715
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D64 RID: 15716
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D65 RID: 15717
		internal static AllianceFightJoinRequest PvpbC9JlfkanuvbWkCPR;
	}
}
