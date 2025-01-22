using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006AF RID: 1711
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsCancelledEvent : IMessage<FightPlacementSwapPositionsCancelledEvent>, IMessage, IEquatable<FightPlacementSwapPositionsCancelledEvent>, IDeepCloneable<FightPlacementSwapPositionsCancelledEvent>, IBufferMessage
	{
		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x00209E20 File Offset: 0x00208020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightPlacementSwapPositionsCancelledEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06005393 RID: 21395 RVA: 0x00209E30 File Offset: 0x00208030
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

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x00209E40 File Offset: 0x00208040
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

		// Token: 0x06005395 RID: 21397 RVA: 0x00209E50 File Offset: 0x00208050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelledEvent()
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00209E60 File Offset: 0x00208060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelledEvent(FightPlacementSwapPositionsCancelledEvent other)
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00209E70 File Offset: 0x00208070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelledEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x00209E80 File Offset: 0x00208080
		// (set) Token: 0x06005399 RID: 21401 RVA: 0x00209E90 File Offset: 0x00208090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RequestId
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

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x00209EA0 File Offset: 0x002080A0
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x00209EB0 File Offset: 0x002080B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CancellerId
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

		// Token: 0x0600539C RID: 21404 RVA: 0x00209EC0 File Offset: 0x002080C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00209ED0 File Offset: 0x002080D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsCancelledEvent other)
		{
			return true;
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00209EE0 File Offset: 0x002080E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00209EF0 File Offset: 0x002080F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00209F00 File Offset: 0x00208100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00209F10 File Offset: 0x00208110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00209F20 File Offset: 0x00208120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00209F30 File Offset: 0x00208130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsCancelledEvent other)
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00209F40 File Offset: 0x00208140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x00209F50 File Offset: 0x00208150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00209F60 File Offset: 0x00208160
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsCancelledEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FightPlacementSwapPositionsCancelledEvent._parser = new MessageParser<FightPlacementSwapPositionsCancelledEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x0020A02C File Offset: 0x0020822C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iOdWmkOSdX58iUG9xyFk()
		{
			return true;
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0020A034 File Offset: 0x00208234
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsCancelledEvent Mc7OgxOS9rCWAgmaXorL()
		{
			return null;
		}

		// Token: 0x04001D75 RID: 7541
		private static readonly MessageParser<FightPlacementSwapPositionsCancelledEvent> _parser;

		// Token: 0x04001D76 RID: 7542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D77 RID: 7543
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04001D78 RID: 7544
		private int requestId_;

		// Token: 0x04001D79 RID: 7545
		public const int CancellerIdFieldNumber = 2;

		// Token: 0x04001D7A RID: 7546
		private long cancellerId_;

		// Token: 0x04001D7B RID: 7547
		private static FightPlacementSwapPositionsCancelledEvent swHL0kOSsp0RnA8v7BYv;
	}
}
