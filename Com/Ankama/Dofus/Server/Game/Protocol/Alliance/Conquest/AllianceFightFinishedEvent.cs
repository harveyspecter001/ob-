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
	// Token: 0x02000D8D RID: 3469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightFinishedEvent : IMessage<AllianceFightFinishedEvent>, IMessage, IEquatable<AllianceFightFinishedEvent>, IDeepCloneable<AllianceFightFinishedEvent>, IBufferMessage
	{
		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600A73C RID: 42812 RVA: 0x0029418C File Offset: 0x0029238C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFightFinishedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x0029419C File Offset: 0x0029239C
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

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x002941AC File Offset: 0x002923AC
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

		// Token: 0x0600A73F RID: 42815 RVA: 0x002941BC File Offset: 0x002923BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFinishedEvent()
		{
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x002941CC File Offset: 0x002923CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFinishedEvent(AllianceFightFinishedEvent other)
		{
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x002941DC File Offset: 0x002923DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFinishedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x002941EC File Offset: 0x002923EC
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x002941FC File Offset: 0x002923FC
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

		// Token: 0x0600A744 RID: 42820 RVA: 0x0029420C File Offset: 0x0029240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x0029421C File Offset: 0x0029241C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightFinishedEvent other)
		{
			return true;
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x0029422C File Offset: 0x0029242C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x0029423C File Offset: 0x0029243C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x0029424C File Offset: 0x0029244C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x0029425C File Offset: 0x0029245C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x0029426C File Offset: 0x0029246C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x0029427C File Offset: 0x0029247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightFinishedEvent other)
		{
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x0029428C File Offset: 0x0029248C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x0029429C File Offset: 0x0029249C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x002942AC File Offset: 0x002924AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightFinishedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					AllianceFightFinishedEvent._parser = new MessageParser<AllianceFightFinishedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A74F RID: 42831 RVA: 0x002943A4 File Offset: 0x002925A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NjEv1dJlEaI7lNOD4dx0()
		{
			return true;
		}

		// Token: 0x0600A750 RID: 42832 RVA: 0x002943AC File Offset: 0x002925AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightFinishedEvent lQcqIVJlXS9GlsAgPWGP()
		{
			return null;
		}

		// Token: 0x04003D89 RID: 15753
		private static readonly MessageParser<AllianceFightFinishedEvent> _parser;

		// Token: 0x04003D8A RID: 15754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D8B RID: 15755
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D8C RID: 15756
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D8D RID: 15757
		private static AllianceFightFinishedEvent c9FPhKJl2sw4RSg8jZfW;
	}
}
