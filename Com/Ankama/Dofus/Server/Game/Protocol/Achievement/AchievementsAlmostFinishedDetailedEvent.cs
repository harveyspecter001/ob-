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
	// Token: 0x02000DC9 RID: 3529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsAlmostFinishedDetailedEvent : IMessage<AchievementsAlmostFinishedDetailedEvent>, IMessage, IEquatable<AchievementsAlmostFinishedDetailedEvent>, IDeepCloneable<AchievementsAlmostFinishedDetailedEvent>, IBufferMessage
	{
		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x00298624 File Offset: 0x00296824
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsAlmostFinishedDetailedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600AA04 RID: 43524 RVA: 0x00298634 File Offset: 0x00296834
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

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x0600AA05 RID: 43525 RVA: 0x00298644 File Offset: 0x00296844
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

		// Token: 0x0600AA06 RID: 43526 RVA: 0x00298654 File Offset: 0x00296854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedEvent()
		{
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x00298664 File Offset: 0x00296864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedEvent(AchievementsAlmostFinishedDetailedEvent other)
		{
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x00298674 File Offset: 0x00296874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x00298684 File Offset: 0x00296884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Achievement> AlmostFinishedAchievements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x00298694 File Offset: 0x00296894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x002986A4 File Offset: 0x002968A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsAlmostFinishedDetailedEvent other)
		{
			return true;
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x002986B4 File Offset: 0x002968B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x002986C4 File Offset: 0x002968C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x002986D4 File Offset: 0x002968D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x002986E4 File Offset: 0x002968E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002986F4 File Offset: 0x002968F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x00298704 File Offset: 0x00296904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsAlmostFinishedDetailedEvent other)
		{
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x00298714 File Offset: 0x00296914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x00298724 File Offset: 0x00296924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x00298734 File Offset: 0x00296934
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsAlmostFinishedDetailedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_E4;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AchievementsAlmostFinishedDetailedEvent._repeated_almostFinishedAchievements_codec = FieldCodec.ForMessage<Achievement>(10U, ghkG7R3su8HaLttAP1sQ.XVInXhlssT(ghkG7R3su8HaLttAP1sQ.Y0G3s8uS0yr));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 5:
						AchievementsAlmostFinishedDetailedEvent._parser = new MessageParser<AchievementsAlmostFinishedDetailedEvent>(() => null);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_E4:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x00298840 File Offset: 0x00296A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mkXZKvJcoix40slLCQWy()
		{
			return true;
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x00298848 File Offset: 0x00296A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsAlmostFinishedDetailedEvent Rf6ptlJc1QuEF0ykmrYg()
		{
			return null;
		}

		// Token: 0x04003E70 RID: 15984
		private static readonly MessageParser<AchievementsAlmostFinishedDetailedEvent> _parser;

		// Token: 0x04003E71 RID: 15985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E72 RID: 15986
		public const int AlmostFinishedAchievementsFieldNumber = 1;

		// Token: 0x04003E73 RID: 15987
		private static readonly FieldCodec<Achievement> _repeated_almostFinishedAchievements_codec;

		// Token: 0x04003E74 RID: 15988
		private readonly RepeatedField<Achievement> almostFinishedAchievements_;

		// Token: 0x04003E75 RID: 15989
		internal static AchievementsAlmostFinishedDetailedEvent Dn5T4QJcvR0PBJpAmmC3;
	}
}
