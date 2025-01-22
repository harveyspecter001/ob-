using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000157 RID: 343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlignmentRankUpdateEvent : IMessage<AlignmentRankUpdateEvent>, IMessage, IEquatable<AlignmentRankUpdateEvent>, IDeepCloneable<AlignmentRankUpdateEvent>, IBufferMessage
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0019D1C0 File Offset: 0x0019B3C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AlignmentRankUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0019D1D0 File Offset: 0x0019B3D0
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0019D1E0 File Offset: 0x0019B3E0
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0019D1F0 File Offset: 0x0019B3F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentRankUpdateEvent()
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0019D200 File Offset: 0x0019B400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentRankUpdateEvent(AlignmentRankUpdateEvent other)
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0019D210 File Offset: 0x0019B410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentRankUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0019D220 File Offset: 0x0019B420
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0019D230 File Offset: 0x0019B430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AlignmentRank
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0019D240 File Offset: 0x0019B440
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0019D250 File Offset: 0x0019B450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Verbose
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

		// Token: 0x06000FCE RID: 4046 RVA: 0x0019D260 File Offset: 0x0019B460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0019D270 File Offset: 0x0019B470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlignmentRankUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0019D280 File Offset: 0x0019B480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0019D290 File Offset: 0x0019B490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0019D2A0 File Offset: 0x0019B4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0019D2B0 File Offset: 0x0019B4B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0019D2C0 File Offset: 0x0019B4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0019D2D0 File Offset: 0x0019B4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlignmentRankUpdateEvent other)
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0019D2E0 File Offset: 0x0019B4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0019D2F0 File Offset: 0x0019B4F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0019D300 File Offset: 0x0019B500
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlignmentRankUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AlignmentRankUpdateEvent._parser = new MessageParser<AlignmentRankUpdateEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0019D3F8 File Offset: 0x0019B5F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wyDm0eOU6M39Cx9M9UpC()
		{
			return true;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0019D400 File Offset: 0x0019B600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlignmentRankUpdateEvent Y7YGIMOULFLC44DT1Hm8()
		{
			return null;
		}

		// Token: 0x040005BF RID: 1471
		private static readonly MessageParser<AlignmentRankUpdateEvent> _parser;

		// Token: 0x040005C0 RID: 1472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005C1 RID: 1473
		public const int AlignmentRankFieldNumber = 1;

		// Token: 0x040005C2 RID: 1474
		private int alignmentRank_;

		// Token: 0x040005C3 RID: 1475
		public const int VerboseFieldNumber = 2;

		// Token: 0x040005C4 RID: 1476
		private bool verbose_;

		// Token: 0x040005C5 RID: 1477
		internal static AlignmentRankUpdateEvent zKdKXeOUyxGIGllkZDI5;
	}
}
