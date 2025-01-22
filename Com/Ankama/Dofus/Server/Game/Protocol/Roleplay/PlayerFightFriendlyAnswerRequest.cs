using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200017A RID: 378
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerFightFriendlyAnswerRequest : IMessage<PlayerFightFriendlyAnswerRequest>, IMessage, IEquatable<PlayerFightFriendlyAnswerRequest>, IDeepCloneable<PlayerFightFriendlyAnswerRequest>, IBufferMessage
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x001A0AEC File Offset: 0x0019ECEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerFightFriendlyAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x001A0AFC File Offset: 0x0019ECFC
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x001A0B0C File Offset: 0x0019ED0C
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

		// Token: 0x06001147 RID: 4423 RVA: 0x001A0B1C File Offset: 0x0019ED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnswerRequest()
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x001A0B2C File Offset: 0x0019ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnswerRequest(PlayerFightFriendlyAnswerRequest other)
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x001A0B3C File Offset: 0x0019ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x001A0B4C File Offset: 0x0019ED4C
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x001A0B5C File Offset: 0x0019ED5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x001A0B6C File Offset: 0x0019ED6C
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x001A0B7C File Offset: 0x0019ED7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accept
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

		// Token: 0x0600114E RID: 4430 RVA: 0x001A0B8C File Offset: 0x0019ED8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x001A0B9C File Offset: 0x0019ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerFightFriendlyAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x001A0BAC File Offset: 0x0019EDAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x001A0BBC File Offset: 0x0019EDBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x001A0BCC File Offset: 0x0019EDCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x001A0BDC File Offset: 0x0019EDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x001A0BEC File Offset: 0x0019EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x001A0BFC File Offset: 0x0019EDFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerFightFriendlyAnswerRequest other)
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x001A0C0C File Offset: 0x0019EE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x001A0C1C File Offset: 0x0019EE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x001A0C2C File Offset: 0x0019EE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerFightFriendlyAnswerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PlayerFightFriendlyAnswerRequest._parser = new MessageParser<PlayerFightFriendlyAnswerRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x001A0D10 File Offset: 0x0019EF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u78pVOOvcwYKrt58yFRu()
		{
			return true;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x001A0D18 File Offset: 0x0019EF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerFightFriendlyAnswerRequest iQbhOuOvUwSGZHKxkWfQ()
		{
			return null;
		}

		// Token: 0x04000647 RID: 1607
		private static readonly MessageParser<PlayerFightFriendlyAnswerRequest> _parser;

		// Token: 0x04000648 RID: 1608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000649 RID: 1609
		public const int FightIdFieldNumber = 1;

		// Token: 0x0400064A RID: 1610
		private int fightId_;

		// Token: 0x0400064B RID: 1611
		public const int AcceptFieldNumber = 2;

		// Token: 0x0400064C RID: 1612
		private bool accept_;

		// Token: 0x0400064D RID: 1613
		internal static PlayerFightFriendlyAnswerRequest ecu8sDOvlOtwAYps9yXB;
	}
}
