using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000977 RID: 2423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachEnterEvent : IMessage<BreachEnterEvent>, IMessage, IEquatable<BreachEnterEvent>, IDeepCloneable<BreachEnterEvent>, IBufferMessage
	{
		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06007550 RID: 30032 RVA: 0x00242C08 File Offset: 0x00240E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachEnterEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06007551 RID: 30033 RVA: 0x00242C18 File Offset: 0x00240E18
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06007552 RID: 30034 RVA: 0x00242C28 File Offset: 0x00240E28
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

		// Token: 0x06007553 RID: 30035 RVA: 0x00242C38 File Offset: 0x00240E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachEnterEvent()
		{
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00242C48 File Offset: 0x00240E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachEnterEvent(BreachEnterEvent other)
		{
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00242C58 File Offset: 0x00240E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachEnterEvent Clone()
		{
			return null;
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x00242C68 File Offset: 0x00240E68
		// (set) Token: 0x06007557 RID: 30039 RVA: 0x00242C78 File Offset: 0x00240E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Owner
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

		// Token: 0x06007558 RID: 30040 RVA: 0x00242C88 File Offset: 0x00240E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x00242C98 File Offset: 0x00240E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachEnterEvent other)
		{
			return true;
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x00242CA8 File Offset: 0x00240EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x00242CB8 File Offset: 0x00240EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x00242CC8 File Offset: 0x00240EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x00242CD8 File Offset: 0x00240ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x00242CE8 File Offset: 0x00240EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00242CF8 File Offset: 0x00240EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachEnterEvent other)
		{
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00242D08 File Offset: 0x00240F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00242D18 File Offset: 0x00240F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x00242D28 File Offset: 0x00240F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachEnterEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BreachEnterEvent._parser = new MessageParser<BreachEnterEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x00242E0C File Offset: 0x0024100C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pAwKSFJRKFn0SA2aUOIe()
		{
			return true;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00242E14 File Offset: 0x00241014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachEnterEvent mtoeQnJRIOPp3kFn6ppW()
		{
			return null;
		}

		// Token: 0x040028DD RID: 10461
		private static readonly MessageParser<BreachEnterEvent> _parser;

		// Token: 0x040028DE RID: 10462
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028DF RID: 10463
		public const int OwnerFieldNumber = 1;

		// Token: 0x040028E0 RID: 10464
		private long owner_;

		// Token: 0x040028E1 RID: 10465
		private static BreachEnterEvent w6EeeAJRjuXUMjJOD9Go;
	}
}
