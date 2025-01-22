using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion
{
	// Token: 0x02000111 RID: 273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivitySuggestionsEvent : IMessage<ActivitySuggestionsEvent>, IMessage, IEquatable<ActivitySuggestionsEvent>, IDeepCloneable<ActivitySuggestionsEvent>, IBufferMessage
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x001975E0 File Offset: 0x001957E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ActivitySuggestionsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x001975F0 File Offset: 0x001957F0
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00197600 File Offset: 0x00195800
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

		// Token: 0x06000C7B RID: 3195 RVA: 0x00197610 File Offset: 0x00195810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsEvent()
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00197620 File Offset: 0x00195820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsEvent(ActivitySuggestionsEvent other)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00197630 File Offset: 0x00195830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsEvent Clone()
		{
			return null;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00197640 File Offset: 0x00195840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockedActivities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00197650 File Offset: 0x00195850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedActivities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00197660 File Offset: 0x00195860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00197670 File Offset: 0x00195870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ActivitySuggestionsEvent other)
		{
			return true;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00197680 File Offset: 0x00195880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00197690 File Offset: 0x00195890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x001976A0 File Offset: 0x001958A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x001976B0 File Offset: 0x001958B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x001976C0 File Offset: 0x001958C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x001976D0 File Offset: 0x001958D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ActivitySuggestionsEvent other)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x001976E0 File Offset: 0x001958E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x001976F0 File Offset: 0x001958F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00197700 File Offset: 0x00195900
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ActivitySuggestionsEvent()
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
					default:
						ActivitySuggestionsEvent._repeated_unlockedActivities_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 3;
						break;
					case 1:
						goto IL_58;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						ActivitySuggestionsEvent._parser = new MessageParser<ActivitySuggestionsEvent>(() => null);
						num2 = 5;
						break;
					case 5:
						ActivitySuggestionsEvent._repeated_lockedActivities_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
						{
							num2 = 0;
						}
						break;
					case 6:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 4;
						}
						break;
					}
				}
				IL_58:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 6;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00197824 File Offset: 0x00195A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vw4xQrOcJU96AoEfM6nI()
		{
			return true;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0019782C File Offset: 0x00195A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ActivitySuggestionsEvent TI6e6SOcGyPRD2lmA8Ut()
		{
			return null;
		}

		// Token: 0x04000484 RID: 1156
		private static readonly MessageParser<ActivitySuggestionsEvent> _parser;

		// Token: 0x04000485 RID: 1157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000486 RID: 1158
		public const int LockedActivitiesFieldNumber = 1;

		// Token: 0x04000487 RID: 1159
		private static readonly FieldCodec<int> _repeated_lockedActivities_codec;

		// Token: 0x04000488 RID: 1160
		private readonly RepeatedField<int> lockedActivities_;

		// Token: 0x04000489 RID: 1161
		public const int UnlockedActivitiesFieldNumber = 2;

		// Token: 0x0400048A RID: 1162
		private static readonly FieldCodec<int> _repeated_unlockedActivities_codec;

		// Token: 0x0400048B RID: 1163
		private readonly RepeatedField<int> unlockedActivities_;

		// Token: 0x0400048C RID: 1164
		internal static ActivitySuggestionsEvent BSEWqgOcO9mjGP2SMJYM;
	}
}
