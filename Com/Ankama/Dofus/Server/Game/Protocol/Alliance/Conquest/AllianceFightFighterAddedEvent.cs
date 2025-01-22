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
	// Token: 0x02000D91 RID: 3473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightFighterAddedEvent : IMessage<AllianceFightFighterAddedEvent>, IMessage, IEquatable<AllianceFightFighterAddedEvent>, IDeepCloneable<AllianceFightFighterAddedEvent>, IBufferMessage
	{
		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600A772 RID: 42866 RVA: 0x002945E8 File Offset: 0x002927E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFightFighterAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600A773 RID: 42867 RVA: 0x002945F8 File Offset: 0x002927F8
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

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x0600A774 RID: 42868 RVA: 0x00294608 File Offset: 0x00292808
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

		// Token: 0x0600A775 RID: 42869 RVA: 0x00294618 File Offset: 0x00292818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterAddedEvent()
		{
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x00294628 File Offset: 0x00292828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterAddedEvent(AllianceFightFighterAddedEvent other)
		{
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x00294638 File Offset: 0x00292838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x0600A778 RID: 42872 RVA: 0x00294648 File Offset: 0x00292848
		// (set) Token: 0x0600A779 RID: 42873 RVA: 0x00294658 File Offset: 0x00292858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x00294668 File Offset: 0x00292868
		// (set) Token: 0x0600A77B RID: 42875 RVA: 0x00294678 File Offset: 0x00292878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character Fighter
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

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x00294688 File Offset: 0x00292888
		// (set) Token: 0x0600A77D RID: 42877 RVA: 0x0029469C File Offset: 0x0029289C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x002946AC File Offset: 0x002928AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x002946BC File Offset: 0x002928BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightFighterAddedEvent other)
		{
			return true;
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x002946CC File Offset: 0x002928CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002946DC File Offset: 0x002928DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x002946EC File Offset: 0x002928EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x002946FC File Offset: 0x002928FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x0029470C File Offset: 0x0029290C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0029471C File Offset: 0x0029291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightFighterAddedEvent other)
		{
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x0029472C File Offset: 0x0029292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x0029473C File Offset: 0x0029293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x0029474C File Offset: 0x0029294C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightFighterAddedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					AllianceFightFighterAddedEvent._parser = new MessageParser<AllianceFightFighterAddedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x00294830 File Offset: 0x00292A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool boCxgDJlKgW4UfslaIwP()
		{
			return true;
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x00294838 File Offset: 0x00292A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightFighterAddedEvent yNuWb7JlISr5MHFDgNdC()
		{
			return null;
		}

		// Token: 0x04003D99 RID: 15769
		private static readonly MessageParser<AllianceFightFighterAddedEvent> _parser;

		// Token: 0x04003D9A RID: 15770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D9B RID: 15771
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D9C RID: 15772
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D9D RID: 15773
		public const int FighterFieldNumber = 2;

		// Token: 0x04003D9E RID: 15774
		private Character fighter_;

		// Token: 0x04003D9F RID: 15775
		public const int TeamFieldNumber = 3;

		// Token: 0x04003DA0 RID: 15776
		private Team team_;

		// Token: 0x04003DA1 RID: 15777
		private static AllianceFightFighterAddedEvent zmlLddJljwSQ75gH4KVY;
	}
}
