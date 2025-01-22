using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000178 RID: 376
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerFightRequest : IMessage<PlayerFightRequest>, IMessage, IEquatable<PlayerFightRequest>, IDeepCloneable<PlayerFightRequest>, IBufferMessage
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x001A0894 File Offset: 0x0019EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFightRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x001A08A4 File Offset: 0x0019EAA4
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x001A08B4 File Offset: 0x0019EAB4
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

		// Token: 0x06001129 RID: 4393 RVA: 0x001A08C4 File Offset: 0x0019EAC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightRequest()
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x001A08D4 File Offset: 0x0019EAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightRequest(PlayerFightRequest other)
		{
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x001A08E4 File Offset: 0x0019EAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightRequest Clone()
		{
			return null;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x001A08F4 File Offset: 0x0019EAF4
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x001A0904 File Offset: 0x0019EB04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetId
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x001A0914 File Offset: 0x0019EB14
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x001A0924 File Offset: 0x0019EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetCellId
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x001A0934 File Offset: 0x0019EB34
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x001A0944 File Offset: 0x0019EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Friendly
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

		// Token: 0x06001132 RID: 4402 RVA: 0x001A0954 File Offset: 0x0019EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x001A0964 File Offset: 0x0019EB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerFightRequest other)
		{
			return true;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x001A0974 File Offset: 0x0019EB74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x001A0984 File Offset: 0x0019EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x001A0994 File Offset: 0x0019EB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x001A09A4 File Offset: 0x0019EBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x001A09B4 File Offset: 0x0019EBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x001A09C4 File Offset: 0x0019EBC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerFightRequest other)
		{
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x001A09D4 File Offset: 0x0019EBD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x001A09E4 File Offset: 0x0019EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x001A09F4 File Offset: 0x0019EBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerFightRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						goto IL_6F;
					case 2:
						PlayerFightRequest._parser = new MessageParser<PlayerFightRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
						{
							num2 = 3;
						}
						break;
					}
				}
				IL_6F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x001A0ADC File Offset: 0x0019ECDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i5pliwOvI8ZjsMeZuTJT()
		{
			return true;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x001A0AE4 File Offset: 0x0019ECE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerFightRequest Lvr1bCOvkg1VQRSLeVIf()
		{
			return null;
		}

		// Token: 0x0400063C RID: 1596
		private static readonly MessageParser<PlayerFightRequest> _parser;

		// Token: 0x0400063D RID: 1597
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400063E RID: 1598
		public const int TargetIdFieldNumber = 1;

		// Token: 0x0400063F RID: 1599
		private long targetId_;

		// Token: 0x04000640 RID: 1600
		public const int TargetCellIdFieldNumber = 2;

		// Token: 0x04000641 RID: 1601
		private int targetCellId_;

		// Token: 0x04000642 RID: 1602
		public const int FriendlyFieldNumber = 3;

		// Token: 0x04000643 RID: 1603
		private bool friendly_;

		// Token: 0x04000644 RID: 1604
		internal static PlayerFightRequest LLfqZfOvK2OfN0Ps9gcE;
	}
}
