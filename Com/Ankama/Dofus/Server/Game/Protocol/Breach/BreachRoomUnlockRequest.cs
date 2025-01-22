using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200096B RID: 2411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRoomUnlockRequest : IMessage<BreachRoomUnlockRequest>, IMessage, IEquatable<BreachRoomUnlockRequest>, IDeepCloneable<BreachRoomUnlockRequest>, IBufferMessage
	{
		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x00241FCC File Offset: 0x002401CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachRoomUnlockRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060074B8 RID: 29880 RVA: 0x00241FDC File Offset: 0x002401DC
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

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060074B9 RID: 29881 RVA: 0x00241FEC File Offset: 0x002401EC
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

		// Token: 0x060074BA RID: 29882 RVA: 0x00241FFC File Offset: 0x002401FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockRequest()
		{
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0024200C File Offset: 0x0024020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockRequest(BreachRoomUnlockRequest other)
		{
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0024201C File Offset: 0x0024021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockRequest Clone()
		{
			return null;
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060074BD RID: 29885 RVA: 0x0024202C File Offset: 0x0024022C
		// (set) Token: 0x060074BE RID: 29886 RVA: 0x0024203C File Offset: 0x0024023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
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

		// Token: 0x060074BF RID: 29887 RVA: 0x0024204C File Offset: 0x0024024C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x0024205C File Offset: 0x0024025C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRoomUnlockRequest other)
		{
			return true;
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x0024206C File Offset: 0x0024026C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x0024207C File Offset: 0x0024027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x0024208C File Offset: 0x0024028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x0024209C File Offset: 0x0024029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x002420AC File Offset: 0x002402AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x002420BC File Offset: 0x002402BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRoomUnlockRequest other)
		{
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x002420CC File Offset: 0x002402CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x002420DC File Offset: 0x002402DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x002420EC File Offset: 0x002402EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRoomUnlockRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					BreachRoomUnlockRequest._parser = new MessageParser<BreachRoomUnlockRequest>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x002421B8 File Offset: 0x002403B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VSXmNPJRBPWuOeSITVrM()
		{
			return true;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x002421C0 File Offset: 0x002403C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRoomUnlockRequest Cvv7tUJReleSBTNNWb28()
		{
			return null;
		}

		// Token: 0x040028B4 RID: 10420
		private static readonly MessageParser<BreachRoomUnlockRequest> _parser;

		// Token: 0x040028B5 RID: 10421
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B6 RID: 10422
		public const int RoomIdFieldNumber = 1;

		// Token: 0x040028B7 RID: 10423
		private int roomId_;

		// Token: 0x040028B8 RID: 10424
		private static BreachRoomUnlockRequest owEYm1JRAxfNLBfMQuGZ;
	}
}
