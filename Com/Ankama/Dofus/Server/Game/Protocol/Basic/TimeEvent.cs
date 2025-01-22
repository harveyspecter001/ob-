using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BC6 RID: 3014
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TimeEvent : IMessage<TimeEvent>, IMessage, IEquatable<TimeEvent>, IDeepCloneable<TimeEvent>, IBufferMessage
	{
		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x0600910C RID: 37132 RVA: 0x0026F2F0 File Offset: 0x0026D4F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TimeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x0026F300 File Offset: 0x0026D500
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

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x0026F310 File Offset: 0x0026D510
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

		// Token: 0x0600910F RID: 37135 RVA: 0x0026F320 File Offset: 0x0026D520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeEvent()
		{
		}

		// Token: 0x06009110 RID: 37136 RVA: 0x0026F330 File Offset: 0x0026D530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeEvent(TimeEvent other)
		{
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x0026F340 File Offset: 0x0026D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x0026F350 File Offset: 0x0026D550
		// (set) Token: 0x06009113 RID: 37139 RVA: 0x0026F360 File Offset: 0x0026D560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timestamp
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06009114 RID: 37140 RVA: 0x0026F370 File Offset: 0x0026D570
		// (set) Token: 0x06009115 RID: 37141 RVA: 0x0026F380 File Offset: 0x0026D580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TimezoneOffset
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

		// Token: 0x06009116 RID: 37142 RVA: 0x0026F390 File Offset: 0x0026D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x0026F3A0 File Offset: 0x0026D5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TimeEvent other)
		{
			return true;
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x0026F3B0 File Offset: 0x0026D5B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009119 RID: 37145 RVA: 0x0026F3C0 File Offset: 0x0026D5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600911A RID: 37146 RVA: 0x0026F3D0 File Offset: 0x0026D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600911B RID: 37147 RVA: 0x0026F3E0 File Offset: 0x0026D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x0026F3F0 File Offset: 0x0026D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x0026F400 File Offset: 0x0026D600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TimeEvent other)
		{
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x0026F410 File Offset: 0x0026D610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0026F420 File Offset: 0x0026D620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009120 RID: 37152 RVA: 0x0026F430 File Offset: 0x0026D630
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TimeEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					TimeEvent._parser = new MessageParser<TimeEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x0026F528 File Offset: 0x0026D728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yVTVZLJ2VJGXOtMFOjPg()
		{
			return true;
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0026F530 File Offset: 0x0026D730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeEvent Lu5RaoJ20PvbeisK108e()
		{
			return null;
		}

		// Token: 0x040035F6 RID: 13814
		private static readonly MessageParser<TimeEvent> _parser;

		// Token: 0x040035F7 RID: 13815
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035F8 RID: 13816
		public const int TimestampFieldNumber = 1;

		// Token: 0x040035F9 RID: 13817
		private long timestamp_;

		// Token: 0x040035FA RID: 13818
		public const int TimezoneOffsetFieldNumber = 2;

		// Token: 0x040035FB RID: 13819
		private int timezoneOffset_;

		// Token: 0x040035FC RID: 13820
		internal static TimeEvent r3UPWWJ2rkRLqwC1EfnW;
	}
}
