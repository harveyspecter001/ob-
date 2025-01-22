using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x0200006D RID: 109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitleGainedEvent : IMessage<TitleGainedEvent>, IMessage, IEquatable<TitleGainedEvent>, IDeepCloneable<TitleGainedEvent>, IBufferMessage
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00188FB0 File Offset: 0x001871B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TitleGainedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00188FC0 File Offset: 0x001871C0
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00188FD0 File Offset: 0x001871D0
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

		// Token: 0x0600043A RID: 1082 RVA: 0x00188FE0 File Offset: 0x001871E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleGainedEvent()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00188FF0 File Offset: 0x001871F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleGainedEvent(TitleGainedEvent other)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00189000 File Offset: 0x00187200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleGainedEvent Clone()
		{
			return null;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00189010 File Offset: 0x00187210
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00189020 File Offset: 0x00187220
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

		// Token: 0x0600043F RID: 1087 RVA: 0x00189030 File Offset: 0x00187230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00189040 File Offset: 0x00187240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitleGainedEvent other)
		{
			return true;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00189050 File Offset: 0x00187250
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00189060 File Offset: 0x00187260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00189070 File Offset: 0x00187270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00189080 File Offset: 0x00187280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00189090 File Offset: 0x00187290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x001890A0 File Offset: 0x001872A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitleGainedEvent other)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x001890B0 File Offset: 0x001872B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x001890C0 File Offset: 0x001872C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x001890D0 File Offset: 0x001872D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitleGainedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					TitleGainedEvent._parser = new MessageParser<TitleGainedEvent>(() => null);
					num2 = 4;
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0018919C File Offset: 0x0018739C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zYciJ3OKgNr6ZmJBQ2tW()
		{
			return true;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x001891A4 File Offset: 0x001873A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitleGainedEvent AEbbFLOKsk2U8A42Eud4()
		{
			return null;
		}

		// Token: 0x040001B7 RID: 439
		private static readonly MessageParser<TitleGainedEvent> _parser;

		// Token: 0x040001B8 RID: 440
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001B9 RID: 441
		public const int TitleIdFieldNumber = 1;

		// Token: 0x040001BA RID: 442
		private int titleId_;

		// Token: 0x040001BB RID: 443
		private static TitleGainedEvent HBZLOpOKGFniBk0AEREk;
	}
}
