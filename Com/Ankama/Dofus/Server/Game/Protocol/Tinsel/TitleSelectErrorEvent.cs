using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000077 RID: 119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitleSelectErrorEvent : IMessage<TitleSelectErrorEvent>, IMessage, IEquatable<TitleSelectErrorEvent>, IDeepCloneable<TitleSelectErrorEvent>, IBufferMessage
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x001899C8 File Offset: 0x00187BC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TitleSelectErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x001899D8 File Offset: 0x00187BD8
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x001899E8 File Offset: 0x00187BE8
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

		// Token: 0x060004BC RID: 1212 RVA: 0x001899F8 File Offset: 0x00187BF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectErrorEvent()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00189A08 File Offset: 0x00187C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectErrorEvent(TitleSelectErrorEvent other)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00189A18 File Offset: 0x00187C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleSelectErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00189A28 File Offset: 0x00187C28
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00189A3C File Offset: 0x00187C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TinselSelectError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TinselSelectError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00189A4C File Offset: 0x00187C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00189A5C File Offset: 0x00187C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitleSelectErrorEvent other)
		{
			return true;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00189A6C File Offset: 0x00187C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00189A7C File Offset: 0x00187C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00189A8C File Offset: 0x00187C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00189A9C File Offset: 0x00187C9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00189AAC File Offset: 0x00187CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00189ABC File Offset: 0x00187CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitleSelectErrorEvent other)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00189ACC File Offset: 0x00187CCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00189ADC File Offset: 0x00187CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00189AEC File Offset: 0x00187CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitleSelectErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					TitleSelectErrorEvent._parser = new MessageParser<TitleSelectErrorEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00189BB8 File Offset: 0x00187DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sCjIRfOKcKXqGojBcpQ5()
		{
			return true;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00189BC0 File Offset: 0x00187DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitleSelectErrorEvent SriMUAOKU990sRyt8H0f()
		{
			return null;
		}

		// Token: 0x040001DA RID: 474
		private static readonly MessageParser<TitleSelectErrorEvent> _parser;

		// Token: 0x040001DB RID: 475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001DC RID: 476
		public const int ReasonFieldNumber = 1;

		// Token: 0x040001DD RID: 477
		private TinselSelectError reason_;

		// Token: 0x040001DE RID: 478
		private static TitleSelectErrorEvent jPZOkcOKlenhXuONKWPZ;
	}
}
