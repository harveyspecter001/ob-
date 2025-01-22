using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BD4 RID: 3028
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoIsNumericEvent : IMessage<WhoIsNumericEvent>, IMessage, IEquatable<WhoIsNumericEvent>, IDeepCloneable<WhoIsNumericEvent>, IBufferMessage
	{
		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x060091C9 RID: 37321 RVA: 0x002701BC File Offset: 0x0026E3BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WhoIsNumericEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x002701CC File Offset: 0x0026E3CC
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

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x060091CB RID: 37323 RVA: 0x002701DC File Offset: 0x0026E3DC
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

		// Token: 0x060091CC RID: 37324 RVA: 0x002701EC File Offset: 0x0026E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericEvent()
		{
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x002701FC File Offset: 0x0026E3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericEvent(WhoIsNumericEvent other)
		{
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0027020C File Offset: 0x0026E40C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsNumericEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x0027021C File Offset: 0x0026E41C
		// (set) Token: 0x060091D0 RID: 37328 RVA: 0x0027022C File Offset: 0x0026E42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x060091D1 RID: 37329 RVA: 0x0027023C File Offset: 0x0026E43C
		// (set) Token: 0x060091D2 RID: 37330 RVA: 0x0027024C File Offset: 0x0026E44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccountId
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

		// Token: 0x060091D3 RID: 37331 RVA: 0x0027025C File Offset: 0x0026E45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x0027026C File Offset: 0x0026E46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoIsNumericEvent other)
		{
			return true;
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x0027027C File Offset: 0x0026E47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x0027028C File Offset: 0x0026E48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x0027029C File Offset: 0x0026E49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x002702AC File Offset: 0x0026E4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x002702BC File Offset: 0x0026E4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x002702CC File Offset: 0x0026E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoIsNumericEvent other)
		{
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x002702DC File Offset: 0x0026E4DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x002702EC File Offset: 0x0026E4EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x002702FC File Offset: 0x0026E4FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoIsNumericEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					WhoIsNumericEvent._parser = new MessageParser<WhoIsNumericEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x002703C8 File Offset: 0x0026E5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uHhXbMJ28DfEVQeoeKHa()
		{
			return true;
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x002703D0 File Offset: 0x0026E5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoIsNumericEvent pJ6dlXJ2ZeJ6GUL7gyBZ()
		{
			return null;
		}

		// Token: 0x0400364E RID: 13902
		private static readonly MessageParser<WhoIsNumericEvent> _parser;

		// Token: 0x0400364F RID: 13903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003650 RID: 13904
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04003651 RID: 13905
		private long playerId_;

		// Token: 0x04003652 RID: 13906
		public const int AccountIdFieldNumber = 2;

		// Token: 0x04003653 RID: 13907
		private long accountId_;

		// Token: 0x04003654 RID: 13908
		private static WhoIsNumericEvent ouTnbRJ2utePEvcobLOb;
	}
}
