using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000598 RID: 1432
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightDetailsEvent : IMessage<MapRunningFightDetailsEvent>, IMessage, IEquatable<MapRunningFightDetailsEvent>, IDeepCloneable<MapRunningFightDetailsEvent>, IBufferMessage
	{
		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x001F71F8 File Offset: 0x001F53F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapRunningFightDetailsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x001F7208 File Offset: 0x001F5408
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

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x001F7218 File Offset: 0x001F5418
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

		// Token: 0x06004512 RID: 17682 RVA: 0x001F7228 File Offset: 0x001F5428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsEvent()
		{
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x001F7238 File Offset: 0x001F5438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsEvent(MapRunningFightDetailsEvent other)
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x001F7248 File Offset: 0x001F5448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x001F7258 File Offset: 0x001F5458
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x001F7268 File Offset: 0x001F5468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightId
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x001F7278 File Offset: 0x001F5478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FighterLightInformation> Attackers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x001F7288 File Offset: 0x001F5488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FighterLightInformation> Defenders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x001F7298 File Offset: 0x001F5498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x001F72A8 File Offset: 0x001F54A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightDetailsEvent other)
		{
			return true;
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x001F72B8 File Offset: 0x001F54B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x001F72C8 File Offset: 0x001F54C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x001F72D8 File Offset: 0x001F54D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001F72E8 File Offset: 0x001F54E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x001F72F8 File Offset: 0x001F54F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001F7308 File Offset: 0x001F5508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightDetailsEvent other)
		{
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x001F7318 File Offset: 0x001F5518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x001F7328 File Offset: 0x001F5528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001F7338 File Offset: 0x001F5538
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightDetailsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MapRunningFightDetailsEvent._repeated_attackers_codec = FieldCodec.ForMessage<FighterLightInformation>(18U, zLDwDtmCOEV8JwgAeDVJ.XVInXhlssT(zLDwDtmCOEV8JwgAeDVJ.eFZmCJQoIFh));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					MapRunningFightDetailsEvent._repeated_defenders_codec = FieldCodec.ForMessage<FighterLightInformation>(26U, zLDwDtmCOEV8JwgAeDVJ.XVInXhlssT(zLDwDtmCOEV8JwgAeDVJ.eFZmCJQoIFh));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					MapRunningFightDetailsEvent._parser = new MessageParser<MapRunningFightDetailsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				break;
			}
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001F7478 File Offset: 0x001F5678
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tGbc2GOYD19AH9eDdfvh()
		{
			return true;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x001F7480 File Offset: 0x001F5680
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightDetailsEvent tGV3T5OYtF533PEHG97x()
		{
			return null;
		}

		// Token: 0x040017BA RID: 6074
		private static readonly MessageParser<MapRunningFightDetailsEvent> _parser;

		// Token: 0x040017BB RID: 6075
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017BC RID: 6076
		public const int FightIdFieldNumber = 1;

		// Token: 0x040017BD RID: 6077
		private int fightId_;

		// Token: 0x040017BE RID: 6078
		public const int AttackersFieldNumber = 2;

		// Token: 0x040017BF RID: 6079
		private static readonly FieldCodec<FighterLightInformation> _repeated_attackers_codec;

		// Token: 0x040017C0 RID: 6080
		private readonly RepeatedField<FighterLightInformation> attackers_;

		// Token: 0x040017C1 RID: 6081
		public const int DefendersFieldNumber = 3;

		// Token: 0x040017C2 RID: 6082
		private static readonly FieldCodec<FighterLightInformation> _repeated_defenders_codec;

		// Token: 0x040017C3 RID: 6083
		private readonly RepeatedField<FighterLightInformation> defenders_;

		// Token: 0x040017C4 RID: 6084
		internal static MapRunningFightDetailsEvent En4NfSOYCGQiThMCpnq5;
	}
}
