using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security
{
	// Token: 0x02000170 RID: 368
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrustStatusEvent : IMessage<TrustStatusEvent>, IMessage, IEquatable<TrustStatusEvent>, IDeepCloneable<TrustStatusEvent>, IBufferMessage
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x0019F13C File Offset: 0x0019D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrustStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0019F14C File Offset: 0x0019D34C
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0019F15C File Offset: 0x0019D35C
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

		// Token: 0x060010D1 RID: 4305 RVA: 0x0019F16C File Offset: 0x0019D36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrustStatusEvent()
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0019F17C File Offset: 0x0019D37C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrustStatusEvent(TrustStatusEvent other)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0019F18C File Offset: 0x0019D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrustStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0019F19C File Offset: 0x0019D39C
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0019F1AC File Offset: 0x0019D3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Certified
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

		// Token: 0x060010D6 RID: 4310 RVA: 0x0019F1BC File Offset: 0x0019D3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0019F1CC File Offset: 0x0019D3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TrustStatusEvent other)
		{
			return true;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0019F1DC File Offset: 0x0019D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0019F1EC File Offset: 0x0019D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0019F1FC File Offset: 0x0019D3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0019F20C File Offset: 0x0019D40C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0019F21C File Offset: 0x0019D41C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0019F22C File Offset: 0x0019D42C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TrustStatusEvent other)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0019F23C File Offset: 0x0019D43C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0019F24C File Offset: 0x0019D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0019F25C File Offset: 0x0019D45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TrustStatusEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					TrustStatusEvent._parser = new MessageParser<TrustStatusEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0019F340 File Offset: 0x0019D540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XUBYKIOvO9fPAx6biUhh()
		{
			return true;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0019F348 File Offset: 0x0019D548
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TrustStatusEvent GyMvKjOvJ5L74FmdIng9()
		{
			return null;
		}

		// Token: 0x04000621 RID: 1569
		private static readonly MessageParser<TrustStatusEvent> _parser;

		// Token: 0x04000622 RID: 1570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000623 RID: 1571
		public const int CertifiedFieldNumber = 1;

		// Token: 0x04000624 RID: 1572
		private bool certified_;

		// Token: 0x04000625 RID: 1573
		internal static TrustStatusEvent y8xN9KOvR28JxeFp2fl1;
	}
}
