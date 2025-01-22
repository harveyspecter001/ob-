using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000075 RID: 117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitleSelectedEvent : IMessage<TitleSelectedEvent>, IMessage, IEquatable<TitleSelectedEvent>, IDeepCloneable<TitleSelectedEvent>, IBufferMessage
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x001897CC File Offset: 0x001879CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TitleSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x001897DC File Offset: 0x001879DC
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x001897EC File Offset: 0x001879EC
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

		// Token: 0x060004A2 RID: 1186 RVA: 0x001897FC File Offset: 0x001879FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectedEvent()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0018980C File Offset: 0x00187A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectedEvent(TitleSelectedEvent other)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0018981C File Offset: 0x00187A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0018982C File Offset: 0x00187A2C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0018983C File Offset: 0x00187A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleId
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x0018984C File Offset: 0x00187A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0018985C File Offset: 0x00187A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitleSelectedEvent other)
		{
			return true;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0018986C File Offset: 0x00187A6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0018987C File Offset: 0x00187A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0018988C File Offset: 0x00187A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0018989C File Offset: 0x00187A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x001898AC File Offset: 0x00187AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x001898BC File Offset: 0x00187ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitleSelectedEvent other)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x001898CC File Offset: 0x00187ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x001898DC File Offset: 0x00187ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x001898EC File Offset: 0x00187AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitleSelectedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				TitleSelectedEvent._parser = new MessageParser<TitleSelectedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x001899B8 File Offset: 0x00187BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rHXKJZOKI5yZcj33GjiG()
		{
			return true;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x001899C0 File Offset: 0x00187BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitleSelectedEvent lTirKQOKkerejVDCLUd1()
		{
			return null;
		}

		// Token: 0x040001D3 RID: 467
		private static readonly MessageParser<TitleSelectedEvent> _parser;

		// Token: 0x040001D4 RID: 468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001D5 RID: 469
		public const int TitleIdFieldNumber = 1;

		// Token: 0x040001D6 RID: 470
		private int titleId_;

		// Token: 0x040001D7 RID: 471
		private static TitleSelectedEvent iy4gg1OKKutwLCOqCMHH;
	}
}
