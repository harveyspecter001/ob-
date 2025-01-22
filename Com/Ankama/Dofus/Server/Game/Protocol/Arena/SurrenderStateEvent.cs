using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C2E RID: 3118
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderStateEvent : IMessage<SurrenderStateEvent>, IMessage, IEquatable<SurrenderStateEvent>, IDeepCloneable<SurrenderStateEvent>, IBufferMessage
	{
		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x00277AD8 File Offset: 0x00275CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurrenderStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x00277AE8 File Offset: 0x00275CE8
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

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x00277AF8 File Offset: 0x00275CF8
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

		// Token: 0x060095E2 RID: 38370 RVA: 0x00277B08 File Offset: 0x00275D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderStateEvent()
		{
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x00277B18 File Offset: 0x00275D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderStateEvent(SurrenderStateEvent other)
		{
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x00277B28 File Offset: 0x00275D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderStateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x00277B38 File Offset: 0x00275D38
		// (set) Token: 0x060095E6 RID: 38374 RVA: 0x00277B48 File Offset: 0x00275D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PermitSurrender
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

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x00277B58 File Offset: 0x00275D58
		// (set) Token: 0x060095E8 RID: 38376 RVA: 0x00277B68 File Offset: 0x00275D68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool PermitVote
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

		// Token: 0x060095E9 RID: 38377 RVA: 0x00277B78 File Offset: 0x00275D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00277B88 File Offset: 0x00275D88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderStateEvent other)
		{
			return true;
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x00277B98 File Offset: 0x00275D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00277BA8 File Offset: 0x00275DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00277BB8 File Offset: 0x00275DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00277BC8 File Offset: 0x00275DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00277BD8 File Offset: 0x00275DD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x00277BE8 File Offset: 0x00275DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderStateEvent other)
		{
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x00277BF8 File Offset: 0x00275DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x00277C08 File Offset: 0x00275E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x00277C18 File Offset: 0x00275E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderStateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					SurrenderStateEvent._parser = new MessageParser<SurrenderStateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x00277CFC File Offset: 0x00275EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LQyRKUJXYbPLnhk3GtlD()
		{
			return true;
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00277D04 File Offset: 0x00275F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderStateEvent zCjPoUJXbwjGu8hOfNHA()
		{
			return null;
		}

		// Token: 0x040037CD RID: 14285
		private static readonly MessageParser<SurrenderStateEvent> _parser;

		// Token: 0x040037CE RID: 14286
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037CF RID: 14287
		public const int PermitSurrenderFieldNumber = 1;

		// Token: 0x040037D0 RID: 14288
		private bool permitSurrender_;

		// Token: 0x040037D1 RID: 14289
		public const int PermitVoteFieldNumber = 2;

		// Token: 0x040037D2 RID: 14290
		private bool permitVote_;

		// Token: 0x040037D3 RID: 14291
		private static SurrenderStateEvent wYjtyIJXH8Di1ebvAISF;
	}
}
