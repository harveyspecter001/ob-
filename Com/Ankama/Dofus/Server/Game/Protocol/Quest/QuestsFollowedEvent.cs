using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001BC RID: 444
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestsFollowedEvent : IMessage<QuestsFollowedEvent>, IMessage, IEquatable<QuestsFollowedEvent>, IDeepCloneable<QuestsFollowedEvent>, IBufferMessage
	{
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x001A5FDC File Offset: 0x001A41DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QuestsFollowedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x001A5FEC File Offset: 0x001A41EC
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x001A5FFC File Offset: 0x001A41FC
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

		// Token: 0x060014C4 RID: 5316 RVA: 0x001A600C File Offset: 0x001A420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedEvent()
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x001A601C File Offset: 0x001A421C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedEvent(QuestsFollowedEvent other)
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x001A602C File Offset: 0x001A422C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedEvent Clone()
		{
			return null;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x001A603C File Offset: 0x001A423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestActive> Quests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x001A604C File Offset: 0x001A424C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x001A605C File Offset: 0x001A425C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestsFollowedEvent other)
		{
			return true;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x001A606C File Offset: 0x001A426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x001A607C File Offset: 0x001A427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x001A608C File Offset: 0x001A428C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x001A609C File Offset: 0x001A429C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x001A60AC File Offset: 0x001A42AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x001A60BC File Offset: 0x001A42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestsFollowedEvent other)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x001A60CC File Offset: 0x001A42CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x001A60DC File Offset: 0x001A42DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x001A60EC File Offset: 0x001A42EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestsFollowedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					QuestsFollowedEvent._repeated_quests_codec = FieldCodec.ForMessage<QuestActive>(10U, jv9ugBbiaJDSaW8ht86.XVInXhlssT(jv9ugBbiaJDSaW8ht86.A5IbPdxby2));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				QuestsFollowedEvent._parser = new MessageParser<QuestsFollowedEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x001A61F4 File Offset: 0x001A43F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dM9ZX9OoFWdsZcFs3x7C()
		{
			return true;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x001A61FC File Offset: 0x001A43FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestsFollowedEvent jI6f0dOozTExR1CkiVWF()
		{
			return null;
		}

		// Token: 0x04000769 RID: 1897
		private static readonly MessageParser<QuestsFollowedEvent> _parser;

		// Token: 0x0400076A RID: 1898
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400076B RID: 1899
		public const int QuestsFieldNumber = 1;

		// Token: 0x0400076C RID: 1900
		private static readonly FieldCodec<QuestActive> _repeated_quests_codec;

		// Token: 0x0400076D RID: 1901
		private readonly RepeatedField<QuestActive> quests_;

		// Token: 0x0400076E RID: 1902
		private static QuestsFollowedEvent eEQZOSOoqvHSdLpmrEJh;
	}
}
