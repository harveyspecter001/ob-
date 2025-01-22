using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DC1 RID: 3521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementRewardRequest : IMessage<AchievementRewardRequest>, IMessage, IEquatable<AchievementRewardRequest>, IDeepCloneable<AchievementRewardRequest>, IBufferMessage
	{
		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600A99D RID: 43421 RVA: 0x00297DCC File Offset: 0x00295FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementRewardRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x00297DDC File Offset: 0x00295FDC
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

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600A99F RID: 43423 RVA: 0x00297DEC File Offset: 0x00295FEC
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

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x00297DFC File Offset: 0x00295FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardRequest()
		{
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00297E0C File Offset: 0x0029600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardRequest(AchievementRewardRequest other)
		{
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00297E1C File Offset: 0x0029601C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardRequest Clone()
		{
			return null;
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x0600A9A3 RID: 43427 RVA: 0x00297E2C File Offset: 0x0029602C
		// (set) Token: 0x0600A9A4 RID: 43428 RVA: 0x00297E3C File Offset: 0x0029603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AchievementId
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

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00297E4C File Offset: 0x0029604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00297E5C File Offset: 0x0029605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementRewardRequest other)
		{
			return true;
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x00297E6C File Offset: 0x0029606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00297E7C File Offset: 0x0029607C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x00297E8C File Offset: 0x0029608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x00297E9C File Offset: 0x0029609C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x00297EAC File Offset: 0x002960AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x00297EBC File Offset: 0x002960BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementRewardRequest other)
		{
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x00297ECC File Offset: 0x002960CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x00297EDC File Offset: 0x002960DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x00297EEC File Offset: 0x002960EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementRewardRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_35;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_4E;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						return;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				IL_4E:
				AchievementRewardRequest._parser = new MessageParser<AchievementRewardRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x00297FC0 File Offset: 0x002961C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wxgAf9JcXBhKQ7NHoJ3N()
		{
			return true;
		}

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x00297FC8 File Offset: 0x002961C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementRewardRequest bS3feZJcNt2XAHdBcDyt()
		{
			return null;
		}

		// Token: 0x04003E52 RID: 15954
		private static readonly MessageParser<AchievementRewardRequest> _parser;

		// Token: 0x04003E53 RID: 15955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E54 RID: 15956
		public const int AchievementIdFieldNumber = 1;

		// Token: 0x04003E55 RID: 15957
		private int achievementId_;

		// Token: 0x04003E56 RID: 15958
		private static AchievementRewardRequest y09rQmJcEmhQ0CKGD7D7;
	}
}
