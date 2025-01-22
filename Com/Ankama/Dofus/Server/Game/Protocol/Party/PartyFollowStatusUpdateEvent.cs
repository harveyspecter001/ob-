using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002EE RID: 750
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyFollowStatusUpdateEvent : IMessage<PartyFollowStatusUpdateEvent>, IMessage, IEquatable<PartyFollowStatusUpdateEvent>, IDeepCloneable<PartyFollowStatusUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x001BD230 File Offset: 0x001BB430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyFollowStatusUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x001BD240 File Offset: 0x001BB440
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x001BD250 File Offset: 0x001BB450
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

		// Token: 0x060022F6 RID: 8950 RVA: 0x001BD260 File Offset: 0x001BB460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowStatusUpdateEvent()
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x001BD270 File Offset: 0x001BB470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowStatusUpdateEvent(PartyFollowStatusUpdateEvent other)
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x001BD280 File Offset: 0x001BB480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowStatusUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x001BD290 File Offset: 0x001BB490
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x001BD2A0 File Offset: 0x001BB4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x001BD2B0 File Offset: 0x001BB4B0
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x001BD2C0 File Offset: 0x001BB4C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Success
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x001BD2D0 File Offset: 0x001BB4D0
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x001BD2E0 File Offset: 0x001BB4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFollowed
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x001BD2F0 File Offset: 0x001BB4F0
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x001BD300 File Offset: 0x001BB500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long FollowedId
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

		// Token: 0x06002301 RID: 8961 RVA: 0x001BD310 File Offset: 0x001BB510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x001BD320 File Offset: 0x001BB520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyFollowStatusUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x001BD330 File Offset: 0x001BB530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x001BD340 File Offset: 0x001BB540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x001BD350 File Offset: 0x001BB550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x001BD360 File Offset: 0x001BB560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x001BD370 File Offset: 0x001BB570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x001BD380 File Offset: 0x001BB580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyFollowStatusUpdateEvent other)
		{
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x001BD390 File Offset: 0x001BB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x001BD3A0 File Offset: 0x001BB5A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x001BD3B0 File Offset: 0x001BB5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyFollowStatusUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PartyFollowStatusUpdateEvent._parser = new MessageParser<PartyFollowStatusUpdateEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x001BD494 File Offset: 0x001BB694
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w2K7M4OLkvmCXkyNOLq9()
		{
			return true;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x001BD49C File Offset: 0x001BB69C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyFollowStatusUpdateEvent q8nK00OLlCYl7VPd0EKF()
		{
			return null;
		}

		// Token: 0x04000C5B RID: 3163
		private static readonly MessageParser<PartyFollowStatusUpdateEvent> _parser;

		// Token: 0x04000C5C RID: 3164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C5D RID: 3165
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C5E RID: 3166
		private int partyId_;

		// Token: 0x04000C5F RID: 3167
		public const int SuccessFieldNumber = 2;

		// Token: 0x04000C60 RID: 3168
		private bool success_;

		// Token: 0x04000C61 RID: 3169
		public const int IsFollowedFieldNumber = 3;

		// Token: 0x04000C62 RID: 3170
		private bool isFollowed_;

		// Token: 0x04000C63 RID: 3171
		public const int FollowedIdFieldNumber = 4;

		// Token: 0x04000C64 RID: 3172
		private long followedId_;

		// Token: 0x04000C65 RID: 3173
		internal static PartyFollowStatusUpdateEvent N1GKh1OLIVdAOB39QDwH;
	}
}
