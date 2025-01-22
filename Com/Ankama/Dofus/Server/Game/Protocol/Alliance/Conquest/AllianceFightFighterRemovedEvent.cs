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
	// Token: 0x02000D93 RID: 3475
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightFighterRemovedEvent : IMessage<AllianceFightFighterRemovedEvent>, IMessage, IEquatable<AllianceFightFighterRemovedEvent>, IDeepCloneable<AllianceFightFighterRemovedEvent>, IBufferMessage
	{
		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x00294840 File Offset: 0x00292A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightFighterRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x00294850 File Offset: 0x00292A50
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

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x00294860 File Offset: 0x00292A60
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

		// Token: 0x0600A793 RID: 42899 RVA: 0x00294870 File Offset: 0x00292A70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterRemovedEvent()
		{
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x00294880 File Offset: 0x00292A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterRemovedEvent(AllianceFightFighterRemovedEvent other)
		{
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x00294890 File Offset: 0x00292A90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightFighterRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600A796 RID: 42902 RVA: 0x002948A0 File Offset: 0x00292AA0
		// (set) Token: 0x0600A797 RID: 42903 RVA: 0x002948B0 File Offset: 0x00292AB0
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

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600A798 RID: 42904 RVA: 0x002948C0 File Offset: 0x00292AC0
		// (set) Token: 0x0600A799 RID: 42905 RVA: 0x002948D0 File Offset: 0x00292AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long FighterId
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

		// Token: 0x0600A79A RID: 42906 RVA: 0x002948E0 File Offset: 0x00292AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x002948F0 File Offset: 0x00292AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightFighterRemovedEvent other)
		{
			return true;
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x00294900 File Offset: 0x00292B00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x00294910 File Offset: 0x00292B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x00294920 File Offset: 0x00292B20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x00294930 File Offset: 0x00292B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x00294940 File Offset: 0x00292B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x00294950 File Offset: 0x00292B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightFighterRemovedEvent other)
		{
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x00294960 File Offset: 0x00292B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x00294970 File Offset: 0x00292B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00294980 File Offset: 0x00292B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightFighterRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceFightFighterRemovedEvent._parser = new MessageParser<AllianceFightFighterRemovedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x00294A64 File Offset: 0x00292C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WbKhcJJllodmk7741hNf()
		{
			return true;
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00294A6C File Offset: 0x00292C6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightFighterRemovedEvent jDMZHuJlcn1xPhsmFZ2S()
		{
			return null;
		}

		// Token: 0x04003DA4 RID: 15780
		private static readonly MessageParser<AllianceFightFighterRemovedEvent> _parser;

		// Token: 0x04003DA5 RID: 15781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA6 RID: 15782
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003DA7 RID: 15783
		private SocialFightInformation fightInformation_;

		// Token: 0x04003DA8 RID: 15784
		public const int FighterIdFieldNumber = 2;

		// Token: 0x04003DA9 RID: 15785
		private long fighterId_;

		// Token: 0x04003DAA RID: 15786
		internal static AllianceFightFighterRemovedEvent orftemJlkR8mAiW6GGgv;
	}
}
