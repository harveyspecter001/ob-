using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D1E RID: 3358
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationReceivedEvent : IMessage<AllianceApplicationReceivedEvent>, IMessage, IEquatable<AllianceApplicationReceivedEvent>, IDeepCloneable<AllianceApplicationReceivedEvent>, IBufferMessage
	{
		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x002894B0 File Offset: 0x002876B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationReceivedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x0600A1AB RID: 41387 RVA: 0x002894C0 File Offset: 0x002876C0
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

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x002894D0 File Offset: 0x002876D0
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

		// Token: 0x0600A1AD RID: 41389 RVA: 0x002894E0 File Offset: 0x002876E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationReceivedEvent()
		{
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x002894F0 File Offset: 0x002876F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationReceivedEvent(AllianceApplicationReceivedEvent other)
		{
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x00289500 File Offset: 0x00287700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationReceivedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x00289510 File Offset: 0x00287710
		// (set) Token: 0x0600A1B1 RID: 41393 RVA: 0x00289520 File Offset: 0x00287720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PlayerName
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

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x00289530 File Offset: 0x00287730
		// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x00289540 File Offset: 0x00287740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00289550 File Offset: 0x00287750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x00289560 File Offset: 0x00287760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationReceivedEvent other)
		{
			return true;
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x00289570 File Offset: 0x00287770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x00289580 File Offset: 0x00287780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00289590 File Offset: 0x00287790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x002895A0 File Offset: 0x002877A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x002895B0 File Offset: 0x002877B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x002895C0 File Offset: 0x002877C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationReceivedEvent other)
		{
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x002895D0 File Offset: 0x002877D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x002895E0 File Offset: 0x002877E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x002895F0 File Offset: 0x002877F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationReceivedEvent()
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
						goto IL_C1;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						AllianceApplicationReceivedEvent._parser = new MessageParser<AllianceApplicationReceivedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_C1:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x002896D8 File Offset: 0x002878D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NYrUiCJK6DEW1ftaZbqC()
		{
			return true;
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x002896E0 File Offset: 0x002878E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationReceivedEvent qUtN6pJKLvc3yG1se3Ds()
		{
			return null;
		}

		// Token: 0x04003BBB RID: 15291
		private static readonly MessageParser<AllianceApplicationReceivedEvent> _parser;

		// Token: 0x04003BBC RID: 15292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BBD RID: 15293
		public const int PlayerNameFieldNumber = 1;

		// Token: 0x04003BBE RID: 15294
		private string playerName_;

		// Token: 0x04003BBF RID: 15295
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04003BC0 RID: 15296
		private long playerId_;

		// Token: 0x04003BC1 RID: 15297
		internal static AllianceApplicationReceivedEvent BAM1nYJKyI59dMD2QGq4;
	}
}
