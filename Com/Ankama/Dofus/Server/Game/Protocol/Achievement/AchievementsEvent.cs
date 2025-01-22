using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DC3 RID: 3523
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsEvent : IMessage<AchievementsEvent>, IMessage, IEquatable<AchievementsEvent>, IDeepCloneable<AchievementsEvent>, IBufferMessage
	{
		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x0600A9B7 RID: 43447 RVA: 0x00297FD0 File Offset: 0x002961D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x0600A9B8 RID: 43448 RVA: 0x00297FE0 File Offset: 0x002961E0
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

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x00297FF0 File Offset: 0x002961F0
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

		// Token: 0x0600A9BA RID: 43450 RVA: 0x00298000 File Offset: 0x00296200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsEvent()
		{
		}

		// Token: 0x0600A9BB RID: 43451 RVA: 0x00298010 File Offset: 0x00296210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsEvent(AchievementsEvent other)
		{
		}

		// Token: 0x0600A9BC RID: 43452 RVA: 0x00298020 File Offset: 0x00296220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x0600A9BD RID: 43453 RVA: 0x00298030 File Offset: 0x00296230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievedAchievement> AchievedAchievements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x00298040 File Offset: 0x00296240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x00298050 File Offset: 0x00296250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsEvent other)
		{
			return true;
		}

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x00298060 File Offset: 0x00296260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A9C1 RID: 43457 RVA: 0x00298070 File Offset: 0x00296270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A9C2 RID: 43458 RVA: 0x00298080 File Offset: 0x00296280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A9C3 RID: 43459 RVA: 0x00298090 File Offset: 0x00296290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A9C4 RID: 43460 RVA: 0x002980A0 File Offset: 0x002962A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x002980B0 File Offset: 0x002962B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsEvent other)
		{
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x002980C0 File Offset: 0x002962C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x002980D0 File Offset: 0x002962D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x002980E0 File Offset: 0x002962E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_39;
					case 4:
						AchievementsEvent._repeated_achievedAchievements_codec = FieldCodec.ForMessage<AchievedAchievement>(10U, w5llKX3sFIpk48KEAP8K.XVInXhlssT(w5llKX3sFIpk48KEAP8K.fFS3szddVkB));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						AchievementsEvent._parser = new MessageParser<AchievementsEvent>(() => null);
						num2 = 4;
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
				}
				IL_39:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x002981D4 File Offset: 0x002963D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H1Q5TBJc46dVRPe23LV0()
		{
			return true;
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x002981DC File Offset: 0x002963DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsEvent EDDtQCJcjWCsXlNnufXR()
		{
			return null;
		}

		// Token: 0x04003E59 RID: 15961
		private static readonly MessageParser<AchievementsEvent> _parser;

		// Token: 0x04003E5A RID: 15962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E5B RID: 15963
		public const int AchievedAchievementsFieldNumber = 1;

		// Token: 0x04003E5C RID: 15964
		private static readonly FieldCodec<AchievedAchievement> _repeated_achievedAchievements_codec;

		// Token: 0x04003E5D RID: 15965
		private readonly RepeatedField<AchievedAchievement> achievedAchievements_;

		// Token: 0x04003E5E RID: 15966
		private static AchievementsEvent zVcpkkJcxjtQT49fexvk;
	}
}
