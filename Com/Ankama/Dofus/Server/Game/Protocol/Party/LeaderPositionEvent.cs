using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002B0 RID: 688
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaderPositionEvent : IMessage<LeaderPositionEvent>, IMessage, IEquatable<LeaderPositionEvent>, IDeepCloneable<LeaderPositionEvent>, IBufferMessage
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x001B97E4 File Offset: 0x001B79E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaderPositionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x001B97F4 File Offset: 0x001B79F4
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x001B9804 File Offset: 0x001B7A04
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

		// Token: 0x0600200D RID: 8205 RVA: 0x001B9814 File Offset: 0x001B7A14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LeaderPositionEvent()
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x001B9824 File Offset: 0x001B7A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LeaderPositionEvent(LeaderPositionEvent other)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x001B9834 File Offset: 0x001B7A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LeaderPositionEvent Clone()
		{
			return null;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x001B9844 File Offset: 0x001B7A44
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x001B9854 File Offset: 0x001B7A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x001B9864 File Offset: 0x001B7A64
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x001B9874 File Offset: 0x001B7A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapExtendedCoordinates Map
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x001B9884 File Offset: 0x001B7A84
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x001B9894 File Offset: 0x001B7A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellId
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

		// Token: 0x06002016 RID: 8214 RVA: 0x001B98A4 File Offset: 0x001B7AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x001B98B4 File Offset: 0x001B7AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LeaderPositionEvent other)
		{
			return true;
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x001B98C4 File Offset: 0x001B7AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x001B98D4 File Offset: 0x001B7AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x001B98E4 File Offset: 0x001B7AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x001B98F4 File Offset: 0x001B7AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x001B9904 File Offset: 0x001B7B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x001B9914 File Offset: 0x001B7B14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LeaderPositionEvent other)
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x001B9924 File Offset: 0x001B7B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x001B9934 File Offset: 0x001B7B34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x001B9944 File Offset: 0x001B7B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LeaderPositionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					LeaderPositionEvent._parser = new MessageParser<LeaderPositionEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x001B9A28 File Offset: 0x001B7C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D4HI4WO6OmFRqr9oXfhF()
		{
			return true;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x001B9A30 File Offset: 0x001B7C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LeaderPositionEvent StM6ZCO6JoJWtmGhbq1E()
		{
			return null;
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly MessageParser<LeaderPositionEvent> _parser;

		// Token: 0x04000B44 RID: 2884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B45 RID: 2885
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B46 RID: 2886
		private long playerId_;

		// Token: 0x04000B47 RID: 2887
		public const int MapFieldNumber = 2;

		// Token: 0x04000B48 RID: 2888
		private MapExtendedCoordinates map_;

		// Token: 0x04000B49 RID: 2889
		public const int CellIdFieldNumber = 3;

		// Token: 0x04000B4A RID: 2890
		private int cellId_;

		// Token: 0x04000B4B RID: 2891
		private static LeaderPositionEvent zY6QObO6RxwUj3l1y89C;
	}
}
