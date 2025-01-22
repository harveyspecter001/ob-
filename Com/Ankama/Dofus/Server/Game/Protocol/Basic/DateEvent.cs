using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BC4 RID: 3012
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DateEvent : IMessage<DateEvent>, IMessage, IEquatable<DateEvent>, IDeepCloneable<DateEvent>, IBufferMessage
	{
		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x0026F09C File Offset: 0x0026D29C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060090EF RID: 37103 RVA: 0x0026F0AC File Offset: 0x0026D2AC
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

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x0026F0BC File Offset: 0x0026D2BC
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

		// Token: 0x060090F1 RID: 37105 RVA: 0x0026F0CC File Offset: 0x0026D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateEvent()
		{
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0026F0DC File Offset: 0x0026D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateEvent(DateEvent other)
		{
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x0026F0EC File Offset: 0x0026D2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x0026F0FC File Offset: 0x0026D2FC
		// (set) Token: 0x060090F5 RID: 37109 RVA: 0x0026F10C File Offset: 0x0026D30C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Day
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

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x0026F11C File Offset: 0x0026D31C
		// (set) Token: 0x060090F7 RID: 37111 RVA: 0x0026F12C File Offset: 0x0026D32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Month
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

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x0026F13C File Offset: 0x0026D33C
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x0026F14C File Offset: 0x0026D34C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Year
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

		// Token: 0x060090FA RID: 37114 RVA: 0x0026F15C File Offset: 0x0026D35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0026F16C File Offset: 0x0026D36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DateEvent other)
		{
			return true;
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x0026F17C File Offset: 0x0026D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x0026F18C File Offset: 0x0026D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x0026F19C File Offset: 0x0026D39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x0026F1AC File Offset: 0x0026D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x0026F1BC File Offset: 0x0026D3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x0026F1CC File Offset: 0x0026D3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DateEvent other)
		{
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x0026F1DC File Offset: 0x0026D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0026F1EC File Offset: 0x0026D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0026F1FC File Offset: 0x0026D3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				DateEvent._parser = new MessageParser<DateEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x0026F2E0 File Offset: 0x0026D4E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pjYHsIJ2WOwt0sqUiUnh()
		{
			return true;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0026F2E8 File Offset: 0x0026D4E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateEvent eXs0twJ2hR4goStetrvE()
		{
			return null;
		}

		// Token: 0x040035EB RID: 13803
		private static readonly MessageParser<DateEvent> _parser;

		// Token: 0x040035EC RID: 13804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035ED RID: 13805
		public const int DayFieldNumber = 1;

		// Token: 0x040035EE RID: 13806
		private int day_;

		// Token: 0x040035EF RID: 13807
		public const int MonthFieldNumber = 2;

		// Token: 0x040035F0 RID: 13808
		private int month_;

		// Token: 0x040035F1 RID: 13809
		public const int YearFieldNumber = 3;

		// Token: 0x040035F2 RID: 13810
		private int year_;

		// Token: 0x040035F3 RID: 13811
		private static DateEvent ybRYSkJ2Lue4t9mq5flr;
	}
}
