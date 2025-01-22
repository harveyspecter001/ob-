using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006A9 RID: 1705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementPossiblePositionsEvent : IMessage<FightPlacementPossiblePositionsEvent>, IMessage, IEquatable<FightPlacementPossiblePositionsEvent>, IDeepCloneable<FightPlacementPossiblePositionsEvent>, IBufferMessage
	{
		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x00209760 File Offset: 0x00207960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightPlacementPossiblePositionsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x00209770 File Offset: 0x00207970
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

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x00209780 File Offset: 0x00207980
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

		// Token: 0x0600533F RID: 21311 RVA: 0x00209790 File Offset: 0x00207990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPossiblePositionsEvent()
		{
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x002097A0 File Offset: 0x002079A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPossiblePositionsEvent(FightPlacementPossiblePositionsEvent other)
		{
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x002097B0 File Offset: 0x002079B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementPossiblePositionsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x002097C0 File Offset: 0x002079C0
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x002097D0 File Offset: 0x002079D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightStartingPositions StartingPositions
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

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x002097E0 File Offset: 0x002079E0
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x002097F4 File Offset: 0x002079F4
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

		// Token: 0x06005346 RID: 21318 RVA: 0x00209804 File Offset: 0x00207A04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00209814 File Offset: 0x00207A14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementPossiblePositionsEvent other)
		{
			return true;
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00209824 File Offset: 0x00207A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00209834 File Offset: 0x00207A34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00209844 File Offset: 0x00207A44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00209854 File Offset: 0x00207A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00209864 File Offset: 0x00207A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00209874 File Offset: 0x00207A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementPossiblePositionsEvent other)
		{
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00209884 File Offset: 0x00207A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00209894 File Offset: 0x00207A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x002098A4 File Offset: 0x00207AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementPossiblePositionsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					FightPlacementPossiblePositionsEvent._parser = new MessageParser<FightPlacementPossiblePositionsEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00209988 File Offset: 0x00207B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ArAg7rOSB4UGD4jqm7gq()
		{
			return true;
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00209990 File Offset: 0x00207B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementPossiblePositionsEvent exGZtlOSeKitaKegWWUA()
		{
			return null;
		}

		// Token: 0x04001D58 RID: 7512
		private static readonly MessageParser<FightPlacementPossiblePositionsEvent> _parser;

		// Token: 0x04001D59 RID: 7513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D5A RID: 7514
		public const int StartingPositionsFieldNumber = 1;

		// Token: 0x04001D5B RID: 7515
		private FightStartingPositions startingPositions_;

		// Token: 0x04001D5C RID: 7516
		public const int TeamFieldNumber = 2;

		// Token: 0x04001D5D RID: 7517
		private Team team_;

		// Token: 0x04001D5E RID: 7518
		internal static FightPlacementPossiblePositionsEvent ed9tdOOSAN4kxWBvILQU;
	}
}
