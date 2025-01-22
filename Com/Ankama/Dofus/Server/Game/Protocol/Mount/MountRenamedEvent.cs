using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000375 RID: 885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountRenamedEvent : IMessage<MountRenamedEvent>, IMessage, IEquatable<MountRenamedEvent>, IDeepCloneable<MountRenamedEvent>, IBufferMessage
	{
		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x001C7DF8 File Offset: 0x001C5FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountRenamedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x001C7E08 File Offset: 0x001C6008
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x001C7E18 File Offset: 0x001C6018
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

		// Token: 0x0600298E RID: 10638 RVA: 0x001C7E28 File Offset: 0x001C6028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedEvent()
		{
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x001C7E38 File Offset: 0x001C6038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedEvent(MountRenamedEvent other)
		{
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x001C7E48 File Offset: 0x001C6048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x001C7E58 File Offset: 0x001C6058
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x001C7E68 File Offset: 0x001C6068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x001C7E78 File Offset: 0x001C6078
		// (set) Token: 0x06002994 RID: 10644 RVA: 0x001C7E88 File Offset: 0x001C6088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x06002995 RID: 10645 RVA: 0x001C7E98 File Offset: 0x001C6098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x001C7EA8 File Offset: 0x001C60A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountRenamedEvent other)
		{
			return true;
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x001C7EB8 File Offset: 0x001C60B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x001C7EC8 File Offset: 0x001C60C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x001C7ED8 File Offset: 0x001C60D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x001C7EE8 File Offset: 0x001C60E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x001C7EF8 File Offset: 0x001C60F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x001C7F08 File Offset: 0x001C6108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountRenamedEvent other)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x001C7F18 File Offset: 0x001C6118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x001C7F28 File Offset: 0x001C6128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x001C7F38 File Offset: 0x001C6138
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountRenamedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MountRenamedEvent._parser = new MessageParser<MountRenamedEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
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
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x001C8004 File Offset: 0x001C6204
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xH1BLaOrskQFWPcYCMPg()
		{
			return true;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x001C800C File Offset: 0x001C620C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountRenamedEvent E12oCjOrdwc43gpv6AXH()
		{
			return null;
		}

		// Token: 0x04000EB3 RID: 3763
		private static readonly MessageParser<MountRenamedEvent> _parser;

		// Token: 0x04000EB4 RID: 3764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EB5 RID: 3765
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000EB6 RID: 3766
		private int mountId_;

		// Token: 0x04000EB7 RID: 3767
		public const int NameFieldNumber = 2;

		// Token: 0x04000EB8 RID: 3768
		private string name_;

		// Token: 0x04000EB9 RID: 3769
		private static MountRenamedEvent LDB4msOrgb8EobRs9P4x;
	}
}
