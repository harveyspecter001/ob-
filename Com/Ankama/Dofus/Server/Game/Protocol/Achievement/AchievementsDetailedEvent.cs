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
	// Token: 0x02000DC7 RID: 3527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsDetailedEvent : IMessage<AchievementsDetailedEvent>, IMessage, IEquatable<AchievementsDetailedEvent>, IDeepCloneable<AchievementsDetailedEvent>, IBufferMessage
	{
		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x002983FC File Offset: 0x002965FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsDetailedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600A9EB RID: 43499 RVA: 0x0029840C File Offset: 0x0029660C
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

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0600A9EC RID: 43500 RVA: 0x0029841C File Offset: 0x0029661C
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

		// Token: 0x0600A9ED RID: 43501 RVA: 0x0029842C File Offset: 0x0029662C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedEvent()
		{
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x0029843C File Offset: 0x0029663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedEvent(AchievementsDetailedEvent other)
		{
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x0029844C File Offset: 0x0029664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600A9F0 RID: 43504 RVA: 0x0029845C File Offset: 0x0029665C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Achievement> Achievements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x0029846C File Offset: 0x0029666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x0029847C File Offset: 0x0029667C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsDetailedEvent other)
		{
			return true;
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x0029848C File Offset: 0x0029668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x0029849C File Offset: 0x0029669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x002984AC File Offset: 0x002966AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x002984BC File Offset: 0x002966BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x002984CC File Offset: 0x002966CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x002984DC File Offset: 0x002966DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsDetailedEvent other)
		{
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x002984EC File Offset: 0x002966EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x002984FC File Offset: 0x002966FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x0029850C File Offset: 0x0029670C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsDetailedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AchievementsDetailedEvent._parser = new MessageParser<AchievementsDetailedEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					AchievementsDetailedEvent._repeated_achievements_codec = FieldCodec.ForMessage<Achievement>(10U, ghkG7R3su8HaLttAP1sQ.XVInXhlssT(ghkG7R3su8HaLttAP1sQ.Y0G3s8uS0yr));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x00298614 File Offset: 0x00296814
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qvvibdJccV9Xo00fqvId()
		{
			return true;
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x0029861C File Offset: 0x0029681C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsDetailedEvent uTobjRJcU6mJUCJoKGki()
		{
			return null;
		}

		// Token: 0x04003E68 RID: 15976
		private static readonly MessageParser<AchievementsDetailedEvent> _parser;

		// Token: 0x04003E69 RID: 15977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E6A RID: 15978
		public const int AchievementsFieldNumber = 1;

		// Token: 0x04003E6B RID: 15979
		private static readonly FieldCodec<Achievement> _repeated_achievements_codec;

		// Token: 0x04003E6C RID: 15980
		private readonly RepeatedField<Achievement> achievements_;

		// Token: 0x04003E6D RID: 15981
		private static AchievementsDetailedEvent YEQ9A8JclH8fmgTUXpw3;
	}
}
