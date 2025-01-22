using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E36 RID: 3638
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForceAccountStatus : IMessage<ForceAccountStatus>, IMessage, IEquatable<ForceAccountStatus>, IDeepCloneable<ForceAccountStatus>, IBufferMessage
	{
		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x002A07D0 File Offset: 0x0029E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForceAccountStatus> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x002A07E0 File Offset: 0x0029E9E0
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

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600AEC1 RID: 44737 RVA: 0x002A07F0 File Offset: 0x0029E9F0
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

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x002A0800 File Offset: 0x0029EA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountStatus()
		{
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002A0810 File Offset: 0x0029EA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountStatus(ForceAccountStatus other)
		{
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x002A0820 File Offset: 0x0029EA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForceAccountStatus Clone()
		{
			return null;
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600AEC5 RID: 44741 RVA: 0x002A0830 File Offset: 0x0029EA30
		// (set) Token: 0x0600AEC6 RID: 44742 RVA: 0x002A0840 File Offset: 0x0029EA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsForced
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600AEC7 RID: 44743 RVA: 0x002A0850 File Offset: 0x0029EA50
		// (set) Token: 0x0600AEC8 RID: 44744 RVA: 0x002A0860 File Offset: 0x0029EA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ForcedAccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600AEC9 RID: 44745 RVA: 0x002A0870 File Offset: 0x0029EA70
		// (set) Token: 0x0600AECA RID: 44746 RVA: 0x002A0880 File Offset: 0x0029EA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ForcedAccountNickname
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

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600AECB RID: 44747 RVA: 0x002A0890 File Offset: 0x0029EA90
		// (set) Token: 0x0600AECC RID: 44748 RVA: 0x002A08A0 File Offset: 0x0029EAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ForcedAccountTag
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

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x002A08B0 File Offset: 0x0029EAB0
		// (set) Token: 0x0600AECE RID: 44750 RVA: 0x002A08C0 File Offset: 0x0029EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerList ServerList
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

		// Token: 0x0600AECF RID: 44751 RVA: 0x002A08D0 File Offset: 0x0029EAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x002A08E0 File Offset: 0x0029EAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForceAccountStatus other)
		{
			return true;
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x002A08F0 File Offset: 0x0029EAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002A0900 File Offset: 0x0029EB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x002A0910 File Offset: 0x0029EB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x002A0920 File Offset: 0x0029EB20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x002A0930 File Offset: 0x0029EB30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x002A0940 File Offset: 0x0029EB40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForceAccountStatus other)
		{
		}

		// Token: 0x0600AED7 RID: 44759 RVA: 0x002A0950 File Offset: 0x0029EB50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x002A0960 File Offset: 0x0029EB60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x002A0970 File Offset: 0x0029EB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForceAccountStatus()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5F;
					case 3:
						ForceAccountStatus._parser = new MessageParser<ForceAccountStatus>(() => null);
						num2 = 4;
						continue;
					case 4:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 2;
					}
				}
				IL_5F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x002A0A40 File Offset: 0x0029EC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UaHsNSJvd229iYQLHBky()
		{
			return true;
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x002A0A48 File Offset: 0x0029EC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForceAccountStatus GNhOdEJv96gctK0MxfOu()
		{
			return null;
		}

		// Token: 0x04004057 RID: 16471
		private static readonly MessageParser<ForceAccountStatus> _parser;

		// Token: 0x04004058 RID: 16472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004059 RID: 16473
		public const int IsForcedFieldNumber = 1;

		// Token: 0x0400405A RID: 16474
		private bool isForced_;

		// Token: 0x0400405B RID: 16475
		public const int ForcedAccountIdFieldNumber = 2;

		// Token: 0x0400405C RID: 16476
		private long forcedAccountId_;

		// Token: 0x0400405D RID: 16477
		public const int ForcedAccountNicknameFieldNumber = 3;

		// Token: 0x0400405E RID: 16478
		private string forcedAccountNickname_;

		// Token: 0x0400405F RID: 16479
		public const int ForcedAccountTagFieldNumber = 4;

		// Token: 0x04004060 RID: 16480
		private string forcedAccountTag_;

		// Token: 0x04004061 RID: 16481
		public const int ServerListFieldNumber = 5;

		// Token: 0x04004062 RID: 16482
		private ServerList serverList_;

		// Token: 0x04004063 RID: 16483
		private static ForceAccountStatus LVRiImJvsX8N9GoUsMhG;
	}
}
